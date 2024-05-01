using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanHelpGroupProject
{
    public partial class titanHelpForm : Form
    {

        //constructor
        public titanHelpForm()
        {
            InitializeComponent();
            
        }

        //code generated through config wizard
        private void titanHelpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titanHelpDatabaseDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.titanHelpDatabaseDataSet.Tickets);

        }
        

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------



        //opens newticketform for users to submit a new help desk ticket
        private void createTicketButton_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicket = new NewTicketForm();
            newTicket.ShowDialog();

            //refresh datagridview when control is given back
            dgvRefresh();
        }

        //ticketsdatagridview refresh
        private void dgvRefresh()
        {
            //create connection string variable
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tjake\\source\\repos\\TitanHelpGroupProject\\TitanHelpGroupProject\\TitanHelpDatabase.mdf;Integrated Security=True";

            //create SQL connection intializing it with connection string
            SqlConnection con = new SqlConnection(connectionString);

            //create a new datatable
            System.Data.DataTable dt = new DataTable();

            //create new adapter initialized with query to select all and connection object
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Tickets", con);

            //open connection, using the adapter, fill the datatable with the data returned from the query, and close connection
            con.Open();
            adp.Fill(dt);
            con.Close();

            //reassign the datagridviews datasource with the data from the datatable, refreshing the list of tickets for the user
            ticketDataGridView.DataSource = dt;


        }

        //close button redundancy
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
