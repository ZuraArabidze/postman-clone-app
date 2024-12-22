namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callAPI_Click(object sender, EventArgs e)
    {
        // Validate the API URL
        try
        {
            systemStatus.Text = "Calling API...";
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch(Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
