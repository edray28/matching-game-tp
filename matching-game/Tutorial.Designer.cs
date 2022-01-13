
namespace matching_game
{
    partial class Tutorial
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
            this.pnlCorrect = new System.Windows.Forms.Panel();
            this.pnlWrong = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlCorrect
            // 
            this.pnlCorrect.BackColor = System.Drawing.Color.White;
            this.pnlCorrect.Location = new System.Drawing.Point(12, 12);
            this.pnlCorrect.Name = "pnlCorrect";
            this.pnlCorrect.Size = new System.Drawing.Size(341, 171);
            this.pnlCorrect.TabIndex = 0;
            // 
            // pnlWrong
            // 
            this.pnlWrong.BackColor = System.Drawing.Color.White;
            this.pnlWrong.Location = new System.Drawing.Point(12, 197);
            this.pnlWrong.Name = "pnlWrong";
            this.pnlWrong.Size = new System.Drawing.Size(341, 182);
            this.pnlWrong.TabIndex = 1;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(365, 391);
            this.Controls.Add(this.pnlWrong);
            this.Controls.Add(this.pnlCorrect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCorrect;
        private System.Windows.Forms.Panel pnlWrong;
    }
}