namespace Gui_1 {
	partial class Assignment {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.btnDirections = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblAssignment = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.startPanel = new System.Windows.Forms.Panel();
			this.startPicture = new System.Windows.Forms.PictureBox();
			this.btnGoEnd = new System.Windows.Forms.Button();
			this.txtStartingID = new System.Windows.Forms.TextBox();
			this.txtStartStationName = new System.Windows.Forms.TextBox();
			this.lblStartStationID = new System.Windows.Forms.Label();
			this.lblStartStationName = new System.Windows.Forms.Label();
			this.txtInputStart = new System.Windows.Forms.TextBox();
			this.lblSelectStart = new System.Windows.Forms.Label();
			this.panelEnd = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtEndStationID = new System.Windows.Forms.TextBox();
			this.txtEndStationName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEndStationInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panelDirections = new System.Windows.Forms.Panel();
			this.lblDirectionStart = new System.Windows.Forms.Label();
			this.txtDisplayStartStation = new System.Windows.Forms.TextBox();
			this.txtDisplayEnd = new System.Windows.Forms.TextBox();
			this.lblDisplayEnd = new System.Windows.Forms.Label();
			this.lblDisplayPath = new System.Windows.Forms.Label();
			this.txtDisplayPath = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.startPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.startPicture)).BeginInit();
			this.panelEnd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelDirections.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.lblCurrent);
			this.panel1.Controls.Add(this.btnDirections);
			this.panel1.Controls.Add(this.btnEnd);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.lblAssignment);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 525);
			this.panel1.TabIndex = 0;
			// 
			// lblCurrent
			// 
			this.lblCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblCurrent.ForeColor = System.Drawing.Color.Yellow;
			this.lblCurrent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblCurrent.Location = new System.Drawing.Point(0, 108);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new System.Drawing.Size(4, 78);
			this.lblCurrent.TabIndex = 1;
			this.lblCurrent.Text = " ";
			// 
			// btnDirections
			// 
			this.btnDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			this.btnDirections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDirections.FlatAppearance.BorderSize = 0;
			this.btnDirections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnDirections.Location = new System.Drawing.Point(0, 305);
			this.btnDirections.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnDirections.Name = "btnDirections";
			this.btnDirections.Size = new System.Drawing.Size(204, 78);
			this.btnDirections.TabIndex = 2;
			this.btnDirections.Text = "View directions";
			this.btnDirections.UseVisualStyleBackColor = false;
			this.btnDirections.Click += new System.EventHandler(this.btnDirections_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEnd.FlatAppearance.BorderSize = 0;
			this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnEnd.Location = new System.Drawing.Point(0, 207);
			this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(204, 78);
			this.btnEnd.TabIndex = 2;
			this.btnEnd.Text = "Select ending station";
			this.btnEnd.UseVisualStyleBackColor = false;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnStart.Location = new System.Drawing.Point(0, 108);
			this.btnStart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(204, 78);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Select starting station";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblAssignment
			// 
			this.lblAssignment.AutoSize = true;
			this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lblAssignment.Location = new System.Drawing.Point(17, 15);
			this.lblAssignment.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
			this.lblAssignment.Name = "lblAssignment";
			this.lblAssignment.Size = new System.Drawing.Size(156, 31);
			this.lblAssignment.TabIndex = 0;
			this.lblAssignment.Text = "Assignment";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(958, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(26, 26);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "X";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// startPanel
			// 
			this.startPanel.Controls.Add(this.btnGoEnd);
			this.startPanel.Controls.Add(this.txtStartingID);
			this.startPanel.Controls.Add(this.panelEnd);
			this.startPanel.Controls.Add(this.txtStartStationName);
			this.startPanel.Controls.Add(this.lblStartStationID);
			this.startPanel.Controls.Add(this.lblStartStationName);
			this.startPanel.Controls.Add(this.txtInputStart);
			this.startPanel.Controls.Add(this.lblSelectStart);
			this.startPanel.Controls.Add(this.startPicture);
			this.startPanel.Location = new System.Drawing.Point(204, 32);
			this.startPanel.Name = "startPanel";
			this.startPanel.Size = new System.Drawing.Size(780, 493);
			this.startPanel.TabIndex = 2;
			// 
			// startPicture
			// 
			this.startPicture.Location = new System.Drawing.Point(474, 74);
			this.startPicture.Name = "startPicture";
			this.startPicture.Size = new System.Drawing.Size(243, 243);
			this.startPicture.TabIndex = 10;
			this.startPicture.TabStop = false;
			// 
			// btnGoEnd
			// 
			this.btnGoEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGoEnd.Location = new System.Drawing.Point(65, 309);
			this.btnGoEnd.Name = "btnGoEnd";
			this.btnGoEnd.Size = new System.Drawing.Size(323, 58);
			this.btnGoEnd.TabIndex = 9;
			this.btnGoEnd.Text = "Select ending station";
			this.btnGoEnd.UseVisualStyleBackColor = true;
			this.btnGoEnd.Click += new System.EventHandler(this.btnGoEnd_Click);
			// 
			// txtStartingID
			// 
			this.txtStartingID.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtStartingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStartingID.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtStartingID.Location = new System.Drawing.Point(199, 204);
			this.txtStartingID.Multiline = true;
			this.txtStartingID.Name = "txtStartingID";
			this.txtStartingID.ReadOnly = true;
			this.txtStartingID.Size = new System.Drawing.Size(189, 99);
			this.txtStartingID.TabIndex = 8;
			// 
			// txtStartStationName
			// 
			this.txtStartStationName.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtStartStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStartStationName.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtStartStationName.Location = new System.Drawing.Point(199, 164);
			this.txtStartStationName.Multiline = true;
			this.txtStartStationName.Name = "txtStartStationName";
			this.txtStartStationName.ReadOnly = true;
			this.txtStartStationName.Size = new System.Drawing.Size(189, 29);
			this.txtStartStationName.TabIndex = 7;
			// 
			// lblStartStationID
			// 
			this.lblStartStationID.AutoSize = true;
			this.lblStartStationID.Location = new System.Drawing.Point(81, 207);
			this.lblStartStationID.Name = "lblStartStationID";
			this.lblStartStationID.Size = new System.Drawing.Size(105, 21);
			this.lblStartStationID.TabIndex = 6;
			this.lblStartStationID.Text = "Station ID(s)  :";
			// 
			// lblStartStationName
			// 
			this.lblStartStationName.AutoSize = true;
			this.lblStartStationName.Location = new System.Drawing.Point(81, 164);
			this.lblStartStationName.Name = "lblStartStationName";
			this.lblStartStationName.Size = new System.Drawing.Size(112, 21);
			this.lblStartStationName.TabIndex = 5;
			this.lblStartStationName.Text = "Station name : ";
			// 
			// txtInputStart
			// 
			this.txtInputStart.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.txtInputStart.Location = new System.Drawing.Point(216, 82);
			this.txtInputStart.Name = "txtInputStart";
			this.txtInputStart.Size = new System.Drawing.Size(172, 34);
			this.txtInputStart.TabIndex = 4;
			this.txtInputStart.TextChanged += new System.EventHandler(this.txtInputStart_TextChanged);
			// 
			// lblSelectStart
			// 
			this.lblSelectStart.AutoSize = true;
			this.lblSelectStart.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.lblSelectStart.Location = new System.Drawing.Point(57, 85);
			this.lblSelectStart.Margin = new System.Windows.Forms.Padding(10);
			this.lblSelectStart.Name = "lblSelectStart";
			this.lblSelectStart.Size = new System.Drawing.Size(155, 28);
			this.lblSelectStart.TabIndex = 0;
			this.lblSelectStart.Text = "Starting station :";
			// 
			// panelEnd
			// 
			this.panelEnd.Controls.Add(this.pictureBox1);
			this.panelEnd.Controls.Add(this.button1);
			this.panelEnd.Controls.Add(this.txtEndStationID);
			this.panelEnd.Controls.Add(this.txtEndStationName);
			this.panelEnd.Controls.Add(this.label1);
			this.panelEnd.Controls.Add(this.label2);
			this.panelEnd.Controls.Add(this.txtEndStationInput);
			this.panelEnd.Controls.Add(this.label3);
			this.panelEnd.Location = new System.Drawing.Point(0, 0);
			this.panelEnd.Name = "panelEnd";
			this.panelEnd.Size = new System.Drawing.Size(780, 493);
			this.panelEnd.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(474, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(243, 243);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(65, 309);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(323, 58);
			this.button1.TabIndex = 9;
			this.button1.Text = "View directions";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtEndStationID
			// 
			this.txtEndStationID.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtEndStationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEndStationID.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtEndStationID.Location = new System.Drawing.Point(199, 204);
			this.txtEndStationID.Multiline = true;
			this.txtEndStationID.Name = "txtEndStationID";
			this.txtEndStationID.ReadOnly = true;
			this.txtEndStationID.Size = new System.Drawing.Size(189, 99);
			this.txtEndStationID.TabIndex = 8;
			// 
			// txtEndStationName
			// 
			this.txtEndStationName.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtEndStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEndStationName.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtEndStationName.Location = new System.Drawing.Point(199, 164);
			this.txtEndStationName.Multiline = true;
			this.txtEndStationName.Name = "txtEndStationName";
			this.txtEndStationName.ReadOnly = true;
			this.txtEndStationName.Size = new System.Drawing.Size(189, 29);
			this.txtEndStationName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(81, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Station ID(s)  :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Station name : ";
			// 
			// txtEndStationInput
			// 
			this.txtEndStationInput.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.txtEndStationInput.Location = new System.Drawing.Point(216, 82);
			this.txtEndStationInput.Name = "txtEndStationInput";
			this.txtEndStationInput.Size = new System.Drawing.Size(172, 34);
			this.txtEndStationInput.TabIndex = 4;
			this.txtEndStationInput.TextChanged += new System.EventHandler(this.txtEndStationInput_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label3.Location = new System.Drawing.Point(57, 85);
			this.label3.Margin = new System.Windows.Forms.Padding(10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ending station :";
			// 
			// panelDirections
			// 
			this.panelDirections.Controls.Add(this.txtDisplayPath);
			this.panelDirections.Controls.Add(this.lblDisplayPath);
			this.panelDirections.Controls.Add(this.txtDisplayEnd);
			this.panelDirections.Controls.Add(this.lblDisplayEnd);
			this.panelDirections.Controls.Add(this.txtDisplayStartStation);
			this.panelDirections.Controls.Add(this.lblDirectionStart);
			this.panelDirections.Location = new System.Drawing.Point(204, 32);
			this.panelDirections.Name = "panelDirections";
			this.panelDirections.Size = new System.Drawing.Size(780, 493);
			this.panelDirections.TabIndex = 12;
			// 
			// lblDirectionStart
			// 
			this.lblDirectionStart.AutoSize = true;
			this.lblDirectionStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDirectionStart.Location = new System.Drawing.Point(61, 105);
			this.lblDirectionStart.Name = "lblDirectionStart";
			this.lblDirectionStart.Size = new System.Drawing.Size(134, 21);
			this.lblDirectionStart.TabIndex = 0;
			this.lblDirectionStart.Text = "Starting station : ";
			// 
			// txtDisplayStartStation
			// 
			this.txtDisplayStartStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDisplayStartStation.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtDisplayStartStation.Location = new System.Drawing.Point(200, 102);
			this.txtDisplayStartStation.Name = "txtDisplayStartStation";
			this.txtDisplayStartStation.ReadOnly = true;
			this.txtDisplayStartStation.Size = new System.Drawing.Size(135, 29);
			this.txtDisplayStartStation.TabIndex = 2;
			// 
			// txtDisplayEnd
			// 
			this.txtDisplayEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDisplayEnd.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtDisplayEnd.Location = new System.Drawing.Point(200, 148);
			this.txtDisplayEnd.Name = "txtDisplayEnd";
			this.txtDisplayEnd.ReadOnly = true;
			this.txtDisplayEnd.Size = new System.Drawing.Size(135, 29);
			this.txtDisplayEnd.TabIndex = 4;
			// 
			// lblDisplayEnd
			// 
			this.lblDisplayEnd.AutoSize = true;
			this.lblDisplayEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayEnd.Location = new System.Drawing.Point(68, 151);
			this.lblDisplayEnd.Name = "lblDisplayEnd";
			this.lblDisplayEnd.Size = new System.Drawing.Size(126, 21);
			this.lblDisplayEnd.TabIndex = 3;
			this.lblDisplayEnd.Text = "Ending station : ";
			// 
			// lblDisplayPath
			// 
			this.lblDisplayPath.AutoSize = true;
			this.lblDisplayPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayPath.Location = new System.Drawing.Point(404, 74);
			this.lblDisplayPath.Name = "lblDisplayPath";
			this.lblDisplayPath.Size = new System.Drawing.Size(110, 21);
			this.lblDisplayPath.TabIndex = 5;
			this.lblDisplayPath.Text = "Path to take :";
			// 
			// txtDisplayPath
			// 
			this.txtDisplayPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDisplayPath.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtDisplayPath.Location = new System.Drawing.Point(408, 105);
			this.txtDisplayPath.Multiline = true;
			this.txtDisplayPath.Name = "txtDisplayPath";
			this.txtDisplayPath.ReadOnly = true;
			this.txtDisplayPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtDisplayPath.Size = new System.Drawing.Size(323, 284);
			this.txtDisplayPath.TabIndex = 6;
			// 
			// Assignment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(984, 525);
			this.Controls.Add(this.panelDirections);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.startPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Assignment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Assignment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.startPanel.ResumeLayout(false);
			this.startPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.startPicture)).EndInit();
			this.panelEnd.ResumeLayout(false);
			this.panelEnd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelDirections.ResumeLayout(false);
			this.panelDirections.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblAssignment;
		private System.Windows.Forms.Button btnDirections;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel startPanel;
		private System.Windows.Forms.Label lblSelectStart;
		private System.Windows.Forms.TextBox txtStartingID;
		private System.Windows.Forms.TextBox txtStartStationName;
		private System.Windows.Forms.Label lblStartStationID;
		private System.Windows.Forms.Label lblStartStationName;
		private System.Windows.Forms.TextBox txtInputStart;
		private System.Windows.Forms.Button btnGoEnd;
		private System.Windows.Forms.PictureBox startPicture;
		private System.Windows.Forms.Panel panelEnd;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtEndStationID;
		private System.Windows.Forms.TextBox txtEndStationName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEndStationInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelDirections;
		private System.Windows.Forms.TextBox txtDisplayPath;
		private System.Windows.Forms.Label lblDisplayPath;
		private System.Windows.Forms.TextBox txtDisplayEnd;
		private System.Windows.Forms.Label lblDisplayEnd;
		private System.Windows.Forms.TextBox txtDisplayStartStation;
		private System.Windows.Forms.Label lblDirectionStart;
	}
}

