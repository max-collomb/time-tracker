using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace time_tracker
{
  public class Event(string date, string time, string type) : IComparable<Event>
  {
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
      command.CommandText += "DELETE FROM events WHERE 1;";
      command.CommandText += "INSERT INTO events (date, time, type) VALUES ";
      command.CommandText += "(\"2024-07-10\", \"08:15\", \"user_check\"),(\"2024-07-10\", \"12:15\", \"user_check\"),(\"2024-07-15\", \"13:15\", \"user_check\"),(\"2024-07-15\", \"17:00\", \"user_check\"),";
      command.CommandText += "(\"2024-07-16\", \"08:15\", \"user_check\"),(\"2024-07-16\", \"12:15\", \"user_check\"),(\"2024-07-16\", \"14:00\", \"user_check\"),(\"2024-07-16\", \"17:00\", \"user_check\"),";
      command.CommandText += "(\"2024-07-17\", \"08:15\", \"user_check\"),(\"2024-07-17\", \"12:15\", \"user_check\"),(\"2024-07-17\", \"13:30\", \"user_check\"),(\"2024-07-17\", \"18:00\", \"user_check\"),";
      //command.CommandText += "(\"2024-07-18\", \"08:15\", \"user_check\"),(\"2024-07-18\", \"12:15\", \"user_check\"),(\"2024-07-18\", \"13:15\", \"user_check\"),(\"2024-07-18\", \"17:30\", \"user_check\"),";
      //command.CommandText += "(\"2024-07-19\", \"08:30\", \"user_check\"),(\"2024-07-19\", \"12:00\", \"user_check\"),(\"2024-07-19\", \"14:00\", \"user_check\"),(\"2024-07-19\", \"16:00\", \"user_check\");";
      command.CommandText += "(\"2024-07-18\", \"08:10\", \"user_check\"),(\"2024-07-18\", \"09:10\", \"user_check\"),(\"2024-07-18\", \"09:20\", \"user_check\"),(\"2024-07-18\", \"10:10\", \"user_check\"),(\"2024-07-18\", \"10:20\", \"user_check\"),(\"2024-07-18\", \"12:15\", \"user_check\"),(\"2024-07-18\", \"13:15\", \"user_check\");";
      command.ExecuteNonQuery();
      // TODO : faire un backup sur U:\
      // https://learn.microsoft.com/fr-fr/dotnet/standard/data/sqlite/backup
    }

    public static void InsertEvent(string? type = null, string? date = null, string? time = null)
    {
      if (sqliteConnection != null)
      {
        // TODO vérifier qu'il n'y a pas déjà un événement "user_check" le même jour à la même heure/minute
        DateTime now = DateTime.Now;
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"INSERT INTO events (date, time, type) VALUES (@date, @time, @type)";
        command.Parameters.AddWithValue("@date", String.IsNullOrEmpty(date) ? $"{now:yyyy-MM-dd}" : date);
        command.Parameters.AddWithValue("@time", String.IsNullOrEmpty(time) ? $"{now:HH:mm}" : time);
        command.Parameters.AddWithValue("@type", String.IsNullOrEmpty(type) ? "user_check" : type);
        command.ExecuteNonQuery();
      }
    }

    public static void UpdateEvent(Event evt, string time)
    {
      if (sqliteConnection != null)
      {
        Match match = new Regex(@"([0-9]{2}):([0-9]{2})").Match(time);
        if (match.Success)
        {
          var command = sqliteConnection.CreateCommand();
          command.CommandText = @"UPDATE events SET time = @newTime WHERE type = @type AND date = @date AND time = @time";
          command.Parameters.AddWithValue("@newTime", time);
          command.Parameters.AddWithValue("@type", evt.Type);
          command.Parameters.AddWithValue("@date", evt.Date);
          command.Parameters.AddWithValue("@time", evt.Time);
          command.ExecuteNonQuery();
        }
      }
    }

    public static void DeleteEvent(Event evt)
    {
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"DELETE FROM events WHERE type = @type AND date = @date AND time = @time";
        command.Parameters.AddWithValue("@type", evt.Type);
        command.Parameters.AddWithValue("@date", evt.Date);
        command.Parameters.AddWithValue("@time", evt.Time);
        command.ExecuteNonQuery();
      }
    }

    public static List<Event> GetEvents(string? date1 = null, string? date2 = null)
    {
      List<Event> rows = [];
      if (sqliteConnection != null)
      {
        var command = sqliteConnection.CreateCommand();
        command.CommandText = @"SELECT date, time, type FROM events";
        if (!String.IsNullOrEmpty(date1) && !String.IsNullOrEmpty(date2))
        {
          command.CommandText += " WHERE date >= @start AND date <= @end";
          command.Parameters.AddWithValue("@start", date1);
          command.Parameters.AddWithValue("@end", date2);
        }
        else if (!String.IsNullOrEmpty(date1))
        {
          command.CommandText += " WHERE date = @date";
          command.Parameters.AddWithValue("@date", date1);
        }
        command.CommandText += " ORDER BY date ASC, time ASC";
        using var reader = command.ExecuteReader();
        while (reader.Read())
          rows.Add(new Event(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
      }
      return rows;
    }

    public static void CloseConnection()
    {
      sqliteConnection?.Close();
    }

  }
}
