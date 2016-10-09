using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataContextOfHiddenTabs
{
    class PlanetControlSpy : INotifyPropertyChanged
    {
        private IDictionary<int, string> _controlList = new Dictionary<int, string>();

        private class LazyInit
        {
            public static PlanetControlSpy Instance = new PlanetControlSpy();
        }

        public static PlanetControlSpy Instance
        {
            get { return LazyInit.Instance; }
        }

        public void RegisterControl(int id, string s)
        {
            _controlList[id] = s;

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ControlList"));
            }
        }

        public IEnumerable<KeyValuePair<int, string>> ControlList
        {
            get 
            {
                return _controlList.OrderBy(pair => pair.Key);
            }
        }

        public event PropertyChangedEventHandler  PropertyChanged;
    }
}
