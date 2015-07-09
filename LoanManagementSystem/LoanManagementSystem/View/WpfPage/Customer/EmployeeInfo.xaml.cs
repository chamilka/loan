using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using HRMSystem.Models;
using System;
using System.IO;
using System.Windows.Media.Imaging;


namespace HRMSystem.Wpf.EmployeePages
{
    /// <summary>
    /// Interaction logic for Employee EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : Page
    {
        private static EmployeeInfo _instance;
        private byte[] _imageData { get; set; }
        public IList<string> ErrorList { get; set; }

        private EmployeeInfo()
        {
            InitializeComponent();
        }

        public static EmployeeInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeInfo();
                }

                return _instance;
            }
        }

        public Employee GetEmployeeDetails()
        {
            try
            {
                Employee employee = new Employee();

                employee.EMP_ID = "CheckID";
                employee.BANK = EmpBankNameTextBox.Text;
                employee.BANK_ACCONT_NUMBER = EmpBanckAccTextBox.Text;
                employee.CIVIL_STATUS = EmpCivilStateTextBox.Text;
                employee.DOB = EmpBirthDayPicker.SelectedDate;
                employee.FIRST_NAME = EmpFNameTextBox.Text;
                employee.GENDER = getGender();

                employee.LAST_NAME = EmpLNameTextBox.Text;
                employee.NATIONALITY = EmpNationalityTextBox.Text;
                employee.NIC = EmpNICTextBox.Text;
                //employee.PASSWORD = null;
                //employee.USERNAME = null;

                employee.PREFERRED_NAME = EmpPNameTextBox.Text;
                employee.PROFPIC = _imageData;
                employee.RELIGION = EmpReligionTextBox.Text;

                employee.ISRESIGN = false;
                employee.INSERT_DATETIME = DateTime.Now;
                employee.INSERT_USER_ID = Session.LoggedEmployee.ID;
                employee.UPDATE_DATETIME = DateTime.Now;
                employee.UPDATE_USER_ID = Session.LoggedEmployee.ID;

                return employee;
            }
            catch (Exception)
            {
                return null;
            }
        }

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
