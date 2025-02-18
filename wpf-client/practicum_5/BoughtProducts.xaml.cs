﻿using System;
using System.Collections.Generic;
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

namespace practicum_5
{
    /// <summary>
    /// Interaction logic for BoughtProducts.xaml
    /// </summary>
    public partial class BoughtProducts : Window
    {
        public BoughtProducts()
        {
            InitializeComponent();

            OrderLineServiceReference.OrderLineServiceClient OrderLineServiceProxy = new OrderLineServiceReference.OrderLineServiceClient();
            int customerId = Int16.Parse(Application.Current.Resources["CUSTOMER_ID"].ToString());
            BoughtProductsGrid.ItemsSource = OrderLineServiceProxy.PerProductByCustomer(customerId);
        }

        private void To_Me(object sender, RoutedEventArgs e)
        {
            Me MeWindow = new Me();
            MeWindow.Show();
            this.Close();
        }
    }
}
