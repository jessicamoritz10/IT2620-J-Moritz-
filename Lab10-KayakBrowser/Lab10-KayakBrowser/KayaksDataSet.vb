Partial Class KayaksDataSet
    Partial Public Class KayakTypesDataTable
        Private Sub KayakTypesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DescriptionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
