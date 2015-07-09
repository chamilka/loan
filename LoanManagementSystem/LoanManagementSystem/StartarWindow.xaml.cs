using LoanManagementSystem.View.WpfWindow;

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

namespace LoanManagementSystem
{
    /// <summary>
    /// Interaction logic for StartarWindow.xaml
    /// </summary>
    public partial class StartarWindow : Window
    {
        public StartarWindow()
        {
            InitializeComponent();
            LoginWindow.Instance.Show();
            this.Close();
        }
    }
}
