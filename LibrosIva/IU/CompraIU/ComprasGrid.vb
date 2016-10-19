Public Class ComprasGrid

    Private Sub ComprasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = lstCompras

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        CompraForm.operacion = "Alta"

        CompraForm.Text = "Agregar compra"
        CompraForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lstCompras.Count = 0 Then Exit Sub


        CompraForm.operacion = "Elimina"


        llenarCompraForm()

        CompraForm.Text = "Eliminar compra"

        CompraForm.Show()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click

        If lstCompras.Count = 0 Then Exit Sub

        CompraForm.operacion = "Modifica"

        llenarCompraForm()

        CompraForm.Text = "Modificar compra"

        CompraForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        Me.Close()

    End Sub

    Private Sub llenarCompraForm()

        CompraForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        CompraForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        CompraForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        CompraForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value
        CompraForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
        CompraForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        CompraForm.TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value
        CompraForm.TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value
        CompraForm.TextBox8.Text = DataGridView1.CurrentRow.Cells(8).Value
        CompraForm.TextBox9.Text = DataGridView1.CurrentRow.Cells(9).Value
        CompraForm.TextBox10.Text = DataGridView1.CurrentRow.Cells(10).Value

    End Sub
End Class