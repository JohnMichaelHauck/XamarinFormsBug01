using System.Collections.ObjectModel;

namespace XamarinFormsBug01.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<EntryViewModel> Entries { get; private set; }

        private double _desiredCount;
        public double DesiredCount
        {
            get { return _desiredCount; }
            set
            {
                _desiredCount = value;
                OnPropertyChanged();
                GenerateEntries();
            }
        }

        private bool _twoOrFive;
        public bool TwoOrFive
        {
            get { return _twoOrFive; }
            set
            {
                _twoOrFive = value;
                OnPropertyChanged();
                DesiredCount = _twoOrFive ? 5 : 2;
            }
        }

        public MainViewModel()
        {
            Entries = new ObservableCollection<EntryViewModel>();
            TwoOrFive = false; // prime
        }

        private void GenerateEntries()
        {
            Entries.Clear();
            for (var i = 0; i < DesiredCount; i++)
            {
                Entries.Add(new EntryViewModel { Name = "Entry " + i + " of " + DesiredCount });
            }
        }
    }
}