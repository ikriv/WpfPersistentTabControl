using System.Diagnostics;
using System.Windows.Controls;

namespace PersistentTabControl
{
    /// <summary>
    /// Interaction logic for ColorView.xaml
    /// </summary>
    public partial class ColorView : UserControl
    {
        public ColorView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            var info = DataContext as ColorInfo;
            if (info == null) return;
            IdText.Text = info.Key;
            DataContextChanged -= OnDataContextChanged; // load text only once
        }
    }
}
