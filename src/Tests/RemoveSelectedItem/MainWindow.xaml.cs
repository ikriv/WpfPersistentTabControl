using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace RemoveSelectedItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> _stuff;

        public MainWindow()
        {
            InitializeComponent();
            _stuff = new ObservableCollection<string>(new[] { "Brown", "Fox", "Jumps", "Over", "A", "Lazy", "Dog" });
            Tabby.ItemsSource = _stuff;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = Tabby.SelectedIndex;
            if (selected < 0) return;
            _stuff.RemoveAt(selected);
        }
    }
}
