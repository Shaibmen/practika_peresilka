using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _1PractPractika.DataSet1TableAdapters;

namespace _1PractPractika
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        PriestTableAdapter priest = new PriestTableAdapter();
        public Page2()
        {
            InitializeComponent();
            SecondGrid.ItemsSource = priest.GetData();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new MainWindow();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
        }
    }
}
