using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentCard.Core;
using StudentCard.View;

namespace StudentCard.ViewModel
{
    class MainViewModel : ObservableObject
    {
		private object _currentView;

		public RelayCommand FullTimetableViewCommand { get; set; }
		public RelayCommand TodayTimetableViewCommand { get; set; }
		public RelayCommand JournalViewCommand { get; set; }
		public RelayCommand LoadViewCommand { get; set; }
		public RelayCommand TeacherListViewCommand { get; set; }
        public RelayCommand CreateLoadView { get; set; }
		public RelayCommand GroupJournalViewCommand { get; set; }
		public RelayCommand GroupViewCommand { get; set; }

		public FullTimetableViewModel FullTimetableVM{ get; set; }
		public TodayTimetableViewModel TodayTimetableVM { get; set; }
		public JournalViewModel JournalVM { get; set; }
		public LoadViewModel LoadVM { get; set; }
		public TeacherListViewModel TeacherListVM { get; set; }
        public CreateLoadViewModel CreateLoadVM { get; set; }
		public GroupJournalViewModel GroupJournalVM { get; set; }
		public GroupViewModel GroupVM { get; set; }

		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value;
				OnPropertyChanged();
			}
		}
		public MainViewModel()
		{
            //window
			FullTimetableVM = new FullTimetableViewModel();
			TodayTimetableVM = new TodayTimetableViewModel();
			JournalVM = new JournalViewModel();
			LoadVM = new LoadViewModel();
			TeacherListVM = new TeacherListViewModel();
			GroupJournalVM = new GroupJournalViewModel();
			GroupVM = new GroupViewModel();
			//create
			CreateLoadVM = new CreateLoadViewModel();

			CurrentView = FullTimetableVM;

			FullTimetableViewCommand = new RelayCommand(o => { CurrentView = FullTimetableVM; });
			TodayTimetableViewCommand = new RelayCommand(o => { CurrentView = TodayTimetableVM; });
			JournalViewCommand = new RelayCommand(o => { CurrentView = JournalVM; });
			LoadViewCommand = new RelayCommand(o => { CurrentView = LoadVM; });
			TeacherListViewCommand = new RelayCommand(o => { CurrentView = TeacherListVM; });
			GroupJournalViewCommand = new RelayCommand(o => { CurrentView = GroupJournalVM; });
			GroupViewCommand = new RelayCommand(o => { CurrentView = GroupVM; });
		}

	}
}
