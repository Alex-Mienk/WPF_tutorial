using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    /// <summary>
    /// Data model for one contact. Nullable strings allow empty form fields.
    /// </summary>
    public class Contact
    {
        // Auto-properties are enough here because WPF reads and writes through public getters/setters.
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        // Enum values are used by the ComboBox and by avatar triggers in MainWindow.xaml.
        public Gender Gender { get; set; }

        // Parameterless constructor is useful for XAML/data-binding scenarios and simple object creation.
        public Contact()
        {
        }
    }

    /// <summary>
    /// Possible contact genders. Add more values here to show them in the add-contact ComboBox.
    /// </summary>
    public enum Gender
    {
        Male, Female
    }
}
