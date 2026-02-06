Imports System.Windows

Namespace WpfApplication24

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.ItemsSource = New ProductList()
            Me.gridControl1.View.ShowColumnChooser()
        End Sub
    End Class
End Namespace
