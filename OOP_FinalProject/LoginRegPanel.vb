Public Class LoginRegPanel
    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        StudentMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Reg_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Reg_showpass.CheckedChanged
        If Reg_password.UseSystemPasswordChar = True Then
            Reg_password.UseSystemPasswordChar = False
        Else
            Reg_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Reg_suffix_TextChanged(sender As Object, e As EventArgs) Handles Reg_suffix.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_suffix.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub LoginRegPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Reg_firstname_TextChanged(sender As Object, e As EventArgs) Handles Reg_firstname.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_firstname.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_lastname_TextChanged(sender As Object, e As EventArgs) Handles Reg_lastname.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_lastname.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_middlename_TextChanged(sender As Object, e As EventArgs) Handles Reg_middlename.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_middlename.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_email_TextChanged(sender As Object, e As EventArgs) Handles Reg_email.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_email.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_pnum_TextChanged(sender As Object, e As EventArgs) Handles Reg_pnum.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_pnum.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint
        If Not String.IsNullOrWhiteSpace(Guna2Panel3.BorderStyle) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint
        If Not String.IsNullOrWhiteSpace(Guna2Panel2.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_city_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Reg_city.SelectedIndexChanged
        If Not String.IsNullOrWhiteSpace(Reg_city.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
            Reg_barangay.Items.Clear()

            Select Case Reg_city.SelectedItem.ToString()

                Case "Pasig"
                    Reg_barangay.Items.AddRange(New String() {"Bagong Ilog", "Bagong Katipunan", "Bambang", "Buting", "Caniogan", "Dela Paz", "Kalawaan", "Kapasigan",
                                            "Kapitolyo", "Malinao", "Manggahan", "Maybunga", "Oranbo", "Palatiw", "Pinagbuhatan", "Pineda", "Rosario", "Sagad",
                                            "San Antonio", "San Joaquin", "San Jose", "San Miguel", "San Nicolas (Poblacion)", "Santa Cruz", "Santa Lucia",
                                            "Santa Rosa", "Santo Tomas", "Santolan", "Sumilang", "Ugong"})

                Case "Pateros"
                    Reg_barangay.Items.AddRange(New String() {"Aguho", "Magtanggol", "Martires del 96", "Poblacion", "San Pedro"})

            End Select
            Reg_barangay.SelectedIndex = -1

        End If
    End Sub

    Private Sub Reg_barangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Reg_barangay.SelectedIndexChanged
        If Not String.IsNullOrWhiteSpace(Reg_barangay.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub reg_VAE_TextChanged(sender As Object, e As EventArgs) Handles reg_VAE.TextChanged
        If Not String.IsNullOrWhiteSpace(reg_VAE.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_UHN_TextChanged(sender As Object, e As EventArgs) Handles Reg_UHN.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_UHN.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_username_TextChanged(sender As Object, e As EventArgs) Handles Reg_username.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_username.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_password_TextChanged(sender As Object, e As EventArgs) Handles Reg_password.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_password.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub Reg_cpassword_TextChanged(sender As Object, e As EventArgs) Handles Reg_cpassword.TextChanged
        If Not String.IsNullOrWhiteSpace(Reg_cpassword.Text) Then
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)

        End If
    End Sub

    Private Sub Reg_CreateAccount_Click(sender As Object, e As EventArgs) Handles Reg_CreateAccount.Click
        If String.IsNullOrWhiteSpace(Reg_firstname.Text) Then
            Reg_firstname.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_lastname.Text) Then
            Reg_lastname.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_middlename.Text) Then
            Reg_middlename.BorderColor = Color.Firebrick
        Else
            Reg_middlename.BorderColor = Color.FromArgb(125, 137, 149)

        End If

        If String.IsNullOrWhiteSpace(Reg_email.Text) Then
            Reg_email.BorderColor = Color.Firebrick
        Else
            Reg_email.BorderColor = Color.FromArgb(125, 137, 149)

        End If

        If String.IsNullOrWhiteSpace(Reg_pnum.Text) Then
            Reg_pnum.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(reg_VAE.Text) Then
            reg_VAE.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_username.Text) Then
            Reg_username.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_password.Text) Then
            Reg_password.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_cpassword.Text) Then
            Reg_cpassword.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_UHN.Text) Then
            Reg_UHN.BorderColor = Color.Firebrick
        End If

        If Reg_city.SelectedIndex = -1 Then
            Reg_city.BorderColor = Color.Firebrick
        End If

        If Reg_barangay.SelectedIndex = -1 Then
            Reg_barangay.BorderColor = Color.Firebrick
        End If

        If String.IsNullOrWhiteSpace(Reg_firstname.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_lastname.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_middlename.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_email.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_pnum.Text) OrElse
           String.IsNullOrWhiteSpace(reg_VAE.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_username.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_password.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_cpassword.Text) OrElse
           String.IsNullOrWhiteSpace(Reg_UHN.Text) OrElse
            Reg_city.SelectedIndex = -1 OrElse
            Reg_barangay.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all the required information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
        Return
    End Sub

    Private Sub Login_email_TextChanged(sender As Object, e As EventArgs) Handles Login_email.TextChanged
        If String.IsNullOrWhiteSpace(Login_email.Text) Then
            Logintxt_invalidemail.Show()
        Else
            Logintxt_invalidemail.Hide()
        End If
    End Sub


    Private Sub Logintxt_invalidemail_Click(sender As Object, e As EventArgs) Handles Logintxt_invalidemail.Click

    End Sub
End Class