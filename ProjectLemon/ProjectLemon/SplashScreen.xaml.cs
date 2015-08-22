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
using System.Windows.Shapes;
using System.IO;


namespace ProjectLemon
{
    /// <summary>
    /// Логика взаимодействия для SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();

            

            MessageBox.Show(Environment.CurrentDirectory);
        }

        //обработка кнопки вход
        private void logon_Click(object sender, RoutedEventArgs e)
        {
            //обращаемся к базе через объектную модель
            using (lemonDbEntities db = new lemonDbEntities())
            {
                //это поиск соответсвия по логину и паролю синтаксис Linq to Entities
                var auth = db.auth.Count(p => p.login == login.Text && p.password == passwordBox.Password);

                if (auth > 0)
                {
                    //если все ок то закрываем наш SplashScreen и открываем главное окно
                    MainWindow mainWindow = new MainWindow();
                    this.Close();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль"); //альтернатива alert в javascript
                }
            }
        }
    }
}
