using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace StudentCard.View
{
    /// <summary>
    /// Логика взаимодействия для LoadView.xaml
    /// </summary>
    public partial class LoadView : UserControl
    {
        YurecDBEntities db = new YurecDBEntities();



        public LoadView()
        {
            InitializeComponent();
            TimetableDG.ItemsSource = db.Load.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           CreateLoad.Visibility = Visibility.Visible;

        }

        
    }
}
