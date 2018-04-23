Imports Microsoft.VisualBasic
Imports System.Windows

Namespace WpfApplication24
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			gridControl1.ItemsSource = New ProductList()
			gridControl1.View.ShowColumnChooser()
		End Sub
	End Class
End Namespace
