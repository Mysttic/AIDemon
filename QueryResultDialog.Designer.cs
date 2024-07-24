	partial class QueryResultDialog
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
			QueryResultTextBox = new TextBox();
			CloseButton = new Button();
			SuspendLayout();
			// 
			// QueryResultTextBox
			// 
			QueryResultTextBox.Dock = DockStyle.Fill;
			QueryResultTextBox.Location = new Point(0, 0);
			QueryResultTextBox.Multiline = true;
			QueryResultTextBox.Name = "QueryResultTextBox";
			QueryResultTextBox.ScrollBars = ScrollBars.Both;
			QueryResultTextBox.Size = new Size(800, 427);
			QueryResultTextBox.TabIndex = 0;
			// 
			// CloseButton
			// 
			CloseButton.Dock = DockStyle.Bottom;
			CloseButton.Location = new Point(0, 427);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(800, 23);
			CloseButton.TabIndex = 1;
			CloseButton.Text = "Accept";
			CloseButton.UseVisualStyleBackColor = true;
			CloseButton.Click += CloseButton_Click;
			// 
			// QueryResultDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(QueryResultTextBox);
			Controls.Add(CloseButton);
			Name = "QueryResultDialog";
			Text = "QueryResultDialog";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public TextBox QueryResultTextBox;
		private Button CloseButton;
	}
