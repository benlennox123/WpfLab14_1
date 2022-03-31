using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLab14_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> pr;
        public MainWindow()
        {
            InitializeComponent();
            pr = new ObservableCollection<Product>();
            pr.Add(new Product()
            {
                ProductImage = "Data/Сахар.jpg",
                ProductName = "Сахар",
                ProductPrice = 99.99,
                ProductCategory = ProductCategoryList.Food
            });
            pr.Add(new Product()
            {
                ProductImage = "Data/Греча.jpg",
                ProductName = "Греча",
                ProductPrice = 59.99,
                ProductCategory = ProductCategoryList.Food
            });
            pr.Add(new Product()
            {
                ProductImage = "Data/ТВ.jpg",
                ProductName = "Телевизор",
                ProductPrice = 22999.99,
                ProductCategory = ProductCategoryList.HomeTechnique
            });
            pr.Add(new Product()
            {
                ProductImage = "Data/Чайник.jpg",
                ProductName = "Чайник",
                ProductPrice = 999.99,
                ProductCategory = ProductCategoryList.HomeTechnique
            });
            lstBox.ItemsSource = pr;
        }
    }
}
