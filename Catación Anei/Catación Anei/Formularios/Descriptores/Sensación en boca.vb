Public Class frmDescriptores_SensaciónBoca

    Private Sub frmDescriptores_SensaciónBoca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DespuesDelFocus_txtAgregarDescriptor()
        AntesDelFocus_txtAgregarDescriptor()
    End Sub

    'Evento: Al iniciar el formulario los campos tiene el efecto Placeholder
    '-------------------------------------------------------------------------------------------------------------
    Sub DespuesDelFocus_txtAgregarDescriptor()
        If txtAgregarDescriptor.Text = "Agregar Descriptor" Then
            txtAgregarDescriptor.ForeColor = Color.DimGray
            txtAgregarDescriptor.Clear()
        End If
    End Sub

    Private Sub txtAgregarDescriptor_GotFocus(sender As Object, e As EventArgs) Handles txtAgregarDescriptor.GotFocus
        DespuesDelFocus_txtAgregarDescriptor()
    End Sub

    Sub AntesDelFocus_txtAgregarDescriptor()
        If txtAgregarDescriptor.Text = Nothing Then
            txtAgregarDescriptor.ForeColor = Color.Silver
            txtAgregarDescriptor.Text = "Agregar Descriptor"
        End If
    End Sub

    Private Sub txtAgregarDescriptor_LostFocus(sender As Object, e As EventArgs) Handles txtAgregarDescriptor.LostFocus
        AntesDelFocus_txtAgregarDescriptor()
    End Sub
    '-------------------------------------------------------------------------------------------------------------
End Class