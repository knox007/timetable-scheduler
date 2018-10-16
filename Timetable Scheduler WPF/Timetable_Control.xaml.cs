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

namespace Timetable_Scheduler_WPF
{
    /// <summary>
    /// Interaction logic for Timetable_Control.xaml
    /// </summary>
    public partial class Timetable_Control : UserControl
    {
        public Timetable_Control()
        {
            InitializeComponent();
            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                Timetable_Grid.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Name = day.ToString()
                });
            for (int i = 1; i <= 16; ++i)
                Timetable_Grid.RowDefinitions.Add(new RowDefinition()
                {
                    Name = i.ToString()
                });
            
        }
    }
}
