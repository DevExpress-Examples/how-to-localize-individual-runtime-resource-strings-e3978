using System.Windows;

namespace WpfApplication24 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            gridControl1.ItemsSource = new ProductList();
            gridControl1.View.ShowColumnChooser();
        }
    }
}
