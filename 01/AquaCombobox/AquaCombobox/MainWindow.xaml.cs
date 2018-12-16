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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AquaCombobox
{
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User() { ischecked=false, Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User() { ischecked = false, Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users.Add(new User() { ischecked = false, Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });
            dgUsers.ItemsSource = users;
            this.combobox.SelectionChanged += new SelectionChangedEventHandler(OnMyComboBoxChanged);
        }
        private void OnMyComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            //string text = (e.AddedItems[0] as ComboBoxItem).Content as string;\
            foreach( var u in users)
            {
                if (u.ischecked == true)
                {
                    count++;
                }
            };
            this.combobox.Text = "Items Selected : " + 0;
        }
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public bool ischecked { get; set; }
    }
}
