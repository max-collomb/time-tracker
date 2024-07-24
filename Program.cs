using Serilog;

namespace time_tracker
{
  internal static class Program
  {
#if DEBUG
    static readonly Mutex Mutex = new(true, "{71da884c-0c70-453f-b47f-81daa9433878}");
    static public readonly string DbFileName = "time-tracker-debug.sqlite";
#else
    static readonly Mutex Mutex = new(true, "{75053982-82ae-454d-9019-1355a1042fa9}");
    static readonly string DbFileName = "time-tracker.sqlite";
#endif
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if (Mutex.WaitOne(TimeSpan.Zero, true))
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();
        InitializeLogger();
        Application.Run(new MainForm());
      }
      else
      {
        // send our Win32 message to make the currently running instance jump on top of all the other windows
        NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_SHOWME, IntPtr.Zero, IntPtr.Zero);
      }
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