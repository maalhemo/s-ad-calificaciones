Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Relacionprof_mate

    Dim CONEXION As New MySqlConnection(" DataBase= normal; User Id=root; Password= mario; DataSource=localhost")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Desea salir de la aplicacion", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub Vistacalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Intentar conectar a la DB.
            CONEXION.Open()
            Dim cmd As New MySqlCommand("Select materia.idmateria,nomateria,grado,semestre,profesor.idprofesor,nomprofesor from materia inner join profesor on materia.idprofesor=profesor.idprofesor", CONEXION)
            Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd
            DataGridView1.DataSource = bs
            drd.Close()
            CONEXION.Close()
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox y cerramos la aplicacion.
            MessageBox.Show("No se pudo conectar con la DB.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try

    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGridView1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGridView1)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("Reporte de materias", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de materias registadas a la fecha :" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            datatable.AddCell(DataGridView1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                datatable.AddCell(DataGridView1(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\profesor-materia.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es bueno, mostrar MsgBox.
            MessageBox.Show("documento generado en PDF revise su Escritorio.", "creado", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Materia.Show()
        Me.Hide()
    End Sub
End Class
