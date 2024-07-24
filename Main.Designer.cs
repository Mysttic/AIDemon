partial class Main
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
		QueryResultsGrid = new DataGridView();
		splitContainer1 = new SplitContainer();
		splitContainer3 = new SplitContainer();
		QueryResultTextBox = new TextBox();
		ExecuteScriptButton = new Button();
		splitContainer2 = new SplitContainer();
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
		QueryResultsGrid.Location = new Point(0, 0);
		QueryResultsGrid.Name = "QueryResultsGrid";
		QueryResultsGrid.Size = new Size(547, 675);
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
		// 
		// splitContainer1.Panel2
		// 
		splitContainer1.Panel2.Controls.Add(QueryResultsGrid);
		splitContainer1.Size = new Size(928, 482);
		splitContainer1.SplitterDistance = 377;
		splitContainer1.TabIndex = 1;
		// 
		// splitContainer3
		// 
		splitContainer3.Dock = DockStyle.Fill;
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
		splitContainer3.Size = new Size(377, 482);
		splitContainer3.SplitterDistance = 422;
		splitContainer3.TabIndex = 1;
		// 
		// QueryResultTextBox
		// 
		QueryResultTextBox.Dock = DockStyle.Fill;
		QueryResultTextBox.Location = new Point(0, 0);
		QueryResultTextBox.Multiline = true;
		QueryResultTextBox.Name = "QueryResultTextBox";
		QueryResultTextBox.ScrollBars = ScrollBars.Both;
		QueryResultTextBox.Size = new Size(377, 422);
		QueryResultTextBox.TabIndex = 0;
		// 
		// ExecuteScriptButton
		// 
		ExecuteScriptButton.Dock = DockStyle.Right;
		ExecuteScriptButton.Location = new Point(292, 10);
		ExecuteScriptButton.Name = "ExecuteScriptButton";
		ExecuteScriptButton.Size = new Size(75, 36);
		ExecuteScriptButton.TabIndex = 0;
		ExecuteScriptButton.Text = "Execute";
		ExecuteScriptButton.UseVisualStyleBackColor = true;
		ExecuteScriptButton.Click += ExecuteScriptButton_Click;
		// 
		// splitContainer2
		// 
		splitContainer2.Dock = DockStyle.Fill;
		splitContainer2.Location = new Point(0, 0);
		splitContainer2.Name = "splitContainer2";
		splitContainer2.Orientation = Orientation.Horizontal;
		// 
		// splitContainer2.Panel1
		// 
		splitContainer2.Panel1.Controls.Add(SendQueryButton);
		splitContainer2.Panel1.Controls.Add(QueryTextBox);
		splitContainer2.Panel1.Padding = new Padding(10);
		// 
		// splitContainer2.Panel2
		// 
		splitContainer2.Panel2.Controls.Add(splitContainer4);
		splitContainer2.Size = new Size(928, 753);
		splitContainer2.SplitterDistance = 74;
		splitContainer2.TabIndex = 2;
		// 
		// SendQueryButton
		// 
		SendQueryButton.Dock = DockStyle.Right;
		SendQueryButton.Location = new Point(843, 33);
		SendQueryButton.Name = "SendQueryButton";
		SendQueryButton.Size = new Size(75, 31);
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
		QueryTextBox.Size = new Size(908, 23);
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
		// 
		// splitContainer4.Panel2
		// 
		splitContainer4.Panel2.Controls.Add(textBoxOutput);
		splitContainer4.Size = new Size(928, 675);
		splitContainer4.SplitterDistance = 482;
		splitContainer4.TabIndex = 2;
		// 
		// textBoxOutput
		// 
		textBoxOutput.Dock = DockStyle.Fill;
		textBoxOutput.Location = new Point(0, 0);
		textBoxOutput.Multiline = true;
		textBoxOutput.Name = "textBoxOutput";
		textBoxOutput.ScrollBars = ScrollBars.Both;
		textBoxOutput.Size = new Size(928, 189);
		textBoxOutput.TabIndex = 0;
		// 
		// Main
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(928, 753);
		Controls.Add(splitContainer2);
		Name = "Main";
		Text = "DemonAI";
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
}

