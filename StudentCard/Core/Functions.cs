using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentCard
{
    class Functions
    {
        public class DayNames
        {
            public string DayColumn { get; set; }
        }

        public void FillGridWithDayNames(object sender)
        {

            DataGrid dg = sender as DataGrid;
            dg.Items.Add(new DayNames { DayColumn = " " });

            dg.Items.Add(new DayNames { DayColumn = "Понедельник" });
            for(int i=0;i<5;i++)
            {
                dg.Items.Add(new DayNames { DayColumn = " " });
            }

            dg.Items.Add(new DayNames { DayColumn = "Вторник" });
            for (int i = 0; i < 5; i++)
            {
                dg.Items.Add(new DayNames { DayColumn = " " });
            }

            dg.Items.Add(new DayNames { DayColumn = "Среда" });
            for (int i = 0; i < 5; i++)
            {
                dg.Items.Add(new DayNames { DayColumn = " " });
            }

            dg.Items.Add(new DayNames { DayColumn = "Четверг" });
            for (int i = 0; i < 5; i++)
            {
                dg.Items.Add(new DayNames { DayColumn = " " });
            }

            dg.Items.Add(new DayNames { DayColumn = "Пятница" });
            for (int i = 0; i < 5; i++)
            {
                dg.Items.Add(new DayNames { DayColumn = " " });
            }

        }
    }
}
