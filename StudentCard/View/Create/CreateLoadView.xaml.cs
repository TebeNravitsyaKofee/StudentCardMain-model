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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
