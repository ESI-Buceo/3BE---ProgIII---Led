Imports System.Data.Odbc

Public MustInherit Class ModeloBaseDeDatos
    Public Driver As String = "Mysql ODBC 8.0 Unicode Driver"
    Public Uid As String
    Public Pwd As String
    Public Port As String = "3306"
    Public DatabaseName As String = "led"
    'El Host debe tener el mismo valor que la salida al comando hostname -I del la VM o servidor
    Public Host As String = "192.168.5.50"

    Public Connect As New OdbcConnection()
    Public Command As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(usuario As String, contra As String)
        Uid = usuario
        Pwd = contra
        Me.Connect.ConnectionString =
        "DRIVER=" + Me.Driver +
        ";UID=" + Me.Uid +
        ";PWD=" + Me.Pwd +
        ";PORT=" + Me.Port +
        ";DATABASE=" + Me.DatabaseName +
        ";SERVER=" + Me.Host

        Me.Connect.Open()
        Me.Command.Connection = Me.Connect
    End Sub

End Class
