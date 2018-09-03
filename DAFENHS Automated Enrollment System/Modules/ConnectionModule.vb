Module ConnectionModule
    Public Function MyConnection() As String
        MyConnection = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DAFENHS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    End Function
End Module
