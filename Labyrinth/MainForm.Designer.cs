namespace Labyrinth
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
            this.btnLevel5 = new System.Windows.Forms.Button();
            this.btnLevel4 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevel5
            // 
            this.btnLevel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLevel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel5.Location = new System.Drawing.Point(58, 180);
            this.btnLevel5.Name = "btnLevel5";
            this.btnLevel5.Size = new System.Drawing.Size(124, 36);
            this.btnLevel5.TabIndex = 0;
            this.btnLevel5.Text = "Уровень 5";
            this.btnLevel5.UseVisualStyleBackColor = false;
            this.btnLevel5.Click += new System.EventHandler(this.btnLevel5_Click);
            // 
            // btnLevel4
            // 
            this.btnLevel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLevel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel4.Location = new System.Drawing.Point(58, 138);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.Size = new System.Drawing.Size(124, 36);
            this.btnLevel4.TabIndex = 0;
            this.btnLevel4.Text = "Уровень 4";
            this.btnLevel4.UseVisualStyleBackColor = false;
            this.btnLevel4.Click += new System.EventHandler(this.btnLevel4_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel3.Location = new System.Drawing.Point(58, 96);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(124, 36);
            this.btnLevel3.TabIndex = 0;
            this.btnLevel3.Text = "Уровень 3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel2.Location = new System.Drawing.Point(58, 54);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(124, 36);
            this.btnLevel2.TabIndex = 0;
            this.btnLevel2.Text = "Уровень 2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel1.Location = new System.Drawing.Point(58, 12);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(124, 36);
            this.btnLevel1.TabIndex = 0;
            this.btnLevel1.Text = "Уровень 1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(160, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(247, 278);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLevel5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLevel5;
        private System.Windows.Forms.Button btnLevel4;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnExit;
    }
}