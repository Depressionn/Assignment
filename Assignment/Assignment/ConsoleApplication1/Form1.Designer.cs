namespace ConsoleApplication1
{
    partial class AssignmentForm
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
			this.Title = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboStartLine = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboStartStation = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboEndStation = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboEndLine = new System.Windows.Forms.ComboBox();
			this.lblEnterStartStation = new System.Windows.Forms.Label();
			this.txtInputStartManual = new System.Windows.Forms.TextBox();
			this.txtInputEndManual = new System.Windows.Forms.TextBox();
			this.lblEndStationManual = new System.Windows.Forms.Label();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.Title.ForeColor = System.Drawing.Color.White;
			this.Title.Location = new System.Drawing.Point(40, 39);
			this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(275, 46);
			this.Title.TabIndex = 0;
			this.Title.Text = "PATHFINDER";
			this.Title.Click += new System.EventHandler(this.label1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(43, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "START STATION";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(43, 267);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "END STATION";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboStartLine
			// 
			this.comboStartLine.FormattingEnabled = true;
			this.comboStartLine.Location = new System.Drawing.Point(228, 144);
			this.comboStartLine.Margin = new System.Windows.Forms.Padding(4);
			this.comboStartLine.Name = "comboStartLine";
			this.comboStartLine.Size = new System.Drawing.Size(296, 33);
			this.comboStartLine.TabIndex = 3;
			this.comboStartLine.SelectedIndexChanged += new System.EventHandler(this.startLineChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(85, 144);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "LINE";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(85, 200);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "STATION";
			// 
			// comboStartStation
			// 
			this.comboStartStation.FormattingEnabled = true;
			this.comboStartStation.Location = new System.Drawing.Point(228, 196);
			this.comboStartStation.Margin = new System.Windows.Forms.Padding(4);
			this.comboStartStation.Name = "comboStartStation";
			this.comboStartStation.Size = new System.Drawing.Size(296, 33);
			this.comboStartStation.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(85, 375);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "STATION";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// comboEndStation
			// 
			this.comboEndStation.FormattingEnabled = true;
			this.comboEndStation.Location = new System.Drawing.Point(228, 371);
			this.comboEndStation.Margin = new System.Windows.Forms.Padding(4);
			this.comboEndStation.Name = "comboEndStation";
			this.comboEndStation.Size = new System.Drawing.Size(296, 33);
			this.comboEndStation.TabIndex = 9;
			this.comboEndStation.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(85, 319);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "LINE";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// comboEndLine
			// 
			this.comboEndLine.FormattingEnabled = true;
			this.comboEndLine.Location = new System.Drawing.Point(228, 315);
			this.comboEndLine.Margin = new System.Windows.Forms.Padding(4);
			this.comboEndLine.Name = "comboEndLine";
			this.comboEndLine.Size = new System.Drawing.Size(296, 33);
			this.comboEndLine.TabIndex = 7;
			this.comboEndLine.SelectedIndexChanged += new System.EventHandler(this.endLineChanged);
			// 
			// lblEnterStartStation
			// 
			this.lblEnterStartStation.AutoSize = true;
			this.lblEnterStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lblEnterStartStation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblEnterStartStation.Location = new System.Drawing.Point(588, 96);
			this.lblEnterStartStation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblEnterStartStation.Name = "lblEnterStartStation";
			this.lblEnterStartStation.Size = new System.Drawing.Size(131, 25);
			this.lblEnterStartStation.TabIndex = 11;
			this.lblEnterStartStation.Text = "Manual entry:";
			// 
			// txtInputStartManual
			// 
			this.txtInputStartManual.Location = new System.Drawing.Point(731, 91);
			this.txtInputStartManual.Margin = new System.Windows.Forms.Padding(6);
			this.txtInputStartManual.Name = "txtInputStartManual";
			this.txtInputStartManual.Size = new System.Drawing.Size(182, 30);
			this.txtInputStartManual.TabIndex = 12;
			this.txtInputStartManual.TextChanged += new System.EventHandler(this.txtInputManual_TextChanged);
			// 
			// txtInputEndManual
			// 
			this.txtInputEndManual.Location = new System.Drawing.Point(731, 262);
			this.txtInputEndManual.Margin = new System.Windows.Forms.Padding(6);
			this.txtInputEndManual.Name = "txtInputEndManual";
			this.txtInputEndManual.Size = new System.Drawing.Size(182, 30);
			this.txtInputEndManual.TabIndex = 14;
			this.txtInputEndManual.TextChanged += new System.EventHandler(this.txtEndManualInput_TextChanged);
			// 
			// lblEndStationManual
			// 
			this.lblEndStationManual.AutoSize = true;
			this.lblEndStationManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lblEndStationManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblEndStationManual.Location = new System.Drawing.Point(588, 267);
			this.lblEndStationManual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblEndStationManual.Name = "lblEndStationManual";
			this.lblEndStationManual.Size = new System.Drawing.Size(131, 25);
			this.lblEndStationManual.TabIndex = 13;
			this.lblEndStationManual.Text = "Manual entry:";
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Silver;
			this.panelTop.Controls.Add(this.btnExit);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(979, 21);
			this.panelTop.TabIndex = 15;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
			// 
			// btnExit
			// 
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(928, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(51, 21);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "X";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// AssignmentForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ClientSize = new System.Drawing.Size(979, 482);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.txtInputEndManual);
			this.Controls.Add(this.lblEndStationManual);
			this.Controls.Add(this.txtInputStartManual);
			this.Controls.Add(this.lblEnterStartStation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboEndStation);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboEndLine);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboStartStation);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboStartLine);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Title);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1984, 1020);
			this.Name = "AssignmentForm";
			this.Text = "Assignment";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboStartLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboStartStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEndStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboEndLine;
		private System.Windows.Forms.Label lblEnterStartStation;
		private System.Windows.Forms.TextBox txtInputStartManual;
		private System.Windows.Forms.TextBox txtInputEndManual;
		private System.Windows.Forms.Label lblEndStationManual;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Button btnExit;
	}
}