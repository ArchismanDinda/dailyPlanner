using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class formTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTimeTable));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThur = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMonTime = new System.Windows.Forms.Button();
            this.btnMonSub = new System.Windows.Forms.Button();
            this.btnTueTime = new System.Windows.Forms.Button();
            this.btnTueSub = new System.Windows.Forms.Button();
            this.btnWedTime = new System.Windows.Forms.Button();
            this.btnWedSub = new System.Windows.Forms.Button();
            this.btnThurTime = new System.Windows.Forms.Button();
            this.btnThurSub = new System.Windows.Forms.Button();
            this.btnFriTime = new System.Windows.Forms.Button();
            this.btnFriSub = new System.Windows.Forms.Button();
            this.btnSatTime = new System.Windows.Forms.Button();
            this.btnSatSub = new System.Windows.Forms.Button();
            this.btnSunTime = new System.Windows.Forms.Button();
            this.btnSunSub = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblMon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblThur, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFri, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSat, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSun, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(112, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.BackColor = System.Drawing.Color.Black;
            this.lblMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMon.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.White;
            this.lblMon.Location = new System.Drawing.Point(4, 0);
            this.lblMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(104, 70);
            this.lblMon.TabIndex = 1;
            this.lblMon.Text = "Monday";
            this.lblMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMon.Click += new System.EventHandler(this.lblMon_Click);
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.BackColor = System.Drawing.Color.Black;
            this.lblTue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTue.ForeColor = System.Drawing.Color.White;
            this.lblTue.Location = new System.Drawing.Point(4, 70);
            this.lblTue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(104, 70);
            this.lblTue.TabIndex = 2;
            this.lblTue.Text = "Tuesday";
            this.lblTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTue.Click += new System.EventHandler(this.lblTue_Click);
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.BackColor = System.Drawing.Color.Black;
            this.lblWed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWed.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWed.ForeColor = System.Drawing.Color.White;
            this.lblWed.Location = new System.Drawing.Point(4, 140);
            this.lblWed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(104, 70);
            this.lblWed.TabIndex = 3;
            this.lblWed.Text = "Wednesday";
            this.lblWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThur
            // 
            this.lblThur.AutoSize = true;
            this.lblThur.BackColor = System.Drawing.Color.Black;
            this.lblThur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThur.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThur.ForeColor = System.Drawing.Color.White;
            this.lblThur.Location = new System.Drawing.Point(4, 210);
            this.lblThur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThur.Name = "lblThur";
            this.lblThur.Size = new System.Drawing.Size(104, 70);
            this.lblThur.TabIndex = 4;
            this.lblThur.Text = "Thursday";
            this.lblThur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.BackColor = System.Drawing.Color.Black;
            this.lblFri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFri.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFri.ForeColor = System.Drawing.Color.White;
            this.lblFri.Location = new System.Drawing.Point(4, 280);
            this.lblFri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(104, 70);
            this.lblFri.TabIndex = 5;
            this.lblFri.Text = "Friday";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.BackColor = System.Drawing.Color.Black;
            this.lblSat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ForeColor = System.Drawing.Color.White;
            this.lblSat.Location = new System.Drawing.Point(4, 350);
            this.lblSat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(104, 70);
            this.lblSat.TabIndex = 6;
            this.lblSat.Text = "Saturday";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.BackColor = System.Drawing.Color.Black;
            this.lblSun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSun.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSun.ForeColor = System.Drawing.Color.White;
            this.lblSun.Location = new System.Drawing.Point(4, 420);
            this.lblSun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(104, 77);
            this.lblSun.TabIndex = 7;
            this.lblSun.Text = "Sunday";
            this.lblSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AllowDrop = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.btnMonTime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMonSub, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnTueTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnTueSub, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnWedTime, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnWedSub, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnThurTime, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnThurSub, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnFriTime, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnFriSub, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnSatTime, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.btnSatSub, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.btnSunTime, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.btnSunSub, 0, 13);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(116, 71);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.868687F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.676768F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.464646F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.676768F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.464646F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.474748F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060606F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.676768F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.464646F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.676768F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(88, 495);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnMonTime
            // 
            this.btnMonTime.BackColor = System.Drawing.Color.Navy;
            this.btnMonTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMonTime.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMonTime.Location = new System.Drawing.Point(4, 5);
            this.btnMonTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonTime.Name = "btnMonTime";
            this.btnMonTime.Size = new System.Drawing.Size(80, 26);
            this.btnMonTime.TabIndex = 0;
            this.btnMonTime.Text = "Time";
            this.btnMonTime.UseVisualStyleBackColor = false;
            this.btnMonTime.Click += new System.EventHandler(this.btnMonTime_Click);
            // 
            // btnMonSub
            // 
            this.btnMonSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMonSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonSub.Location = new System.Drawing.Point(4, 41);
            this.btnMonSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonSub.Name = "btnMonSub";
            this.btnMonSub.Size = new System.Drawing.Size(80, 24);
            this.btnMonSub.TabIndex = 1;
            this.btnMonSub.Text = "Subject";
            this.btnMonSub.UseVisualStyleBackColor = true;
            this.btnMonSub.Click += new System.EventHandler(this.btnMonSub_Click);
            // 
            // btnTueTime
            // 
            this.btnTueTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTueTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTueTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTueTime.Location = new System.Drawing.Point(4, 75);
            this.btnTueTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTueTime.Name = "btnTueTime";
            this.btnTueTime.Size = new System.Drawing.Size(80, 28);
            this.btnTueTime.TabIndex = 2;
            this.btnTueTime.Text = "Time";
            this.btnTueTime.UseVisualStyleBackColor = true;
            this.btnTueTime.Click += new System.EventHandler(this.btnTueTime_Click);
            // 
            // btnTueSub
            // 
            this.btnTueSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTueSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTueSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTueSub.Location = new System.Drawing.Point(4, 113);
            this.btnTueSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTueSub.Name = "btnTueSub";
            this.btnTueSub.Size = new System.Drawing.Size(80, 22);
            this.btnTueSub.TabIndex = 3;
            this.btnTueSub.Text = "Subject";
            this.btnTueSub.UseVisualStyleBackColor = true;
            this.btnTueSub.Click += new System.EventHandler(this.btnTueSub_Click);
            // 
            // btnWedTime
            // 
            this.btnWedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWedTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWedTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWedTime.Location = new System.Drawing.Point(4, 145);
            this.btnWedTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWedTime.Name = "btnWedTime";
            this.btnWedTime.Size = new System.Drawing.Size(80, 28);
            this.btnWedTime.TabIndex = 4;
            this.btnWedTime.Text = "Time";
            this.btnWedTime.UseVisualStyleBackColor = true;
            this.btnWedTime.Click += new System.EventHandler(this.btnWedTime_Click);
            // 
            // btnWedSub
            // 
            this.btnWedSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWedSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWedSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWedSub.Location = new System.Drawing.Point(4, 183);
            this.btnWedSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWedSub.Name = "btnWedSub";
            this.btnWedSub.Size = new System.Drawing.Size(80, 22);
            this.btnWedSub.TabIndex = 5;
            this.btnWedSub.Text = "Subject";
            this.btnWedSub.UseVisualStyleBackColor = true;
            this.btnWedSub.Click += new System.EventHandler(this.btnWedSub_Click);
            // 
            // btnThurTime
            // 
            this.btnThurTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThurTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThurTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThurTime.Location = new System.Drawing.Point(4, 215);
            this.btnThurTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThurTime.Name = "btnThurTime";
            this.btnThurTime.Size = new System.Drawing.Size(80, 27);
            this.btnThurTime.TabIndex = 6;
            this.btnThurTime.Text = "Time";
            this.btnThurTime.UseVisualStyleBackColor = true;
            this.btnThurTime.Click += new System.EventHandler(this.btnThurTime_Click);
            // 
            // btnThurSub
            // 
            this.btnThurSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThurSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThurSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThurSub.Location = new System.Drawing.Point(4, 252);
            this.btnThurSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThurSub.Name = "btnThurSub";
            this.btnThurSub.Size = new System.Drawing.Size(80, 23);
            this.btnThurSub.TabIndex = 7;
            this.btnThurSub.Text = "Subject";
            this.btnThurSub.UseVisualStyleBackColor = true;
            this.btnThurSub.Click += new System.EventHandler(this.btnThurSub_Click);
            // 
            // btnFriTime
            // 
            this.btnFriTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFriTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFriTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriTime.Location = new System.Drawing.Point(4, 285);
            this.btnFriTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFriTime.Name = "btnFriTime";
            this.btnFriTime.Size = new System.Drawing.Size(80, 30);
            this.btnFriTime.TabIndex = 8;
            this.btnFriTime.Text = "Time";
            this.btnFriTime.UseVisualStyleBackColor = true;
            this.btnFriTime.Click += new System.EventHandler(this.btnFriTime_Click);
            // 
            // btnFriSub
            // 
            this.btnFriSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFriSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFriSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriSub.Location = new System.Drawing.Point(4, 325);
            this.btnFriSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFriSub.Name = "btnFriSub";
            this.btnFriSub.Size = new System.Drawing.Size(80, 20);
            this.btnFriSub.TabIndex = 9;
            this.btnFriSub.Text = "Subject";
            this.btnFriSub.UseVisualStyleBackColor = true;
            this.btnFriSub.Click += new System.EventHandler(this.btnFriSub_Click);
            // 
            // btnSatTime
            // 
            this.btnSatTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSatTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSatTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatTime.Location = new System.Drawing.Point(4, 355);
            this.btnSatTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSatTime.Name = "btnSatTime";
            this.btnSatTime.Size = new System.Drawing.Size(80, 28);
            this.btnSatTime.TabIndex = 10;
            this.btnSatTime.Text = "Time";
            this.btnSatTime.UseVisualStyleBackColor = true;
            this.btnSatTime.Click += new System.EventHandler(this.btnSatTime_Click);
            // 
            // btnSatSub
            // 
            this.btnSatSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSatSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSatSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatSub.Location = new System.Drawing.Point(4, 393);
            this.btnSatSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSatSub.Name = "btnSatSub";
            this.btnSatSub.Size = new System.Drawing.Size(80, 22);
            this.btnSatSub.TabIndex = 11;
            this.btnSatSub.Text = "Subject";
            this.btnSatSub.UseVisualStyleBackColor = true;
            this.btnSatSub.Click += new System.EventHandler(this.btnSatSub_Click);
            // 
            // btnSunTime
            // 
            this.btnSunTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSunTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSunTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSunTime.Location = new System.Drawing.Point(4, 425);
            this.btnSunTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSunTime.Name = "btnSunTime";
            this.btnSunTime.Size = new System.Drawing.Size(80, 26);
            this.btnSunTime.TabIndex = 12;
            this.btnSunTime.Text = "Time";
            this.btnSunTime.UseVisualStyleBackColor = true;
            this.btnSunTime.Click += new System.EventHandler(this.btnSunTime_Click);
            // 
            // btnSunSub
            // 
            this.btnSunSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSunSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSunSub.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSunSub.Location = new System.Drawing.Point(4, 461);
            this.btnSunSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSunSub.Name = "btnSunSub";
            this.btnSunSub.Size = new System.Drawing.Size(80, 29);
            this.btnSunSub.TabIndex = 13;
            this.btnSunSub.Text = "Subject";
            this.btnSunSub.UseVisualStyleBackColor = true;
            this.btnSunSub.Click += new System.EventHandler(this.btnSunSub_Click);
            // 
            // formTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 568);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formTimeTable";
            this.Text = "Time Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formTimeTable_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formTimeTable_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThur;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Button btnMonTime;
        private System.Windows.Forms.Button btnMonSub;
        private System.Windows.Forms.Button btnTueTime;
        private System.Windows.Forms.Button btnTueSub;
        private System.Windows.Forms.Button btnWedTime;
        private System.Windows.Forms.Button btnWedSub;
        private System.Windows.Forms.Button btnThurTime;
        private System.Windows.Forms.Button btnThurSub;
        private System.Windows.Forms.Button btnFriTime;
        private System.Windows.Forms.Button btnFriSub;
        private System.Windows.Forms.Button btnSatTime;
        private System.Windows.Forms.Button btnSatSub;
        private System.Windows.Forms.Button btnSunTime;
        private System.Windows.Forms.Button btnSunSub;
    }
}

