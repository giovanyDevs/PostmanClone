using Microsoft.Extensions.Configuration;
using Serilog;
using PostmanClone.UI.FormUI;
using Microsoft.Extensions.Hosting;
using PostmanClone.UI.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace PostmanClone.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //Add appsettings manualy, for the configuration
        var configBuilder = new ConfigurationBuilder();
        BuildConfig(configBuilder);

        //Add Logging Before DI, for that:
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configBuilder.Build())
            .Enrich.FromLogContext()
            .WriteTo.File("logs/PostmanClone.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        //Add Exception Logging Before DI:
        Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        Log.Logger.Information("Application Starting");

        //Add DI:
        var host = Host.CreateDefaultBuilder()
            .ConfigureLogging((configuration) => {
                configuration.AddSerilog(Log.Logger, dispose: true);
            })
            .ConfigureServices((context, services) => {
                services.AddUIDependencies(context.Configuration);
            })
            .Build();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(host.Services.GetRequiredService<Dashboard>());
    }

    static void BuildConfig(IConfigurationBuilder config)
    {
        config.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables();
    }

    #region Exceptions Trappers

    /// <summary>
    ///  Handle Exception that are catch by windows forms native exception trapper
    /// </summary>
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        try
        {
            if (e.Exception != null)
            {
                Exception exception = e.Exception;

                Log.Error(exception, "Application Error");

                MessageBox.Show($"Error: {exception.Message}",
                            "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Application error occurred ",
                            "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Application Error");
            MessageBox.Show($"Error: {ex.Message}",
                            "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    ///   Handle Exception that did not came from Windows Forms native exception trapper
    /// </summary>
    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        try
        {
            if (e.ExceptionObject != null)
            {
                Exception exception = (Exception)e.ExceptionObject;

                Log.Error(exception, "Domain Error");

                MessageBox.Show($"Error: {exception.Message}",
                            "Domain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Application error occurred ",
                            "Domain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.IsTerminating)
            {
                MessageBox.Show($"Finishing application ",
                           "Domain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Domain Error");

            MessageBox.Show($"Error: {ex.Message}",
                            "Domain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    #endregion
}