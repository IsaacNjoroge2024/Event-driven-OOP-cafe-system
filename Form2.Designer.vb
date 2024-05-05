<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customer_informationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_AppDataSet = New Njoro_s_cafe.Food_AppDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customer_informationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Customer_informationTableAdapter = New Njoro_s_cafe.Food_AppDataSetTableAdapters.Customer_informationTableAdapter()
        Me.TableAdapterManager = New Njoro_s_cafe.Food_AppDataSetTableAdapters.TableAdapterManager()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Customer_informationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_informationBindingNavigator.SuspendLayout()
        CType(Me.Customer_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_AppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(15, 25)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(184, 37)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(15, 100)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(182, 37)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(15, 246)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(242, 37)
        PhoneNumberLabel.TabIndex = 6
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(15, 328)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(106, 37)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(15, 402)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(144, 37)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(15, 477)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(173, 37)
        UsernameLabel.TabIndex = 12
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(15, 550)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(167, 37)
        PasswordLabel.TabIndex = 14
        PasswordLabel.Text = "Password:"
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel1.Location = New System.Drawing.Point(15, 175)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(132, 37)
        GenderLabel1.TabIndex = 18
        GenderLabel1.Text = "Gender:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(82, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1710, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(521, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration Form"
        '
        'Customer_informationBindingNavigator
        '
        Me.Customer_informationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_informationBindingNavigator.BindingSource = Me.Customer_informationBindingSource
        Me.Customer_informationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_informationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customer_informationBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Customer_informationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Customer_informationBindingNavigatorSaveItem})
        Me.Customer_informationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Customer_informationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_informationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_informationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_informationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_informationBindingNavigator.Name = "Customer_informationBindingNavigator"
        Me.Customer_informationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_informationBindingNavigator.Size = New System.Drawing.Size(1878, 33)
        Me.Customer_informationBindingNavigator.TabIndex = 1
        Me.Customer_informationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Customer_informationBindingSource
        '
        Me.Customer_informationBindingSource.DataMember = "Customer_information"
        Me.Customer_informationBindingSource.DataSource = Me.Food_AppDataSet
        '
        'Food_AppDataSet
        '
        Me.Food_AppDataSet.DataSetName = "Food_AppDataSet"
        Me.Food_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'Customer_informationBindingNavigatorSaveItem
        '
        Me.Customer_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Customer_informationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_informationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_informationBindingNavigatorSaveItem.Name = "Customer_informationBindingNavigatorSaveItem"
        Me.Customer_informationBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.Customer_informationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(GenderLabel1)
        Me.Panel2.Controls.Add(Me.txtgender)
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(PasswordLabel)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(UsernameLabel)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(AddressLabel)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(EmailLabel)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(PhoneNumberLabel)
        Me.Panel2.Controls.Add(Me.txtphonenumber)
        Me.Panel2.Controls.Add(LastNameLabel)
        Me.Panel2.Controls.Add(Me.txtlastname)
        Me.Panel2.Controls.Add(FirstNameLabel)
        Me.Panel2.Controls.Add(Me.txtfirstname)
        Me.Panel2.Location = New System.Drawing.Point(522, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 748)
        Me.Panel2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtgender
        '
        Me.txtgender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "Gender", True))
        Me.txtgender.Location = New System.Drawing.Point(368, 186)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(259, 26)
        Me.txtgender.TabIndex = 19
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(306, 641)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(167, 43)
        Me.btnexit.TabIndex = 17
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(38, 641)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(167, 43)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "Password", True))
        Me.txtpassword.Location = New System.Drawing.Point(368, 560)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(259, 26)
        Me.txtpassword.TabIndex = 15
        '
        'txtusername
        '
        Me.txtusername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "Username", True))
        Me.txtusername.Location = New System.Drawing.Point(368, 487)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(259, 26)
        Me.txtusername.TabIndex = 13
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "Address", True))
        Me.txtaddress.Location = New System.Drawing.Point(368, 412)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(259, 26)
        Me.txtaddress.TabIndex = 11
        '
        'txtemail
        '
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "Email", True))
        Me.txtemail.Location = New System.Drawing.Point(368, 338)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(259, 26)
        Me.txtemail.TabIndex = 9
        '
        'txtphonenumber
        '
        Me.txtphonenumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "PhoneNumber", True))
        Me.txtphonenumber.Location = New System.Drawing.Point(368, 257)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(259, 26)
        Me.txtphonenumber.TabIndex = 7
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "LastName", True))
        Me.txtlastname.Location = New System.Drawing.Point(368, 111)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(259, 26)
        Me.txtlastname.TabIndex = 5
        '
        'txtfirstname
        '
        Me.txtfirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_informationBindingSource, "FirstName", True))
        Me.txtfirstname.Location = New System.Drawing.Point(368, 36)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(259, 26)
        Me.txtfirstname.TabIndex = 3
        '
        'Customer_informationTableAdapter
        '
        Me.Customer_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CakesTableAdapter = Nothing
        Me.TableAdapterManager.Customer_informationTableAdapter = Me.Customer_informationTableAdapter
        Me.TableAdapterManager.DrinksTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Njoro_s_cafe.Food_AppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(113, 38)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(57, 20)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "Label2"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(1418, 38)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(57, 20)
        Me.lbltime.TabIndex = 2
        Me.lbltime.Text = "Label3"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1878, 1024)
        Me.Controls.Add(Me.Customer_informationBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Customer_informationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_informationBindingNavigator.ResumeLayout(False)
        Me.Customer_informationBindingNavigator.PerformLayout()
        CType(Me.Customer_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_AppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Food_AppDataSet As Food_AppDataSet
    Friend WithEvents Customer_informationBindingSource As BindingSource
    Friend WithEvents Customer_informationTableAdapter As Food_AppDataSetTableAdapters.Customer_informationTableAdapter
    Friend WithEvents TableAdapterManager As Food_AppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_informationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Customer_informationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnexit As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
End Class
