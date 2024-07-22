using Microsoft.Data.Sqlite;
using Serilog;
using System.Text.RegularExpressions;

namespace time_tracker
{
  public class Event(long id, string date, string time, string type) : IComparable<Event>
  {
    public long Id { get; set; } = id;
    public string Date { get; set; } = date;
    public string Time { get; set; } = time;
    public string Type { get; set; } = type;

    int IComparable<Event>.CompareTo(Event? other)
    {
      if (other != null)
        return (Date + "_" + Time).CompareTo(other.Date + "_" + other.Time);
      return 0;
    }
  }

  internal static class DataBase
  {
    static string sqliteDbPath = string.Empty;
    static SqliteConnection? sqliteConnection = null;

    public static void Initialize(string _sqliteDbPath)
    {
      sqliteDbPath = _sqliteDbPath;
      sqliteConnection = new SqliteConnection("Data Source=" + sqliteDbPath);
      sqliteConnection.Open();
      var command = sqliteConnection.CreateCommand();
      command.CommandText = "CREATE TABLE IF NOT EXISTS events (date TEXT, time TEXT, type TEXT);";
      command.ExecuteNonQuery();
      // TODO : faire un backup sur U:\
      // https://learn.microsoft.com/fr-fr/dotnet/standard/data/sqlite/backup
    }

    public static void InsertEvent(string? type = null, string? date = null, string? time = null)
    {
      if (sqliteConnection != null)
      {
        // TODO vérifier qu'il n'y a pas déjà un événement "usr_check" le même jour à la même heure/minute
        DateTime now = DateTime.Now;
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"INSERT INTO events (date, time, type) VALUES (@date, @time, @type)";
        command.Parameters.AddWithValue("@date", String.IsNullOrEmpty(date) ? $"{now:yyyy-MM-dd}" : date);
        command.Parameters.AddWithValue("@time", String.IsNullOrEmpty(time) ? $"{now:HH:mm}" : time);
        command.Parameters.AddWithValue("@type", String.IsNullOrEmpty(type) ? "usr_check" : type);
        Log.Information($"INSERT INTO events (\"{command.Parameters[0].Value}\", \"{command.Parameters[1].Value}\", \"{command.Parameters[2].Value}\");");
        command.ExecuteNonQuery();
      }
    }

    public static void UpdateEvent(Event evt, string date, string time)
    {
      if (sqliteConnection != null)
      {
        Match match = new Regex(@"([0-9]{2}):([0-9]{2})").Match(time);
        if (match.Success)
        {
          var command = sqliteConnection.CreateCommand();
          command.CommandText = @"UPDATE events SET time = @newTime, date = @newDate WHERE rowid = @id";
          command.Parameters.AddWithValue("@newTime", time);
          command.Parameters.AddWithValue("@newDate", date);
          command.Parameters.AddWithValue("@id", evt.Id);
          Log.Information($"UPDATE events SET time = \"{command.Parameters[0].Value}\", date = \"{command.Parameters[1].Value}\" WHERE rowid = {command.Parameters[2].Value}; # date was \"{evt.Date}\", time was \"{evt.Time}\"");
          command.ExecuteNonQuery();
        }
      }
    }

    public static void DeleteEvent(Event evt)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"DELETE FROM events WHERE rowid = @id";
        command.Parameters.AddWithValue("@id", evt.Id);
        Log.Information($"DELETE FROM events WHERE rowid = {command.Parameters[0].Value}; # values were (\"{evt.Date}\", \"{evt.Time}\", \"{evt.Type}\")");
        command.ExecuteNonQuery();
      }
    }

    public static List<Event> GetEvents(string? type, string? date1 = null, string? date2 = null)
    {
      List<Event> rows = [];
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"SELECT rowid, date, time, type FROM events";
        string cond = " WHERE";
        if (!String.IsNullOrEmpty(type))
        {
          command.CommandText += cond + " type = @type";
          command.Parameters.AddWithValue("@type", type);
          cond = " AND";
        }
        if (!String.IsNullOrEmpty(date1) && !String.IsNullOrEmpty(date2))
        {
          command.CommandText += cond + " date >= @start AND date <= @end";
          command.Parameters.AddWithValue("@start", date1);
          command.Parameters.AddWithValue("@end", date2);
        }
        else if (!String.IsNullOrEmpty(date1))
        {
          command.CommandText += cond + " date = @date";
          command.Parameters.AddWithValue("@date", date1);
        }
        command.CommandText += " ORDER BY date ASC, time ASC";
        using var reader = command.ExecuteReader();
        while (reader.Read())
          rows.Add(new Event(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
      }
      return rows;
    }

    public static void CloseConnection()
    {
      sqliteConnection?.Close();
    }

  }
}
