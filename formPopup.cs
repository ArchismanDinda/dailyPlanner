using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class formPopup : Form
    {
        string time;
        public formPopup()
        {
            InitializeComponent();
        }

        private void formPopup_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
            this.time = timePicker.Value.ToShortDateString();
        }
    }
}
