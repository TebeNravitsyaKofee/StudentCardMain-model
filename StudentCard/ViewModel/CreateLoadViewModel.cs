using StudentCard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentCard.ViewModel
{
    class CreateLoadViewModel : ObservableObject
    {
        private DataGrid dgg;
        
        public ICommand SaveLoadCommand { get; }
        public ICommand DeleteLoadCommand { get; }
        public ICommand DG { get; }
        public void dg()
        {

        }

        public CreateLoadViewModel()
        {
            SaveLoadCommand = new Command(SaveLoad);

            DeleteLoadCommand = new Command(DeleteLoad);
            DG = new Command(dg);
        }
        public Group GroupCB{ get; set; }
        public Discipline DisciplineCB { get; set; }
        public int? Sem1Weeks { get; set; } = null;
        public int? Sem1Hours { get; set; } = null;
        public int? Sem1ExamNum { get; set; } = null;
        public ExamType Sem1ExamType { get; set; }
        public int? Sem2Weeks { get; set; } = null;
        public int? Sem2Hours { get; set; } = null;
        public int? Sem2ExamNum { get; set; } = null;
        public int? Sem2ExamHours { get; set; } = null;
        public ExamType Sem2ExamType { get; set; }

        void SaveLoad()
        {
            YurecDBEntities db = new YurecDBEntities();
            Load load = new Load
            {
                ID_group = GroupCB.ID_group,
                ID_distributed_dis = DisciplineCB.ID_discipline,
                sem1_weeks = Sem1Weeks,
                sem1_hours = Sem1Hours,
                sem1_exam_num = Sem1ExamNum,
                sem1_ID_exam_type = Sem1ExamType.ID_exam_type,
                sem2_weeks = Sem2Weeks,
                sem2_hours = Sem2Hours,
                sem2_exam_num = Sem2ExamNum,
                sem2_exam_hours = Sem2ExamHours,
                sem2_ID_exam_type = Sem2ExamType.ID_exam_type
            };
            db.Load.Add(load);
            db.SaveChanges();
        }

        public void DeleteLoad()
        {
            Load a = dgg.SelectedItem as Load;
        }

    }
}
