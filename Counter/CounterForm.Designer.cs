namespace Counter
{
	public partial class CounterForm
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
			this.uxCounter = new System.Windows.Forms.TextBox();
			this.uxCountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// uxCounter
			// 
			this.uxCounter.Location = new System.Drawing.Point(12, 41);
			this.uxCounter.Name = "uxCounter";
			this.uxCounter.Size = new System.Drawing.Size(100, 20);
			this.uxCounter.TabIndex = 0;
			// 
			// uxCountButton
			// 
			this.uxCountButton.Location = new System.Drawing.Point(12, 12);
			this.uxCountButton.Name = "uxCountButton";
			this.uxCountButton.Size = new System.Drawing.Size(100, 23);
			this.uxCountButton.TabIndex = 1;
			this.uxCountButton.Text = "Count";
			this.uxCountButton.UseVisualStyleBackColor = true;
			this.uxCountButton.Click += new System.EventHandler(this.CountButton_Click);
			// 
			// AppMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(123, 71);
			this.Controls.Add(this.uxCountButton);
			this.Controls.Add(this.uxCounter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AppMain";
			this.Text = "Counter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox uxCounter;
		private System.Windows.Forms.Button uxCountButton;
	}
}

