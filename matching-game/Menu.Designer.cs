
namespace matching_game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTutorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuTitle.Font = new System.Drawing.Font("Rockwell Extra Bold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(18, 203);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(383, 90);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Twice \r\nMatching Game";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCredits.FlatAppearance.BorderSize = 0;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredits.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.Location = new System.Drawing.Point(219, 401);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(109, 52);
            this.btnCredits.TabIndex = 2;
            this.btnCredits.TabStop = false;
            this.btnCredits.Text = "About";
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLevel3.FlatAppearance.BorderSize = 0;
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLevel3.Location = new System.Drawing.Point(289, 330);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(112, 52);
            this.btnLevel3.TabIndex = 4;
            this.btnLevel3.TabStop = false;
            this.btnLevel3.Text = "Hard";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLevel2.FlatAppearance.BorderSize = 0;
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLevel2.Location = new System.Drawing.Point(153, 329);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(111, 53);
            this.btnLevel2.TabIndex = 3;
            this.btnLevel2.TabStop = false;
            this.btnLevel2.Text = "Average";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLevel1.FlatAppearance.BorderSize = 0;
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.ForeColor = System.Drawing.Color.Black;
            this.btnLevel1.Location = new System.Drawing.Point(12, 330);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(110, 52);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.TabStop = false;
            this.btnLevel1.Text = "Easy";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::matching_game.Properties.Resources.menulogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 166);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTutorial.FlatAppearance.BorderSize = 0;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorial.Location = new System.Drawing.Point(81, 400);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(110, 53);
            this.btnTutorial.TabIndex = 5;
            this.btnTutorial.TabStop = false;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 477);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.lblMenuTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

