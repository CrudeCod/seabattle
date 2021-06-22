namespace seabattle
{
    partial class Form1
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
        //test test test
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.mainMenuStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(91, 67);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(646, 29);
            this.mainMenuLabel.TabIndex = 0;
            this.mainMenuLabel.Text = "Sea Battle by Mikael Khudiev and Savva Krasnokutskiy";
            this.mainMenuLabel.Click += new System.EventHandler(this.mainMenuLabel_Click);
            // 
            // mainMenuStart
            // 
            this.mainMenuStart.Location = new System.Drawing.Point(201, 282);
            this.mainMenuStart.Name = "mainMenuStart";
            this.mainMenuStart.Size = new System.Drawing.Size(398, 41);
            this.mainMenuStart.TabIndex = 1;
            this.mainMenuStart.Text = "START!!!";
            this.mainMenuStart.UseVisualStyleBackColor = true;
            this.mainMenuStart.Click += new System.EventHandler(this.mainMenuStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuStart);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button mainMenuStart;
    }
}

