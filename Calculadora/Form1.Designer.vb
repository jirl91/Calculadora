<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New TextBox()
        siete = New Button()
        ocho = New Button()
        nueve = New Button()
        diviSion = New Button()
        cuatro = New Button()
        cinco = New Button()
        seis = New Button()
        multiplicar = New Button()
        uno = New Button()
        dos = New Button()
        tres = New Button()
        resta = New Button()
        cero = New Button()
        igual = New Button()
        suma = New Button()
        borrar = New Button()
        L = New Label()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(93, 136)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(271, 23)
        txtDisplay.TabIndex = 0
        ' 
        ' siete
        ' 
        siete.Location = New Point(93, 225)
        siete.Name = "siete"
        siete.Size = New Size(60, 40)
        siete.TabIndex = 1
        siete.Text = "7"
        siete.UseVisualStyleBackColor = True
        ' 
        ' ocho
        ' 
        ocho.Location = New Point(159, 225)
        ocho.Name = "ocho"
        ocho.Size = New Size(60, 40)
        ocho.TabIndex = 2
        ocho.Text = "8"
        ocho.UseVisualStyleBackColor = True
        ' 
        ' nueve
        ' 
        nueve.Location = New Point(225, 225)
        nueve.Name = "nueve"
        nueve.Size = New Size(60, 40)
        nueve.TabIndex = 3
        nueve.Text = "9"
        nueve.UseVisualStyleBackColor = True
        ' 
        ' diviSion
        ' 
        diviSion.Location = New Point(304, 179)
        diviSion.Name = "diviSion"
        diviSion.Size = New Size(60, 40)
        diviSion.TabIndex = 5
        diviSion.Text = "/"
        diviSion.UseVisualStyleBackColor = True
        ' 
        ' cuatro
        ' 
        cuatro.Location = New Point(93, 271)
        cuatro.Name = "cuatro"
        cuatro.Size = New Size(60, 40)
        cuatro.TabIndex = 6
        cuatro.Text = "4"
        cuatro.UseVisualStyleBackColor = True
        ' 
        ' cinco
        ' 
        cinco.Location = New Point(159, 271)
        cinco.Name = "cinco"
        cinco.Size = New Size(60, 40)
        cinco.TabIndex = 7
        cinco.Text = "5"
        cinco.UseVisualStyleBackColor = True
        ' 
        ' seis
        ' 
        seis.Location = New Point(225, 271)
        seis.Name = "seis"
        seis.Size = New Size(60, 40)
        seis.TabIndex = 8
        seis.Text = "6"
        seis.UseVisualStyleBackColor = True
        ' 
        ' multiplicar
        ' 
        multiplicar.Location = New Point(304, 225)
        multiplicar.Name = "multiplicar"
        multiplicar.Size = New Size(60, 40)
        multiplicar.TabIndex = 10
        multiplicar.Text = "*"
        multiplicar.UseVisualStyleBackColor = True
        ' 
        ' uno
        ' 
        uno.Location = New Point(93, 317)
        uno.Name = "uno"
        uno.Size = New Size(60, 40)
        uno.TabIndex = 11
        uno.Text = "1"
        uno.UseVisualStyleBackColor = True
        ' 
        ' dos
        ' 
        dos.Location = New Point(159, 317)
        dos.Name = "dos"
        dos.Size = New Size(60, 40)
        dos.TabIndex = 12
        dos.Text = "2"
        dos.UseVisualStyleBackColor = True
        ' 
        ' tres
        ' 
        tres.Location = New Point(225, 317)
        tres.Name = "tres"
        tres.Size = New Size(60, 40)
        tres.TabIndex = 13
        tres.Text = "3"
        tres.UseVisualStyleBackColor = True
        ' 
        ' resta
        ' 
        resta.Location = New Point(304, 271)
        resta.Name = "resta"
        resta.Size = New Size(60, 40)
        resta.TabIndex = 15
        resta.Text = "-"
        resta.UseVisualStyleBackColor = True
        ' 
        ' cero
        ' 
        cero.Location = New Point(93, 363)
        cero.Name = "cero"
        cero.Size = New Size(126, 40)
        cero.TabIndex = 17
        cero.Text = "0"
        cero.UseVisualStyleBackColor = True
        ' 
        ' igual
        ' 
        igual.Location = New Point(225, 363)
        igual.Name = "igual"
        igual.Size = New Size(139, 40)
        igual.TabIndex = 18
        igual.Text = "="
        igual.UseVisualStyleBackColor = True
        ' 
        ' suma
        ' 
        suma.Location = New Point(304, 317)
        suma.Name = "suma"
        suma.Size = New Size(60, 40)
        suma.TabIndex = 19
        suma.Text = "+"
        suma.UseVisualStyleBackColor = True
        ' 
        ' borrar
        ' 
        borrar.Location = New Point(93, 179)
        borrar.Name = "borrar"
        borrar.Size = New Size(192, 40)
        borrar.TabIndex = 20
        borrar.Text = "Borrar"
        borrar.UseVisualStyleBackColor = True
        ' 
        ' L
        ' 
        L.Image = My.Resources.Resources.descarga__1_
        L.Location = New Point(93, 9)
        L.MaximumSize = New Size(100, 100)
        L.MinimumSize = New Size(271, 100)
        L.Name = "L"
        L.Size = New Size(271, 100)
        L.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(447, 461)
        Controls.Add(L)
        Controls.Add(borrar)
        Controls.Add(suma)
        Controls.Add(igual)
        Controls.Add(cero)
        Controls.Add(resta)
        Controls.Add(tres)
        Controls.Add(dos)
        Controls.Add(uno)
        Controls.Add(multiplicar)
        Controls.Add(seis)
        Controls.Add(cinco)
        Controls.Add(cuatro)
        Controls.Add(diviSion)
        Controls.Add(nueve)
        Controls.Add(ocho)
        Controls.Add(siete)
        Controls.Add(txtDisplay)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EVA1_JASNA_RAMIREZ"
        WindowState = FormWindowState.Minimized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents siete As Button
    Friend WithEvents ocho As Button
    Friend WithEvents nueve As Button
    Friend WithEvents diviSion As Button
    Friend WithEvents cuatro As Button
    Friend WithEvents cinco As Button
    Friend WithEvents seis As Button
    Friend WithEvents multiplicar As Button
    Friend WithEvents uno As Button
    Friend WithEvents dos As Button
    Friend WithEvents tres As Button
    Friend WithEvents resta As Button
    Friend WithEvents cero As Button
    Friend WithEvents igual As Button
    Friend WithEvents suma As Button
    Friend WithEvents borrar As Button
    Friend WithEvents L As Label

End Class
