namespace Assignment_2_module_marks
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnEditMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMark
            // 
            this.btnAddMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMark.Location = new System.Drawing.Point(35, 71);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(100, 50);
            this.btnAddMark.TabIndex = 0;
            this.btnAddMark.Text = "Add Mark";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnEditMark
            // 
            this.btnEditMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMark.Location = new System.Drawing.Point(151, 71);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(100, 50);
            this.btnEditMark.TabIndex = 1;
            this.btnEditMark.Text = "Edit Mark";
            this.btnEditMark.UseVisualStyleBackColor = true;
            this.btnEditMark.Click += new System.EventHandler(this.btnEditMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMark.Location = new System.Drawing.Point(267, 71);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteMark.TabIndex = 2;
            this.btnDeleteMark.Text = "Delete Mark";
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // lstMarks
            // 
            this.lstMarks.BackColor = System.Drawing.Color.LightGray;
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(388, 71);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(170, 394);
            this.lstMarks.TabIndex = 3;
            // 
            // btnMax
            // 
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(35, 239);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(100, 50);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Location = new System.Drawing.Point(267, 239);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(100, 50);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(151, 239);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 50);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(35, 323);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(332, 61);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToFile.Location = new System.Drawing.Point(35, 415);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(100, 50);
            this.btnSaveToFile.TabIndex = 8;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(267, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(593, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnEditMark);
            this.Controls.Add(this.btnAddMark);
            this.Name = "Form1";
            this.Text = "Module Marks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnEditMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.ListBox lstMarks;
    }
}

