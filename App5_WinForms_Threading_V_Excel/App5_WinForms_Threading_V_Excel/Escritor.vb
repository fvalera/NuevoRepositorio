Public Class Escritor
    Public Shared Sub NuevoExcelFijo(nombreFich As String)

        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object

        oExcel = CreateObject("Excel.Application")

        oLibro = oExcel.Workbooks.Add

        oHoja = oLibro.Worksheets(1)

        oHoja.Range("A1").Value = "Nombre"
        oHoja.Range("B1").Value = "Apellidos"
        oHoja.Range("A1:B1").Font.Bold = True

        oHoja.Range("A2").Value = "Fernando"
        oHoja.Range("B2").Value = "Valera Guardiola"

        oLibro.SaveAs(nombreFich)

        oExcel.Quit()

    End Sub

End Class
