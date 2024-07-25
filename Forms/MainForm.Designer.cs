partial class MainForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		QueryResultsGrid = new DataGridView();
		splitContainer1 = new SplitContainer();
		splitContainer3 = new SplitContainer();
		QueryResultTextBox = new TextBox();
		ExecuteScriptButton = new Button();
		splitContainer2 = new SplitContainer();
		SettingsButton = new Button();
		SendQueryButton = new Button();
		QueryTextBox = new TextBox();
		splitContainer4 = new SplitContainer();
		textBoxOutput = new TextBox();
		((System.ComponentModel.ISupportInitialize)QueryResultsGrid).BeginInit();
		((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
		splitContainer1.Panel1.SuspendLayout();
		splitContainer1.Panel2.SuspendLayout();
		splitContainer1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
		splitContainer3.Panel1.SuspendLayout();
		splitContainer3.Panel2.SuspendLayout();
		splitContainer3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
		splitContainer2.Panel1.SuspendLayout();
		splitContainer2.Panel2.SuspendLayout();
		splitContainer2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
		splitContainer4.Panel1.SuspendLayout();
		splitContainer4.Panel2.SuspendLayout();
		splitContainer4.SuspendLayout();
		SuspendLayout();
		// 
		// QueryResultsGrid
		// 
		QueryResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		QueryResultsGrid.Dock = DockStyle.Fill;
		QueryResultsGrid.Location = new Point(0, 0);
		QueryResultsGrid.Name = "QueryResultsGrid";
		QueryResultsGrid.Size = new Size(326, 455);
		QueryResultsGrid.TabIndex = 0;
		QueryResultsGrid.CellDoubleClick += QueryResultsGrid_CellDoubleClick;
		// 
		// splitContainer1
		// 
		splitContainer1.Dock = DockStyle.Fill;
		splitContainer1.Location = new Point(0, 0);
		splitContainer1.Name = "splitContainer1";
		// 
		// splitContainer1.Panel1
		// 
		splitContainer1.Panel1.Controls.Add(splitContainer3);
		splitContainer1.Panel1MinSize = 200;
		// 
		// splitContainer1.Panel2
		// 
		splitContainer1.Panel2.Controls.Add(QueryResultsGrid);
		splitContainer1.Panel2MinSize = 200;
		splitContainer1.Size = new Size(684, 455);
		splitContainer1.SplitterDistance = 354;
		splitContainer1.TabIndex = 1;
		// 
		// splitContainer3
		// 
		splitContainer3.Dock = DockStyle.Fill;
		splitContainer3.FixedPanel = FixedPanel.Panel2;
		splitContainer3.IsSplitterFixed = true;
		splitContainer3.Location = new Point(0, 0);
		splitContainer3.Name = "splitContainer3";
		splitContainer3.Orientation = Orientation.Horizontal;
		// 
		// splitContainer3.Panel1
		// 
		splitContainer3.Panel1.Controls.Add(QueryResultTextBox);
		// 
		// splitContainer3.Panel2
		// 
		splitContainer3.Panel2.Controls.Add(ExecuteScriptButton);
		splitContainer3.Panel2.Padding = new Padding(10);
		splitContainer3.Panel2MinSize = 50;
		splitContainer3.Size = new Size(354, 455);
		splitContainer3.SplitterDistance = 399;
		splitContainer3.TabIndex = 1;
		// 
		// QueryResultTextBox
		// 
		QueryResultTextBox.Dock = DockStyle.Fill;
		QueryResultTextBox.Location = new Point(0, 0);
		QueryResultTextBox.Multiline = true;
		QueryResultTextBox.Name = "QueryResultTextBox";
		QueryResultTextBox.ScrollBars = ScrollBars.Both;
		QueryResultTextBox.Size = new Size(354, 399);
		QueryResultTextBox.TabIndex = 0;
		// 
		// ExecuteScriptButton
		// 
		ExecuteScriptButton.Dock = DockStyle.Right;
		ExecuteScriptButton.Location = new Point(269, 10);
		ExecuteScriptButton.Name = "ExecuteScriptButton";
		ExecuteScriptButton.Size = new Size(75, 32);
		ExecuteScriptButton.TabIndex = 0;
		ExecuteScriptButton.Text = "Execute";
		ExecuteScriptButton.UseVisualStyleBackColor = true;
		ExecuteScriptButton.Click += ExecuteScriptButton_Click;
		// 
		// splitContainer2
		// 
		splitContainer2.Dock = DockStyle.Fill;
		splitContainer2.FixedPanel = FixedPanel.Panel1;
		splitContainer2.IsSplitterFixed = true;
		splitContainer2.Location = new Point(0, 0);
		splitContainer2.Name = "splitContainer2";
		splitContainer2.Orientation = Orientation.Horizontal;
		// 
		// splitContainer2.Panel1
		// 
		splitContainer2.Panel1.Controls.Add(SettingsButton);
		splitContainer2.Panel1.Controls.Add(SendQueryButton);
		splitContainer2.Panel1.Controls.Add(QueryTextBox);
		splitContainer2.Panel1.Padding = new Padding(10);
		splitContainer2.Panel1MinSize = 75;
		// 
		// splitContainer2.Panel2
		// 
		splitContainer2.Panel2.Controls.Add(splitContainer4);
		splitContainer2.Size = new Size(684, 761);
		splitContainer2.SplitterDistance = 75;
		splitContainer2.TabIndex = 2;
		// 
		// SettingsButton
		// 
		SettingsButton.Dock = DockStyle.Left;
		SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
		SettingsButton.Location = new Point(10, 33);
		SettingsButton.Name = "SettingsButton";
		SettingsButton.Size = new Size(28, 32);
		SettingsButton.TabIndex = 2;
		SettingsButton.UseVisualStyleBackColor = true;
		SettingsButton.Click += SettingsButton_Click;
		// 
		// SendQueryButton
		// 
		SendQueryButton.Dock = DockStyle.Right;
		SendQueryButton.Location = new Point(599, 33);
		SendQueryButton.Name = "SendQueryButton";
		SendQueryButton.Size = new Size(75, 32);
		SendQueryButton.TabIndex = 0;
		SendQueryButton.Text = "Send";
		SendQueryButton.UseVisualStyleBackColor = true;
		SendQueryButton.Click += SendQueryButton_Click;
		// 
		// QueryTextBox
		// 
		QueryTextBox.Dock = DockStyle.Top;
		QueryTextBox.Location = new Point(10, 10);
		QueryTextBox.Name = "QueryTextBox";
		QueryTextBox.Size = new Size(664, 23);
		QueryTextBox.TabIndex = 1;
		// 
		// splitContainer4
		// 
		splitContainer4.Dock = DockStyle.Fill;
		splitContainer4.Location = new Point(0, 0);
		splitContainer4.Name = "splitContainer4";
		splitContainer4.Orientation = Orientation.Horizontal;
		// 
		// splitContainer4.Panel1
		// 
		splitContainer4.Panel1.Controls.Add(splitContainer1);
		splitContainer4.Panel1MinSize = 200;
		// 
		// splitContainer4.Panel2
		// 
		splitContainer4.Panel2.Controls.Add(textBoxOutput);
		splitContainer4.Panel2MinSize = 100;
		splitContainer4.Size = new Size(684, 682);
		splitContainer4.SplitterDistance = 455;
		splitContainer4.TabIndex = 2;
		// 
		// textBoxOutput
		// 
		textBoxOutput.Dock = DockStyle.Fill;
		textBoxOutput.Location = new Point(0, 0);
		textBoxOutput.Multiline = true;
		textBoxOutput.Name = "textBoxOutput";
		textBoxOutput.ScrollBars = ScrollBars.Both;
		textBoxOutput.Size = new Size(684, 223);
		textBoxOutput.TabIndex = 0;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(684, 761);
		Controls.Add(splitContainer2);
		Icon = (Icon)resources.GetObject("$this.Icon");
		MinimumSize = new Size(480, 450);
		Name = "MainForm";
		Text = "AIDemon";
		((System.ComponentModel.ISupportInitialize)QueryResultsGrid).EndInit();
		splitContainer1.Panel1.ResumeLayout(false);
		splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
		splitContainer1.ResumeLayout(false);
		splitContainer3.Panel1.ResumeLayout(false);
		splitContainer3.Panel1.PerformLayout();
		splitContainer3.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
		splitContainer3.ResumeLayout(false);
		splitContainer2.Panel1.ResumeLayout(false);
		splitContainer2.Panel1.PerformLayout();
		splitContainer2.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
		splitContainer2.ResumeLayout(false);
		splitContainer4.Panel1.ResumeLayout(false);
		splitContainer4.Panel2.ResumeLayout(false);
		splitContainer4.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
		splitContainer4.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private DataGridView QueryResultsGrid;
	private SplitContainer splitContainer1;
	private TextBox QueryResultTextBox;
	private SplitContainer splitContainer2;
	private Button SendQueryButton;
	private TextBox QueryTextBox;
	private SplitContainer splitContainer3;
	private Button ExecuteScriptButton;
	private SplitContainer splitContainer4;
	private TextBox textBoxOutput;
	private Button SettingsButton;
}

