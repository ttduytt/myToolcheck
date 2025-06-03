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
using System.Windows.Shapes;
using CHECKTOOL.ViewModel;

namespace CHECKTOOL.View
{
    /// <summary>
    /// Interaction logic for Barcode.xaml
    /// </summary>
    public partial class Barcode : Window
    {
        protected readonly BarcodeViewModel barcodeViewModel = new BarcodeViewModel();
        public Barcode()
        {
            InitializeComponent();
            DataContext = barcodeViewModel;
        }
    }
}
