namespace MusicViewer
{
	partial class MainForm
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
			this.loadButton = new System.Windows.Forms.Button();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.fromLabel = new System.Windows.Forms.Label();
			this.lengthLabel = new System.Windows.Forms.Label();
			this.albumLabel = new System.Windows.Forms.Label();
			this.releasedLabel = new System.Windows.Forms.Label();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.listBox = new System.Windows.Forms.ListBox();
			this.genresLabel = new System.Windows.Forms.Label();
			this.albumTextBox = new System.Windows.Forms.TextBox();
			this.releasedTextBox = new System.Windows.Forms.TextBox();
			this.lengthTextBox = new System.Windows.Forms.TextBox();
			this.genresTextBox = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(12, 12);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(75, 23);
			this.loadButton.TabIndex = 0;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.Location = new System.Drawing.Point(93, 14);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(417, 21);
			this.comboBox.TabIndex = 1;
			this.comboBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fromLabel.Location = new System.Drawing.Point(12, 52);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(44, 17);
			this.fromLabel.TabIndex = 2;
			this.fromLabel.Text = "From:";
			// 
			// lengthLabel
			// 
			this.lengthLabel.AutoSize = true;
			this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lengthLabel.Location = new System.Drawing.Point(297, 180);
			this.lengthLabel.Name = "lengthLabel";
			this.lengthLabel.Size = new System.Drawing.Size(56, 17);
			this.lengthLabel.TabIndex = 3;
			this.lengthLabel.Text = "Length:";
			// 
			// albumLabel
			// 
			this.albumLabel.AutoSize = true;
			this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.albumLabel.Location = new System.Drawing.Point(302, 80);
			this.albumLabel.Name = "albumLabel";
			this.albumLabel.Size = new System.Drawing.Size(51, 17);
			this.albumLabel.TabIndex = 4;
			this.albumLabel.Text = "Album:";
			// 
			// releasedLabel
			// 
			this.releasedLabel.AutoSize = true;
			this.releasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.releasedLabel.Location = new System.Drawing.Point(281, 130);
			this.releasedLabel.Name = "releasedLabel";
			this.releasedLabel.Size = new System.Drawing.Size(72, 17);
			this.releasedLabel.TabIndex = 5;
			this.releasedLabel.Text = "Released:";
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toLabel.Location = new System.Drawing.Point(294, 52);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(29, 17);
			this.toLabel.TabIndex = 6;
			this.toLabel.Text = "To:";
			// 
			// fromDateTimePicker
			// 
			this.fromDateTimePicker.Enabled = false;
			this.fromDateTimePicker.Location = new System.Drawing.Point(64, 50);
			this.fromDateTimePicker.Name = "fromDateTimePicker";
			this.fromDateTimePicker.Size = new System.Drawing.Size(179, 20);
			this.fromDateTimePicker.TabIndex = 7;
			this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
			// 
			// toDateTimePicker
			// 
			this.toDateTimePicker.Enabled = false;
			this.toDateTimePicker.Location = new System.Drawing.Point(331, 52);
			this.toDateTimePicker.Name = "toDateTimePicker";
			this.toDateTimePicker.Size = new System.Drawing.Size(179, 20);
			this.toDateTimePicker.TabIndex = 8;
			this.toDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(20, 80);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(223, 277);
			this.listBox.TabIndex = 9;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
			// 
			// genresLabel
			// 
			this.genresLabel.AutoSize = true;
			this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genresLabel.Location = new System.Drawing.Point(294, 230);
			this.genresLabel.Name = "genresLabel";
			this.genresLabel.Size = new System.Drawing.Size(59, 17);
			this.genresLabel.TabIndex = 10;
			this.genresLabel.Text = "Genres:";
			// 
			// albumTextBox
			// 
			this.albumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.albumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.albumTextBox.Location = new System.Drawing.Point(359, 80);
			this.albumTextBox.Multiline = true;
			this.albumTextBox.Name = "albumTextBox";
			this.albumTextBox.ReadOnly = true;
			this.albumTextBox.Size = new System.Drawing.Size(151, 44);
			this.albumTextBox.TabIndex = 11;
			// 
			// releasedTextBox
			// 
			this.releasedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.releasedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.releasedTextBox.Location = new System.Drawing.Point(359, 130);
			this.releasedTextBox.Multiline = true;
			this.releasedTextBox.Name = "releasedTextBox";
			this.releasedTextBox.ReadOnly = true;
			this.releasedTextBox.Size = new System.Drawing.Size(151, 17);
			this.releasedTextBox.TabIndex = 12;
			// 
			// lengthTextBox
			// 
			this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lengthTextBox.Location = new System.Drawing.Point(359, 180);
			this.lengthTextBox.Multiline = true;
			this.lengthTextBox.Name = "lengthTextBox";
			this.lengthTextBox.ReadOnly = true;
			this.lengthTextBox.Size = new System.Drawing.Size(151, 17);
			this.lengthTextBox.TabIndex = 13;
			// 
			// genresTextBox
			// 
			this.genresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.genresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genresTextBox.Location = new System.Drawing.Point(359, 230);
			this.genresTextBox.Multiline = true;
			this.genresTextBox.Name = "genresTextBox";
			this.genresTextBox.ReadOnly = true;
			this.genresTextBox.Size = new System.Drawing.Size(151, 75);
			this.genresTextBox.TabIndex = 14;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 377);
			this.Controls.Add(this.genresTextBox);
			this.Controls.Add(this.lengthTextBox);
			this.Controls.Add(this.releasedTextBox);
			this.Controls.Add(this.albumTextBox);
			this.Controls.Add(this.genresLabel);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.toDateTimePicker);
			this.Controls.Add(this.fromDateTimePicker);
			this.Controls.Add(this.toLabel);
			this.Controls.Add(this.releasedLabel);
			this.Controls.Add(this.albumLabel);
			this.Controls.Add(this.lengthLabel);
			this.Controls.Add(this.fromLabel);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.loadButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MusicViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label lengthLabel;
		private System.Windows.Forms.Label albumLabel;
		private System.Windows.Forms.Label releasedLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.DateTimePicker fromDateTimePicker;
		private System.Windows.Forms.DateTimePicker toDateTimePicker;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Label genresLabel;
		private System.Windows.Forms.TextBox albumTextBox;
		private System.Windows.Forms.TextBox releasedTextBox;
		private System.Windows.Forms.TextBox lengthTextBox;
		private System.Windows.Forms.TextBox genresTextBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

