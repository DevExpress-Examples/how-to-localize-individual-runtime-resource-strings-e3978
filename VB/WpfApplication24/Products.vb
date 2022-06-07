Imports System.Collections.ObjectModel

Public Class Product

    Public Property ProductName As String

    Public Property Country As String

    Public Property City As String

    Public Property UnitPrice As Double

    Public Property Quantity As Integer
End Class

Public Class ProductList

    Public Shared Function GetProducts() As ObservableCollection(Of Product)
        Dim products As ObservableCollection(Of Product) = New ObservableCollection(Of Product)()
        products.Add(New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10})
        products.Add(New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16})
        products.Add(New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12})
        products.Add(New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "QUICK-Stop", .UnitPrice = 22, .Quantity = 50})
        products.Add(New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Reggio Emilia", .UnitPrice = 18, .Quantity = 20})
        products.Add(New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52})
        products.Add(New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120})
        products.Add(New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15})
        products.Add(New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16})
        Return products
    End Function
End Class
