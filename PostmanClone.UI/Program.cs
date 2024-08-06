using PostmanClone.UI.FormUI;

namespace PostmanClone.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Dashboard());
    }

    #region Exceptions Trappers
    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        try
        {
            if (e.ExceptionObject != null)
            {
                Exception exception = (Exception)e.ExceptionObject;

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
            MessageBox.Show($"Error: {ex.Message}",
                            "Domain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        try
        {
            if (e.Exception != null)
            {
                Exception exception = e.Exception;

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
            MessageBox.Show($"Error: {ex.Message}",
                            "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    } 
    #endregion
}