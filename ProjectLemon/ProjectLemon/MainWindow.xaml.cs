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

namespace ProjectLemon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            //lemonDBEntities lem = new lemonDBEntities();
            lemonDbEntities lem = new lemonDbEntities(); //вот эта хрень берется от сюда, но дело не в ней
            var data = from d in lem.c_request select d; //это называется linq запросы

            authTable.ItemsSource = data.ToList();

        }
    }
}
