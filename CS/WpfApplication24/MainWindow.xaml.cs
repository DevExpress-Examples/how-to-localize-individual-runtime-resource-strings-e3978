﻿using DevExpress.Xpf.Grid;
using System.Windows;

namespace WpfApplication24 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = ProductList.GetProducts();
        }
        void LocalizeGroupPanelText() {
            var NewText = textBox.Text;
            var localization = new GridRuntimeStringCollection();
            localization.Add(new RuntimeStringIdInfo(GridControlRuntimeStringId.GridGroupPanelText, NewText));
            view.RuntimeLocalizationStrings = localization;
        }
        void Button_Click(object sender, RoutedEventArgs e) {
            LocalizeGroupPanelText();
        }

        void textBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            if (e.Key == System.Windows.Input.Key.Enter) {
                LocalizeGroupPanelText();
            }
        }
    }
}
