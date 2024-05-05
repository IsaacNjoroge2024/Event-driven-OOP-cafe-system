<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmmenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Food_AppDataSet = New Njoro_s_cafe.Food_AppDataSet()
        Me.CakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CakesTableAdapter = New Njoro_s_cafe.Food_AppDataSetTableAdapters.CakesTableAdapter()
        Me.TableAdapterManager = New Njoro_s_cafe.Food_AppDataSetTableAdapters.TableAdapterManager()
        Me.DrinksTableAdapter = New Njoro_s_cafe.Food_AppDataSetTableAdapters.DrinksTableAdapter()
        Me.CakesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CakesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DrinksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtlatte = New System.Windows.Forms.TextBox()
        Me.txtexpresso = New System.Windows.Forms.TextBox()
        Me.txticedlatte = New System.Windows.Forms.TextBox()
        Me.txtcappucino = New System.Windows.Forms.TextBox()
        Me.txtvalescoffee = New System.Windows.Forms.TextBox()
        Me.txtafricancoffee = New System.Windows.Forms.TextBox()
        Me.txtamericancoffee = New System.Windows.Forms.TextBox()
        Me.txtredvelvetcake = New System.Windows.Forms.TextBox()
        Me.txtblackforestcake = New System.Windows.Forms.TextBox()
        Me.txtcreamcake = New System.Windows.Forms.TextBox()
        Me.txtchocolatecake = New System.Windows.Forms.TextBox()
        Me.txtcheesecake = New System.Windows.Forms.TextBox()
        Me.txtmarblecake = New System.Windows.Forms.TextBox()
        Me.txtbrownies = New System.Windows.Forms.TextBox()
        Me.ckbbrownies = New System.Windows.Forms.CheckBox()
        Me.ckbmarbelcake = New System.Windows.Forms.CheckBox()
        Me.ckbcheesecake = New System.Windows.Forms.CheckBox()
        Me.ckbchocolatecake = New System.Windows.Forms.CheckBox()
        Me.ckbcreamcake = New System.Windows.Forms.CheckBox()
        Me.ckbblackforestcake = New System.Windows.Forms.CheckBox()
        Me.ckbredvelvetcake = New System.Windows.Forms.CheckBox()
        Me.ckbamericancoffee = New System.Windows.Forms.CheckBox()
        Me.ckbafricancoffee = New System.Windows.Forms.CheckBox()
        Me.ckbvalescoffee = New System.Windows.Forms.CheckBox()
        Me.ckbcappucino = New System.Windows.Forms.CheckBox()
        Me.ckbicedlatte = New System.Windows.Forms.CheckBox()
        Me.ckbexpresso = New System.Windows.Forms.CheckBox()
        Me.ckblatte = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New Njoro_s_cafe.Food_AppDataSetTableAdapters.OrderTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblServicecharge = New System.Windows.Forms.Label()
        Me.txtservicecharge = New System.Windows.Forms.TextBox()
        Me.lblCostofcakes = New System.Windows.Forms.Label()
        Me.txtcostofcakes = New System.Windows.Forms.TextBox()
        Me.lblCostofdrinks = New System.Windows.Forms.Label()
        Me.txtcostofdrinks = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rtfReceipt = New System.Windows.Forms.RichTextBox()
        Me.txticedcappucino = New System.Windows.Forms.TextBox()
        Me.ckbicedcappucino = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_AppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CakesBindingNavigator.SuspendLayout()
        CType(Me.DrinksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1854, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(392, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 40)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "With homebrewed coffee and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the most delicious baked cakes"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(1536, 15)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(57, 20)
        Me.lbldate.TabIndex = 5
        Me.lbldate.Text = "Label6"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(1536, 61)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(57, 20)
        Me.lbltime.TabIndex = 4
        Me.lbltime.Text = "Label5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(932, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 82)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MENU"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Njoro_s_cafe.My.Resources.Resources.pngwing_com
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Njoro's Cafe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.OldLace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CAKES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Linen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(950, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 46)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "COFFEE"
        '
        'Food_AppDataSet
        '
        Me.Food_AppDataSet.DataSetName = "Food_AppDataSet"
        Me.Food_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CakesBindingSource
        '
        Me.CakesBindingSource.DataMember = "Cakes"
        Me.CakesBindingSource.DataSource = Me.Food_AppDataSet
        '
        'CakesTableAdapter
        '
        Me.CakesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CakesTableAdapter = Me.CakesTableAdapter
        Me.TableAdapterManager.Customer_informationTableAdapter = Nothing
        Me.TableAdapterManager.DrinksTableAdapter = Me.DrinksTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Njoro_s_cafe.Food_AppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DrinksTableAdapter
        '
        Me.DrinksTableAdapter.ClearBeforeFill = True
        '
        'CakesBindingNavigator
        '
        Me.CakesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CakesBindingNavigator.BindingSource = Me.CakesBindingSource
        Me.CakesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CakesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CakesBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CakesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CakesBindingNavigatorSaveItem})
        Me.CakesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CakesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CakesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CakesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CakesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CakesBindingNavigator.Name = "CakesBindingNavigator"
        Me.CakesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CakesBindingNavigator.Size = New System.Drawing.Size(1878, 33)
        Me.CakesBindingNavigator.TabIndex = 3
        Me.CakesBindingNavigator.Text = "BindingNavigator1"
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
        'CakesBindingNavigatorSaveItem
        '
        Me.CakesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CakesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CakesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CakesBindingNavigatorSaveItem.Name = "CakesBindingNavigatorSaveItem"
        Me.CakesBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.CakesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DrinksBindingSource
        '
        Me.DrinksBindingSource.DataMember = "Drinks"
        Me.DrinksBindingSource.DataSource = Me.Food_AppDataSet
        '
        'txtlatte
        '
        Me.txtlatte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Latte", True))
        Me.txtlatte.Location = New System.Drawing.Point(296, 395)
        Me.txtlatte.Name = "txtlatte"
        Me.txtlatte.Size = New System.Drawing.Size(138, 26)
        Me.txtlatte.TabIndex = 33
        '
        'txtexpresso
        '
        Me.txtexpresso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Expresso", True))
        Me.txtexpresso.Location = New System.Drawing.Point(296, 343)
        Me.txtexpresso.Name = "txtexpresso"
        Me.txtexpresso.Size = New System.Drawing.Size(138, 26)
        Me.txtexpresso.TabIndex = 31
        '
        'txticedlatte
        '
        Me.txticedlatte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Iced Latte", True))
        Me.txticedlatte.Location = New System.Drawing.Point(296, 290)
        Me.txticedlatte.Name = "txticedlatte"
        Me.txticedlatte.Size = New System.Drawing.Size(138, 26)
        Me.txticedlatte.TabIndex = 29
        '
        'txtcappucino
        '
        Me.txtcappucino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Cappucino", True))
        Me.txtcappucino.Location = New System.Drawing.Point(296, 236)
        Me.txtcappucino.Name = "txtcappucino"
        Me.txtcappucino.Size = New System.Drawing.Size(138, 26)
        Me.txtcappucino.TabIndex = 27
        '
        'txtvalescoffee
        '
        Me.txtvalescoffee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Vales Coffee", True))
        Me.txtvalescoffee.Location = New System.Drawing.Point(296, 183)
        Me.txtvalescoffee.Name = "txtvalescoffee"
        Me.txtvalescoffee.Size = New System.Drawing.Size(138, 26)
        Me.txtvalescoffee.TabIndex = 25
        '
        'txtafricancoffee
        '
        Me.txtafricancoffee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "African Coffee", True))
        Me.txtafricancoffee.Location = New System.Drawing.Point(296, 129)
        Me.txtafricancoffee.Name = "txtafricancoffee"
        Me.txtafricancoffee.Size = New System.Drawing.Size(138, 26)
        Me.txtafricancoffee.TabIndex = 23
        '
        'txtamericancoffee
        '
        Me.txtamericancoffee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "American Coffee", True))
        Me.txtamericancoffee.Location = New System.Drawing.Point(296, 76)
        Me.txtamericancoffee.Name = "txtamericancoffee"
        Me.txtamericancoffee.Size = New System.Drawing.Size(138, 26)
        Me.txtamericancoffee.TabIndex = 21
        '
        'txtredvelvetcake
        '
        Me.txtredvelvetcake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Red Velvet Cake", True))
        Me.txtredvelvetcake.Location = New System.Drawing.Point(435, 335)
        Me.txtredvelvetcake.Name = "txtredvelvetcake"
        Me.txtredvelvetcake.Size = New System.Drawing.Size(138, 26)
        Me.txtredvelvetcake.TabIndex = 17
        '
        'txtblackforestcake
        '
        Me.txtblackforestcake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Black Forest Cake", True))
        Me.txtblackforestcake.Location = New System.Drawing.Point(435, 282)
        Me.txtblackforestcake.Name = "txtblackforestcake"
        Me.txtblackforestcake.Size = New System.Drawing.Size(138, 26)
        Me.txtblackforestcake.TabIndex = 15
        '
        'txtcreamcake
        '
        Me.txtcreamcake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Boston Cream Cake", True))
        Me.txtcreamcake.Location = New System.Drawing.Point(435, 228)
        Me.txtcreamcake.Name = "txtcreamcake"
        Me.txtcreamcake.Size = New System.Drawing.Size(138, 26)
        Me.txtcreamcake.TabIndex = 13
        '
        'txtchocolatecake
        '
        Me.txtchocolatecake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Nairobi Special Chocolate Cake", True))
        Me.txtchocolatecake.Location = New System.Drawing.Point(435, 172)
        Me.txtchocolatecake.Name = "txtchocolatecake"
        Me.txtchocolatecake.Size = New System.Drawing.Size(138, 26)
        Me.txtchocolatecake.TabIndex = 11
        '
        'txtcheesecake
        '
        Me.txtcheesecake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "New York Cheese Cake", True))
        Me.txtcheesecake.Location = New System.Drawing.Point(435, 118)
        Me.txtcheesecake.Name = "txtcheesecake"
        Me.txtcheesecake.Size = New System.Drawing.Size(138, 26)
        Me.txtcheesecake.TabIndex = 9
        '
        'txtmarblecake
        '
        Me.txtmarblecake.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Marbel Cake", True))
        Me.txtmarblecake.Location = New System.Drawing.Point(435, 70)
        Me.txtmarblecake.Name = "txtmarblecake"
        Me.txtmarblecake.Size = New System.Drawing.Size(138, 26)
        Me.txtmarblecake.TabIndex = 7
        '
        'txtbrownies
        '
        Me.txtbrownies.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CakesBindingSource, "Queen Park's Brownies", True))
        Me.txtbrownies.Location = New System.Drawing.Point(435, 27)
        Me.txtbrownies.Name = "txtbrownies"
        Me.txtbrownies.Size = New System.Drawing.Size(138, 26)
        Me.txtbrownies.TabIndex = 5
        '
        'ckbbrownies
        '
        Me.ckbbrownies.AutoSize = True
        Me.ckbbrownies.BackColor = System.Drawing.Color.MistyRose
        Me.ckbbrownies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbbrownies.Location = New System.Drawing.Point(17, 25)
        Me.ckbbrownies.Name = "ckbbrownies"
        Me.ckbbrownies.Size = New System.Drawing.Size(248, 29)
        Me.ckbbrownies.TabIndex = 35
        Me.ckbbrownies.Text = "Queen Park's Brownies:"
        Me.ckbbrownies.UseVisualStyleBackColor = False
        '
        'ckbmarbelcake
        '
        Me.ckbmarbelcake.AutoSize = True
        Me.ckbmarbelcake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbmarbelcake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbmarbelcake.Location = New System.Drawing.Point(17, 70)
        Me.ckbmarbelcake.Name = "ckbmarbelcake"
        Me.ckbmarbelcake.Size = New System.Drawing.Size(156, 29)
        Me.ckbmarbelcake.TabIndex = 36
        Me.ckbmarbelcake.Text = "Marbel Cake:"
        Me.ckbmarbelcake.UseVisualStyleBackColor = False
        '
        'ckbcheesecake
        '
        Me.ckbcheesecake.AutoSize = True
        Me.ckbcheesecake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbcheesecake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbcheesecake.Location = New System.Drawing.Point(17, 118)
        Me.ckbcheesecake.Name = "ckbcheesecake"
        Me.ckbcheesecake.Size = New System.Drawing.Size(254, 29)
        Me.ckbcheesecake.TabIndex = 37
        Me.ckbcheesecake.Text = "New York Cheese Cake:"
        Me.ckbcheesecake.UseVisualStyleBackColor = False
        '
        'ckbchocolatecake
        '
        Me.ckbchocolatecake.AutoSize = True
        Me.ckbchocolatecake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbchocolatecake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbchocolatecake.Location = New System.Drawing.Point(17, 172)
        Me.ckbchocolatecake.Name = "ckbchocolatecake"
        Me.ckbchocolatecake.Size = New System.Drawing.Size(321, 29)
        Me.ckbchocolatecake.TabIndex = 38
        Me.ckbchocolatecake.Text = "Nairobi Special Chocolate Cake:"
        Me.ckbchocolatecake.UseVisualStyleBackColor = False
        '
        'ckbcreamcake
        '
        Me.ckbcreamcake.AutoSize = True
        Me.ckbcreamcake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbcreamcake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbcreamcake.Location = New System.Drawing.Point(17, 228)
        Me.ckbcreamcake.Name = "ckbcreamcake"
        Me.ckbcreamcake.Size = New System.Drawing.Size(221, 29)
        Me.ckbcreamcake.TabIndex = 39
        Me.ckbcreamcake.Text = "Boston Cream Cake:"
        Me.ckbcreamcake.UseVisualStyleBackColor = False
        '
        'ckbblackforestcake
        '
        Me.ckbblackforestcake.AutoSize = True
        Me.ckbblackforestcake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbblackforestcake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbblackforestcake.Location = New System.Drawing.Point(17, 282)
        Me.ckbblackforestcake.Name = "ckbblackforestcake"
        Me.ckbblackforestcake.Size = New System.Drawing.Size(204, 29)
        Me.ckbblackforestcake.TabIndex = 40
        Me.ckbblackforestcake.Text = "Black Forest Cake:"
        Me.ckbblackforestcake.UseVisualStyleBackColor = False
        '
        'ckbredvelvetcake
        '
        Me.ckbredvelvetcake.AutoSize = True
        Me.ckbredvelvetcake.BackColor = System.Drawing.Color.MistyRose
        Me.ckbredvelvetcake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbredvelvetcake.Location = New System.Drawing.Point(17, 335)
        Me.ckbredvelvetcake.Name = "ckbredvelvetcake"
        Me.ckbredvelvetcake.Size = New System.Drawing.Size(191, 29)
        Me.ckbredvelvetcake.TabIndex = 41
        Me.ckbredvelvetcake.Text = "Red Velvet Cake:"
        Me.ckbredvelvetcake.UseVisualStyleBackColor = False
        '
        'ckbamericancoffee
        '
        Me.ckbamericancoffee.AutoSize = True
        Me.ckbamericancoffee.BackColor = System.Drawing.Color.Moccasin
        Me.ckbamericancoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbamericancoffee.Location = New System.Drawing.Point(13, 71)
        Me.ckbamericancoffee.Name = "ckbamericancoffee"
        Me.ckbamericancoffee.Size = New System.Drawing.Size(190, 29)
        Me.ckbamericancoffee.TabIndex = 43
        Me.ckbamericancoffee.Text = "American Coffee:"
        Me.ckbamericancoffee.UseVisualStyleBackColor = False
        '
        'ckbafricancoffee
        '
        Me.ckbafricancoffee.AutoSize = True
        Me.ckbafricancoffee.BackColor = System.Drawing.Color.Moccasin
        Me.ckbafricancoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbafricancoffee.Location = New System.Drawing.Point(13, 126)
        Me.ckbafricancoffee.Name = "ckbafricancoffee"
        Me.ckbafricancoffee.Size = New System.Drawing.Size(168, 29)
        Me.ckbafricancoffee.TabIndex = 44
        Me.ckbafricancoffee.Text = "African Coffee:"
        Me.ckbafricancoffee.UseVisualStyleBackColor = False
        '
        'ckbvalescoffee
        '
        Me.ckbvalescoffee.AutoSize = True
        Me.ckbvalescoffee.BackColor = System.Drawing.Color.Moccasin
        Me.ckbvalescoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbvalescoffee.Location = New System.Drawing.Point(13, 180)
        Me.ckbvalescoffee.Name = "ckbvalescoffee"
        Me.ckbvalescoffee.Size = New System.Drawing.Size(157, 29)
        Me.ckbvalescoffee.TabIndex = 45
        Me.ckbvalescoffee.Text = "Vales Coffee:"
        Me.ckbvalescoffee.UseVisualStyleBackColor = False
        '
        'ckbcappucino
        '
        Me.ckbcappucino.AutoSize = True
        Me.ckbcappucino.BackColor = System.Drawing.Color.Moccasin
        Me.ckbcappucino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbcappucino.Location = New System.Drawing.Point(13, 233)
        Me.ckbcappucino.Name = "ckbcappucino"
        Me.ckbcappucino.Size = New System.Drawing.Size(139, 29)
        Me.ckbcappucino.TabIndex = 46
        Me.ckbcappucino.Text = "Cappucino:"
        Me.ckbcappucino.UseVisualStyleBackColor = False
        '
        'ckbicedlatte
        '
        Me.ckbicedlatte.AutoSize = True
        Me.ckbicedlatte.BackColor = System.Drawing.Color.Moccasin
        Me.ckbicedlatte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbicedlatte.Location = New System.Drawing.Point(13, 290)
        Me.ckbicedlatte.Name = "ckbicedlatte"
        Me.ckbicedlatte.Size = New System.Drawing.Size(129, 29)
        Me.ckbicedlatte.TabIndex = 47
        Me.ckbicedlatte.Text = "Iced Latte:"
        Me.ckbicedlatte.UseVisualStyleBackColor = False
        '
        'ckbexpresso
        '
        Me.ckbexpresso.AutoSize = True
        Me.ckbexpresso.BackColor = System.Drawing.Color.Moccasin
        Me.ckbexpresso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbexpresso.Location = New System.Drawing.Point(13, 343)
        Me.ckbexpresso.Name = "ckbexpresso"
        Me.ckbexpresso.Size = New System.Drawing.Size(126, 29)
        Me.ckbexpresso.TabIndex = 48
        Me.ckbexpresso.Text = "Expresso:"
        Me.ckbexpresso.UseVisualStyleBackColor = False
        '
        'ckblatte
        '
        Me.ckblatte.AutoSize = True
        Me.ckblatte.BackColor = System.Drawing.Color.Moccasin
        Me.ckblatte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblatte.Location = New System.Drawing.Point(13, 395)
        Me.ckblatte.Name = "ckblatte"
        Me.ckblatte.Size = New System.Drawing.Size(87, 29)
        Me.ckblatte.TabIndex = 49
        Me.ckblatte.Text = "Latte:"
        Me.ckblatte.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FloralWhite
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1442, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 46)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Checkout"
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.Food_AppDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.lblServicecharge)
        Me.GroupBox1.Controls.Add(Me.txtservicecharge)
        Me.GroupBox1.Controls.Add(Me.lblCostofcakes)
        Me.GroupBox1.Controls.Add(Me.txtcostofcakes)
        Me.GroupBox1.Controls.Add(Me.lblCostofdrinks)
        Me.GroupBox1.Controls.Add(Me.txtcostofdrinks)
        Me.GroupBox1.Location = New System.Drawing.Point(91, 641)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 260)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblServicecharge
        '
        Me.lblServicecharge.AutoSize = True
        Me.lblServicecharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicecharge.Location = New System.Drawing.Point(13, 177)
        Me.lblServicecharge.Name = "lblServicecharge"
        Me.lblServicecharge.Size = New System.Drawing.Size(244, 37)
        Me.lblServicecharge.TabIndex = 4
        Me.lblServicecharge.Text = "Service Charge:"
        '
        'txtservicecharge
        '
        Me.txtservicecharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Service Charge", True))
        Me.txtservicecharge.Location = New System.Drawing.Point(263, 187)
        Me.txtservicecharge.Name = "txtservicecharge"
        Me.txtservicecharge.Size = New System.Drawing.Size(177, 26)
        Me.txtservicecharge.TabIndex = 5
        '
        'lblCostofcakes
        '
        Me.lblCostofcakes.AutoSize = True
        Me.lblCostofcakes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofcakes.Location = New System.Drawing.Point(13, 113)
        Me.lblCostofcakes.Name = "lblCostofcakes"
        Me.lblCostofcakes.Size = New System.Drawing.Size(227, 37)
        Me.lblCostofcakes.TabIndex = 2
        Me.lblCostofcakes.Text = "Cost of Cakes:"
        '
        'txtcostofcakes
        '
        Me.txtcostofcakes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Cost of Cakes", True))
        Me.txtcostofcakes.Location = New System.Drawing.Point(263, 120)
        Me.txtcostofcakes.Name = "txtcostofcakes"
        Me.txtcostofcakes.Size = New System.Drawing.Size(177, 26)
        Me.txtcostofcakes.TabIndex = 3
        '
        'lblCostofdrinks
        '
        Me.lblCostofdrinks.AutoSize = True
        Me.lblCostofdrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofdrinks.Location = New System.Drawing.Point(13, 48)
        Me.lblCostofdrinks.Name = "lblCostofdrinks"
        Me.lblCostofdrinks.Size = New System.Drawing.Size(228, 37)
        Me.lblCostofdrinks.TabIndex = 0
        Me.lblCostofdrinks.Text = "Cost of Drinks:"
        '
        'txtcostofdrinks
        '
        Me.txtcostofdrinks.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Cost of Drinks", True))
        Me.txtcostofdrinks.Location = New System.Drawing.Point(263, 55)
        Me.txtcostofdrinks.Name = "txtcostofdrinks"
        Me.txtcostofdrinks.Size = New System.Drawing.Size(177, 26)
        Me.txtcostofdrinks.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.txtTax)
        Me.GroupBox2.Controls.Add(Me.lblSubtotal)
        Me.GroupBox2.Controls.Add(Me.txtsubtotal)
        Me.GroupBox2.Location = New System.Drawing.Point(918, 686)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 210)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(12, 139)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 46)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Total", True))
        Me.txtTotal.Location = New System.Drawing.Point(220, 150)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(164, 26)
        Me.txtTotal.TabIndex = 5
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(12, 36)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(98, 46)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax:"
        '
        'txtTax
        '
        Me.txtTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Tax", True))
        Me.txtTax.Location = New System.Drawing.Point(221, 46)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(164, 26)
        Me.txtTax.TabIndex = 3
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(12, 88)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(202, 46)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Sub Total:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "SubTotal", True))
        Me.txtsubtotal.Location = New System.Drawing.Point(220, 99)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(165, 26)
        Me.txtsubtotal.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox4.Controls.Add(Me.ckbbrownies)
        Me.GroupBox4.Controls.Add(Me.ckbmarbelcake)
        Me.GroupBox4.Controls.Add(Me.ckbcheesecake)
        Me.GroupBox4.Controls.Add(Me.ckbchocolatecake)
        Me.GroupBox4.Controls.Add(Me.ckbcreamcake)
        Me.GroupBox4.Controls.Add(Me.ckbredvelvetcake)
        Me.GroupBox4.Controls.Add(Me.txtredvelvetcake)
        Me.GroupBox4.Controls.Add(Me.ckbblackforestcake)
        Me.GroupBox4.Controls.Add(Me.txtblackforestcake)
        Me.GroupBox4.Controls.Add(Me.txtbrownies)
        Me.GroupBox4.Controls.Add(Me.txtcreamcake)
        Me.GroupBox4.Controls.Add(Me.txtmarblecake)
        Me.GroupBox4.Controls.Add(Me.txtchocolatecake)
        Me.GroupBox4.Controls.Add(Me.txtcheesecake)
        Me.GroupBox4.Location = New System.Drawing.Point(91, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 379)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'PictureBox2
        '
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DrinksBindingSource, "Iced-Cappucino", True))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Njoro_s_cafe.My.Resources.Resources.cafe_ppl_drinking
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1878, 1024)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Black
        Me.btnTotal.ForeColor = System.Drawing.Color.White
        Me.btnTotal.Location = New System.Drawing.Point(10, 36)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(98, 75)
        Me.btnTotal.TabIndex = 56
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TabControl1)
        Me.GroupBox5.Location = New System.Drawing.Point(1361, 246)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(455, 437)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 412)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtfReceipt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(435, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rtfReceipt
        '
        Me.rtfReceipt.Location = New System.Drawing.Point(6, 6)
        Me.rtfReceipt.Name = "rtfReceipt"
        Me.rtfReceipt.Size = New System.Drawing.Size(426, 371)
        Me.rtfReceipt.TabIndex = 0
        Me.rtfReceipt.Text = ""
        '
        'txticedcappucino
        '
        Me.txticedcappucino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrinksBindingSource, "Iced-Cappucino", True))
        Me.txticedcappucino.Location = New System.Drawing.Point(296, 27)
        Me.txticedcappucino.Name = "txticedcappucino"
        Me.txticedcappucino.Size = New System.Drawing.Size(138, 26)
        Me.txticedcappucino.TabIndex = 2
        '
        'ckbicedcappucino
        '
        Me.ckbicedcappucino.AutoSize = True
        Me.ckbicedcappucino.BackColor = System.Drawing.Color.Moccasin
        Me.ckbicedcappucino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbicedcappucino.Location = New System.Drawing.Point(13, 24)
        Me.ckbicedcappucino.Name = "ckbicedcappucino"
        Me.ckbicedcappucino.Size = New System.Drawing.Size(193, 29)
        Me.ckbicedcappucino.TabIndex = 58
        Me.ckbicedcappucino.Text = "Iced - Cappucino:"
        Me.ckbicedcappucino.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Controls.Add(Me.txticedcappucino)
        Me.GroupBox3.Controls.Add(Me.txticedlatte)
        Me.GroupBox3.Controls.Add(Me.ckbicedcappucino)
        Me.GroupBox3.Controls.Add(Me.ckbamericancoffee)
        Me.GroupBox3.Controls.Add(Me.ckbafricancoffee)
        Me.GroupBox3.Controls.Add(Me.ckbvalescoffee)
        Me.GroupBox3.Controls.Add(Me.ckbcappucino)
        Me.GroupBox3.Controls.Add(Me.ckbicedlatte)
        Me.GroupBox3.Controls.Add(Me.ckblatte)
        Me.GroupBox3.Controls.Add(Me.ckbexpresso)
        Me.GroupBox3.Controls.Add(Me.txtamericancoffee)
        Me.GroupBox3.Controls.Add(Me.txtafricancoffee)
        Me.GroupBox3.Controls.Add(Me.txtvalescoffee)
        Me.GroupBox3.Controls.Add(Me.txtlatte)
        Me.GroupBox3.Controls.Add(Me.txtcappucino)
        Me.GroupBox3.Controls.Add(Me.txtexpresso)
        Me.GroupBox3.Location = New System.Drawing.Point(839, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 437)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnExit)
        Me.GroupBox6.Controls.Add(Me.btnReset)
        Me.GroupBox6.Controls.Add(Me.btnTotal)
        Me.GroupBox6.Controls.Add(Me.btnReceipt)
        Me.GroupBox6.Location = New System.Drawing.Point(1361, 686)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(455, 125)
        Me.GroupBox6.TabIndex = 60
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkGray
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(342, 36)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 75)
        Me.btnExit.TabIndex = 58
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Gray
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(232, 36)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 75)
        Me.btnReset.TabIndex = 57
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.DimGray
        Me.btnReceipt.ForeColor = System.Drawing.Color.White
        Me.btnReceipt.Location = New System.Drawing.Point(122, 36)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(98, 75)
        Me.btnReceipt.TabIndex = 34
        Me.btnReceipt.Text = "Save"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'fmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1878, 1024)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CakesBindingNavigator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "fmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_AppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CakesBindingNavigator.ResumeLayout(False)
        Me.CakesBindingNavigator.PerformLayout()
        CType(Me.DrinksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Food_AppDataSet As Food_AppDataSet
    Friend WithEvents CakesBindingSource As BindingSource
    Friend WithEvents CakesTableAdapter As Food_AppDataSetTableAdapters.CakesTableAdapter
    Friend WithEvents TableAdapterManager As Food_AppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CakesBindingNavigator As BindingNavigator
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
    Friend WithEvents CakesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DrinksTableAdapter As Food_AppDataSetTableAdapters.DrinksTableAdapter
    Friend WithEvents DrinksBindingSource As BindingSource
    Friend WithEvents txtlatte As TextBox
    Friend WithEvents txtexpresso As TextBox
    Friend WithEvents txticedlatte As TextBox
    Friend WithEvents txtcappucino As TextBox
    Friend WithEvents txtvalescoffee As TextBox
    Friend WithEvents txtafricancoffee As TextBox
    Friend WithEvents txtamericancoffee As TextBox
    Friend WithEvents txtredvelvetcake As TextBox
    Friend WithEvents txtblackforestcake As TextBox
    Friend WithEvents txtcreamcake As TextBox
    Friend WithEvents txtchocolatecake As TextBox
    Friend WithEvents txtcheesecake As TextBox
    Friend WithEvents txtmarblecake As TextBox
    Friend WithEvents txtbrownies As TextBox
    Friend WithEvents ckbbrownies As CheckBox
    Friend WithEvents ckbmarbelcake As CheckBox
    Friend WithEvents ckbcheesecake As CheckBox
    Friend WithEvents ckbchocolatecake As CheckBox
    Friend WithEvents ckbcreamcake As CheckBox
    Friend WithEvents ckbblackforestcake As CheckBox
    Friend WithEvents ckbredvelvetcake As CheckBox
    Friend WithEvents ckbamericancoffee As CheckBox
    Friend WithEvents ckbafricancoffee As CheckBox
    Friend WithEvents ckbvalescoffee As CheckBox
    Friend WithEvents ckbcappucino As CheckBox
    Friend WithEvents ckbicedlatte As CheckBox
    Friend WithEvents ckbexpresso As CheckBox
    Friend WithEvents ckblatte As CheckBox
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As Food_AppDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtservicecharge As TextBox
    Friend WithEvents txtcostofcakes As TextBox
    Friend WithEvents txtcostofdrinks As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblServicecharge As Label
    Friend WithEvents lblCostofcakes As Label
    Friend WithEvents lblCostofdrinks As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txticedcappucino As TextBox
    Friend WithEvents ckbicedcappucino As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents rtfReceipt As RichTextBox
End Class
