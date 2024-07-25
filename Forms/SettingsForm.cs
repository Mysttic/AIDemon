using AIDemon.Properties;

public partial class SettingsForm : Form
{
	public SettingsForm()
	{
		InitializeComponent();
		ApiKeyTextBox.Text = Settings.Default.ApiKey;
	}

	private void CloseButton_Click(object sender, EventArgs e)
	{
		Settings.Default.ApiKey = ApiKeyTextBox.Text;
		Settings.Default.Save();
		this.Close();
	}
}
