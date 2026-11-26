using System.Collections.Generic;
using System.Globalization;
using time_tracker;

namespace time_tracker_test
{
  public class Steps
  {
    [Fact]
    public void Test1()
    {
      Day.WeekLoad = 2220; // 37h
      string currentDay = "2024-08-26";
      string currentTime = "09:15";
      List<string> steps = TimeHelper.GetTargetSteps(
        [
          new("2024-08-26", ["08:45"], "", currentDay, currentTime),
          new("2024-08-27", [], "", currentDay, currentTime),
          new("2024-08-28", [], "", currentDay, currentTime),
          new("2024-08-29", [], "", currentDay, currentTime),
          new("2024-08-30", [], "", currentDay, currentTime),
        ],
        0,
        DateTime.ParseExact(currentTime, "HH:mm", CultureInfo.InvariantCulture),
        [465, 465, 465, 465, 360],
        [60, 60, 60, 60, 120],
        false,
        ""
      );
      Assert.Equal("12:15|13:15|17:30", string.Join('|', steps));
    }

    [Fact]
    public void Test2()
    {
      Day.WeekLoad = 2220; // 37h
      string currentDay = "2024-08-26";
      string currentTime = "09:15";
      List<string> steps = TimeHelper.GetTargetSteps(
        [
          new("2024-08-26", ["08:45"], "", currentDay, currentTime),
          new("2024-08-27", [], "", currentDay, currentTime),
          new("2024-08-28", [], "", currentDay, currentTime),
          new("2024-08-29", [], "", currentDay, currentTime),
          new("2024-08-30", [], "", currentDay, currentTime),
        ],
        0,
        DateTime.ParseExact(currentTime, "HH:mm", CultureInfo.InvariantCulture),
        [465, 465, 465, 465, 360],
        [60, 60, 60, 60, 120],
        true,
        "12:30"
      );
      Assert.Equal("12:30|13:30|17:30", string.Join('|', steps));
    }

    [Fact]
    public void Test3()
    {
      Day.WeekLoad = 2220;
      string currentDay = "2025-05-07";
      string currentTime = "14:00";
      List<string> steps = TimeHelper.GetTargetSteps(
        [
          new("2025-05-05", ["08:38","12:15","13:15","17:30"], "", currentDay, currentTime),
          new("2025-05-06", ["07:11","07:31","08:10","13:30","15:20","17:50"], "", currentDay, currentTime),
          new("2025-05-07", ["08:36","12:16","14:00"], "", currentDay, currentTime),
          new("2025-05-08", [], "day_off", currentDay, currentTime),
          new("2025-05-09", [], "day_off", currentDay, currentTime),
          new("2025-05-10", [], "", currentDay, currentTime),
          new("2025-05-11", [], "", currentDay, currentTime),
        ],
        2, // Today's week index
        DateTime.ParseExact(currentTime, "HH:mm", CultureInfo.InvariantCulture),
        [465, 465, 465, 465, 360, 0, 0],
        [60, 60, 60, 60, 120, 0, 0],
        true, // rappel activé ?
        "" // heure du prochain rappel
      );
      // étapes de rappel attendues
      Assert.Equal("16:30", string.Join('|', steps)); // si on tient compte du fait que le mercredi est le dernier jour de la semaine, car jeu et ven sont en day_off
    }


  }
}