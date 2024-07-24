using AIDemon.Properties;
using OpenAI.Chat;

public partial class QueryResultDialog : Form
{
	public bool Saved { get; private set; } = false;
	public QueryResultDialog(string query)
	{
		InitializeComponent();
		this.Text = query;
		LoadQueryResultAsync(query);
	}

	private void CloseButton_Click(object sender, EventArgs e)
	{
		this.Saved = true;
		this.Close();
	}

	private async void LoadQueryResultAsync(string query)
	{
		try
		{
			string result = await CallAI(query);
			QueryResultTextBox.Text = result;
		}
		catch (Exception ex)
		{
			QueryResultTextBox.Text = $"Error calling AI: {ex.Message}";
		}
	}

	private async Task<string> CallAI(string query)
	{
		// Call AI here
		ChatClient client = new(model: Settings.Default.Model, Settings.Default.ApiKey);
		ChatCompletion completion = await client.CompleteChatAsync(query);
		if (completion.Content.Count == 0)
		{
			throw new Exception("No completion returned");
		}
		string result = completion.Content[0].Text;
		return result;
	}
}

