Public Class Form1
    Dim test_global As Boolean = True
    Dim egal_apres As Boolean = False
    Dim one As Integer
    Dim two As Integer
    Dim op_global As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        egale(lbl_operateur.Text)
        lbl_operateur.Text = ""
        test_global = True
        egal_apres = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "0"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "0"
        End If
    End Sub
    Sub kliin()
        If (egal_apres = True) Then
            calcule.Text = ""
            lbl_nombre_recu.Text = ""
            lbl_operateur.Text = ""
            egal_apres = False
        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "1"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "1"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "2"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "2"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "3"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "3"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "4"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "4"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "5"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "5"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "6"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "6"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "7"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "7"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "8"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "8"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        kliin()
        calcule.Text = ""
        If (test_global = True) Then
            lbl_taper.Text = "9"
            test_global! = False
        Else
            lbl_taper.Text = lbl_taper.Text + "9"
        End If
    End Sub
    Sub plus(operateur As String)
        Dim nombre2 = CInt(lbl_taper.Text)
        Dim nombre1 = CInt(lbl_nombre_recu.Text)
        If (operateur = "+") Then
            lbl_nombre_recu.Text = nombre1 + nombre2
        ElseIf (operateur = "-") Then
            lbl_nombre_recu.Text = nombre1 - nombre2
        ElseIf (operateur = "x") Then
            lbl_nombre_recu.Text = nombre1 * nombre2
        ElseIf (operateur = "/") Then
            lbl_nombre_recu.Text = nombre1 / nombre2
        End If

    End Sub
    Sub egale(operators As String)

        If (lbl_nombre_recu.Text = "") Then
            If (op_global = "+") Then
                lbl_taper.Text = one + two
                one = lbl_taper.Text
                calcule.Text = $"{one} {op_global} {two} ="
            ElseIf (op_global = "-") Then
                lbl_taper.Text = one - two
                one = lbl_taper.Text
                calcule.Text = $"{one} {op_global} {two} ="
            ElseIf (op_global = "x") Then
                lbl_taper.Text = one * two
                one = lbl_taper.Text
                calcule.Text = $"{one} {op_global} {two} ="
            ElseIf (op_global = "/") Then
                lbl_taper.Text = one / two
                one = lbl_taper.Text
                calcule.Text = $"{one} {op_global} {two} ="
            End If

        Else

                Dim nombre2 = CInt(lbl_taper.Text)
            Dim nombre1 = CInt(lbl_nombre_recu.Text)
            If (operators = "+") Then
                lbl_taper.Text = nombre1 + nombre2
                calcule.Text = $"{nombre1} {operators} {nombre2} ="
                one = nombre1
                two = nombre2
                op_global = operators
            ElseIf (operators = "-") Then
                lbl_taper.Text = nombre1 - nombre2
                calcule.Text = $"{nombre1} {operators} {nombre2} ="
                one = nombre1
                two = nombre2
                op_global = operators
            ElseIf (operators = "x") Then
                lbl_taper.Text = nombre1 * nombre2
                calcule.Text = $"{nombre1} {operators} {nombre2} ="
                one = nombre1
                two = nombre2
                op_global = operators
            ElseIf (operators = "/") Then
                lbl_taper.Text = nombre1 / nombre2
                calcule.Text = $"{nombre1} {operators} {nombre2} ="
                one = nombre1
                two = nombre2
                op_global = operators

            End If
            lbl_nombre_recu.Text = ""
        End If


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        calcule.Text = ""
        If (lbl_operateur.Text = "+") Then
            lbl_operateur.Text = "+"
        Else
            If (lbl_nombre_recu.Text = "") Then
                lbl_nombre_recu.Text = lbl_taper.Text
                lbl_operateur.Text = "+"
            Else
                plus(lbl_operateur.Text)
            End If
            lbl_operateur.Text = "+"
            test_global = True
        End If
        egal_apres = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        calcule.Text = ""
        If (lbl_operateur.Text = "-") Then
            lbl_operateur.Text = "-"
        Else

            If (lbl_nombre_recu.Text = "") Then
                lbl_nombre_recu.Text = lbl_taper.Text
                lbl_operateur.Text = "-"
            Else
                plus(lbl_operateur.Text)
            End If
            lbl_operateur.Text = "-"
            test_global = True
        End If
        egal_apres = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        calcule.Text = ""
        If (lbl_operateur.Text = "x") Then
            lbl_operateur.Text = "x"
        Else

            If (lbl_nombre_recu.Text = "") Then
                lbl_nombre_recu.Text = lbl_taper.Text
                lbl_operateur.Text = "x"
            Else
                plus(lbl_operateur.Text)
            End If
            lbl_operateur.Text = "x"
            test_global = True
        End If
        egal_apres = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        calcule.Text = ""
        If (lbl_operateur.Text = "/") Then
            lbl_operateur.Text = "/"
        Else

            If (lbl_nombre_recu.Text = "") Then
                lbl_nombre_recu.Text = lbl_taper.Text
                lbl_operateur.Text = "/"
            Else
                plus(lbl_operateur.Text)
            End If
            lbl_operateur.Text = "/"
            test_global = True
        End If
        egal_apres = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        lbl_taper.Text = "0"
        lbl_nombre_recu.Text = ""
        lbl_operateur.Text = ""
        calcule.Text = ""
        test_global = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim longueur As Integer
        longueur = Len(lbl_taper.Text)
        If (longueur > 0) Then
            If (longueur > 1) Then
                Dim chaine As String = lbl_taper.Text
                chaine = chaine.Remove(Len(chaine) - 1)
                lbl_taper.Text = chaine
            Else
                test_global = True
                lbl_taper.Text = 0
            End If
        End If
    End Sub
End Class
