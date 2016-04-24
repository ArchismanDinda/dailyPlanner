using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class formTimeTable : Form
    {

        string s = time;
        public formTimeTable()
        {
            InitializeComponent();
            
            //Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Button.PerformClick();
            }
        }*/

        Dictionary<TextBox, Label> textBoxLabelPairing = new Dictionary<TextBox, Label>();

        int CMonTime = 0;
        private void btnMonTime_Click(object sender, EventArgs e)
        {

            var form = new formPopup();
            form.Show(this); // if you need non-modal window
            
            /*
            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            timePicker.Location = new System.Drawing.Point(205 + (100 * CMonTime), 75);
            timePicker.Size = new System.Drawing.Size(100, 28);
            Controls.Add(timePicker);
            */

            //string theDate = timePicker.Value.ToShortDateString();
            /*
            MessageBox.Show(timePicker.Value.ToString());

            timePicker.Value = DateTime.Now.AddDays(1);
            MessageBox.Show(timePicker.Value.ToString());
            */

            //DateTime time = timePicker.Value;
            
            Label lbl = new Label();
            lbl.Text = 
            lbl.Location = new System.Drawing.Point(205 + (100 * CMonTime), 75);
            CMonTime++;
            lbl.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(lbl);
            
            //string time = (timePicker.Value).ToString;

            /*MaskedTextBox mtxtMonTime = new MaskedTextBox();
            mtxtMonTime.Name = "MonTime" + CMonTime;
            mtxtMonTime.Location = new System.Drawing.Point(205 + (100 * CMonTime), 75);
            mtxtMonTime.Size = new System.Drawing.Size(100, 28);

            //ADDED: keypress event
            //mtxtMonTime.KeyPress += mtxtMonTime_KeyPress;

            this.Controls.Add(mtxtMonTime);
            string s = mtxtMonTime.Text;
            Label lbl = new Label();
            lbl.Text = s;
            lbl.Location = new System.Drawing.Point(205 + (100 * CMonTime), 75);
            CMonTime++;
            lbl.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(lbl);
            */

            //ADDED: Dictionary Pairing
            //textBoxLabelPairing.Add(mtxtMonTime, lbl);

        }

        /*void mtxtMonTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyChar == (char)13)
            {
                MaskedTextBox thisTextBox = (MaskedTextBox)sender;
                string mtextBoxText = thisTextBox.Text;
                Label associatedLabel = textBoxLabelPairing[thisTextBox];
                associatedLabel.Text = mtextBoxText;
                this.Controls.Remove(thisTextBox);
                thisTextBox.Dispose();
            }
        }*/


        int CMonSub = 0;
        public void btnMonSub_Click(object sender, EventArgs e)
        {
            
            TextBox txtMonSub = new TextBox();
            txtMonSub.Name = "MonSub" + CMonSub;
            txtMonSub.Location = new System.Drawing.Point(205 + (100 * CMonSub), 108);
            txtMonSub.Size = new System.Drawing.Size(100, 28);

            //ADDED: keypress event
            txtMonSub.KeyPress += txtMonSub_KeyPress;

            Controls.Add(txtMonSub);
            string s = txtMonSub.Text;
            Label lbl = new Label();
            lbl.Text = s;
            lbl.Location = new System.Drawing.Point(205 + (100 * CMonSub), 111);
            //lbl.Name = "H";
            CMonSub++;
            lbl.Size = new System.Drawing.Size(100, 25);
            lbl.BackColor = System.Drawing.Color.White;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lbl.ForeColor = System.Drawing.Color.Black;
            Controls.Add(lbl);

            //ContextMenuStrip cms = new ContextMenuStrip();
            ContextMenu cm = new ContextMenu();
            //cms.Items.Add("Mark Important",);
            cm.MenuItems.Add("Mark Important", MarkImportant);
            //cm.MenuItems.Add("Edit", EditLabel);

            lbl.ContextMenu = cm;


            //ADDED: Dictionary Pairing
            textBoxLabelPairing.Add(txtMonSub, lbl);

        }

        private void EditLabel(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                // Get the parent (the ContextMenu) and read the SourceControl as a label
                Label lbl = (mi.Parent as ContextMenu).SourceControl as Label;
                if (lbl != null)
                {
                    //lbl.BackColor = System.Drawing.Color.IndianRed;
                }
            }
        }

        private void MarkImportant(object sender, EventArgs e)
        {
            // imp..
            // Convert to a MenuItem the sender object
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                // Get the parent (the ContextMenu) and read the SourceControl as a label
                Label lbl = (mi.Parent as ContextMenu).SourceControl as Label;
                if (lbl != null)
                {
                    lbl.BackColor = System.Drawing.Color.Crimson;
                    lbl.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        void txtMonSub_KeyPress(object sender, KeyPressEventArgs e)
    {
            //if enter key is pressed
            if (e.KeyChar == (char)13)
            {
                TextBox thisTextBox = (TextBox)sender;
                string textBoxText = thisTextBox.Text;
                Label associatedLabel = textBoxLabelPairing[thisTextBox];
                associatedLabel.Text = textBoxText;
                Controls.Remove(thisTextBox);
                thisTextBox.Dispose();
            }
        }

        int CTueTime;
        private void btnTueTime_Click(object sender, EventArgs e)
        {
            TextBox txtTueTime = new TextBox();
            txtTueTime.Name = "TueTime" + CTueTime ;
            txtTueTime.Location = new System.Drawing.Point(205 + (100 * CTueTime), 147);
            CTueTime++;
            txtTueTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtTueTime);
        }

        int CTueSub;
        private void btnTueSub_Click(object sender, EventArgs e)
        {
            TextBox txtTueSub = new TextBox();
            txtTueSub.Name = "TueSub" + CTueSub;
            txtTueSub.Location = new System.Drawing.Point(205 + (100 * CTueSub), 100);
            CTueSub++;
            txtTueSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtTueSub);
        }

        int CWedTime;
        private void btnWedTime_Click(object sender, EventArgs e)
        {
            TextBox txtWedTime = new TextBox();
            txtWedTime.Name = "WedTime" + CWedTime;
            txtWedTime.Location = new System.Drawing.Point(205 + (100 * CWedTime), 120);
            CWedTime++;
            txtWedTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtWedTime);
        }

        int CWedSub;
        private void btnWedSub_Click(object sender, EventArgs e)
        {
            TextBox txtWedSub = new TextBox();
            txtWedSub.Name = "WedSub" + CWedSub;
            txtWedSub.Location = new System.Drawing.Point(205 + (100 * CWedSub), 140);
            CWedSub++;
            txtWedSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtWedSub);
        }

        int CThurTime;
        private void btnThurTime_Click(object sender, EventArgs e)
        {
            TextBox txtThurTime = new TextBox();
            txtThurTime.Name = "ThurTime" + CThurTime;
            txtThurTime.Location = new System.Drawing.Point(205 + (100 * CThurTime), 160);
            CThurTime++;
            txtThurTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtThurTime);
        }

        int CThurSub;
        private void btnThurSub_Click(object sender, EventArgs e)
        {
            TextBox txtThurSub = new TextBox();
            txtThurSub.Name = "ThurSub" + CThurSub;
            txtThurSub.Location = new System.Drawing.Point(205 + (100 * CThurSub), 180);
            CThurSub++;
            txtThurSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtThurSub);
        }

        int CFriTime;
        private void btnFriTime_Click(object sender, EventArgs e)
        {
            TextBox txtFriTime = new TextBox();
            txtFriTime.Name = "FriTime" + CFriTime;
            txtFriTime.Location = new System.Drawing.Point(205 + (100 * CFriTime), 200);
            CFriTime++;
            txtFriTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtFriTime);
        }

        int CFriSub;
        private void btnFriSub_Click(object sender, EventArgs e)
        {
            TextBox txtFriSub = new TextBox();
            txtFriSub.Name = "FriSub" + CFriSub;
            txtFriSub.Location = new System.Drawing.Point(205 + (100 * CFriSub), 220);
            CFriSub++;
            txtFriSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtFriSub);
        }

        int CSatTime;
        private void btnSatTime_Click(object sender, EventArgs e)
        {
            TextBox txtSatTime = new TextBox();
            txtSatTime.Name = "SatTime" + CSatTime;
            txtSatTime.Location = new System.Drawing.Point(205 + (100 * CSatTime), 240);
            CSatTime++;
            txtSatTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtSatTime);
        }

        int CSatSub;
        private void btnSatSub_Click(object sender, EventArgs e)
        {
            TextBox txtSatSub = new TextBox();
            txtSatSub.Name = "SatSub" + CSatSub;
            txtSatSub.Location = new System.Drawing.Point(155 + (100 * CSatSub), 260);
            CSatSub++;
            txtSatSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtSatSub);
        }

        int CSunTime;
        private void btnSunTime_Click(object sender, EventArgs e)
        {
            TextBox txtSunTime = new TextBox();
            txtSunTime.Name = "SunTime" + CSunTime;
            txtSunTime.Location = new System.Drawing.Point(155 + (100 * CSunTime), 280);
            CSunTime++;
            txtSunTime.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtSunTime);
        }

        int CSunSub;
        private void btnSunSub_Click(object sender, EventArgs e)
        {
            TextBox txtSunSub = new TextBox();
            txtSunSub.Name = "SunSub" + CSunSub;
            txtSunSub.Location = new System.Drawing.Point(155 + (100 * CSunSub), 300);
            CSunSub++;
            txtSunSub.Size = new System.Drawing.Size(100, 25);
            Controls.Add(txtSunSub);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTue_Click(object sender, EventArgs e)
        {

        }

        private void lblMon_Click(object sender, EventArgs e)
        {

        }

        private void formTimeTable_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void formTimeTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            //Application.Exit();
        }
    }
}
