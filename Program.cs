using Serilog;

namespace time_tracker
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      ApplicationConfiguration.Initialize();
      InitializeLogger();
      Application.Run(new MainForm());
    }

    static void InitializeLogger()
    {
      Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.File(
                      Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"time-tracker-{DateTime.Now.Year}.log"),
                      rollingInterval: RollingInterval.Infinite,
                      outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
                    .CreateLogger();
    }
  }
}