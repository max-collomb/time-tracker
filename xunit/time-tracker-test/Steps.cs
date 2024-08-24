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

  }
}