using MahApps.Metro.Controls;

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

namespace LoanManagementSystem.View.WpfWindow
{
    public partial class LoginWindow : MetroWindow
    {
        private static LoginWindow instance;

        public LoginWindow()
        {
            InitializeComponent();
        }


        public static LoginWindow Instance
        {
            get
            {
                if (instance == null || !instance.IsActive)
                {
                    instance = new LoginWindow();
                }

                return instance;
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.Show();
            this.Close();
        }
    }
}
