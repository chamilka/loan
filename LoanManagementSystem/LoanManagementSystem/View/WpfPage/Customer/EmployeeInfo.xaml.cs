using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Media.Imaging;


namespace LoanManagementSystem.View.WpfPage.Customer.CustomerPages
{
    /// <summary>
    /// Interaction logic for Customer CustomerInfo.xaml
    /// </summary>
    public partial class CustomerInfo : Page
    {
        private static CustomerInfo _instance;
        private byte[] _imageData { get; set; }
        public IList<string> ErrorList { get; set; }

        private CustomerInfo()
        {
            InitializeComponent();
        }

        public static CustomerInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomerInfo();
                }

                return _instance;
            }
        }

        //public Customer GetCustomerDetails()
        //{
        //    try
        //    {
        //        Customer Customer = new Customer();

        //        Customer.EMP_ID = "CheckID";
        //        Customer.BANK = EmpBankNameTextBox.Text;
        //        Customer.BANK_ACCONT_NUMBER = EmpBanckAccTextBox.Text;
        //        Customer.CIVIL_STATUS = EmpCivilStateTextBox.Text;
        //        Customer.DOB = EmpBirthDayPicker.SelectedDate;
        //        Customer.FIRST_NAME = EmpFNameTextBox.Text;
        //        Customer.GENDER = getGender();

        //        Customer.LAST_NAME = EmpLNameTextBox.Text;
        //        Customer.NATIONALITY = EmpNationalityTextBox.Text;
        //        Customer.NIC = EmpNICTextBox.Text;
        //        //Customer.PASSWORD = null;
        //        //Customer.USERNAME = null;

        //        Customer.PREFERRED_NAME = EmpPNameTextBox.Text;
        //        Customer.PROFPIC = _imageData;
        //        Customer.RELIGION = EmpReligionTextBox.Text;

        //        Customer.ISRESIGN = false;
        //        Customer.INSERT_DATETIME = DateTime.Now;
        //        Customer.INSERT_USER_ID = Session.LoggedCustomer.ID;
        //        Customer.UPDATE_DATETIME = DateTime.Now;
        //        Customer.UPDATE_USER_ID = Session.LoggedCustomer.ID;

        //        return Customer;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        private string getGender()
        {
            string SEX = "";

            if (GenderRBM.IsChecked == true)
                SEX = ((Label)GenderRBM.Content).Content.ToString();
            else if (GenderRBF.IsChecked == true)
                SEX = ((Label)GenderRBF.Content).Content.ToString();

            return SEX;
        }

        private void LoadImageButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                FileStream fs;
                BinaryReader br;

                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                _imageData = br.ReadBytes((int)fs.Length);

                ProfPicBox.ImageSource = new BitmapImage(new Uri(filename)); //Image.FromFile(newFileName);
            }
        }
    }
}
