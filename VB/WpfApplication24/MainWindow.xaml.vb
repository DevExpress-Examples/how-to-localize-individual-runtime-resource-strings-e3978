Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace WpfApplication24

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = ProductList.GetProducts()
        End Sub

        Private Sub LocalizeGroupPanelText()
            Dim NewText = Me.textBox.Text
            Dim localization = New GridRuntimeStringCollection()
            localization.Add(New RuntimeStringIdInfo(GridControlRuntimeStringId.GridGroupPanelText, NewText))
            Me.view.RuntimeLocalizationStrings = localization
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            LocalizeGroupPanelText()
        End Sub

        Private Sub textBox_KeyDown(ByVal sender As Object, ByVal e As Input.KeyEventArgs)
            If e.Key = Input.Key.Enter Then
                LocalizeGroupPanelText()
            End If
        End Sub
    End Class
End Namespace
