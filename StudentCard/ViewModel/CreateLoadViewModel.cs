using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentCard.ViewModel
{
    class CreateLoadViewModel
    {
        YurecDBEntities db = new YurecDBEntities();
        public ICommand GroupCBCommand { get; }

        public CreateLoadViewModel()
        {
            //GroupCBCommand = new Command();
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

    }
}
