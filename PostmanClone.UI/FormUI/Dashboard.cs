using PostmanClone.Library;
using PostmanClone.Library.ApiCallCenter;
using PostmanClone.Library.ApiCallCenter.Interfaces;
using PostmanClone.Library.ApiCallCenter.Models;

namespace PostmanClone.UI.FormUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess apiCall = new ApiAccess();

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

            //Clean previous call
            ClearDashBoard();

            //Validate User Input
            if (apiCall.IsValidUrl(UrlRequestTextBox.Text, acceptOnlyHttps: true) is false)
            {
                ErrorProvider.SetError(UrlRequestTextBox, "Invalid URL");
                UpdateSystemStatus("Ready");
                return;
            }

            //Make a API CALL
            ApiCallResultModel apiCallResultModel = await apiCall.CallApiAsync(UrlRequestTextBox.Text);

            //Show Results
            LoadRequestResults(apiCallResultModel);
            LoadResponseResults(apiCallResultModel);

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

    private void ClearDashBoard()
    {
        ErrorProvider.Clear();

        StartLineRequestTextBox.Clear();
        HttpHeadersRequestTextBox.Clear();
        BodyRequestTextBox.Clear();
        StartLineResponseTextBox.Clear();
        HttpHeadersResponseTextBox.Clear();
        BodyResponseTextBox.Clear();
    }

    private void LoadRequestResults(ApiCallResultModel apiCallResultModel)
    {
        this.Invoke(() =>
        {
            HttpRestModel Request = apiCallResultModel.Request ?? new();

            StartLineRequestTextBox.Text = Request.StartLine;
            HttpHeadersRequestTextBox.Text = Request.HttpHeaders;
            BodyRequestTextBox.Text = Request.HttpBody;
        });
    }

    private void LoadResponseResults(ApiCallResultModel apiCallResultModel)
    {
        this.Invoke(() =>
        {
            HttpRestModel Responce = apiCallResultModel.Responce ?? new();

            StartLineResponseTextBox.Text = Responce.StartLine;
            HttpHeadersResponseTextBox.Text = Responce.HttpHeaders;
            BodyResponseTextBox.Text = Responce.HttpBody;
        });
    }

    private void UpdateSystemStatus(string status)
    {
        SystemStatusToolStripLabel.Text = $"Status: {status}.";
    }

    private static void InitiateFormAsyncMethod(Button button) => button.Enabled = false;

    private static void FinalizeFormAsyncMethod(Button button) => button.Enabled = true;
}
