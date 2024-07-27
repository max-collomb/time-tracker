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
  public class Annotation(long id, string date, string type, string description) : IComparable<Event>
  {
    public long Id { get; set; } = id;
    public string Date { get; set; } = date;
    public string Type { get; set; } = type;
    public string Description { get; set; } = description;

    int IComparable<Event>.CompareTo(Event? other)
    {
      return (other == null) ? 0 : Date.CompareTo(other.Date);
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
      command = sqliteConnection.CreateCommand();
      command.CommandText = "CREATE TABLE IF NOT EXISTS annotations (date TEXT, type TEXT, description TEXT);";
      command.ExecuteNonQuery();
      // TODO : faire un backup sur U:\
      // https://learn.microsoft.com/fr-fr/dotnet/standard/data/sqlite/backup
    }

    public static void InsertEvent(string? type = null, string? date = null, string? time = null)
    {
      if (sqliteConnection != null)
      {
        DateTime now = DateTime.Now;
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"INSERT INTO events (date, time, type) VALUES (@date, @time, @type)";
        command.Parameters.AddWithValue("@date", string.IsNullOrEmpty(date) ? $"{now:yyyy-MM-dd}" : date);
        command.Parameters.AddWithValue("@time", string.IsNullOrEmpty(time) ? $"{now:HH:mm}" : time);
        command.Parameters.AddWithValue("@type", string.IsNullOrEmpty(type) ? "usr_check" : type);
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
        if (!string.IsNullOrEmpty(type))
        {
          command.CommandText += cond + " type = @type";
          command.Parameters.AddWithValue("@type", type);
          cond = " AND";
        }
        if (!string.IsNullOrEmpty(date1) && !string.IsNullOrEmpty(date2))
        {
          command.CommandText += cond + " date >= @start AND date <= @end";
          command.Parameters.AddWithValue("@start", date1);
          command.Parameters.AddWithValue("@end", date2);
        }
        else if (!string.IsNullOrEmpty(date1))
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

    public static Tuple<int, string, string> GetPreviousDayChecks(DateTime date)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        string today = date.Date.ToString("yyyy-MM-dd");
        string lastMonth = date.AddMonths(-1).Date.ToString("yyyy-MM-dd");
        command.CommandText = @"SELECT COUNT(rowid), GROUP_CONCAT(TIME, "" | ""), date
          FROM events
          WHERE TYPE = @type
            AND date = (
              SELECT MAX(date)
              FROM events
              WHERE DATE < @today
                AND date > @lastmonth
            )";
        command.Parameters.AddWithValue("@type", "usr_check");
        command.Parameters.AddWithValue("@today", today);
        command.Parameters.AddWithValue("@lastmonth", lastMonth);
        using var reader = command.ExecuteReader();
        if (reader.Read())
          return new Tuple<int, string, string>(reader.GetInt32(0), reader.IsDBNull(1) ? "" : reader.GetString(1), reader.IsDBNull(1) ? "" : reader.GetString(2));
      }
      return new Tuple<int, string, string>(0, "", "");
    }
    
    public static void InsertAnnotation(string date, string type, string? description = null)
    {
      if (sqliteConnection != null)
      {
        DateTime now = DateTime.Now;
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"INSERT INTO annotations (date, type, description) VALUES (@date, @type, @description)";
        command.Parameters.AddWithValue("@date", date);
        command.Parameters.AddWithValue("@type", type);
        command.Parameters.AddWithValue("@description", description ?? "");
        Log.Information($"INSERT INTO annotations (\"{command.Parameters[0].Value}\", \"{command.Parameters[1].Value}\", \"{command.Parameters[2].Value}\");");
        command.ExecuteNonQuery();
      }
    }

    public static void UpdateAnnotation(Annotation annotation, string date, string type, string description)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"UPDATE annotations SET date = @newDate, type = @newType, description = @newDescription WHERE rowid = @id";
        command.Parameters.AddWithValue("@newDate", date);
        command.Parameters.AddWithValue("@newType", type);
        command.Parameters.AddWithValue("@newDescription", description);
        command.Parameters.AddWithValue("@id", annotation.Id);
        Log.Information($"UPDATE annotations SET date = \"{command.Parameters[0].Value}\", type = \"{command.Parameters[1].Value}\", description = \"{command.Parameters[2].Value}\" WHERE rowid = {command.Parameters[3].Value}; # date was \"{annotation.Date}\", type was \"{annotation.Type}\", description was \"{annotation.Description}\"");
        command.ExecuteNonQuery();
      }
    }

    public static void DeleteAnnotation(Annotation annotation)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"DELETE FROM annotations WHERE rowid = @id";
        command.Parameters.AddWithValue("@id", annotation.Id);
        Log.Information($"DELETE FROM annotations WHERE rowid = {command.Parameters[0].Value}; # values were (\"{annotation.Date}\", \"{annotation.Type}\", \"{annotation.Description}\")");
        command.ExecuteNonQuery();
      }
    }

    public static List<Annotation> GetAnnotations(string? date1 = null, string? date2 = null)
    {
      List<Annotation> rows = [];
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"SELECT rowid, date, type, description FROM annotations";
        if (!string.IsNullOrEmpty(date1) && !string.IsNullOrEmpty(date2))
        {
          command.CommandText += " WHERE date >= @start AND date <= @end";
          command.Parameters.AddWithValue("@start", date1);
          command.Parameters.AddWithValue("@end", date2);
        }
        command.CommandText += " ORDER BY date ASC";
        using var reader = command.ExecuteReader();
        while (reader.Read())
          rows.Add(new Annotation(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
      }
      return rows;
    }

    public static Annotation? GetAnnotation(string date)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"SELECT rowid, date, type, description FROM annotations WHERE date = @date";
        command.Parameters.AddWithValue("@date", date);
        using var reader = command.ExecuteReader();
        if (reader.Read())
          return new Annotation(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
      }
      return null;
    }

    public static void InsertDaysOff()
    {
      Annotation? christmas = GetAnnotation(DateTime.Now.Year.ToString() + "-12-25");
      if (christmas == null)
      {
        Dictionary<string, DateTime> holidays = Calendar.GetHolidays(DateTime.Now.Year);
        foreach (var kvp in holidays)
        {
          InsertAnnotation(kvp.Value.ToString("yyyy-MM-dd"), "day_off", kvp.Key);
        }
      }
    }

    public static void CloseConnection()
    {
      sqliteConnection?.Close();
    }

  }
}
