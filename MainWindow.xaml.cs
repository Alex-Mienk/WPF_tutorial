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

namespace Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ObservableCollection notifies the UI when contacts are added or removed.
        private ObservableCollection<Contact> Contacts { get; set; }

        public MainWindow()
        {
            // Loads and connects all controls declared in MainWindow.xaml.
            InitializeComponent();

            Contacts = new ObservableCollection<Contact>();

            // Makes the contacts collection the default binding source for this window.
            DataContext = Contacts;
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            // Close() ends the main window and therefore exits this simple app.
            Close();
        }

        private void MenuItem_AddContact(object sender, RoutedEventArgs e)
        {
            // Dim the owner window while the modal dialog is active.
            Opacity = 0.5;

            var addContactWindow = new AddContactWindow();
            // ShowDialog returns true only when the Add button sets DialogResult to true.
            if (addContactWindow.ShowDialog().Value)
            {
                Contacts.Add(addContactWindow.NewContact);
            }

            // Restore the window once the dialog has closed.
            Opacity = 1;
        }

        private void MenuItem_ClearContacts(object sender, RoutedEventArgs e)
        {
            // Clear raises collection notifications so bound controls refresh automatically.
            Contacts.Clear();
        }

        private void MenuItem_About(object sender, RoutedEventArgs e)
        {
            // MessageBoxButton and MessageBoxImage have alternatives such as YesNo, Warning, and Error.
            MessageBox.Show("This is a simple contact manager.", "Contact Manager", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
