using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Xaml.Behaviors.Layout;

namespace CarApp2.MVVM.View
{
    /// <summary>
    /// Interaction logic for PurchaseDetailsView.xaml
    /// </summary>
    public partial class PurchaseDetailsView : UserControl
    {
        private List<string> searchSuggestions = new List<string>();

        public PurchaseDetailsView()
        {
            InitializeComponent();
        }

        private void getdata()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string sql = "SELECT * FROM Vehicle";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Vehicle Data");
                DataGridEdetails.ItemsSource = ds.Tables["Vehicle Data"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private void searchData(string searchTerm)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string sql = "SELECT * FROM Vehicle WHERE Name LIKE @searchTerm OR Vehicle_Id LIKE @searchTerm";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Vehicle Data");
                DataGridEdetails.ItemsSource = ds.Tables["Vehicle Data"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnverify_Click(object sender, RoutedEventArgs e)
        {
        }

        private void comboBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = comboBoxSearch.Text;
            if (searchTerm.Length >= 2)
            {
                FilterSearchSuggestions(searchTerm);
            }
        }

        private void comboBoxSearch_DropDownOpened(object sender, EventArgs e)
        {
            LoadSearchSuggestions();
        }

        private void LoadSearchSuggestions()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string sql = "SELECT DISTINCT Vehicle_Id FROM Vehicle";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                searchSuggestions.Clear();
                while (reader.Read())
                {
                    searchSuggestions.Add(reader["Vehicle_Id"].ToString());
                }
                comboBoxSearch.ItemsSource = searchSuggestions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void FilterSearchSuggestions(string searchTerm)
        {
            var filteredSuggestions = searchSuggestions.FindAll(s => s.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
            comboBoxSearch.ItemsSource = filteredSuggestions;
            comboBoxSearch.IsDropDownOpen = true;

            // Set cursor position
            var textBox = (TextBox)comboBoxSearch.Template.FindName("PART_EditableTextBox", comboBoxSearch);
            if (textBox != null)
            {
                textBox.SelectionStart = searchTerm.Length;
                textBox.SelectionLength = 0;
            }
        }
        void fillingDataGridUsingDataTable()
        {
            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("Vehicle_ID", typeof(int));
            DataColumn Name = new DataColumn("Name", typeof(string));
            DataColumn Price = new DataColumn("Price", typeof(float));


            dt.Columns.Add(id);
            dt.Columns.Add(Name);
            dt.Columns.Add(Price);





        }

        private void DataGridEdetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridEdetails.SelectedItem is DataRowView row_selected)
            {
                txtCarID.Text = row_selected["Vehicle_Id"].ToString();
                txtName.Text = row_selected["Name"].ToString();
                txtPrice.Text = row_selected["Price"].ToString();



            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
             searchData(comboBoxSearch.Text);
        }
    }
}
