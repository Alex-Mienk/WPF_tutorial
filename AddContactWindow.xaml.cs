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

namespace Tutorial
{
    /// <summary>
    /// Interaction logic for AddContactWindow.xaml
    /// </summary>
    public partial class AddContactWindow : Window
    {
        // The main window reads this property after the dialog returns true.
        public Contact NewContact { get; private set; }

        public AddContactWindow()
        {
            // Loads the visual tree from AddContactWindow.xaml.
            InitializeComponent();
            // The form edits this object directly through bindings.
            NewContact = new Contact();
            // Allows TextBox and ComboBox bindings to resolve against NewContact.
            DataContext = NewContact;
        }

        private void AddContact(object sender, RoutedEventArgs e)
        {
            // true tells ShowDialog callers that the user confirmed the form.
            DialogResult = true;
            Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            // false tells ShowDialog callers to ignore the current NewContact value.
            DialogResult = false;
            Close();
        }
    }
}
