<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientLedger
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
        Me.lblLASTFIRST = New System.Windows.Forms.Label()
        Me.lblFirstLast = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.gvTransactions = New System.Windows.Forms.DataGridView()
        Me.ReceiptNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdjustmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorizationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentBalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrevBalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WriteOffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet10 = New DaySheetTest.KalpaxisDBDataSet10()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpouseFN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSpouseLN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDriversLiscense = New System.Windows.Forms.TextBox()
        Me.txtEmployer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmpZip = New System.Windows.Forms.TextBox()
        Me.gbEmployer = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.ddlEmpState = New System.Windows.Forms.ComboBox()
        Me.txtEmpCity = New System.Windows.Forms.TextBox()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbNearestRelative = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtNRLastName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ddlNRState = New System.Windows.Forms.ComboBox()
        Me.txtNRphone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNRFirstName = New System.Windows.Forms.TextBox()
        Me.txtNRcity = New System.Windows.Forms.TextBox()
        Me.txtNRAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNRRelation = New System.Windows.Forms.TextBox()
        Me.txtNRzip = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbOtherProServices = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ddlProServiceState = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtProServiceCity = New System.Windows.Forms.TextBox()
        Me.txtProService = New System.Windows.Forms.TextBox()
        Me.txtProServicePhone = New System.Windows.Forms.TextBox()
        Me.txtProServiceZip = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.gbInsurance = New System.Windows.Forms.GroupBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtPriInsName = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ddlPriInsState = New System.Windows.Forms.ComboBox()
        Me.txtPriInsCity = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPriInsPhone = New System.Windows.Forms.TextBox()
        Me.txtPriInsID = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtPriInsAddress = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtPriInsGroupNo = New System.Windows.Forms.TextBox()
        Me.txtPriInsZip = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtSpouseEmpAddress = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.ddlSpouseGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSpouseEmp = New System.Windows.Forms.TextBox()
        Me.ddlSpouseEmpState = New System.Windows.Forms.ComboBox()
        Me.txtSpouseEmpCity = New System.Windows.Forms.TextBox()
        Me.txtSpouseEmpPhone = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtSpouseEmpZip = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.gbSecondaryInsurance = New System.Windows.Forms.GroupBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtSecInsName = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ddlSecInsState = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtSecInsCity = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtSecInsPhone = New System.Windows.Forms.TextBox()
        Me.txtSecInsID = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtSecInsAddress = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtSecInsGroupNo = New System.Windows.Forms.TextBox()
        Me.txtSecInsZip = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.gbTertiaryInsurance = New System.Windows.Forms.GroupBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtTerInsName = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.ddlTerInsState = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtTerInsCity = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtTerInsPhone = New System.Windows.Forms.TextBox()
        Me.txtTerInsID = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtTerInsAddress = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtTerInsGroupNo = New System.Windows.Forms.TextBox()
        Me.txtTerInsZip = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtTotalCurrentBalance = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.ddlGender = New System.Windows.Forms.ComboBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PatientIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PatientIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TblTransactionTableAdapter = New DaySheetTest.KalpaxisDBDataSet10TableAdapters.tblTransactionTableAdapter()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.KalpaxisDBDataSet9 = New DaySheetTest.KalpaxisDBDataSet9()
        Me.TblInsuranceTableAdapter = New DaySheetTest.KalpaxisDBDataSet7TableAdapters.tblInsuranceTableAdapter()
        Me.TblInsuranceTableAdapter1 = New DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter()
        Me.TblInsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ddlPatState = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtPatFN = New System.Windows.Forms.TextBox()
        Me.txtPatAddress = New System.Windows.Forms.TextBox()
        Me.txtPatCity = New System.Windows.Forms.TextBox()
        Me.txtPatZip = New System.Windows.Forms.TextBox()
        Me.txtPatLN = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.gvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmployer.SuspendLayout()
        Me.gbNearestRelative.SuspendLayout()
        Me.gbOtherProServices.SuspendLayout()
        Me.gbInsurance.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbSecondaryInsurance.SuspendLayout()
        Me.gbTertiaryInsurance.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.KalpaxisDBDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLASTFIRST
        '
        Me.lblLASTFIRST.AutoSize = True
        Me.lblLASTFIRST.Location = New System.Drawing.Point(17, 16)
        Me.lblLASTFIRST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLASTFIRST.Name = "lblLASTFIRST"
        Me.lblLASTFIRST.Size = New System.Drawing.Size(0, 17)
        Me.lblLASTFIRST.TabIndex = 0
        '
        'lblFirstLast
        '
        Me.lblFirstLast.AutoSize = True
        Me.lblFirstLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstLast.Location = New System.Drawing.Point(256, 94)
        Me.lblFirstLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstLast.Name = "lblFirstLast"
        Me.lblFirstLast.Size = New System.Drawing.Size(0, 25)
        Me.lblFirstLast.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(256, 121)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(0, 25)
        Me.lblAddress.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "[If NH, use NH address]"
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.AutoSize = True
        Me.lblCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityStateZip.Location = New System.Drawing.Point(256, 148)
        Me.lblCityStateZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(0, 25)
        Me.lblCityStateZip.TabIndex = 4
        '
        'gvTransactions
        '
        Me.gvTransactions.AllowUserToAddRows = False
        Me.gvTransactions.AllowUserToDeleteRows = False
        Me.gvTransactions.AutoGenerateColumns = False
        Me.gvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptNumberDataGridViewTextBoxColumn, Me.TransDateDataGridViewTextBoxColumn, Me.RefDateDataGridViewTextBoxColumn, Me.AdjustmentsDataGridViewTextBoxColumn, Me.ChargeDataGridViewTextBoxColumn, Me.CheckDataGridViewTextBoxColumn, Me.CheckNoDataGridViewTextBoxColumn, Me.CashDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.AuthorizationNoDataGridViewTextBoxColumn, Me.CurrentBalDataGridViewTextBoxColumn, Me.PrevBalDataGridViewTextBoxColumn, Me.WriteOffDataGridViewTextBoxColumn})
        Me.gvTransactions.DataSource = Me.TblTransactionBindingSource
        Me.gvTransactions.Location = New System.Drawing.Point(21, 246)
        Me.gvTransactions.Margin = New System.Windows.Forms.Padding(4)
        Me.gvTransactions.Name = "gvTransactions"
        Me.gvTransactions.ReadOnly = True
        Me.gvTransactions.RowTemplate.Height = 24
        Me.gvTransactions.Size = New System.Drawing.Size(730, 585)
        Me.gvTransactions.TabIndex = 5
        '
        'ReceiptNumberDataGridViewTextBoxColumn
        '
        Me.ReceiptNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ReceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNumber"
        Me.ReceiptNumberDataGridViewTextBoxColumn.HeaderText = "ReceiptNumber"
        Me.ReceiptNumberDataGridViewTextBoxColumn.Name = "ReceiptNumberDataGridViewTextBoxColumn"
        Me.ReceiptNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceiptNumberDataGridViewTextBoxColumn.Width = 131
        '
        'TransDateDataGridViewTextBoxColumn
        '
        Me.TransDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TransDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate"
        Me.TransDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate"
        Me.TransDateDataGridViewTextBoxColumn.Name = "TransDateDataGridViewTextBoxColumn"
        Me.TransDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransDateDataGridViewTextBoxColumn.Width = 138
        '
        'RefDateDataGridViewTextBoxColumn
        '
        Me.RefDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.RefDateDataGridViewTextBoxColumn.DataPropertyName = "RefDate"
        Me.RefDateDataGridViewTextBoxColumn.HeaderText = "ReferenceDate"
        Me.RefDateDataGridViewTextBoxColumn.Name = "RefDateDataGridViewTextBoxColumn"
        Me.RefDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RefDateDataGridViewTextBoxColumn.Width = 129
        '
        'AdjustmentsDataGridViewTextBoxColumn
        '
        Me.AdjustmentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.AdjustmentsDataGridViewTextBoxColumn.DataPropertyName = "Adjustments"
        Me.AdjustmentsDataGridViewTextBoxColumn.HeaderText = "Adjustments"
        Me.AdjustmentsDataGridViewTextBoxColumn.Name = "AdjustmentsDataGridViewTextBoxColumn"
        Me.AdjustmentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdjustmentsDataGridViewTextBoxColumn.Width = 110
        '
        'ChargeDataGridViewTextBoxColumn
        '
        Me.ChargeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ChargeDataGridViewTextBoxColumn.DataPropertyName = "Charge"
        Me.ChargeDataGridViewTextBoxColumn.HeaderText = "Charge"
        Me.ChargeDataGridViewTextBoxColumn.Name = "ChargeDataGridViewTextBoxColumn"
        Me.ChargeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChargeDataGridViewTextBoxColumn.Width = 79
        '
        'CheckDataGridViewTextBoxColumn
        '
        Me.CheckDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CheckDataGridViewTextBoxColumn.DataPropertyName = "Check"
        Me.CheckDataGridViewTextBoxColumn.HeaderText = "Check"
        Me.CheckDataGridViewTextBoxColumn.Name = "CheckDataGridViewTextBoxColumn"
        Me.CheckDataGridViewTextBoxColumn.ReadOnly = True
        Me.CheckDataGridViewTextBoxColumn.Width = 72
        '
        'CheckNoDataGridViewTextBoxColumn
        '
        Me.CheckNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CheckNoDataGridViewTextBoxColumn.DataPropertyName = "CheckNo"
        Me.CheckNoDataGridViewTextBoxColumn.HeaderText = "CheckNo"
        Me.CheckNoDataGridViewTextBoxColumn.Name = "CheckNoDataGridViewTextBoxColumn"
        Me.CheckNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CheckNoDataGridViewTextBoxColumn.Width = 90
        '
        'CashDataGridViewTextBoxColumn
        '
        Me.CashDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CashDataGridViewTextBoxColumn.DataPropertyName = "Cash"
        Me.CashDataGridViewTextBoxColumn.HeaderText = "Cash"
        Me.CashDataGridViewTextBoxColumn.Name = "CashDataGridViewTextBoxColumn"
        Me.CashDataGridViewTextBoxColumn.ReadOnly = True
        Me.CashDataGridViewTextBoxColumn.Width = 65
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 70
        '
        'AuthorizationNoDataGridViewTextBoxColumn
        '
        Me.AuthorizationNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.AuthorizationNoDataGridViewTextBoxColumn.DataPropertyName = "AuthorizationNo"
        Me.AuthorizationNoDataGridViewTextBoxColumn.HeaderText = "AuthorizationNo"
        Me.AuthorizationNoDataGridViewTextBoxColumn.Name = "AuthorizationNoDataGridViewTextBoxColumn"
        Me.AuthorizationNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AuthorizationNoDataGridViewTextBoxColumn.Width = 134
        '
        'CurrentBalDataGridViewTextBoxColumn
        '
        Me.CurrentBalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CurrentBalDataGridViewTextBoxColumn.DataPropertyName = "CurrentBal"
        Me.CurrentBalDataGridViewTextBoxColumn.HeaderText = "CurrentBalance"
        Me.CurrentBalDataGridViewTextBoxColumn.Name = "CurrentBalDataGridViewTextBoxColumn"
        Me.CurrentBalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrentBalDataGridViewTextBoxColumn.Width = 131
        '
        'PrevBalDataGridViewTextBoxColumn
        '
        Me.PrevBalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrevBalDataGridViewTextBoxColumn.DataPropertyName = "PrevBal"
        Me.PrevBalDataGridViewTextBoxColumn.HeaderText = "PrevBalance"
        Me.PrevBalDataGridViewTextBoxColumn.Name = "PrevBalDataGridViewTextBoxColumn"
        Me.PrevBalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrevBalDataGridViewTextBoxColumn.Width = 113
        '
        'WriteOffDataGridViewTextBoxColumn
        '
        Me.WriteOffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.WriteOffDataGridViewTextBoxColumn.DataPropertyName = "WriteOff"
        Me.WriteOffDataGridViewTextBoxColumn.HeaderText = "WriteOff"
        Me.WriteOffDataGridViewTextBoxColumn.Name = "WriteOffDataGridViewTextBoxColumn"
        Me.WriteOffDataGridViewTextBoxColumn.ReadOnly = True
        Me.WriteOffDataGridViewTextBoxColumn.Width = 85
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.KalpaxisDBDataSet10
        '
        'KalpaxisDBDataSet10
        '
        Me.KalpaxisDBDataSet10.DataSetName = "KalpaxisDBDataSet10"
        Me.KalpaxisDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(882, 110)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelephone.MaxLength = 10
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.ReadOnly = True
        Me.txtTelephone.Size = New System.Drawing.Size(148, 23)
        Me.txtTelephone.TabIndex = 2
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(885, 90)
        Me.lblTelephone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(78, 16)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.Text = "Telephone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1028, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Spouse First Name:"
        '
        'txtSpouseFN
        '
        Me.txtSpouseFN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpouseFN.Location = New System.Drawing.Point(1032, 110)
        Me.txtSpouseFN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseFN.MaxLength = 35
        Me.txtSpouseFN.Name = "txtSpouseFN"
        Me.txtSpouseFN.ReadOnly = True
        Me.txtSpouseFN.Size = New System.Drawing.Size(148, 23)
        Me.txtSpouseFN.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1180, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Spouse Last Name:"
        '
        'txtSpouseLN
        '
        Me.txtSpouseLN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpouseLN.Location = New System.Drawing.Point(1181, 110)
        Me.txtSpouseLN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseLN.MaxLength = 35
        Me.txtSpouseLN.Name = "txtSpouseLN"
        Me.txtSpouseLN.ReadOnly = True
        Me.txtSpouseLN.Size = New System.Drawing.Size(140, 23)
        Me.txtSpouseLN.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1321, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Social Security #:"
        '
        'txtSSN
        '
        Me.txtSSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSN.Location = New System.Drawing.Point(1322, 110)
        Me.txtSSN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSSN.MaxLength = 9
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.ReadOnly = True
        Me.txtSSN.Size = New System.Drawing.Size(128, 23)
        Me.txtSSN.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1454, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Drivers License #:"
        '
        'txtDriversLiscense
        '
        Me.txtDriversLiscense.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriversLiscense.Location = New System.Drawing.Point(1453, 110)
        Me.txtDriversLiscense.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDriversLiscense.MaxLength = 8
        Me.txtDriversLiscense.Name = "txtDriversLiscense"
        Me.txtDriversLiscense.ReadOnly = True
        Me.txtDriversLiscense.Size = New System.Drawing.Size(137, 23)
        Me.txtDriversLiscense.TabIndex = 6
        '
        'txtEmployer
        '
        Me.txtEmployer.Location = New System.Drawing.Point(88, 27)
        Me.txtEmployer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployer.MaxLength = 45
        Me.txtEmployer.Name = "txtEmployer"
        Me.txtEmployer.ReadOnly = True
        Me.txtEmployer.Size = New System.Drawing.Size(335, 23)
        Me.txtEmployer.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Employer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "City:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 89)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "State:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 118)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Zip:"
        '
        'txtEmpZip
        '
        Me.txtEmpZip.Location = New System.Drawing.Point(88, 116)
        Me.txtEmpZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpZip.MaxLength = 5
        Me.txtEmpZip.Name = "txtEmpZip"
        Me.txtEmpZip.ReadOnly = True
        Me.txtEmpZip.Size = New System.Drawing.Size(129, 23)
        Me.txtEmpZip.TabIndex = 4
        '
        'gbEmployer
        '
        Me.gbEmployer.BackColor = System.Drawing.Color.Transparent
        Me.gbEmployer.Controls.Add(Me.Label68)
        Me.gbEmployer.Controls.Add(Me.txtEmpAddress)
        Me.gbEmployer.Controls.Add(Me.ddlEmpState)
        Me.gbEmployer.Controls.Add(Me.txtEmpCity)
        Me.gbEmployer.Controls.Add(Me.txtEmpPhone)
        Me.gbEmployer.Controls.Add(Me.Label34)
        Me.gbEmployer.Controls.Add(Me.Label6)
        Me.gbEmployer.Controls.Add(Me.Label8)
        Me.gbEmployer.Controls.Add(Me.Label9)
        Me.gbEmployer.Controls.Add(Me.txtEmpZip)
        Me.gbEmployer.Controls.Add(Me.Label7)
        Me.gbEmployer.Controls.Add(Me.txtEmployer)
        Me.gbEmployer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmployer.Location = New System.Drawing.Point(764, 142)
        Me.gbEmployer.Margin = New System.Windows.Forms.Padding(4)
        Me.gbEmployer.Name = "gbEmployer"
        Me.gbEmployer.Padding = New System.Windows.Forms.Padding(4)
        Me.gbEmployer.Size = New System.Drawing.Size(435, 156)
        Me.gbEmployer.TabIndex = 7
        Me.gbEmployer.TabStop = False
        Me.gbEmployer.Text = "Employer Information"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(16, 59)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(64, 16)
        Me.Label68.TabIndex = 45
        Me.Label68.Text = "Address:"
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(88, 55)
        Me.txtEmpAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpAddress.MaxLength = 100
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.ReadOnly = True
        Me.txtEmpAddress.Size = New System.Drawing.Size(335, 23)
        Me.txtEmpAddress.TabIndex = 1
        '
        'ddlEmpState
        '
        Me.ddlEmpState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmpState.Enabled = False
        Me.ddlEmpState.FormattingEnabled = True
        Me.ddlEmpState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlEmpState.Location = New System.Drawing.Point(289, 84)
        Me.ddlEmpState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlEmpState.Name = "ddlEmpState"
        Me.ddlEmpState.Size = New System.Drawing.Size(136, 24)
        Me.ddlEmpState.TabIndex = 3
        '
        'txtEmpCity
        '
        Me.txtEmpCity.Location = New System.Drawing.Point(88, 84)
        Me.txtEmpCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpCity.MaxLength = 50
        Me.txtEmpCity.Name = "txtEmpCity"
        Me.txtEmpCity.ReadOnly = True
        Me.txtEmpCity.Size = New System.Drawing.Size(129, 23)
        Me.txtEmpCity.TabIndex = 2
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.Location = New System.Drawing.Point(289, 114)
        Me.txtEmpPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpPhone.MaxLength = 11
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.ReadOnly = True
        Me.txtEmpPhone.Size = New System.Drawing.Size(136, 23)
        Me.txtEmpPhone.TabIndex = 5
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(227, 118)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 16)
        Me.Label34.TabIndex = 39
        Me.Label34.Text = "Phone:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 34)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "First Name:"
        '
        'gbNearestRelative
        '
        Me.gbNearestRelative.Controls.Add(Me.Label54)
        Me.gbNearestRelative.Controls.Add(Me.txtNRLastName)
        Me.gbNearestRelative.Controls.Add(Me.Label19)
        Me.gbNearestRelative.Controls.Add(Me.ddlNRState)
        Me.gbNearestRelative.Controls.Add(Me.Label15)
        Me.gbNearestRelative.Controls.Add(Me.txtNRphone)
        Me.gbNearestRelative.Controls.Add(Me.Label11)
        Me.gbNearestRelative.Controls.Add(Me.Label16)
        Me.gbNearestRelative.Controls.Add(Me.Label12)
        Me.gbNearestRelative.Controls.Add(Me.txtNRFirstName)
        Me.gbNearestRelative.Controls.Add(Me.txtNRcity)
        Me.gbNearestRelative.Controls.Add(Me.txtNRAddress)
        Me.gbNearestRelative.Controls.Add(Me.Label13)
        Me.gbNearestRelative.Controls.Add(Me.Label17)
        Me.gbNearestRelative.Controls.Add(Me.Label14)
        Me.gbNearestRelative.Controls.Add(Me.txtNRRelation)
        Me.gbNearestRelative.Controls.Add(Me.txtNRzip)
        Me.gbNearestRelative.Controls.Add(Me.Label18)
        Me.gbNearestRelative.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNearestRelative.Location = New System.Drawing.Point(764, 306)
        Me.gbNearestRelative.Margin = New System.Windows.Forms.Padding(4)
        Me.gbNearestRelative.Name = "gbNearestRelative"
        Me.gbNearestRelative.Padding = New System.Windows.Forms.Padding(4)
        Me.gbNearestRelative.Size = New System.Drawing.Size(440, 202)
        Me.gbNearestRelative.TabIndex = 9
        Me.gbNearestRelative.TabStop = False
        Me.gbNearestRelative.Text = "Nearest Relative Information"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(212, 34)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(79, 16)
        Me.Label54.TabIndex = 53
        Me.Label54.Text = "Last Name:"
        '
        'txtNRLastName
        '
        Me.txtNRLastName.Location = New System.Drawing.Point(293, 30)
        Me.txtNRLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRLastName.MaxLength = 35
        Me.txtNRLastName.Name = "txtNRLastName"
        Me.txtNRLastName.ReadOnly = True
        Me.txtNRLastName.Size = New System.Drawing.Size(129, 23)
        Me.txtNRLastName.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(47, 129)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 16)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "City:"
        '
        'ddlNRState
        '
        Me.ddlNRState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlNRState.Enabled = False
        Me.ddlNRState.FormattingEnabled = True
        Me.ddlNRState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlNRState.Location = New System.Drawing.Point(289, 122)
        Me.ddlNRState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlNRState.Name = "ddlNRState"
        Me.ddlNRState.Size = New System.Drawing.Size(136, 24)
        Me.ddlNRState.TabIndex = 5
        '
        'txtNRphone
        '
        Me.txtNRphone.Location = New System.Drawing.Point(289, 153)
        Me.txtNRphone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRphone.MaxLength = 10
        Me.txtNRphone.Name = "txtNRphone"
        Me.txtNRphone.ReadOnly = True
        Me.txtNRphone.Size = New System.Drawing.Size(136, 23)
        Me.txtNRphone.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 127)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "State:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(-809, -33)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Employer:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(885, 213)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "City:"
        '
        'txtNRFirstName
        '
        Me.txtNRFirstName.Location = New System.Drawing.Point(88, 30)
        Me.txtNRFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRFirstName.MaxLength = 35
        Me.txtNRFirstName.Name = "txtNRFirstName"
        Me.txtNRFirstName.ReadOnly = True
        Me.txtNRFirstName.Size = New System.Drawing.Size(115, 23)
        Me.txtNRFirstName.TabIndex = 0
        '
        'txtNRcity
        '
        Me.txtNRcity.Location = New System.Drawing.Point(88, 122)
        Me.txtNRcity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRcity.MaxLength = 50
        Me.txtNRcity.Name = "txtNRcity"
        Me.txtNRcity.ReadOnly = True
        Me.txtNRcity.Size = New System.Drawing.Size(129, 23)
        Me.txtNRcity.TabIndex = 4
        '
        'txtNRAddress
        '
        Me.txtNRAddress.Location = New System.Drawing.Point(88, 92)
        Me.txtNRAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRAddress.MaxLength = 100
        Me.txtNRAddress.Name = "txtNRAddress"
        Me.txtNRAddress.ReadOnly = True
        Me.txtNRAddress.Size = New System.Drawing.Size(335, 23)
        Me.txtNRAddress.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 156)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Phone:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 69)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Relation:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 156)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 16)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Zip:"
        '
        'txtNRRelation
        '
        Me.txtNRRelation.Location = New System.Drawing.Point(88, 62)
        Me.txtNRRelation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRRelation.Name = "txtNRRelation"
        Me.txtNRRelation.ReadOnly = True
        Me.txtNRRelation.Size = New System.Drawing.Size(335, 23)
        Me.txtNRRelation.TabIndex = 2
        '
        'txtNRzip
        '
        Me.txtNRzip.Location = New System.Drawing.Point(88, 154)
        Me.txtNRzip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNRzip.MaxLength = 5
        Me.txtNRzip.Name = "txtNRzip"
        Me.txtNRzip.ReadOnly = True
        Me.txtNRzip.Size = New System.Drawing.Size(129, 23)
        Me.txtNRzip.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 98)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Address:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 58)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Service:"
        '
        'gbOtherProServices
        '
        Me.gbOtherProServices.Controls.Add(Me.Label22)
        Me.gbOtherProServices.Controls.Add(Me.Label20)
        Me.gbOtherProServices.Controls.Add(Me.ddlProServiceState)
        Me.gbOtherProServices.Controls.Add(Me.Label21)
        Me.gbOtherProServices.Controls.Add(Me.txtProServiceCity)
        Me.gbOtherProServices.Controls.Add(Me.txtProService)
        Me.gbOtherProServices.Controls.Add(Me.txtProServicePhone)
        Me.gbOtherProServices.Controls.Add(Me.txtProServiceZip)
        Me.gbOtherProServices.Controls.Add(Me.Label23)
        Me.gbOtherProServices.Controls.Add(Me.Label35)
        Me.gbOtherProServices.Controls.Add(Me.Label24)
        Me.gbOtherProServices.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOtherProServices.Location = New System.Drawing.Point(1212, 342)
        Me.gbOtherProServices.Margin = New System.Windows.Forms.Padding(4)
        Me.gbOtherProServices.Name = "gbOtherProServices"
        Me.gbOtherProServices.Padding = New System.Windows.Forms.Padding(4)
        Me.gbOtherProServices.Size = New System.Drawing.Size(440, 166)
        Me.gbOtherProServices.TabIndex = 10
        Me.gbOtherProServices.TabStop = False
        Me.gbOtherProServices.Text = "Other Professional Service Used"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(41, 90)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 16)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "City:"
        '
        'ddlProServiceState
        '
        Me.ddlProServiceState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlProServiceState.Enabled = False
        Me.ddlProServiceState.FormattingEnabled = True
        Me.ddlProServiceState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlProServiceState.Location = New System.Drawing.Point(289, 85)
        Me.ddlProServiceState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlProServiceState.Name = "ddlProServiceState"
        Me.ddlProServiceState.Size = New System.Drawing.Size(136, 24)
        Me.ddlProServiceState.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-809, -33)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 16)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Employer:"
        '
        'txtProServiceCity
        '
        Me.txtProServiceCity.Location = New System.Drawing.Point(88, 85)
        Me.txtProServiceCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProServiceCity.MaxLength = 50
        Me.txtProServiceCity.Name = "txtProServiceCity"
        Me.txtProServiceCity.ReadOnly = True
        Me.txtProServiceCity.Size = New System.Drawing.Size(129, 23)
        Me.txtProServiceCity.TabIndex = 1
        '
        'txtProService
        '
        Me.txtProService.Location = New System.Drawing.Point(88, 54)
        Me.txtProService.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProService.Name = "txtProService"
        Me.txtProService.ReadOnly = True
        Me.txtProService.Size = New System.Drawing.Size(335, 23)
        Me.txtProService.TabIndex = 0
        '
        'txtProServicePhone
        '
        Me.txtProServicePhone.Location = New System.Drawing.Point(289, 116)
        Me.txtProServicePhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProServicePhone.MaxLength = 10
        Me.txtProServicePhone.Name = "txtProServicePhone"
        Me.txtProServicePhone.ReadOnly = True
        Me.txtProServicePhone.Size = New System.Drawing.Size(136, 23)
        Me.txtProServicePhone.TabIndex = 4
        '
        'txtProServiceZip
        '
        Me.txtProServiceZip.Location = New System.Drawing.Point(88, 117)
        Me.txtProServiceZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProServiceZip.MaxLength = 5
        Me.txtProServiceZip.Name = "txtProServiceZip"
        Me.txtProServiceZip.ReadOnly = True
        Me.txtProServiceZip.Size = New System.Drawing.Size(129, 23)
        Me.txtProServiceZip.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(227, 119)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 16)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Phone:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(44, 119)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(31, 16)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "Zip:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(227, 90)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "State:"
        '
        'rtbComments
        '
        Me.rtbComments.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbComments.Location = New System.Drawing.Point(766, 792)
        Me.rtbComments.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbComments.MaxLength = 255
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.ReadOnly = True
        Me.rtbComments.Size = New System.Drawing.Size(873, 94)
        Me.rtbComments.TabIndex = 14
        Me.rtbComments.Text = ""
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(768, 773)
        Me.lblComments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(79, 16)
        Me.lblComments.TabIndex = 37
        Me.lblComments.Text = "Comments:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(47, 90)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 16)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "ID #:"
        '
        'gbInsurance
        '
        Me.gbInsurance.Controls.Add(Me.Label64)
        Me.gbInsurance.Controls.Add(Me.txtPriInsName)
        Me.gbInsurance.Controls.Add(Me.Label29)
        Me.gbInsurance.Controls.Add(Me.Label30)
        Me.gbInsurance.Controls.Add(Me.ddlPriInsState)
        Me.gbInsurance.Controls.Add(Me.Label25)
        Me.gbInsurance.Controls.Add(Me.txtPriInsCity)
        Me.gbInsurance.Controls.Add(Me.Label26)
        Me.gbInsurance.Controls.Add(Me.txtPriInsPhone)
        Me.gbInsurance.Controls.Add(Me.txtPriInsID)
        Me.gbInsurance.Controls.Add(Me.Label31)
        Me.gbInsurance.Controls.Add(Me.txtPriInsAddress)
        Me.gbInsurance.Controls.Add(Me.Label32)
        Me.gbInsurance.Controls.Add(Me.Label27)
        Me.gbInsurance.Controls.Add(Me.Label33)
        Me.gbInsurance.Controls.Add(Me.txtPriInsGroupNo)
        Me.gbInsurance.Controls.Add(Me.txtPriInsZip)
        Me.gbInsurance.Controls.Add(Me.Label28)
        Me.gbInsurance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInsurance.Location = New System.Drawing.Point(766, 515)
        Me.gbInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInsurance.Name = "gbInsurance"
        Me.gbInsurance.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInsurance.Size = New System.Drawing.Size(291, 254)
        Me.gbInsurance.TabIndex = 11
        Me.gbInsurance.TabStop = False
        Me.gbInsurance.Text = "Primary Insurance"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(17, 58)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(65, 16)
        Me.Label64.TabIndex = 55
        Me.Label64.Text = "Provider:"
        '
        'txtPriInsName
        '
        Me.txtPriInsName.Location = New System.Drawing.Point(91, 52)
        Me.txtPriInsName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsName.MaxLength = 45
        Me.txtPriInsName.Name = "txtPriInsName"
        Me.txtPriInsName.ReadOnly = True
        Me.txtPriInsName.Size = New System.Drawing.Size(176, 23)
        Me.txtPriInsName.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 188)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 16)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "City:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(13, 30)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(277, 16)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "(Do not need address if MC, MK, or BCBS)"
        '
        'ddlPriInsState
        '
        Me.ddlPriInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPriInsState.Enabled = False
        Me.ddlPriInsState.FormattingEnabled = True
        Me.ddlPriInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlPriInsState.Location = New System.Drawing.Point(201, 181)
        Me.ddlPriInsState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlPriInsState.Name = "ddlPriInsState"
        Me.ddlPriInsState.Size = New System.Drawing.Size(68, 24)
        Me.ddlPriInsState.TabIndex = 5
        '
        'txtPriInsCity
        '
        Me.txtPriInsCity.Location = New System.Drawing.Point(39, 183)
        Me.txtPriInsCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsCity.MaxLength = 50
        Me.txtPriInsCity.Name = "txtPriInsCity"
        Me.txtPriInsCity.ReadOnly = True
        Me.txtPriInsCity.Size = New System.Drawing.Size(111, 23)
        Me.txtPriInsCity.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-809, -33)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 16)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Employer:"
        '
        'txtPriInsPhone
        '
        Me.txtPriInsPhone.Location = New System.Drawing.Point(164, 217)
        Me.txtPriInsPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsPhone.MaxLength = 11
        Me.txtPriInsPhone.Name = "txtPriInsPhone"
        Me.txtPriInsPhone.ReadOnly = True
        Me.txtPriInsPhone.Size = New System.Drawing.Size(105, 23)
        Me.txtPriInsPhone.TabIndex = 7
        '
        'txtPriInsID
        '
        Me.txtPriInsID.Location = New System.Drawing.Point(91, 84)
        Me.txtPriInsID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsID.MaxLength = 15
        Me.txtPriInsID.Name = "txtPriInsID"
        Me.txtPriInsID.ReadOnly = True
        Me.txtPriInsID.Size = New System.Drawing.Size(176, 23)
        Me.txtPriInsID.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(109, 220)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 16)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "Phone:"
        '
        'txtPriInsAddress
        '
        Me.txtPriInsAddress.Location = New System.Drawing.Point(91, 146)
        Me.txtPriInsAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsAddress.MaxLength = 100
        Me.txtPriInsAddress.Name = "txtPriInsAddress"
        Me.txtPriInsAddress.ReadOnly = True
        Me.txtPriInsAddress.Size = New System.Drawing.Size(176, 23)
        Me.txtPriInsAddress.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(157, 186)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 16)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "State:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(19, 119)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Group #:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 220)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 16)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Zip:"
        '
        'txtPriInsGroupNo
        '
        Me.txtPriInsGroupNo.Location = New System.Drawing.Point(91, 116)
        Me.txtPriInsGroupNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsGroupNo.MaxLength = 15
        Me.txtPriInsGroupNo.Name = "txtPriInsGroupNo"
        Me.txtPriInsGroupNo.ReadOnly = True
        Me.txtPriInsGroupNo.Size = New System.Drawing.Size(176, 23)
        Me.txtPriInsGroupNo.TabIndex = 2
        '
        'txtPriInsZip
        '
        Me.txtPriInsZip.Location = New System.Drawing.Point(39, 217)
        Me.txtPriInsZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriInsZip.MaxLength = 5
        Me.txtPriInsZip.Name = "txtPriInsZip"
        Me.txtPriInsZip.ReadOnly = True
        Me.txtPriInsZip.Size = New System.Drawing.Size(67, 23)
        Me.txtPriInsZip.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 149)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 16)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Address:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label67)
        Me.GroupBox3.Controls.Add(Me.txtSpouseEmpAddress)
        Me.GroupBox3.Controls.Add(Me.Label63)
        Me.GroupBox3.Controls.Add(Me.ddlSpouseGender)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtSpouseEmp)
        Me.GroupBox3.Controls.Add(Me.ddlSpouseEmpState)
        Me.GroupBox3.Controls.Add(Me.txtSpouseEmpCity)
        Me.GroupBox3.Controls.Add(Me.txtSpouseEmpPhone)
        Me.GroupBox3.Controls.Add(Me.Label57)
        Me.GroupBox3.Controls.Add(Me.Label58)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.txtSpouseEmpZip)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1209, 142)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(440, 192)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Spouse Information"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(15, 95)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(64, 16)
        Me.Label67.TabIndex = 49
        Me.Label67.Text = "Address:"
        '
        'txtSpouseEmpAddress
        '
        Me.txtSpouseEmpAddress.Location = New System.Drawing.Point(91, 89)
        Me.txtSpouseEmpAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseEmpAddress.MaxLength = 100
        Me.txtSpouseEmpAddress.Name = "txtSpouseEmpAddress"
        Me.txtSpouseEmpAddress.ReadOnly = True
        Me.txtSpouseEmpAddress.Size = New System.Drawing.Size(335, 23)
        Me.txtSpouseEmpAddress.TabIndex = 2
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(23, 37)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(60, 16)
        Me.Label63.TabIndex = 47
        Me.Label63.Text = "Gender:"
        '
        'ddlSpouseGender
        '
        Me.ddlSpouseGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSpouseGender.Enabled = False
        Me.ddlSpouseGender.FormattingEnabled = True
        Me.ddlSpouseGender.Items.AddRange(New Object() {"M", "F"})
        Me.ddlSpouseGender.Location = New System.Drawing.Point(91, 27)
        Me.ddlSpouseGender.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSpouseGender.Name = "ddlSpouseGender"
        Me.ddlSpouseGender.Size = New System.Drawing.Size(333, 24)
        Me.ddlSpouseGender.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 123)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "City:"
        '
        'txtSpouseEmp
        '
        Me.txtSpouseEmp.Location = New System.Drawing.Point(91, 60)
        Me.txtSpouseEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseEmp.MaxLength = 45
        Me.txtSpouseEmp.Name = "txtSpouseEmp"
        Me.txtSpouseEmp.ReadOnly = True
        Me.txtSpouseEmp.Size = New System.Drawing.Size(335, 23)
        Me.txtSpouseEmp.TabIndex = 1
        '
        'ddlSpouseEmpState
        '
        Me.ddlSpouseEmpState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSpouseEmpState.Enabled = False
        Me.ddlSpouseEmpState.FormattingEnabled = True
        Me.ddlSpouseEmpState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlSpouseEmpState.Location = New System.Drawing.Point(292, 118)
        Me.ddlSpouseEmpState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSpouseEmpState.Name = "ddlSpouseEmpState"
        Me.ddlSpouseEmpState.Size = New System.Drawing.Size(136, 24)
        Me.ddlSpouseEmpState.TabIndex = 4
        '
        'txtSpouseEmpCity
        '
        Me.txtSpouseEmpCity.Location = New System.Drawing.Point(91, 118)
        Me.txtSpouseEmpCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseEmpCity.MaxLength = 50
        Me.txtSpouseEmpCity.Name = "txtSpouseEmpCity"
        Me.txtSpouseEmpCity.ReadOnly = True
        Me.txtSpouseEmpCity.Size = New System.Drawing.Size(129, 23)
        Me.txtSpouseEmpCity.TabIndex = 3
        '
        'txtSpouseEmpPhone
        '
        Me.txtSpouseEmpPhone.Location = New System.Drawing.Point(292, 149)
        Me.txtSpouseEmpPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseEmpPhone.MaxLength = 11
        Me.txtSpouseEmpPhone.Name = "txtSpouseEmpPhone"
        Me.txtSpouseEmpPhone.ReadOnly = True
        Me.txtSpouseEmpPhone.Size = New System.Drawing.Size(136, 23)
        Me.txtSpouseEmpPhone.TabIndex = 6
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(229, 153)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(53, 16)
        Me.Label57.TabIndex = 39
        Me.Label57.Text = "Phone:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(12, 65)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(71, 16)
        Me.Label58.TabIndex = 17
        Me.Label58.Text = "Employer:"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(229, 123)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(45, 16)
        Me.Label59.TabIndex = 19
        Me.Label59.Text = "State:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(51, 153)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(31, 16)
        Me.Label60.TabIndex = 20
        Me.Label60.Text = "Zip:"
        '
        'txtSpouseEmpZip
        '
        Me.txtSpouseEmpZip.Location = New System.Drawing.Point(91, 150)
        Me.txtSpouseEmpZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSpouseEmpZip.MaxLength = 5
        Me.txtSpouseEmpZip.Name = "txtSpouseEmpZip"
        Me.txtSpouseEmpZip.ReadOnly = True
        Me.txtSpouseEmpZip.Size = New System.Drawing.Size(129, 23)
        Me.txtSpouseEmpZip.TabIndex = 5
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(17, 39)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(42, 16)
        Me.Label55.TabIndex = 46
        Me.Label55.Text = "DOB:"
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(64, 36)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(88, 23)
        Me.txtDOB.TabIndex = 0
        '
        'gbSecondaryInsurance
        '
        Me.gbSecondaryInsurance.Controls.Add(Me.Label65)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsName)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label36)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label37)
        Me.gbSecondaryInsurance.Controls.Add(Me.ddlSecInsState)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label38)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsCity)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label39)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsPhone)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsID)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label40)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsAddress)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label41)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label42)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label43)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsGroupNo)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsZip)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label44)
        Me.gbSecondaryInsurance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSecondaryInsurance.Location = New System.Drawing.Point(1065, 515)
        Me.gbSecondaryInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSecondaryInsurance.Name = "gbSecondaryInsurance"
        Me.gbSecondaryInsurance.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSecondaryInsurance.Size = New System.Drawing.Size(291, 254)
        Me.gbSecondaryInsurance.TabIndex = 12
        Me.gbSecondaryInsurance.TabStop = False
        Me.gbSecondaryInsurance.Text = "Secondary Insurance"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(17, 58)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(65, 16)
        Me.Label65.TabIndex = 56
        Me.Label65.Text = "Provider:"
        '
        'txtSecInsName
        '
        Me.txtSecInsName.Location = New System.Drawing.Point(93, 52)
        Me.txtSecInsName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsName.MaxLength = 45
        Me.txtSecInsName.Name = "txtSecInsName"
        Me.txtSecInsName.ReadOnly = True
        Me.txtSecInsName.Size = New System.Drawing.Size(176, 23)
        Me.txtSecInsName.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(5, 188)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 16)
        Me.Label36.TabIndex = 53
        Me.Label36.Text = "City:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(13, 30)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(277, 16)
        Me.Label37.TabIndex = 34
        Me.Label37.Text = "(Do not need address if MC, MK, or BCBS)"
        '
        'ddlSecInsState
        '
        Me.ddlSecInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSecInsState.Enabled = False
        Me.ddlSecInsState.FormattingEnabled = True
        Me.ddlSecInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlSecInsState.Location = New System.Drawing.Point(201, 181)
        Me.ddlSecInsState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSecInsState.Name = "ddlSecInsState"
        Me.ddlSecInsState.Size = New System.Drawing.Size(68, 24)
        Me.ddlSecInsState.TabIndex = 5
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(47, 90)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(37, 16)
        Me.Label38.TabIndex = 18
        Me.Label38.Text = "ID #:"
        '
        'txtSecInsCity
        '
        Me.txtSecInsCity.Location = New System.Drawing.Point(39, 183)
        Me.txtSecInsCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsCity.MaxLength = 50
        Me.txtSecInsCity.Name = "txtSecInsCity"
        Me.txtSecInsCity.ReadOnly = True
        Me.txtSecInsCity.Size = New System.Drawing.Size(111, 23)
        Me.txtSecInsCity.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(-809, -33)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 16)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "Employer:"
        '
        'txtSecInsPhone
        '
        Me.txtSecInsPhone.Location = New System.Drawing.Point(164, 217)
        Me.txtSecInsPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsPhone.MaxLength = 11
        Me.txtSecInsPhone.Name = "txtSecInsPhone"
        Me.txtSecInsPhone.ReadOnly = True
        Me.txtSecInsPhone.Size = New System.Drawing.Size(105, 23)
        Me.txtSecInsPhone.TabIndex = 7
        '
        'txtSecInsID
        '
        Me.txtSecInsID.Location = New System.Drawing.Point(91, 84)
        Me.txtSecInsID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsID.MaxLength = 15
        Me.txtSecInsID.Name = "txtSecInsID"
        Me.txtSecInsID.ReadOnly = True
        Me.txtSecInsID.Size = New System.Drawing.Size(176, 23)
        Me.txtSecInsID.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(109, 220)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 16)
        Me.Label40.TabIndex = 49
        Me.Label40.Text = "Phone:"
        '
        'txtSecInsAddress
        '
        Me.txtSecInsAddress.Location = New System.Drawing.Point(91, 146)
        Me.txtSecInsAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsAddress.MaxLength = 100
        Me.txtSecInsAddress.Name = "txtSecInsAddress"
        Me.txtSecInsAddress.ReadOnly = True
        Me.txtSecInsAddress.Size = New System.Drawing.Size(176, 23)
        Me.txtSecInsAddress.TabIndex = 3
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(157, 186)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(45, 16)
        Me.Label41.TabIndex = 46
        Me.Label41.Text = "State:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(19, 119)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(64, 16)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Group #:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 218)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(31, 16)
        Me.Label43.TabIndex = 47
        Me.Label43.Text = "Zip:"
        '
        'txtSecInsGroupNo
        '
        Me.txtSecInsGroupNo.Location = New System.Drawing.Point(91, 116)
        Me.txtSecInsGroupNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsGroupNo.MaxLength = 15
        Me.txtSecInsGroupNo.Name = "txtSecInsGroupNo"
        Me.txtSecInsGroupNo.ReadOnly = True
        Me.txtSecInsGroupNo.Size = New System.Drawing.Size(176, 23)
        Me.txtSecInsGroupNo.TabIndex = 2
        '
        'txtSecInsZip
        '
        Me.txtSecInsZip.Location = New System.Drawing.Point(39, 215)
        Me.txtSecInsZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecInsZip.MaxLength = 5
        Me.txtSecInsZip.Name = "txtSecInsZip"
        Me.txtSecInsZip.ReadOnly = True
        Me.txtSecInsZip.Size = New System.Drawing.Size(67, 23)
        Me.txtSecInsZip.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(15, 149)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(64, 16)
        Me.Label44.TabIndex = 29
        Me.Label44.Text = "Address:"
        '
        'gbTertiaryInsurance
        '
        Me.gbTertiaryInsurance.Controls.Add(Me.Label66)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsName)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label45)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label46)
        Me.gbTertiaryInsurance.Controls.Add(Me.ddlTerInsState)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label47)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsCity)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label48)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsPhone)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsID)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label49)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsAddress)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label50)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label51)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label52)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsGroupNo)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsZip)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label53)
        Me.gbTertiaryInsurance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTertiaryInsurance.Location = New System.Drawing.Point(1364, 514)
        Me.gbTertiaryInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.gbTertiaryInsurance.Name = "gbTertiaryInsurance"
        Me.gbTertiaryInsurance.Padding = New System.Windows.Forms.Padding(4)
        Me.gbTertiaryInsurance.Size = New System.Drawing.Size(291, 254)
        Me.gbTertiaryInsurance.TabIndex = 13
        Me.gbTertiaryInsurance.TabStop = False
        Me.gbTertiaryInsurance.Text = "Tertiary Insurance"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(16, 57)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(65, 16)
        Me.Label66.TabIndex = 57
        Me.Label66.Text = "Provider:"
        '
        'txtTerInsName
        '
        Me.txtTerInsName.Location = New System.Drawing.Point(89, 53)
        Me.txtTerInsName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsName.MaxLength = 45
        Me.txtTerInsName.Name = "txtTerInsName"
        Me.txtTerInsName.ReadOnly = True
        Me.txtTerInsName.Size = New System.Drawing.Size(176, 23)
        Me.txtTerInsName.TabIndex = 0
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(4, 187)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(36, 16)
        Me.Label45.TabIndex = 53
        Me.Label45.Text = "City:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(13, 30)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(277, 16)
        Me.Label46.TabIndex = 34
        Me.Label46.Text = "(Do not need address if MC, MK, or BCBS)"
        '
        'ddlTerInsState
        '
        Me.ddlTerInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTerInsState.Enabled = False
        Me.ddlTerInsState.FormattingEnabled = True
        Me.ddlTerInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ddlTerInsState.Location = New System.Drawing.Point(201, 180)
        Me.ddlTerInsState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlTerInsState.Name = "ddlTerInsState"
        Me.ddlTerInsState.Size = New System.Drawing.Size(68, 24)
        Me.ddlTerInsState.TabIndex = 5
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(45, 89)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(37, 16)
        Me.Label47.TabIndex = 18
        Me.Label47.Text = "ID #:"
        '
        'txtTerInsCity
        '
        Me.txtTerInsCity.Location = New System.Drawing.Point(37, 182)
        Me.txtTerInsCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsCity.MaxLength = 50
        Me.txtTerInsCity.Name = "txtTerInsCity"
        Me.txtTerInsCity.ReadOnly = True
        Me.txtTerInsCity.Size = New System.Drawing.Size(111, 23)
        Me.txtTerInsCity.TabIndex = 4
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(-809, -33)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(71, 16)
        Me.Label48.TabIndex = 27
        Me.Label48.Text = "Employer:"
        '
        'txtTerInsPhone
        '
        Me.txtTerInsPhone.Location = New System.Drawing.Point(163, 215)
        Me.txtTerInsPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsPhone.MaxLength = 11
        Me.txtTerInsPhone.Name = "txtTerInsPhone"
        Me.txtTerInsPhone.ReadOnly = True
        Me.txtTerInsPhone.Size = New System.Drawing.Size(105, 23)
        Me.txtTerInsPhone.TabIndex = 7
        '
        'txtTerInsID
        '
        Me.txtTerInsID.Location = New System.Drawing.Point(89, 82)
        Me.txtTerInsID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsID.MaxLength = 15
        Me.txtTerInsID.Name = "txtTerInsID"
        Me.txtTerInsID.ReadOnly = True
        Me.txtTerInsID.Size = New System.Drawing.Size(176, 23)
        Me.txtTerInsID.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(108, 219)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(53, 16)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "Phone:"
        '
        'txtTerInsAddress
        '
        Me.txtTerInsAddress.Location = New System.Drawing.Point(89, 145)
        Me.txtTerInsAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsAddress.MaxLength = 100
        Me.txtTerInsAddress.Name = "txtTerInsAddress"
        Me.txtTerInsAddress.ReadOnly = True
        Me.txtTerInsAddress.Size = New System.Drawing.Size(176, 23)
        Me.txtTerInsAddress.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(156, 185)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(45, 16)
        Me.Label50.TabIndex = 46
        Me.Label50.Text = "State:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(17, 118)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(64, 16)
        Me.Label51.TabIndex = 28
        Me.Label51.Text = "Group #:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(7, 217)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(31, 16)
        Me.Label52.TabIndex = 47
        Me.Label52.Text = "Zip:"
        '
        'txtTerInsGroupNo
        '
        Me.txtTerInsGroupNo.Location = New System.Drawing.Point(89, 114)
        Me.txtTerInsGroupNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsGroupNo.MaxLength = 15
        Me.txtTerInsGroupNo.Name = "txtTerInsGroupNo"
        Me.txtTerInsGroupNo.ReadOnly = True
        Me.txtTerInsGroupNo.Size = New System.Drawing.Size(176, 23)
        Me.txtTerInsGroupNo.TabIndex = 2
        '
        'txtTerInsZip
        '
        Me.txtTerInsZip.Location = New System.Drawing.Point(37, 214)
        Me.txtTerInsZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerInsZip.MaxLength = 5
        Me.txtTerInsZip.Name = "txtTerInsZip"
        Me.txtTerInsZip.ReadOnly = True
        Me.txtTerInsZip.Size = New System.Drawing.Size(67, 23)
        Me.txtTerInsZip.TabIndex = 6
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(13, 148)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(64, 16)
        Me.Label53.TabIndex = 29
        Me.Label53.Text = "Address:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(530, 841)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(115, 16)
        Me.Label56.TabIndex = 55
        Me.Label56.Text = "Current Balance:"
        '
        'txtTotalCurrentBalance
        '
        Me.txtTotalCurrentBalance.Location = New System.Drawing.Point(651, 837)
        Me.txtTotalCurrentBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCurrentBalance.Name = "txtTotalCurrentBalance"
        Me.txtTotalCurrentBalance.ReadOnly = True
        Me.txtTotalCurrentBalance.Size = New System.Drawing.Size(103, 22)
        Me.txtTotalCurrentBalance.TabIndex = 15
        Me.txtTotalCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Save
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1536, 6)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(53, 49)
        Me.btnSave.TabIndex = 16
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Edi
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1376, 6)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(53, 49)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Cancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1459, 6)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(53, 49)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(1609, 6)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(53, 49)
        Me.btnHome.TabIndex = 17
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(764, 92)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(60, 16)
        Me.Label62.TabIndex = 64
        Me.Label62.Text = "Gender:"
        '
        'ddlGender
        '
        Me.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlGender.Enabled = False
        Me.ddlGender.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ddlGender.FormattingEnabled = True
        Me.ddlGender.Items.AddRange(New Object() {"--", "M", "F"})
        Me.ddlGender.Location = New System.Drawing.Point(764, 110)
        Me.ddlGender.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlGender.Name = "ddlGender"
        Me.ddlGender.Size = New System.Drawing.Size(119, 24)
        Me.ddlGender.TabIndex = 1
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(1592, 110)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.MaxLength = 8
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(56, 23)
        Me.txtPatientID.TabIndex = 65
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(1589, 90)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(73, 16)
        Me.Label61.TabIndex = 66
        Me.Label61.Text = "Patient ID:"
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.Location = New System.Drawing.Point(627, 209)
        Me.btnAddTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(124, 28)
        Me.btnAddTransaction.TabIndex = 67
        Me.btnAddTransaction.Text = "Add Transaction"
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(21, 68)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(68, 21)
        Me.chkActive.TabIndex = 68
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        Me.chkActive.Visible = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientIDToolStripLabel, Me.PatientIDToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1682, 27)
        Me.FillByToolStrip.TabIndex = 69
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'PatientIDToolStripLabel
        '
        Me.PatientIDToolStripLabel.Name = "PatientIDToolStripLabel"
        Me.PatientIDToolStripLabel.Size = New System.Drawing.Size(73, 24)
        Me.PatientIDToolStripLabel.Text = "PatientID:"
        '
        'PatientIDToolStripTextBox
        '
        Me.PatientIDToolStripTextBox.Name = "PatientIDToolStripTextBox"
        Me.PatientIDToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(1469, 59)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(56, 17)
        Me.Label69.TabIndex = 70
        Me.Label69.Text = "Close"
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(1543, 59)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(42, 27)
        Me.Label70.TabIndex = 71
        Me.Label70.Text = "Save"
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(1612, 59)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(50, 27)
        Me.Label71.TabIndex = 72
        Me.Label71.Text = "Home"
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(1385, 59)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(44, 17)
        Me.Label72.TabIndex = 73
        Me.Label72.Text = "Edit"
        '
        'KalpaxisDBDataSet9
        '
        Me.KalpaxisDBDataSet9.DataSetName = "KalpaxisDBDataSet9"
        Me.KalpaxisDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInsuranceTableAdapter
        '
        Me.TblInsuranceTableAdapter.ClearBeforeFill = True
        '
        'TblInsuranceTableAdapter1
        '
        Me.TblInsuranceTableAdapter1.ClearBeforeFill = True
        '
        'TblInsuranceBindingSource
        '
        Me.TblInsuranceBindingSource.DataMember = "tblInsurance"
        '
        'ddlPatState
        '
        Me.ddlPatState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPatState.Enabled = False
        Me.ddlPatState.ForeColor = System.Drawing.Color.Black
        Me.ddlPatState.FormattingEnabled = True
        Me.ddlPatState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlPatState.Location = New System.Drawing.Point(408, 153)
        Me.ddlPatState.Name = "ddlPatState"
        Me.ddlPatState.Size = New System.Drawing.Size(52, 24)
        Me.ddlPatState.TabIndex = 78
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(208, 131)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(64, 17)
        Me.Label73.TabIndex = 81
        Me.Label73.Text = "Address:"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(360, 159)
        Me.Label74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(45, 17)
        Me.Label74.TabIndex = 83
        Me.Label74.Text = "State:"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(237, 156)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(35, 17)
        Me.Label75.TabIndex = 85
        Me.Label75.Text = "City:"
        '
        'txtPatFN
        '
        Me.txtPatFN.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatFN.Enabled = False
        Me.txtPatFN.Location = New System.Drawing.Point(281, 68)
        Me.txtPatFN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatFN.MaxLength = 35
        Me.txtPatFN.Name = "txtPatFN"
        Me.txtPatFN.Size = New System.Drawing.Size(288, 22)
        Me.txtPatFN.TabIndex = 74
        '
        'txtPatAddress
        '
        Me.txtPatAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatAddress.Enabled = False
        Me.txtPatAddress.Location = New System.Drawing.Point(281, 128)
        Me.txtPatAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatAddress.MaxLength = 100
        Me.txtPatAddress.Name = "txtPatAddress"
        Me.txtPatAddress.Size = New System.Drawing.Size(288, 22)
        Me.txtPatAddress.TabIndex = 76
        '
        'txtPatCity
        '
        Me.txtPatCity.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatCity.Enabled = False
        Me.txtPatCity.Location = New System.Drawing.Point(281, 153)
        Me.txtPatCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatCity.MaxLength = 45
        Me.txtPatCity.Name = "txtPatCity"
        Me.txtPatCity.Size = New System.Drawing.Size(79, 22)
        Me.txtPatCity.TabIndex = 77
        '
        'txtPatZip
        '
        Me.txtPatZip.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatZip.Enabled = False
        Me.txtPatZip.Location = New System.Drawing.Point(494, 153)
        Me.txtPatZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatZip.MaxLength = 5
        Me.txtPatZip.Name = "txtPatZip"
        Me.txtPatZip.Size = New System.Drawing.Size(75, 22)
        Me.txtPatZip.TabIndex = 79
        '
        'txtPatLN
        '
        Me.txtPatLN.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatLN.Enabled = False
        Me.txtPatLN.Location = New System.Drawing.Point(281, 93)
        Me.txtPatLN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatLN.MaxLength = 35
        Me.txtPatLN.Name = "txtPatLN"
        Me.txtPatLN.Size = New System.Drawing.Size(288, 22)
        Me.txtPatLN.TabIndex = 75
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(192, 71)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(80, 17)
        Me.Label76.TabIndex = 80
        Me.Label76.Text = "First Name:"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(193, 96)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(80, 17)
        Me.Label77.TabIndex = 84
        Me.Label77.Text = "Last Name:"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(467, 158)
        Me.Label78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(32, 17)
        Me.Label78.TabIndex = 82
        Me.Label78.Text = "Zip:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(86, 202)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 86
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'PatientLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1682, 895)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.ddlPatState)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.txtPatFN)
        Me.Controls.Add(Me.txtPatAddress)
        Me.Controls.Add(Me.txtPatCity)
        Me.Controls.Add(Me.txtPatZip)
        Me.Controls.Add(Me.txtPatLN)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.btnAddTransaction)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.ddlGender)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.txtTotalCurrentBalance)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.gbTertiaryInsurance)
        Me.Controls.Add(Me.gbSecondaryInsurance)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbInsurance)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.rtbComments)
        Me.Controls.Add(Me.gbOtherProServices)
        Me.Controls.Add(Me.gbNearestRelative)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDriversLiscense)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSpouseLN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSpouseFN)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.gvTransactions)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblFirstLast)
        Me.Controls.Add(Me.lblLASTFIRST)
        Me.Controls.Add(Me.gbEmployer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Ledger"
        CType(Me.gvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmployer.ResumeLayout(False)
        Me.gbEmployer.PerformLayout()
        Me.gbNearestRelative.ResumeLayout(False)
        Me.gbNearestRelative.PerformLayout()
        Me.gbOtherProServices.ResumeLayout(False)
        Me.gbOtherProServices.PerformLayout()
        Me.gbInsurance.ResumeLayout(False)
        Me.gbInsurance.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbSecondaryInsurance.ResumeLayout(False)
        Me.gbSecondaryInsurance.PerformLayout()
        Me.gbTertiaryInsurance.ResumeLayout(False)
        Me.gbTertiaryInsurance.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.KalpaxisDBDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLASTFIRST As System.Windows.Forms.Label
    Friend WithEvents lblFirstLast As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCityStateZip As System.Windows.Forms.Label
    Friend WithEvents gvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSpouseFN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSpouseLN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDriversLiscense As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmpZip As System.Windows.Forms.TextBox
    Friend WithEvents gbEmployer As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbNearestRelative As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNRFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtNRAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNRRelation As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gbOtherProServices As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtProService As System.Windows.Forms.TextBox
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gbInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPriInsID As System.Windows.Forms.TextBox
    Friend WithEvents txtPriInsAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtPriInsGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtEmpCity As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents ddlEmpState As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtNRLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ddlNRState As System.Windows.Forms.ComboBox
    Friend WithEvents txtNRphone As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNRcity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNRzip As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ddlProServiceState As System.Windows.Forms.ComboBox
    Friend WithEvents txtProServiceCity As System.Windows.Forms.TextBox
    Friend WithEvents txtProServicePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtProServiceZip As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ddlPriInsState As System.Windows.Forms.ComboBox
    Friend WithEvents txtPriInsCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPriInsPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtPriInsZip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSpouseEmp As System.Windows.Forms.TextBox
    Friend WithEvents ddlSpouseEmpState As System.Windows.Forms.ComboBox
    Friend WithEvents txtSpouseEmpCity As System.Windows.Forms.TextBox
    Friend WithEvents txtSpouseEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtSpouseEmpZip As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents gbSecondaryInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ddlSecInsState As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsCity As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsID As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsZip As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents gbTertiaryInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ddlTerInsState As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsCity As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsID As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsZip As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents ddlSpouseGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtPriInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtSpouseEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents ddlGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents btnAddTransaction As System.Windows.Forms.Button
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents KalpaxisDBDataSet10 As DaySheetTest.KalpaxisDBDataSet10
    Friend WithEvents TblTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTransactionTableAdapter As DaySheetTest.KalpaxisDBDataSet10TableAdapters.tblTransactionTableAdapter
    Friend WithEvents ReceiptNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdjustmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorizationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentBalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrevBalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WriteOffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PatientIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PatientIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents KalpaxisDBDataSet9 As DaySheetTest.KalpaxisDBDataSet9
    Friend WithEvents TblInsuranceTableAdapter As DaySheetTest.KalpaxisDBDataSet7TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents TblInsuranceTableAdapter1 As DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents TblInsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ddlPatState As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txtPatFN As System.Windows.Forms.TextBox
    Friend WithEvents txtPatAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPatCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPatZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPatLN As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button

End Class
