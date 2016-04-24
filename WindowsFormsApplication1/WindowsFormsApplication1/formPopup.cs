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
        public static string time;

        public formPopup()
        {
            InitializeComponent();
        }

        private void formPopup_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker.CheckForIllegalCrossThreadCalls = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)        //this handler here closes the foerm and hopefully copies time to a string
        {
            formPopup.time = timePicker.Value.ToShortTimeString();
            this.Close();
        }
    }
}
