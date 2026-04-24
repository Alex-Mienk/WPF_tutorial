using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tutorial_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public partial class AddContactWindow : Window
        {
            public Contact NewContact { get; private set; }
            public AddContactWindow()
            {
                InitializeComponent();
                NewContact = new Contact();
                DataContext = NewContact;
            }
        }

        private ObservableCollection<Contact> Contacts {  get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Contacts = new ObservableCollection<Contact>();

            DataContext = Contacts;
        }
    }

    public class Contact{
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Gender Gender { get; set; }
        public Contact()
        {
        }
    }
    public enum Gender
    {
        Male,
        Female
    }

    

}