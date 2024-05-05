Imports System.Data.Common
Imports System.Data.OleDb

Public Class LoginForm1

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim attempts As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (txtpassword.Text = "class" And txtusername.Text = "coding") Then
            MDIParent1.Show()
            Me.Hide()
        ElseIf (txtpassword.Text IsNot "class" And txtusername.Text IsNot "coding") Then
            txtpassword.Text = ""
            txtusername.Clear()
            txtusername.Focus()
            attempts += 1
            If attempts = 3 Then
                Application.Exit()
            End If
        End If
        'Me.Close()

        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Food App.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = " insert into Customer_information ( [Username] , [Password] ) values ('" & txtusername.Text & "','" & txtpassword.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtusername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtpassword.Text, String)))
        'MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            txtusername.Clear()
            txtpassword.Clear()

        Catch ex As Exception

            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub LoginForm1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each Ctrl As Control In Controls
            Ctrl.Width += Ctrl.Width * RatioWidth
            Ctrl.Left += Ctrl.Left * RatioWidth
            Ctrl.Top += Ctrl.Top * RatioHeight
            Ctrl.Height += Ctrl.Height * RatioHeight
        Next

        CuRHeight = Me.Height
        CuRWidth = Me.Width

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class
