namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private void apiLabel_Click(object sender, EventArgs e)
    {

    }

    private void systemStatus_Click(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // validate the API URL

        try
        {
            systemStatus.Text = "Calling API...";

            //test code - replace with actual API call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
