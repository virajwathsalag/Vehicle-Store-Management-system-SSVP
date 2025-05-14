﻿using System;
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
    /// Interaction logic for PriusCustomize.xaml
    /// </summary>
    public partial class PriusCustomize : Window
    {
        public PriusCustomize()
        {
            InitializeComponent();
        }

        private void IconImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnViewPricePriusCus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnViewPricePriusCas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\ssvpCarAppDB.mdf;Integrated Security=True;Connect Timeout=30;";
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle (Vehicle_Id, Name, Colour, QTY, Seat_Material, DashBoard, StearingWheel, Rim, Door, Generation, Engine, FuelType, Price, DelivaryDate) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14)", con);
                    float Price = 6500000;

                    // Validate NIC and Name
                    if (string.IsNullOrEmpty(txtNIC.Text) || string.IsNullOrEmpty(txtName.Text))
                    {
                        MessageBox.Show("Please enter valid NIC and Name.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@v1", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@v2", txtName.Text);

                    // Colour
                    if (rdbColour_B.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v3", "Black");
                    }
                    else if (rdbColour_W.IsChecked == true)
                    {
                        Price += 200000;
                        cmd.Parameters.AddWithValue("@v3", "White");
                    }
                    else if (rdbColour_R.IsChecked == true)
                    {
                        Price += 185000;
                        cmd.Parameters.AddWithValue("@v3", "Red");
                    }
                    else if (rdbColour_Bu.IsChecked == true)
                    {
                        Price += 150000;
                        cmd.Parameters.AddWithValue("@v3", "Blue");
                    }
                    else if (rdbColour_G.IsChecked == true)
                    {
                        Price += 150000;
                        cmd.Parameters.AddWithValue("@v3", "Grey");
                    }
                    else
                    {
                        MessageBox.Show("Please select a color.");
                        return;
                    }

                    // Quantity
                    if (!float.TryParse(txtQty.Text, out float qty) || qty <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@v4", (int)qty);



                    // Seat Material
                    if (rdbLether.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v5", "Leather");
                    }
                    else if (rdbNylon.IsChecked == true)
                    {
                        Price += 100000;
                        cmd.Parameters.AddWithValue("@v5", "Nylon");
                    }
                    else
                    {
                        MessageBox.Show("Please select a seat material.");
                        return;
                    }

                    // Dashboard
                    if (rdbAnalog.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v6", "Analog");
                    }
                    else if (rdbDigital.IsChecked == true)
                    {
                        Price += 350000;
                        cmd.Parameters.AddWithValue("@v6", "Digital");
                    }
                    else
                    {
                        MessageBox.Show("Please select a dashboard type.");
                        return;
                    }

                    //SterianWheel
                    if (rdbCircle.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v7", "Circle");
                    }
                    else if (rdbSquare.IsChecked == true)
                    {
                        Price += 250000;
                        cmd.Parameters.AddWithValue("@v7", "Square");
                    }
                    else
                    {
                        MessageBox.Show("Please select a dashboard type.");
                        return;
                    }

                    // Rim
                    if (rdbRim_S.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v8", "S");
                    }
                    else if (rdbRim_M.IsChecked == true)
                    {
                        Price += 100000;
                        cmd.Parameters.AddWithValue("@v8", "M");
                    }
                    else if (rdbRim_L.IsChecked == true)
                    {
                        Price += 185000;
                        cmd.Parameters.AddWithValue("@v8", "L");
                    }
                    else
                    {
                        MessageBox.Show("Please select a rim size.");
                        return;
                    }

                    // Doors
                    if (rdbDoor_B.IsChecked == true)
                    {
                        Price += 550000;
                        cmd.Parameters.AddWithValue("@v9", "B");
                    }
                    else if (rdbDoor_S.IsChecked == true)
                    {
                        cmd.Parameters.AddWithValue("@v9", "S");
                    }
                    else
                    {
                        MessageBox.Show("Please select a door type.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@v10", "5.1");
                    cmd.Parameters.AddWithValue("@v11", "Hybrid");
                    cmd.Parameters.AddWithValue("@v12", "Petrol");


                    Price = Price * qty;
                    txtViewPrice.Text = Convert.ToString(Price);
                    cmd.Parameters.AddWithValue("@v13", Price);
                    txtViewPrice.Text = Price.ToString("F2");

                    int date;
                    if (qty < 3)
                    {
                        date = 3;
                    }
                    else if (qty > 3 && qty <= 5)
                    {
                        date = 10;
                    }
                    else
                    {
                        date = 30;
                    }
                    cmd.Parameters.AddWithValue("@v14", date);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }

                    if (result == 0)
                    {
                        MessageBox.Show("Something Went Wrong");
                    }

                    con.Close();
                }



            }
            catch (Exception obj) { MessageBox.Show(obj.Message.ToString()); }
        }

        private void btnViewPricePriusCus_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerPaymentDetails cpd1 = new CustomerPaymentDetails();
            this.Close();
            cpd1.Show();
        }
    }
}
