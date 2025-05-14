using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarApp2
{
    /// <summary>
    /// Interaction logic for CustomerPaymentDetails.xaml
    /// </summary>
    public partial class CustomerPaymentDetails : Window
    {
        public CustomerPaymentDetails()
        {
            InitializeComponent();
        }

        private void btnDefaultCOnfigOk_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30;";
                SqlConnection con = new SqlConnection(connstring);

                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES(@v1,@v2,@v3,@v4,@v5,@v6)", con);

                cmd.Parameters.AddWithValue("@v1", txtNIC.Text);
                cmd.Parameters.AddWithValue("@v2", txtFname.Text);
                cmd.Parameters.AddWithValue("@v3", txtAddress.Text);
                string country = Convert.ToString(cobCuntry.Text);
                cmd.Parameters.AddWithValue("@v4", country);
                cmd.Parameters.AddWithValue("@v5", txtTele.Text);
                cmd.Parameters.AddWithValue("@v6", txtEmail.Text);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {

                }

                if (result == 0)
                {
                    MessageBox.Show("Something Went Wrong");
                }

                con.Close();

            }
            catch (Exception obj) { MessageBox.Show(obj.Message.ToString()); }


            SSVPBill bill = new SSVPBill();
            this.Close();
            bill.Show();
        }

        private void txtTele_MouseEnter(object sender, MouseEventArgs e)
        {
            string NO = Convert.ToString(cobNO.Text);
            txtTele.Text = Convert.ToString(NO);
        }

        private void imgBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    MessageBox.Show("Database connected successfully");

                    // Delete query for Vehicle
                    string deleteVehicleQuery = "DELETE FROM Vehicle WHERE Vehicle_Id = @NICParam";

                    using (SqlCommand cmd = new SqlCommand(deleteVehicleQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@NICParam", txtNIC.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No vehicle record found for the given NIC.");
                        }
                    }
                }

                DashBoard board = new DashBoard();
                this.Close();
                board.Show();
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message.ToString());
            }

        }
    }
}
