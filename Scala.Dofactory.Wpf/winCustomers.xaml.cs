using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Scala.Dofactory.Core.Entities;
using Scala.Dofactory.Core.Services;

namespace Scala.Dofactory.Wpf
{
    /// <summary>
    /// Interaction logic for winCustomers.xaml
    /// </summary>
    public partial class winCustomers : Window
    {
        bool isNew;

        public winCustomers()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void ViewLeft()
        {
            grpCustomers.IsEnabled = true;
            grpDetails.IsEnabled = false;
            btnCustomerSave.Visibility = Visibility.Hidden;
            btnCustomerCancel.Visibility = Visibility.Hidden;
        }
        private void ViewRight()
        {
            grpCustomers.IsEnabled = false;
            grpDetails.IsEnabled = true;
            btnCustomerSave.Visibility = Visibility.Visible;
            btnCustomerCancel.Visibility = Visibility.Visible;
        }
        private void ClearControls()
        {
            txtCity.Text = "";
            txtCountry.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
        }
        private void PopulateCustomers()
        {
            lstCustomers.ItemsSource = null;
        }
        private void LstCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnCustomerNew_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnCustomerEdit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnCustomerDelete_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnCustomerSave_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SelectCustomer(int id)
        {
            //for (int r = 0; r < lstCustomers.Items.Count; r++)
            //{
            //    if (((Customer)lstCustomers.Items[r]).Id == id)
            //    {
            //        lstCustomers.SelectedIndex = r;
            //        lstCustomers.BringIntoView();
            //        return;
            //    }

            //}
        }
        private void btnCustomerCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
