Public Class Form1


    ' Variables para almacenar los números y la operación seleccionada
    Private primerNumero As Double
    Private segundoNumero As Double
    Private operador As String
    Private resultado As Double

    ' Configurar el TextBox como solo lectura en la inicialización del formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.ReadOnly = True ' Establece el TextBox como solo lectura para evitar que el usuario escriba directamente en él
    End Sub

    ' Para mostrar el número en el TextBox cuando se hace clic en un botón numérico
    Private Sub Numero_Click(sender As Object, e As EventArgs) Handles uno.Click, dos.Click, tres.Click, cuatro.Click, cinco.Click, seis.Click, siete.Click, ocho.Click, nueve.Click, cero.Click
        ' Agregar el número al txtDisplay
        txtDisplay.Text &= DirectCast(sender, Button).Text ' Añade el texto del botón clickeado al TextBox
    End Sub

    ' Para manejar la suma
    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        ' Guardar el primer número y el operador
        primerNumero = Convert.ToDouble(txtDisplay.Text) ' Convierte el texto actual del TextBox a un número y lo asigna a primerNumero
        operador = "+" ' Define la operación a realizar
        txtDisplay.Text &= " + " ' Muestra el operador en el TextBox
    End Sub

    ' Para manejar la resta
    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        ' Guardar el primer número y el operador
        primerNumero = Convert.ToDouble(txtDisplay.Text) ' Convierte el texto actual del TextBox a un número y lo asigna a primerNumero
        operador = "-" ' Define la operación a realizar
        txtDisplay.Text &= " - " ' Muestra el operador en el TextBox
    End Sub

    ' Para manejar la multiplicación
    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        ' Guardar el primer número y el operador
        primerNumero = Convert.ToDouble(txtDisplay.Text) ' Convierte el texto actual del TextBox a un número y lo asigna a primerNumero
        operador = "*" ' Define la operación a realizar
        txtDisplay.Text &= " * " ' Muestra el operador en el TextBox
    End Sub

    ' Para manejar la división
    Private Sub Division_Click(sender As Object, e As EventArgs) Handles diviSion.Click
        ' Guardar el primer número y el operador
        primerNumero = Convert.ToDouble(txtDisplay.Text) ' Convierte el texto actual del TextBox a un número y lo asigna a primerNumero
        operador = "/" ' Define la operación a realizar
        txtDisplay.Text &= " / " ' Muestra el operador en el TextBox
    End Sub

    ' Para calcular el resultado cuando se hace clic en el botón "="
    Private Sub Igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        ' Obtener el segundo número
        Dim partes As String() = txtDisplay.Text.Split(New Char() {" "c}) ' Divide el texto del TextBox en partes usando el espacio como separador
        If partes.Length >= 3 Then
            segundoNumero = Convert.ToDouble(partes(2)) ' Convierte la tercera parte del texto a número y la asigna a segundoNumero
        End If

        ' Calcular el resultado
        Select Case operador
            Case "+"
                resultado = primerNumero + segundoNumero ' Realiza la suma
            Case "-"
                resultado = primerNumero - segundoNumero ' Realiza la resta
            Case "*"
                resultado = primerNumero * segundoNumero ' Realiza la multiplicación
            Case "/"
                If segundoNumero = 0 Then
                    ' Manejar la división por cero
                    txtDisplay.Clear() ' Limpia el TextBox
                    txtDisplay.Text = "Ǝ" ' Muestra un mensaje de error
                    Exit Sub ' Sale del método para evitar una división por cero
                Else
                    resultado = primerNumero / segundoNumero ' Realiza la división
                End If
        End Select

        ' Mostrar solo el resultado en el TextBox
        txtDisplay.Clear() ' Limpia el TextBox
        txtDisplay.Text = resultado.ToString() ' Muestra el resultado calculado
    End Sub

    ' Para borrar el contenido del TextBox cuando se hace clic en el botón "Borrar"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles borrar.Click
        txtDisplay.Clear() ' Limpia el TextBox
        primerNumero = 0 ' Reinicia el primer número
        segundoNumero = 0 ' Reinicia el segundo número
        operador = "" ' Reinicia el operador
    End Sub

End Class
