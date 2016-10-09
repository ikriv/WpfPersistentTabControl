using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PersistentTabControl
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ColorInfo _selectedColor;

        public ColorInfo SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                _selectedColor = value;

                if (!_items.Contains(value))
                {
                    _items.Add(value);
                }

                PropertyChanged(this, new PropertyChangedEventArgs("SelectedColor"));
            }
        }

        private ObservableCollection<ColorInfo> _items = new ObservableCollection<ColorInfo>();
        public IEnumerable<ColorInfo> Items { get { return _items; } }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
