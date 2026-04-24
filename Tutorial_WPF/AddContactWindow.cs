using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tutorial_WPF
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
}
