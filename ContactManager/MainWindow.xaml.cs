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
using ContactManager.DB;

namespace ContactManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            //db init :D
            //var context = new ContactManagerContext();

            //People initPerson = new People
            //{
            //    Name = "Anderson"
            //};

            //context.Peoples.Add(initPerson);
            //context.SaveChanges();
        }
    }
}
