using System.Diagnostics;

public partial class Main : Form
{
	public Main()
	{
		InitializeComponent();
		QueryResultsGrid.Columns.Add("Query", "Query");
		QueryResultsGrid.Columns.Add("Result", "Result");
	}

	private void QueryResultsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		//QueryResultsGrid.Rows[e.RowIndex][e.ColumnIndex]
		string text = QueryResultsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
		QueryResultTextBox.Text = text;
	}

	private void SendQueryButton_Click(object sender, EventArgs e)
	{
		if (QueryTextBox.Text == "")
		{
			MessageBox.Show("Please enter a query");
			return;
		}
		string result = "";
		QueryResultDialog queryResultDialog = new QueryResultDialog(QueryTextBox.Text);
		queryResultDialog.FormClosed += (s, ev) =>
		{
			result = queryResultDialog.QueryResultTextBox.Text;
			if (!string.IsNullOrEmpty(result) && queryResultDialog.Saved)
			{
				QueryResultsGrid.Rows.Add(QueryTextBox.Text, result);
				QueryTextBox.Text = "";
			}
		};
		queryResultDialog.Show();
	}

	private void ExecuteScriptButton_Click(object sender, EventArgs e)
	{
		string scriptContent = QueryResultTextBox.Text;

		string scriptPath = Path.Combine(Path.GetTempPath(), $"{Path.GetTempFileName()}.ps1");
		File.WriteAllText(scriptPath, scriptContent);

		RunPowerShellScript(scriptPath);
	}

	private async void RunPowerShellScript(string scriptPath)
	{
		var psi = new ProcessStartInfo
		{
			FileName = "powershell.exe",
			Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
			UseShellExecute = false,
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			CreateNoWindow = true
		};

		var process = new Process();
		process.StartInfo = psi;
		process.OutputDataReceived += (sender, e) => UpdateTextBox(e.Data);
		process.ErrorDataReceived += (sender, e) => UpdateTextBox(e.Data);

		process.Start();
		process.BeginOutputReadLine();
		process.BeginErrorReadLine();
		await Task.Run(() => process.WaitForExit());
	}

	private void UpdateTextBox(string text)
	{
		if (textBoxOutput.InvokeRequired)
		{
			textBoxOutput.Invoke(new Action<string>(UpdateTextBox), text);
		}
		else
		{
			textBoxOutput.AppendText(text + Environment.NewLine);
		}
	}
}
