partial class SettingsForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
		ApiKeyTextBox = new TextBox();
		CloseButton = new Button();
		ApiKeyLabel = new Label();
		SuspendLayout();
		// 
		// ApiKeyTextBox
		// 
		ApiKeyTextBox.Dock = DockStyle.Top;
		ApiKeyTextBox.Location = new Point(3, 18);
		ApiKeyTextBox.Name = "ApiKeyTextBox";
		ApiKeyTextBox.ScrollBars = ScrollBars.Both;
		ApiKeyTextBox.Size = new Size(678, 23);
		ApiKeyTextBox.TabIndex = 2;
		// 
		// CloseButton
		// 
		CloseButton.Dock = DockStyle.Bottom;
		CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
		CloseButton.Location = new Point(3, 128);
		CloseButton.Name = "CloseButton";
		CloseButton.Size = new Size(678, 23);
		CloseButton.TabIndex = 3;
		CloseButton.Text = "Save";
		CloseButton.UseVisualStyleBackColor = true;
		CloseButton.Click += CloseButton_Click;
		// 
		// ApiKeyLabel
		// 
		ApiKeyLabel.AutoSize = true;
		ApiKeyLabel.Dock = DockStyle.Top;
		ApiKeyLabel.Location = new Point(3, 3);
		ApiKeyLabel.Name = "ApiKeyLabel";
		ApiKeyLabel.Size = new Size(49, 15);
		ApiKeyLabel.TabIndex = 4;
		ApiKeyLabel.Text = "Api key:";
		// 
		// SettingsForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(684, 161);
		Controls.Add(ApiKeyTextBox);
		Controls.Add(ApiKeyLabel);
		Controls.Add(CloseButton);
		Icon = (Icon)resources.GetObject("$this.Icon");
		MinimumSize = new Size(225, 120);
		Name = "SettingsForm";
		Padding = new Padding(3, 3, 3, 10);
		Text = "SettingsForm";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	public TextBox ApiKeyTextBox;
	private Button CloseButton;
	private Label ApiKeyLabel;
}
