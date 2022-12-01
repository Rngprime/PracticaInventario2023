Imports System.Data.SqlClient
Imports Microsoft.SqlServer


Public Class Conexcion


    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=LQUINTEROS;Initial Catalog=BasePractica;Integrated Security=True")

    End Sub



End Class
