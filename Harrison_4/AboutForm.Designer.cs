namespace Harrison_4
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            this.aboutFormPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aboutFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutFormPictureBox
            // 
            this.aboutFormPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutFormPictureBox.Image = global::Harrison_4.Properties.Resources.theater_two;
            this.aboutFormPictureBox.Location = new System.Drawing.Point(16, 15);
            this.aboutFormPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.aboutFormPictureBox.Name = "aboutFormPictureBox";
            this.aboutFormPictureBox.Size = new System.Drawing.Size(133, 139);
            this.aboutFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutFormPictureBox.TabIndex = 0;
            this.aboutFormPictureBox.TabStop = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutLabel.Location = new System.Drawing.Point(193, 32);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(241, 48);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Programmer: Brennan Harrison Copyright (2018)";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Location = new System.Drawing.Point(251, 120);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 34);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Cl&ose";
            this.aboutFormToolTip.SetToolTip(this.closeButton, "Click to return to registration");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 186);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.aboutFormPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Registration Entry";
            ((System.ComponentModel.ISupportInitialize)(this.aboutFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aboutFormPictureBox;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip aboutFormToolTip;
    }
}