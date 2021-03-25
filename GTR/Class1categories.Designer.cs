namespace Quiz_App
{
    partial class Science
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
            this.English = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GK = new System.Windows.Forms.Button();
            this.Mathematics = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // English
            // 
            this.English.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.English.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English.Location = new System.Drawing.Point(257, 244);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(240, 110);
            this.English.TabIndex = 0;
            this.English.Text = "ENGLISH";
            this.English.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(901, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "SCIENCE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GK
            // 
            this.GK.BackColor = System.Drawing.Color.Gold;
            this.GK.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GK.Location = new System.Drawing.Point(257, 485);
            this.GK.Name = "GK";
            this.GK.Size = new System.Drawing.Size(240, 110);
            this.GK.TabIndex = 2;
            this.GK.Text = "General Knowledge";
            this.GK.UseVisualStyleBackColor = false;
            // 
            // Mathematics
            // 
            this.Mathematics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Mathematics.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mathematics.Location = new System.Drawing.Point(901, 244);
            this.Mathematics.Name = "Mathematics";
            this.Mathematics.Size = new System.Drawing.Size(240, 110);
            this.Mathematics.TabIndex = 3;
            this.Mathematics.Text = "MATHEMATICS";
            this.Mathematics.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(678, 698);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT YOUR SUBJECT:";
            // 
            // Science
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1380, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mathematics);
            this.Controls.Add(this.GK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.English);
            this.Name = "Science";
            this.Text = "Quiz In It";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button English;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GK;
        private System.Windows.Forms.Button Mathematics;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}