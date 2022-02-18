using StudentCard.ViewModel;
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

namespace StudentCard.View
{
    /// <summary>
    /// Логика взаимодействия для CreateLoadView.xaml
    /// </summary>
    public partial class CreateLoadView : UserControl
    {
        YurecDBEntities db = new YurecDBEntities();
       
       
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
            Group gr = group_cb.SelectedItem as Group;
            DistributedDiscipline dd = discipline_cb.SelectedItem as DistributedDiscipline;

            Load a = new Load
            {
                ID_group = gr.ID_group,
                ID_distributed_dis = dd.ID_distrubuted_dis,
                sem1_weeks = Convert.ToInt32(sem1_weeks_tb),
                sem1_hours = Convert.ToInt32(sem1_hours_tb),
                sem1_exam_num = Convert.ToInt32(sem1_exam_num_tb),

            };
        }


    }
}
