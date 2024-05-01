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
    public partial class NewTicketForm : Form
    {
        
        //constructor
        public NewTicketForm()
        {
            InitializeComponent();
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        

        //adds a new ticket to database using user input on the form 
        private void submitButton_Click(object sender, EventArgs e)
        {
            //save connection string to variable
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tjake\\source\\repos\\TitanHelpGroupProject\\TitanHelpGroupProject\\TitanHelpDatabase.mdf;Integrated Security=True";

            //create variable to hold the query to add the new tickets to the database
            string queryString = "insert into Tickets (StudentName, Date, ProblemDescription) values (@StudentName, @Date, @ProblemDescription)";

            //create connection object initialized with the database connection string
            SqlConnection con = new SqlConnection(connectionString);

            //create command object intialized with our query and connection object
            SqlCommand cmd = new SqlCommand(queryString, con);

            //add student name to database
            cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
            //add date to database. Date will always be current and field has been locked out of editing from the user
            cmd.Parameters.AddWithValue("@Date", ticketDateTimePicker.Text);
            //add problem description to database
            cmd.Parameters.AddWithValue("@ProblemDescription", problemDescriptionTextBox.Text);

            //open the connection, execute, and close
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //confirm to the user that the ticket was submitted
            MessageBox.Show("Ticket Submitted");

            //close the form
            this.Close();
 
        }


        //close button redundancy
        private void cancelNewTicketButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
