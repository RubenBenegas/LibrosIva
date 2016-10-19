Public Class ContribuyentesGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        ContribuyenteForm.operacion = "Alta"

        ContribuyenteForm.Text = "Agregar contribuyente"

        ContribuyenteForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lst.Count = 0 Then Exit Sub


        ContribuyenteForm.operacion = "Elimina"


        LlenarPersonaForm()

        ContribuyenteForm.Text = "Eliminar contribuyente"

        ContribuyenteForm.Show()

    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click

        If lst.Count = 0 Then Exit Sub


        ContribuyenteForm.operacion = "Modifica"


        LlenarPersonaForm()

        ContribuyenteForm.Text = "Modificar contribuyente"

        ContribuyenteForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        Me.Close()

    End Sub


    Private Sub ContribuyentesGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = lst

    End Sub

    Private Sub llenarPersonaForm()

        ContribuyenteForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ContribuyenteForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        ContribuyenteForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        ContribuyenteForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ContribuyenteForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
        ContribuyenteForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        ContribuyenteForm.TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value
        ContribuyenteForm.TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value
        ContribuyenteForm.TextBox8.Text = DataGridView1.CurrentRow.Cells(8).Value
        ContribuyenteForm.TextBox9.Text = DataGridView1.CurrentRow.Cells(9).Value
        ContribuyenteForm.ComboBox2.SelectedIndex = DataGridView1.CurrentRow.Cells(10).Value
        ContribuyenteForm.TextBox10.Text = DataGridView1.CurrentRow.Cells(11).Value
        ContribuyenteForm.TextBox11.Text = DataGridView1.CurrentRow.Cells(12).Value
        ContribuyenteForm.TextBox12.Text = DataGridView1.CurrentRow.Cells(13).Value
        ContribuyenteForm.TextBox13.Text = DataGridView1.CurrentRow.Cells(14).Value



    End Sub
End Class