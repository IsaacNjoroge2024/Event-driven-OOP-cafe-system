Imports System.Data.OleDb
Public Class Form2
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    'Dim con As New OleDbConnection
    'Dim cmd As OleDbCommand
    'Dim dt As New DataTable
    'Dim da As New OleDbDataAdapter(cmd)

    'Private bitmap As Bitmap
    Private Sub Customer_informationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_informationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Food_AppDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_AppDataSet.Customer_information' table. You can move, or remove it, as needed.
        Me.Customer_informationTableAdapter.Fill(Me.Food_AppDataSet.Customer_information)
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Event programming\Njoro's cafe\Food App.accdb"
        'Call connection()
        lbldate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GenderLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneNumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LastNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FirstNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Food App.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = " insert into Customer_information ( [FirstName] , [LastName] , [Gender] , [PhoneNumber] , [Email] , [Address] , [Username] , [Password] ) values ('" & txtfirstname.Text & "','" & txtlastname.Text & "','" & txtgender.Text & "','" & txtphonenumber.Text & "','" & txtemail.Text & "','" & txtaddress.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtfirstname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtlastname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(txtgender.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PhoneNumber", CType(txtphonenumber.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(txtemail.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtaddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtusername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtpassword.Text, String)))
        MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            txtfirstname.Clear()
            txtlastname.Clear()
            txtgender.Clear()
            txtphonenumber.Clear()
            txtemail.Clear()
            txtaddress.Clear()
            txtusername.Clear()
            txtpassword.Clear()

        Catch ex As Exception

            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


        Me.Hide()
        fmmenu.Show()

        'Try
        'cm = New OleDb.OleDbCommand
        'With cm
        '.Connection = cn
        '.CommandType = CommandType.Text
        '.CommandText = "INSERT INTO Food App(FirstName,LastName,Gender,PhoneNumber,Email,Address,Username,Password) VALUES 
        '(@FirstName,@LastName,@Gender,@PhoneNumber,@Email,@Address,@Username,@Password)"
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@FirstName", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtfirstname.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@LastName", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtlastname.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@Gender", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtgender.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@PhoneNumber", System.Data.OleDb.OleDbType.Integer, 15, Me.txtphonenumber.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@Email", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtemail.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@Address", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtaddress.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@Username", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtusername.Text))
        '.Parameters.Add(New System.Data.OleDb.OleDbParameter("@Password", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtpassword.Text))


        'cm.Parameters("@FirstName").Value = Me.txtfirstname.Text
        'cm.Parameters("@LastName").Value = Me.txtlastname.Text
        'cm.Parameters("@Gender").Value = Me.txtgender.Text
        'cm.Parameters("@PhoneNumber").Value = Me.txtphonenumber.Text
        'cm.Parameters("@Email").Value = Me.txtemail.Text
        'cm.Parameters("@Address").Value = Me.txtaddress.Text
        'cm.Parameters("@Username").Value = Me.txtusername.Text
        'cm.Parameters("@Password").Value = Me.txtpassword.Text

        'cm.ExecuteNonQuery()
        'MsgBox("Record Saved Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.txtfirstname.Text = ""
        'Me.txtlastname.Text = ""
        'Me.txtgender.Text = ""
        'Me.txtphonenumber.Text = ""
        'Me.txtemail.Text = ""
        'Me.txtaddress.Text = ""
        'Me.txtusername.Text = ""
        'Me.txtpassword.Text = ""
        'Exit Sub
        'End With
        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try



        'Try
        'con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "insert into Food App(FirstName,LastName,Gender,PhoneNumber,Email,Address,Username,Password)values('" +
        'txtfirstname.Text + "','" + txtlastname.Text + "','" + txtgender.Text + "','" + txtphonenumber.Text +
        '"','" + txtemail.Text + "','" + txtaddress.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')"
        'cmd.ExecuteNonQuery()
        'con.Close()
        'MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        'MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub cmbgender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class