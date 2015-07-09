using System.Windows;
using System.Windows.Controls;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Data;
using LoanManagementSystem.View.WpfWindow;
using LoanManagementSystem.View.WpfPage;


namespace LoanManagementSystem.View.WpfPage
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class DashBoardPage : Page
    {
        private static DashBoardPage instance;
        public IList<string> ErrorList { get; set; }

        private DashBoardPage()
        {
            InitializeComponent();
        }

        public static DashBoardPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DashBoardPage();
                }

                return instance;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Application.Current.Shutdown();
            //UsernameText.Text = "";
            //PasswordText.Password = "";
        }

        private void EnterClicked(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            { //Keys.Enter
               
                e.Handled = true;
            }
        }

        private void LoadIrisPatientButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        
        private void CompanyBtn_Click(object sender, RoutedEventArgs e)
        {
           // MainWindow.Instance.ContentFrame.Content = CompanyPage.Instance;
           // CompanyPage.Instance.ContentFrame.Content = ViewPage.Instance;
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
           // MainWindow.Instance.ContentFrame.Content = EmployeePage.Instance;
        }

        private void ReportsBtn_Click(object sender, RoutedEventArgs e)
        {
           // MainWindow.Instance.ContentFrame.Content = ReportPage.Instance;
        }

        private void AttendenceBtn_Click(object sender, RoutedEventArgs e)
        {
         //   MainWindow.Instance.ContentFrame.Content = AttendencePage.Instance;
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.ContentFrame.Content = SettingsPage.Instance;
        }

    }
}
