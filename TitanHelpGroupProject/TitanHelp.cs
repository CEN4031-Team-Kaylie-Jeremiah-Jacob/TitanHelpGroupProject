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
    public partial class titanHelpForm : Form
    {
        newTicketForm newTicketForm = new newTicketForm();

        public titanHelpForm()
        {
            InitializeComponent();
        }

        //close button functionality
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createTicketButton_Click(object sender, EventArgs e)
        {
            newTicketForm.Visible = true;
        }
    }
}
