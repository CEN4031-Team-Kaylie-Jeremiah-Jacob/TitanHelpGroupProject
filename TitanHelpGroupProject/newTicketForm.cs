using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanHelpGroupProject
{
    public partial class newTicketForm : Form
    {
        public newTicketForm()
        {
            InitializeComponent();
        }

        //cancel and close new ticket window
        private void cancelNewTicketButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
