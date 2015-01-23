namespace XamarinFormsBug01.ViewModels
{
    public class EntryViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; OnPropertyChanged(); }
        }
    }
}