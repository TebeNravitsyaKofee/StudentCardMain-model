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
            //filling the group combobox
            List<Group> a = new List<Group>(db.Group.ToList());
            foreach (var group in a)
            {
                group_cb.Items.Add(group.name_group);
            }

            //filling the subject combobox
            List<DistributedDiscipline> b = new List<DistributedDiscipline>(db.DistributedDiscipline.ToList());
            foreach (var dis in b)
            {
                discipline_cb.Items.Add(dis.Discipline.name_discipline);
            }
            //filling the exam type cb
            List<ExamType> c = new List<ExamType>(db.ExamType.ToList());
            foreach (var et in c)
            {
                exam
            }
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
