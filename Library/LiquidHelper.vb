Public Class LiquidHelper
    Inherits DotLiquid.Drop
    Private _dataRow As DataRow
    Public Sub New(ByVal dataRow As DataRow)
        Me._dataRow = dataRow

    End Sub
    Public Overrides Function BeforeMethod(ByVal method As String)
        If _dataRow.Table.Columns.Contains(method) Then
            Return _dataRow(method)
        Else
            Return Nothing
        End If
    End Function
End Class
