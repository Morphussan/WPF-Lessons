using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace WpfLarionov1
{
    public partial class ProductManagerWindow : Window
    {
        private List<IProduct> _products = new List<IProduct>();

        public ProductManagerWindow()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            if (decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                Product newProduct = new Product
                {
                    Name = name,
                    Price = price
                };

                _products.Add(newProduct);
                ProductListBox.ItemsSource = null; 
                ProductListBox.ItemsSource = _products; 

                // Показываем что мы добавили
                Debug.WriteLine(newProduct); // ToString() для вывода в окно отладки

                // Очищаем поял
                NameTextBox.Clear();
                PriceTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Ввведите нормально цену, иначе ничего не покажу >:[");
            }
        }
    }
}