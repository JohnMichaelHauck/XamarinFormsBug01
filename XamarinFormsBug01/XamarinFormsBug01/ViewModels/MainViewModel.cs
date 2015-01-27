using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinFormsBug01.ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		private ObservableCollection<EntryViewModel> _entries;
		public ObservableCollection<EntryViewModel> Entries
		{
			get { return _entries; }
			private set { _entries = value; OnPropertyChanged(); }
		}

		private bool _newOc;
		public bool NewOc
		{
			get { return _newOc; }
			set
			{
				_newOc = value;
				OnPropertyChanged();
				Entries = new ObservableCollection<EntryViewModel>();
				Entries.Add(new EntryViewModel { Name = "Just created a new ObservableCollection" });
			}
		}

		private bool _ocClear;
		public bool OcClear
		{
			get { return _ocClear; }
			set
			{
				_ocClear = value;
				OnPropertyChanged();
				Entries.Clear();
				Entries.Add(new EntryViewModel { Name = "Just cleared the ObservableCollection" });
			}
		}

		public MainViewModel()
		{
			Entries = new ObservableCollection<EntryViewModel>();
		}
	}
}