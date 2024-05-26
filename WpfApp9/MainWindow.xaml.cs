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

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            redSlider.ValueChanged += (s, e) => UpdateColor();
            greenSlider.ValueChanged += (s, e) => UpdateColor();
            blueSlider.ValueChanged += (s, e) => UpdateColor();
        }

        private void UpdateColor()
        {
            var color = Color.FromRgb((byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);
            colorBrush.Color = color;
        }
    }
}
