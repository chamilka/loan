using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;


namespace LoanManagementSystem.View.WpfPage.Customer.CustomerPages
{
    /// <summary>
    /// Interaction logic for Employee QuickSearchPage.xaml
    /// </summary>
    public partial class QuickSearchPage : Page
    {
        private static QuickSearchPage instance;
        //public IList<string> ErrorList { get; set; }
        //public List<Employee> EmployeeList { get; set; }
        //public List<PageData> PagingList { get; set; }

        //private PagingCollection<Employee> _PagingCollection { get; set; }

        private bool _isSearchedPerformed = false;
        private string _searchText = "";

        private QuickSearchPage()
        {
            InitializeComponent();
            RefreshEmployeeListByPage(1);
        }

        public static QuickSearchPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuickSearchPage();
                }

                return instance;
            }
        }


        private void QuickSearchButton_Click(object sender, RoutedEventArgs e)
        {
            _isSearchedPerformed = true;
            _searchText = QuickSearchTextBox.Text;
            RefreshEmployeeListByPage(1);
        }

        private void RefreshEmployeeListByPage(int page)
        {
            //if (_isSearchedPerformed)
            //{
            //    _PagingCollection = EmployeeService.GetPaginatedQuickSearchedEmployeeListByPage(_searchText, page);
            //}
            //else
            //{
            //    _PagingCollection = EmployeeService.GetPaginatedEmployeeListByPage(page);
            //}

            //EmployeeList = _PagingCollection.Collection;
            //PagingList = _PagingCollection.PagesList;

            //EmployeeListView.ItemsSource = EmployeeList;
            //EmployeeListView.Items.Refresh();

            //PagingListView.ItemsSource = PagingList;
            //PagingListView.Items.Refresh();
        }

        private void PaginationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int selectedpage = int.Parse(button.Content.ToString());

            RefreshEmployeeListByPage(selectedpage);
        }

        private void EmployeeDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            //Button button = (Button)sender;
            //StackPanel sp = (StackPanel)button.Content;
            //Label lbl = sp.Children.OfType<Label>().FirstOrDefault();

            //if (lbl.Content.ToString() != "")
            //{
            //    Employee selected = EmployeeList.Single(c => c.ID == int.Parse(lbl.Content.ToString()));

            //    Session.SelectedEmployee = selected;
            //}
            //else
            //{
            //    MessageWindow msg = new MessageWindow(Messages.TTL_MSG, Messages.MSG_SELECT_EMPLOYEE);
            //    msg.ShowDialog();
            //}
        }

    }
}
