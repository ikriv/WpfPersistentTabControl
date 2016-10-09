using System.Windows;
using System.Windows.Controls;

namespace DataContextOfHiddenTabs
{
    /// <summary>
    /// Interaction logic for PlanetControl.xaml
    /// </summary>
    public partial class PlanetControl : UserControl
    {
        int _id;
        static int _count;

        public PlanetControl()
        {
            _id = ++_count;
            InitializeComponent();
        }

        public string PlanetName
        {
            get { return (string)GetValue(PlanetNameProperty); }
            set { SetValue(PlanetNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlanetName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlanetNameProperty =
            DependencyProperty.Register("PlanetName", typeof(string), typeof(PlanetControl), new UIPropertyMetadata(null, OnPlanetNameChanged));


        private static void OnPlanetNameChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            var planetControl = sender as PlanetControl;
            if (planetControl == null) return;

            var str = "(null)";
            if (args.NewValue != null)
            {
                str = args.NewValue.ToString();
            }

            PlanetControlSpy.Instance.RegisterControl(planetControl._id, str);
        }
    }
}
