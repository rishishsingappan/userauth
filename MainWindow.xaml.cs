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

namespace Userauthentication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var username = textbox1.Text;
            var password = passwordbox.Password;

            using(userdatacontext userdatacontext = new userdatacontext())
            {
                bool userfound = userdatacontext.Users.Any(user => user.name == username && user.password == password);

                if (userfound)
                {
                    Grantaccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }

        }

        public void Grantaccess()
        {
           main main = new main();
            main.Show();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
