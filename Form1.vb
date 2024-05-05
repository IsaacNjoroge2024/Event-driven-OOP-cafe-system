Imports System.Data.OleDb
Imports System.Windows.Forms.AxHost

Public Class fmmenu
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_AppDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.Food_AppDataSet.Order)
        'TODO: This line of code loads data into the 'Food_AppDataSet.Drinks' table. You can move, or remove it, as needed.
        Me.DrinksTableAdapter.Fill(Me.Food_AppDataSet.Drinks)
        'TODO: This line of code loads data into the 'Food_AppDataSet.Cakes' table. You can move, or remove it, as needed.
        Me.CakesTableAdapter.Fill(Me.Food_AppDataSet.Cakes)

        lbldate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

        txtbrownies.Text = "0"
        txtmarblecake.Text = "0"
        txtcheesecake.Text = "0"
        txtchocolatecake.Text = "0"
        txtcreamcake.Text = "0"
        txtblackforestcake.Text = "0"
        txtredvelvetcake.Text = "0"
        txticedcappucino.Text = "0"
        txtamericancoffee.Text = "0"
        txtafricancoffee.Text = "0"
        txtvalescoffee.Text = "0"
        txtcappucino.Text = "0"
        txticedlatte.Text = "0"
        txtexpresso.Text = "0"
        txtlatte.Text = "0"
        txtcostofdrinks.Text = "0"
        txtcostofcakes.Text = "0"
        txtservicecharge.Text = "2.95"

        txtbrownies.Enabled = False
        txtmarblecake.Enabled = False
        txtcheesecake.Enabled = False
        txtchocolatecake.Enabled = False
        txtcreamcake.Enabled = False
        txtblackforestcake.Enabled = False
        txtredvelvetcake.Enabled = False
        txticedcappucino.Enabled = False
        txtamericancoffee.Enabled = False
        txtafricancoffee.Enabled = False
        txtvalescoffee.Enabled = False
        txtcappucino.Enabled = False
        txticedlatte.Enabled = False
        txtexpresso.Enabled = False
        txtlatte.Enabled = False

        rtfReceipt.Clear()

        ckbbrownies.Checked = False
        ckbmarbelcake.Checked = False
        ckbcheesecake.Checked = False
        ckbchocolatecake.Checked = False
        ckbcreamcake.Checked = False
        ckbblackforestcake.Checked = False
        ckbredvelvetcake.Checked = False
        ckbicedcappucino.Checked = False
        ckbamericancoffee.Checked = False
        ckbafricancoffee.Checked = False
        ckbvalescoffee.Checked = False
        ckbcappucino.Checked = False
        ckbicedlatte.Checked = False
        ckbexpresso.Checked = False
        ckblatte.Checked = False

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CakesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CakesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CakesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Food_AppDataSet)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Queen_Park_s_BrowniesLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LatteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LatteTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtlatte.TextChanged

    End Sub

    Private Sub ExpressoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExpressoTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtexpresso.TextChanged

    End Sub

    Private Sub Iced_LatteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Iced_LatteTextBox_TextChanged(sender As Object, e As EventArgs) Handles txticedlatte.TextChanged

    End Sub

    Private Sub CappucinoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CappucinoTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtcappucino.TextChanged

    End Sub

    Private Sub Vales_CoffeeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Vales_CoffeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtvalescoffee.TextChanged

    End Sub

    Private Sub African_CoffeeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub African_CoffeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtafricancoffee.TextChanged

    End Sub

    Private Sub American_CoffeeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub American_CoffeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtamericancoffee.TextChanged

    End Sub

    Private Sub Iced_CappucinoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Iced_CappucinoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Red_Velvet_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Red_Velvet_CakeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtredvelvetcake.TextChanged

    End Sub

    Private Sub Black_Forest_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Black_Forest_CakeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtblackforestcake.TextChanged

    End Sub

    Private Sub Boston_Cream_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Boston_Cream_CakeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtcreamcake.TextChanged

    End Sub

    Private Sub Nairobi_Special_Chocolate_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nairobi_Special_Chocolate_CakeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtchocolatecake.TextChanged

    End Sub

    Private Sub New_York_Cheese_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcheese_TextChanged(sender As Object, e As EventArgs) Handles txtcheesecake.TextChanged

    End Sub

    Private Sub Marbel_CakeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtmarble_TextChanged(sender As Object, e As EventArgs) Handles txtmarblecake.TextChanged

    End Sub

    Private Sub txtbrownies_TextChanged(sender As Object, e As EventArgs) Handles txtbrownies.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        TabControl1.SelectedTab = TabPage2

        rtfReceipt.Clear()

        rtfReceipt.AppendText(vbTab + vbTab + "Just do coffee" + Environment.NewLine)
        rtfReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine)

        rtfReceipt.AppendText("Iced-Cappucino:" + vbTab + txticedcappucino.Text + Environment.NewLine)
        rtfReceipt.AppendText("American Coffee:" + vbTab + txtamericancoffee.Text + Environment.NewLine)
        rtfReceipt.AppendText("African Coffee:" + vbTab + txtafricancoffee.Text + Environment.NewLine)
        rtfReceipt.AppendText("Vales Coffee:" + vbTab + txtvalescoffee.Text + Environment.NewLine)
        rtfReceipt.AppendText("Cappucino Coffee:" + vbTab + txtcappucino.Text + Environment.NewLine)
        rtfReceipt.AppendText("Iced Latte:" + vbTab + txticedlatte.Text + Environment.NewLine)
        rtfReceipt.AppendText("Expresso:" + vbTab + txtexpresso.Text + Environment.NewLine)
        rtfReceipt.AppendText("Latte:" + vbTab + txtlatte.Text + Environment.NewLine)

        rtfReceipt.AppendText("Queen Park's Brownines:" + vbTab + txtbrownies.Text + Environment.NewLine)
        rtfReceipt.AppendText("Marbel Cake:" + vbTab + txtmarblecake.Text + Environment.NewLine)
        rtfReceipt.AppendText("New York Cheese Cake:" + vbTab + txtcheesecake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Nairobi Special Chocolate Cake:" + vbTab + txtchocolatecake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Boston Cream Cake:" + vbTab + txtcreamcake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Black Forest Cake:" + vbTab + txtblackforestcake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Red Velvet Cake:" + vbTab + txtredvelvetcake.Text + Environment.NewLine)

        rtfReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText("Service Charge:" + vbTab + txtservicecharge.Text + Environment.NewLine)
        rtfReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText("Tax:" + vbTab + txtTax.Text + Environment.NewLine)
        rtfReceipt.AppendText("Sub Total:" + vbTab + txtsubtotal.Text + Environment.NewLine)
        rtfReceipt.AppendText("Total:" + vbTab + txtTotal.Text + Environment.NewLine)
        rtfReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText(lbltime.Text + vbTab + vbTab + vbTab + lbldate.Text)



        MsgBox("Thank you for shopping with us, please check your receipt!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '=========================================================================================================================================================================================================================================================================================================================================================================================================================================================================

        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Food App.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = " insert into Cakes ( [Queen Park's Brownies] , [Marbel Cake] , [New York Cheese Cake] , [Nairobi Special Chocolate Cake] , [Boston Cream Cake] , [Black Forest Cake] , [Red Velvet Cake] ) values ('" & txtbrownies.Text & "','" & txtmarblecake.Text & "','" & txtcheesecake.Text & "','" & txtchocolatecake.Text & "','" & txtcreamcake.Text & "','" & txtblackforestcake.Text & "','" & txtredvelvetcake.Text & "')"
        command = " insert into Drinks ( [Iced-Cappucino] , [American Coffee] , [African Coffee] , [Vales Coffee] , [Cappucino] , [Iced Latte] , [Expresso] , [Latte] ) values ('" & txticedcappucino.Text & "','" & txtamericancoffee.Text & "','" & txtafricancoffee.Text & "','" & txtvalescoffee.Text & "','" & txtcappucino.Text & "','" & txticedlatte.Text & "','" & txtexpresso.Text & txtlatte.Text & "')"
        command = " insert into Order ( [Cost of Drinks] , [Cost of Cakes] , [Service Charge] , [Tax] , [SubTotal] , [Total] ) values ('" & txtcostofdrinks.Text & "','" & txtcostofcakes.Text & "','" & txtservicecharge.Text & "','" & txtTax.Text & "','" & txtsubtotal.Text & "','" & txtTotal.Text & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Queen Park's Brownies", CType(txtbrownies.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Marbel Cake", CType(txtmarblecake.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("New York Cheese Cake", CType(txtcheesecake.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Nairobi Special Chocolate Cake", CType(txtchocolatecake.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Boston Cream Cake", CType(txtcreamcake.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Black Forest Cake", CType(txtblackforestcake.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Red Velvet Cake", CType(txtredvelvetcake.Text, Integer)))

        cmd.Parameters.Add(New OleDbParameter("Iced-Cappucino", CType(txticedcappucino.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("American Coffee", CType(txtamericancoffee.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("African Coffee", CType(txtafricancoffee.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Vales Coffee", CType(txtvalescoffee.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Cappuccino", CType(txtcappucino.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Iced Latte", CType(txticedlatte.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Expresso", CType(txtexpresso.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Latte", CType(txtlatte.Text, Integer)))

        cmd.Parameters.Add(New OleDbParameter("Cost of Drinks", CType(txtcostofdrinks.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Cost of Cakes", CType(txtcostofcakes.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Service Charge", CType(txtservicecharge.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Tax", CType(txtTax.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("SubTotal", CType(txtsubtotal.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Total", CType(txtTotal.Text, Integer)))

        MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            txtbrownies.Clear()
            txtmarblecake.Clear()
            txtcheesecake.Clear()
            txtchocolatecake.Clear()
            txtcreamcake.Clear()
            txtblackforestcake.Clear()
            txtredvelvetcake.Clear()

            txticedcappucino.Clear()
            txtamericancoffee.Clear()
            txtafricancoffee.Clear()
            txtvalescoffee.Clear()
            txtcappucino.Clear()
            txticedlatte.Clear()
            txtexpresso.Clear()
            txtlatte.Clear()

            txtcostofdrinks.Clear()
            txtcostofcakes.Clear()
            txtservicecharge.Clear()
            txtTax.Clear()
            txtsubtotal.Clear()
            txtTotal.Clear()

        Catch ex As Exception

            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try



        'pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Food App.accdb"
        'connstring = pro
        'myconnection.ConnectionString = connstring
        'myconnection.Open()
        'command = " insert into Drinks ( [Iced-Cappucino] , [American Coffee] , [African Coffee] , [Vales Coffee] , [Cappucino] , [Iced Latte] , [Expresso] , [Latte] ) values ('" & txticedcappucino.Text & "','" & txtamericancoffee.Text & "','" & txtafricancoffee.Text & "','" & txtvalescoffee.Text & "','" & txtcappucino.Text & "','" & txticedlatte.Text & "','" & txtexpresso.Text & txtlatte.Text & "')"
        'Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        'cmd.Parameters.Add(New OleDbParameter("Iced-Cappucino", CType(txticedcappucino.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("American Coffee", CType(txtamericancoffee.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("African Coffee", CType(txtafricancoffee.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Vales Coffee", CType(txtvalescoffee.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Cappuccino", CType(txtcappucino.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Iced Latte", CType(txticedlatte.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Expresso", CType(txtexpresso.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Latte", CType(txtlatte.Text, Integer)))
        'MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Try
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
        'txticedcappucino.Clear()
        'txtamericancoffee.Clear()
        'txtafricancoffee.Clear()
        'txtvalescoffee.Clear()
        'txtcappucino.Clear()
        'txticedlatte.Clear()
        'txtexpresso.Clear()
        'txtlatte.Clear()

        'Catch ex As Exception

        'MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'End Try
        'myconnection.Close()

        'pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ENVY\Downloads\Food App.accdb"
        'connstring = pro
        'myconnection.ConnectionString = connstring
        'myconnection.Open()
        'command = " insert into Order ( [Cost of Drinks] , [Cost of Cakes] , [Service Charge] , [Tax] , [SubTotal] , [Total] ) values ('" & txtcostofdrinks.Text & "','" & txtcostofcakes.Text & "','" & txtservicecharge.Text & "','" & txtTax.Text & "','" & txtsubtotal.Text & "','" & txtTotal.Text & "')"
        'Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        'cmd.Parameters.Add(New OleDbParameter("Cost of Drinks", CType(txtcostofdrinks.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Cost of Cakes", CType(txtcostofcakes.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Service Charge", CType(txtservicecharge.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Tax", CType(txtTax.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("SubTotal", CType(txtsubtotal.Text, Integer)))
        'cmd.Parameters.Add(New OleDbParameter("Total", CType(txtTotal.Text, Integer)))
        'MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Try
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
        'txtcostofdrinks.Clear()
        'txtcostofcakes.Clear()
        'txtservicecharge.Clear()
        'txtTax.Clear()
        'txtsubtotal.Clear()
        'txtTotal.Clear()

        'Catch ex As Exception

        'MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'End Try
        'myconnection.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CakesBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CakesBindingNavigator.RefreshItems

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub ckbbrownies_CheckedChanged(sender As Object, e As EventArgs) Handles ckbbrownies.CheckedChanged
        If (ckbbrownies.Checked = True) Then
            txtbrownies.Enabled = True
        End If

        If (ckbbrownies.Checked = False) Then
            txtbrownies.Enabled = False
            txtbrownies.Text = "0"
        End If
    End Sub

    Private Sub txtbrownies_Click(sender As Object, e As EventArgs) Handles txtbrownies.Click
        txtbrownies.Text = ""
        txtbrownies.Focus()
    End Sub

    Private Sub ckbmarbelcake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbmarbelcake.CheckedChanged
        If (ckbmarbelcake.Checked = True) Then
            txtmarblecake.Enabled = True
        End If

        If (ckbmarbelcake.Checked = False) Then
            txtmarblecake.Enabled = False
            txtmarblecake.Text = "0"
        End If
    End Sub

    Private Sub txtmarblecake_Click(sender As Object, e As EventArgs) Handles txtmarblecake.Click
        txtmarblecake.Text = ""
        txtmarblecake.Focus()
    End Sub

    Private Sub ckbcheesecake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbcheesecake.CheckedChanged
        If (ckbcheesecake.Checked = True) Then
            txtcheesecake.Enabled = True
        End If

        If (ckbcheesecake.Checked = False) Then
            txtcheesecake.Enabled = False
            txtcheesecake.Text = "0"
        End If
    End Sub

    Private Sub txtcheesecake_Click(sender As Object, e As EventArgs) Handles txtcheesecake.Click
        txtcheesecake.Text = ""
        txtcheesecake.Focus()
    End Sub

    Private Sub ckbchocolatecake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbchocolatecake.CheckedChanged
        If (ckbchocolatecake.Checked = True) Then
            txtchocolatecake.Enabled = True
        End If

        If (ckbchocolatecake.Checked = False) Then
            txtchocolatecake.Enabled = False
            txtchocolatecake.Text = "0"
        End If
    End Sub

    Private Sub txtchocolatecake_Click(sender As Object, e As EventArgs) Handles txtchocolatecake.Click
        txtchocolatecake.Text = ""
        txtchocolatecake.Focus()
    End Sub

    Private Sub ckbcreamcake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbcreamcake.CheckedChanged
        If (ckbcreamcake.Checked = True) Then
            txtcreamcake.Enabled = True
        End If

        If (ckbcreamcake.Checked = False) Then
            txtcreamcake.Enabled = False
            txtcreamcake.Text = "0"
        End If
    End Sub

    Private Sub txtcreamcake_Click(sender As Object, e As EventArgs) Handles txtcreamcake.Click
        txtcreamcake.Text = ""
        txtcreamcake.Focus()
    End Sub

    Private Sub ckbblackforestcake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbblackforestcake.CheckedChanged
        If (ckbblackforestcake.Checked = True) Then
            txtblackforestcake.Enabled = True
        End If

        If (ckbblackforestcake.Checked = False) Then
            txtblackforestcake.Enabled = False
            txtblackforestcake.Text = "0"
        End If
    End Sub

    Private Sub txtblackforestcake_Click(sender As Object, e As EventArgs) Handles txtblackforestcake.Click
        txtblackforestcake.Text = ""
        txtblackforestcake.Focus()
    End Sub

    Private Sub ckbredvelvetcake_CheckedChanged(sender As Object, e As EventArgs) Handles ckbredvelvetcake.CheckedChanged
        If (ckbredvelvetcake.Checked = True) Then
            txtredvelvetcake.Enabled = True
        End If

        If (ckbredvelvetcake.Checked = False) Then
            txtredvelvetcake.Enabled = False
            txtredvelvetcake.Text = "0"
        End If
    End Sub

    Private Sub txtredvelvetcake_Click(sender As Object, e As EventArgs) Handles txtredvelvetcake.Click
        txtredvelvetcake.Text = ""
        txtredvelvetcake.Focus()
    End Sub

    Private Sub ckbicedcappucino_CheckedChanged(sender As Object, e As EventArgs)
        If (ckbicedcappucino.Checked = True) Then
            txticedcappucino.Enabled = True
        End If

        If (ckbicedcappucino.Checked = False) Then
            txticedcappucino.Enabled = False
            txticedcappucino.Text = "0"
        End If
    End Sub

    Private Sub txticedcappucino_Click(sender As Object, e As EventArgs)
        txticedcappucino.Text = ""
        txticedcappucino.Focus()
    End Sub

    Private Sub ckbamericancoffee_CheckedChanged(sender As Object, e As EventArgs) Handles ckbamericancoffee.CheckedChanged
        If (ckbamericancoffee.Checked = True) Then
            txtamericancoffee.Enabled = True
        End If

        If (ckbamericancoffee.Checked = False) Then
            txtamericancoffee.Enabled = False
            txtamericancoffee.Text = "0"
        End If
    End Sub

    Private Sub txtamericancoffee_Click(sender As Object, e As EventArgs) Handles txtamericancoffee.Click
        txtamericancoffee.Text = ""
        txtamericancoffee.Focus()
    End Sub

    Private Sub ckbafricancoffee_CheckedChanged(sender As Object, e As EventArgs) Handles ckbafricancoffee.CheckedChanged
        If (ckbafricancoffee.Checked = True) Then
            txtafricancoffee.Enabled = True
        End If

        If (ckbafricancoffee.Checked = False) Then
            txtafricancoffee.Enabled = False
            txtafricancoffee.Text = "0"
        End If
    End Sub

    Private Sub txtafricancoffee_Click(sender As Object, e As EventArgs) Handles txtafricancoffee.Click
        txtafricancoffee.Text = ""
        txtafricancoffee.Focus()
    End Sub

    Private Sub ckbvalescoffee_CheckedChanged(sender As Object, e As EventArgs) Handles ckbvalescoffee.CheckedChanged
        If (ckbvalescoffee.Checked = True) Then
            txtvalescoffee.Enabled = True
        End If

        If (ckbvalescoffee.Checked = False) Then
            txtvalescoffee.Enabled = False
            txtvalescoffee.Text = "0"
        End If
    End Sub

    Private Sub txtvalescoffee_Click(sender As Object, e As EventArgs) Handles txtvalescoffee.Click
        txtvalescoffee.Text = ""
        txtvalescoffee.Focus()
    End Sub

    Private Sub ckbcappucino_CheckedChanged(sender As Object, e As EventArgs) Handles ckbcappucino.CheckedChanged
        If (ckbcappucino.Checked = True) Then
            txtcappucino.Enabled = True
        End If

        If (ckbcappucino.Checked = False) Then
            txtcappucino.Enabled = False
            txtcappucino.Text = "0"
        End If
    End Sub

    Private Sub txtcappucino_Click(sender As Object, e As EventArgs) Handles txtcappucino.Click
        txtcappucino.Text = ""
        txtcappucino.Focus()
    End Sub

    Private Sub ckbicedlatte_CheckedChanged(sender As Object, e As EventArgs) Handles ckbicedlatte.CheckedChanged
        If (ckbicedlatte.Checked = True) Then
            txticedlatte.Enabled = True
        End If

        If (ckbicedlatte.Checked = False) Then
            txticedlatte.Enabled = False
            txticedlatte.Text = "0"
        End If
    End Sub

    Private Sub txticedlatte_Click(sender As Object, e As EventArgs) Handles txticedlatte.Click
        txticedlatte.Text = ""
        txticedlatte.Focus()
    End Sub

    Private Sub ckbexpresso_CheckedChanged(sender As Object, e As EventArgs) Handles ckbexpresso.CheckedChanged
        If (ckbexpresso.Checked = True) Then
            txtexpresso.Enabled = True
        End If

        If (ckbexpresso.Checked = False) Then
            txtexpresso.Enabled = False
            txtexpresso.Text = "0"
        End If
    End Sub

    Private Sub txtexpresso_Click(sender As Object, e As EventArgs) Handles txtexpresso.Click
        txtexpresso.Text = ""
        txtexpresso.Focus()
    End Sub

    Private Sub ckblatte_CheckedChanged(sender As Object, e As EventArgs) Handles ckblatte.CheckedChanged
        If (ckblatte.Checked = True) Then
            txtlatte.Enabled = True
        End If

        If (ckblatte.Checked = False) Then
            txtlatte.Enabled = False
            txtlatte.Text = "0"
        End If
    End Sub

    Private Sub txtlatte_Click(sender As Object, e As EventArgs) Handles txtlatte.Click
        txtlatte.Text = ""
        txtlatte.Focus()
    End Sub

    Private Sub txtNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles txtvalescoffee.KeyPress, txtredvelvetcake.KeyPress, txtmarblecake.KeyPress, txtlatte.KeyPress, txticedlatte.KeyPress, txtexpresso.KeyPress, txtcreamcake.KeyPress, txtchocolatecake.KeyPress, txtcheesecake.KeyPress, txtcappucino.KeyPress, txtbrownies.KeyPress, txtblackforestcake.KeyPress, txtamericancoffee.KeyPress, txtafricancoffee.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please enter a valid number", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim tax As Double
        tax = 5.2
        Dim icappucino, amcoffee, afcoffee, vcoffee, cappucino, ilatte, expresso, latte As Double
        Dim brownies, mcake, checake, chocake, crecake, forcake, velcake As Double

        'coffee
        icappucino = 1.1
        amcoffee = 1.45
        afcoffee = 1.5
        vcoffee = 1.45
        cappucino = 1.7
        ilatte = 1.5
        expresso = 1.5
        latte = 1.3

        Dim icapp_coffee As Double = Convert.ToDouble(txticedcappucino.Text)
        Dim american_coffee As Double = Convert.ToDouble(txtamericancoffee.Text)
        Dim african_coffee As Double = Convert.ToDouble(txtafricancoffee.Text)
        Dim vales_coffee As Double = Convert.ToDouble(txtvalescoffee.Text)
        Dim capp_coffee As Double = Convert.ToDouble(txtcappucino.Text)
        Dim ilatte_coffee As Double = Convert.ToDouble(txticedlatte.Text)
        Dim expresso_coffee As Double = Convert.ToDouble(txtexpresso.Text)
        Dim latte_coffee As Double = Convert.ToDouble(txtlatte.Text)


        'cakes
        brownies = 1.1
        mcake = 1.3
        checake = 1.5
        chocake = 1.4
        crecake = 1.3
        forcake = 1.9
        velcake = 1.2

        Dim queen_brownies As Double = Convert.ToDouble(txtbrownies.Text)
        Dim marble_cake As Double = Convert.ToDouble(txtmarblecake.Text)
        Dim cheese_cake As Double = Convert.ToDouble(txtcheesecake.Text)
        Dim choc_cake As Double = Convert.ToDouble(txtchocolatecake.Text)
        Dim cream_cake As Double = Convert.ToDouble(txtcreamcake.Text)
        Dim bforest_cake As Double = Convert.ToDouble(txtblackforestcake.Text)
        Dim rvelvet_cake As Double = Convert.ToDouble(txtredvelvetcake.Text)
        '==========================================================================================
        Dim cost_of_drinks, service_charge, cost_of_cakes, iTax As Double
        cost_of_drinks = (icapp_coffee * icappucino) + (american_coffee * amcoffee) + (african_coffee * afcoffee) + (vales_coffee * vcoffee) + (capp_coffee * cappucino) + (ilatte_coffee * ilatte) + (expresso_coffee * expresso) + (latte_coffee * latte)
        txtcostofdrinks.Text = Convert.ToString(cost_of_drinks)

        cost_of_cakes = (queen_brownies * brownies) + (marble_cake * mcake) + (cheese_cake * checake) + (choc_cake * chocake) + (cream_cake * crecake) + (bforest_cake * forcake) + (rvelvet_cake * velcake)
        txtcostofcakes.Text = Convert.ToString(cost_of_cakes)

        service_charge = Convert.ToDouble(txtservicecharge.Text)

        txtsubtotal.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + service_charge)
        txtTax.Text = Convert.ToString(((cost_of_drinks + cost_of_cakes + service_charge) * tax) / 100)
        iTax = Convert.ToDouble(txtTax.Text)
        txtTotal.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + iTax + service_charge)

        txtcostofdrinks.Text = FormatCurrency(cost_of_drinks)
        txtcostofcakes.Text = FormatCurrency(cost_of_cakes)
        txtservicecharge.Text = FormatCurrency(service_charge)
        txtsubtotal.Text = FormatCurrency((cost_of_drinks + cost_of_cakes + service_charge))
        txtTax.Text = FormatCurrency(iTax)
        txtTotal.Text = FormatCurrency((cost_of_drinks + cost_of_cakes + service_charge + iTax))



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbrownies.Text = "0"
        txtmarblecake.Text = "0"
        txtcheesecake.Text = "0"
        txtchocolatecake.Text = "0"
        txtcreamcake.Text = "0"
        txtblackforestcake.Text = "0"
        txtredvelvetcake.Text = "0"
        txticedcappucino.Text = "0"
        txtamericancoffee.Text = "0"
        txtafricancoffee.Text = "0"
        txtvalescoffee.Text = "0"
        txtcappucino.Text = "0"
        txticedlatte.Text = "0"
        txtexpresso.Text = "0"
        txtlatte.Text = "0"
        txtcostofdrinks.Text = "0"
        txtcostofcakes.Text = "0"
        txtservicecharge.Text = "2.95"

        txtbrownies.Enabled = False
        txtmarblecake.Enabled = False
        txtcheesecake.Enabled = False
        txtchocolatecake.Enabled = False
        txtcreamcake.Enabled = False
        txtblackforestcake.Enabled = False
        txtredvelvetcake.Enabled = False
        txticedcappucino.Enabled = False
        txtamericancoffee.Enabled = False
        txtafricancoffee.Enabled = False
        txtvalescoffee.Enabled = False
        txtcappucino.Enabled = False
        txticedlatte.Enabled = False
        txtexpresso.Enabled = False
        txtlatte.Enabled = False

        rtfReceipt.Clear()

        ckbbrownies.Checked = False
        ckbmarbelcake.Checked = False
        ckbcheesecake.Checked = False
        ckbchocolatecake.Checked = False
        ckbcreamcake.Checked = False
        ckbblackforestcake.Checked = False
        ckbredvelvetcake.Checked = False
        ckbicedcappucino.Checked = False
        ckbamericancoffee.Checked = False
        ckbafricancoffee.Checked = False
        ckbvalescoffee.Checked = False
        ckbcappucino.Checked = False
        ckbicedlatte.Checked = False
        ckbexpresso.Checked = False
        ckblatte.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ckbicedcappucino_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckbicedcappucino.CheckedChanged
        If (ckbicedcappucino.Checked = True) Then
            txticedcappucino.Enabled = True
        End If

        If (ckbicedcappucino.Checked = False) Then
            txticedcappucino.Enabled = False
            txticedcappucino.Text = "0"
        End If
    End Sub

    Private Sub txticedcappucino_Click_1(sender As Object, e As EventArgs) Handles txticedcappucino.Click
        txticedcappucino.Text = ""
        txticedcappucino.Focus()
    End Sub
End Class