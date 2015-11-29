Public Class Pruebas
    'NUMERO MAXIMO DE MUESTRAS = 1375
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Abecedario(25) As String
        Dim Letra As Integer = 65
        lboxListas.Items.Clear()

        For i = 0 To 25
            Abecedario(i) = Chr(Letra)
            Letra = Letra + 1
        Next

        Dim Imprimir(txtMuestras.Text) As String
        Dim abc As Integer = 0 'Flujo del abecedario
        Dim aux1 As Integer = 0 'Optiene la letra que le antepone al flujo del abecedario despues que la cantidad de muestras sea mayor 26
        Dim aux2 As Integer = 0
        Dim resive As String 'Resive el 'aux1' seguido de la letra de flujo del abecedario

        For i = 0 To CInt(txtMuestras.Text) - 1
            If abc = 26 Then
                aux1 = aux1 + 1
                If i = 702 Then
                    aux1 = 1
                End If
                abc = 0
            End If
            If i <= 25 Then
                Imprimir(i) = Abecedario(abc)
                lboxListas.Items.Add(Imprimir(i))
                abc = abc + 1
            ElseIf i >= 26 And i <= 701 Then
                resive = Abecedario(aux1 - 1)
                Imprimir(i) = resive + Abecedario(abc)
                lboxListas.Items.Add(Imprimir(i))
                abc = abc + 1
            ElseIf i >= 702 Then
                resive = Abecedario(aux1 - 1)
                Imprimir(i) = resive + resive + Abecedario(abc)
                lboxListas.Items.Add(Imprimir(i))
                abc = abc + 1
            End If
        Next

        '---------------ahora para listbox1
        Dim rand As New Random(DateTime.Now.Millisecond)

        Dim letra2 As Char = Convert.ToChar(rand.Next(97, 122))
        letra2 = UCase(letra2)

        ListBox1.Items.Add(letra2)
    End Sub

End Class