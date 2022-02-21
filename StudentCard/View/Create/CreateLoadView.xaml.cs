using StudentCard.Core;
using StudentCard.ViewModel;
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
    /// Логика взаимодействия для CreateLoadView.xaml
    /// </summary>
    public partial class CreateLoadView : UserControl, INotifyPropertyChanged
    {
        YurecDBEntities db = new YurecDBEntities();
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public CreateLoadView()
        {
            InitializeComponent();
            group_cb.ItemsSource = db.Group.ToList();
            discipline_cb.ItemsSource = db.Discipline.ToList();
            sem1_exam_type_cb.ItemsSource = db.ExamType.ToList();
            sem2_exam_type_cb.ItemsSource = db.ExamType.ToList();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            OnPropertyChanged();
        }


    }
}
