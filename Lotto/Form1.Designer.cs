namespace Lotto
{
    partial class Lotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AscendingCheckbox = new System.Windows.Forms.CheckBox();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateButton.BackColor = System.Drawing.SystemColors.Menu;
            this.GenerateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(106)))));
            this.GenerateButton.Location = new System.Drawing.Point(319, 677);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(816, 107);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate Random Lottery Numbers!";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // AscendingCheckbox
            // 
            this.AscendingCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AscendingCheckbox.AutoSize = true;
            this.AscendingCheckbox.Location = new System.Drawing.Point(85, 700);
            this.AscendingCheckbox.Name = "AscendingCheckbox";
            this.AscendingCheckbox.Size = new System.Drawing.Size(172, 54);
            this.AscendingCheckbox.TabIndex = 2;
            this.AscendingCheckbox.Text = "Organise In \r\nAscending Order";
            this.AscendingCheckbox.UseVisualStyleBackColor = true;
            this.AscendingCheckbox.CheckedChanged += new System.EventHandler(this.AscendingCheckbox_CheckedChanged);
            // 
            // numbersListBox
            // 
            this.numbersListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numbersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numbersListBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numbersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(222)))), ((int)(((byte)(64)))));
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.ItemHeight = 115;
            this.numbersListBox.Location = new System.Drawing.Point(470, 41);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(951, 115);
            this.numbersListBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1307, 606);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(106)))));
            this.CloseButton.Location = new System.Drawing.Point(1309, 773);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(112, 34);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 819);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AscendingCheckbox);
            this.Controls.Add(this.GenerateButton);
            this.Name = "Lotto";
            this.Text = "Lotto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox AscendingCheckbox;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
    }
}

