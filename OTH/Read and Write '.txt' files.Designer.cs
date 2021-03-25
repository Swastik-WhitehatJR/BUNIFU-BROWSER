namespace Read_and_Write_Text_From__.txt__files
{
    partial class My_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.AddEmployeeBTN = new System.Windows.Forms.Button();
            this.ReadFilesRTD = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTB.Location = new System.Drawing.Point(151, 52);
            this.LastNameTB.Multiline = true;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(306, 33);
            this.LastNameTB.TabIndex = 5;
            // 
            // GenderCB
            // 
            this.GenderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.GenderCB.Location = new System.Drawing.Point(147, 99);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(310, 33);
            this.GenderCB.TabIndex = 6;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTB.Location = new System.Drawing.Point(151, 9);
            this.FirstNameTB.Multiline = true;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(306, 33);
            this.FirstNameTB.TabIndex = 7;
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.Location = new System.Drawing.Point(147, 152);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(310, 129);
            this.AddressTB.TabIndex = 8;
            // 
            // AddEmployeeBTN
            // 
            this.AddEmployeeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBTN.Location = new System.Drawing.Point(316, 287);
            this.AddEmployeeBTN.Name = "AddEmployeeBTN";
            this.AddEmployeeBTN.Size = new System.Drawing.Size(141, 49);
            this.AddEmployeeBTN.TabIndex = 9;
            this.AddEmployeeBTN.Text = "Add Employee";
            this.AddEmployeeBTN.UseVisualStyleBackColor = true;
            this.AddEmployeeBTN.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // ReadFilesRTD
            // 
            this.ReadFilesRTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFilesRTD.Location = new System.Drawing.Point(482, 9);
            this.ReadFilesRTD.Name = "ReadFilesRTD";
            this.ReadFilesRTD.Size = new System.Drawing.Size(523, 323);
            this.ReadFilesRTD.TabIndex = 10;
            this.ReadFilesRTD.Text = "";
            // 
            // My_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 344);
            this.Controls.Add(this.ReadFilesRTD);
            this.Controls.Add(this.AddEmployeeBTN);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "My_Form";
            this.Text = "Read Write .txt Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Button AddEmployeeBTN;
        private System.Windows.Forms.RichTextBox ReadFilesRTD;
    }
}

