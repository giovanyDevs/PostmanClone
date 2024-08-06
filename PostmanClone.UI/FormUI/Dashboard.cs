namespace PostmanClone.UI.FormUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void StartRequestButton_Click(object sender, EventArgs e)
    {
        try
        {
            InitiateFormAsyncMethod((Button)sender);

            UpdateSystemStatus("Calling API.....");

            //Validate User Input

            //Make a API CALL

            //Show Results

            // Similation of API Calling
            await Task.Delay(2000);

            UpdateSystemStatus("Ready");
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Error: {ex.Message}",
                                  "Start Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateSystemStatus("An error occurred");
        }
        finally 
        {
            FinalizeFormAsyncMethod((Button)sender);
        }
    }

    private void UpdateSystemStatus(string status)
    {
        SystemStatusToolStripLabel.Text = $"Status: {status}.";
    }

    private static void InitiateFormAsyncMethod(Button button) => button.Enabled = false;

    private static void FinalizeFormAsyncMethod(Button button) => button.Enabled = true;
}
