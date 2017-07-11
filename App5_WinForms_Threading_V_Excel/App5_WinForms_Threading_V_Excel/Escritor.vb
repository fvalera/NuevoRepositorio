Public Class Escritor
    Public Shared Sub NuevoExcelFijo(nombreFich As String)

        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object

        oExcel = CreateObject("Excel.Application")

        oLibro = oExcel.Workbooks.Add

        oHoja = oLibro.Worksheets(1)

        Dim arrayDatos(99, 2) As String
        Dim r As Integer

        For r = 0 To 99
            arrayDatos(r, 0) = "FACTURA_" & Format(r, "0000")
            arrayDatos(r, 1) = Rnd() * 1000
            arrayDatos(r, 2) = arrayDatos(r, 1) * 0.21
        Next

        oHoja.Range("A1:C1").Value = New String{"ID Factura","Precio","IVA"}

        oHoja.Range("A2").Resize(100, 3).Value() = arrayDatos

        oLibro.SaveAs(nombreFich)

        oExcel.Quit()

    End Sub

    Public Shared Sub NuevoExcelFijo2(nombreFich As String)

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
