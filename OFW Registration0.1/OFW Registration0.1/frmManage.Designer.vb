<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManage
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
        Me.components = New System.ComponentModel.Container
        Dim A_houseNumLabel As System.Windows.Forms.Label
        Dim A_lotNumLabel As System.Windows.Forms.Label
        Dim A_blockNumLabel As System.Windows.Forms.Label
        Dim A_phaseNumLabel As System.Windows.Forms.Label
        Dim A_streetLabel As System.Windows.Forms.Label
        Dim A_subLabel As System.Windows.Forms.Label
        Dim A_brgyLabel As System.Windows.Forms.Label
        Dim A_cityLabel As System.Windows.Forms.Label
        Dim A_provLabel As System.Windows.Forms.Label
        Dim A_zipcodeLabel As System.Windows.Forms.Label
        Dim C_nameLabel As System.Windows.Forms.Label
        Dim C_addressLabel As System.Windows.Forms.Label
        Dim C_telephoneLabel As System.Windows.Forms.Label
        Dim C_countryLabel As System.Windows.Forms.Label
        Dim C_positionLabel As System.Windows.Forms.Label
        Dim C_salaryLabel As System.Windows.Forms.Label
        Dim C_contractLabel As System.Windows.Forms.Label
        Dim C_agencyLabel As System.Windows.Forms.Label
        Dim B_name1Label As System.Windows.Forms.Label
        Dim B_relationship1Label As System.Windows.Forms.Label
        Dim B_bdate1Label As System.Windows.Forms.Label
        Dim B_address1Label As System.Windows.Forms.Label
        Dim B_contact1Label As System.Windows.Forms.Label
        Dim B_email1Label As System.Windows.Forms.Label
        Dim B_name2Label As System.Windows.Forms.Label
        Dim B_relationship2Label As System.Windows.Forms.Label
        Dim B_bdate2Label As System.Windows.Forms.Label
        Dim B_address2Label As System.Windows.Forms.Label
        Dim B_contact2Label As System.Windows.Forms.Label
        Dim B_email2Label As System.Windows.Forms.Label
        Dim B_name3Label As System.Windows.Forms.Label
        Dim B_relationship3Label As System.Windows.Forms.Label
        Dim B_bdate3Label As System.Windows.Forms.Label
        Dim B_address3Label As System.Windows.Forms.Label
        Dim B_contact3Label As System.Windows.Forms.Label
        Dim B_email3Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManage))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblSearch = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnFilter = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PersonalDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OFWRegistrationDataSet = New OFW_Registration0._1.OFWRegistrationDataSet
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.grpBeneficiary = New System.Windows.Forms.GroupBox
        Me.B_name1TextBox = New System.Windows.Forms.TextBox
        Me.BeneficiariesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_relationship1TextBox = New System.Windows.Forms.TextBox
        Me.B_bdate1DateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.B_address1TextBox = New System.Windows.Forms.TextBox
        Me.B_contact1TextBox = New System.Windows.Forms.TextBox
        Me.B_email1TextBox = New System.Windows.Forms.TextBox
        Me.B_name2TextBox = New System.Windows.Forms.TextBox
        Me.B_relationship2TextBox = New System.Windows.Forms.TextBox
        Me.B_bdate2DateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.B_address2TextBox = New System.Windows.Forms.TextBox
        Me.B_contact2TextBox = New System.Windows.Forms.TextBox
        Me.B_email2TextBox = New System.Windows.Forms.TextBox
        Me.B_name3TextBox = New System.Windows.Forms.TextBox
        Me.B_relationship3TextBox = New System.Windows.Forms.TextBox
        Me.B_bdate3DateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.B_address3TextBox = New System.Windows.Forms.TextBox
        Me.B_contact3TextBox = New System.Windows.Forms.TextBox
        Me.B_email3TextBox = New System.Windows.Forms.TextBox
        Me.grpContract = New System.Windows.Forms.GroupBox
        Me.C_nameTextBox = New System.Windows.Forms.TextBox
        Me.ContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C_addressTextBox = New System.Windows.Forms.TextBox
        Me.C_telephoneTextBox = New System.Windows.Forms.TextBox
        Me.C_countryTextBox = New System.Windows.Forms.TextBox
        Me.C_positionTextBox = New System.Windows.Forms.TextBox
        Me.C_salaryTextBox = New System.Windows.Forms.TextBox
        Me.C_contractTextBox = New System.Windows.Forms.TextBox
        Me.C_agencyTextBox = New System.Windows.Forms.TextBox
        Me.grpAddress = New System.Windows.Forms.GroupBox
        Me.R_dateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.A_zipcodeTextBox = New System.Windows.Forms.TextBox
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.A_houseNumTextBox = New System.Windows.Forms.TextBox
        Me.A_provTextBox = New System.Windows.Forms.TextBox
        Me.A_lotNumTextBox = New System.Windows.Forms.TextBox
        Me.A_cityTextBox = New System.Windows.Forms.TextBox
        Me.A_blockNumTextBox = New System.Windows.Forms.TextBox
        Me.A_brgyTextBox = New System.Windows.Forms.TextBox
        Me.A_phaseNumTextBox = New System.Windows.Forms.TextBox
        Me.A_subTextBox = New System.Windows.Forms.TextBox
        Me.A_streetTextBox = New System.Windows.Forms.TextBox
        Me.PersonalTableAdapter = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.PersonalTableAdapter
        Me.TableAdapterManager = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.TableAdapterManager
        Me.AddressTableAdapter = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.AddressTableAdapter
        Me.BeneficiariesTableAdapter = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.BeneficiariesTableAdapter
        Me.ContractTableAdapter = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.ContractTableAdapter
        Me.RegistrationTableAdapter = New OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.RegistrationTableAdapter
        A_houseNumLabel = New System.Windows.Forms.Label
        A_lotNumLabel = New System.Windows.Forms.Label
        A_blockNumLabel = New System.Windows.Forms.Label
        A_phaseNumLabel = New System.Windows.Forms.Label
        A_streetLabel = New System.Windows.Forms.Label
        A_subLabel = New System.Windows.Forms.Label
        A_brgyLabel = New System.Windows.Forms.Label
        A_cityLabel = New System.Windows.Forms.Label
        A_provLabel = New System.Windows.Forms.Label
        A_zipcodeLabel = New System.Windows.Forms.Label
        C_nameLabel = New System.Windows.Forms.Label
        C_addressLabel = New System.Windows.Forms.Label
        C_telephoneLabel = New System.Windows.Forms.Label
        C_countryLabel = New System.Windows.Forms.Label
        C_positionLabel = New System.Windows.Forms.Label
        C_salaryLabel = New System.Windows.Forms.Label
        C_contractLabel = New System.Windows.Forms.Label
        C_agencyLabel = New System.Windows.Forms.Label
        B_name1Label = New System.Windows.Forms.Label
        B_relationship1Label = New System.Windows.Forms.Label
        B_bdate1Label = New System.Windows.Forms.Label
        B_address1Label = New System.Windows.Forms.Label
        B_contact1Label = New System.Windows.Forms.Label
        B_email1Label = New System.Windows.Forms.Label
        B_name2Label = New System.Windows.Forms.Label
        B_relationship2Label = New System.Windows.Forms.Label
        B_bdate2Label = New System.Windows.Forms.Label
        B_address2Label = New System.Windows.Forms.Label
        B_contact2Label = New System.Windows.Forms.Label
        B_email2Label = New System.Windows.Forms.Label
        B_name3Label = New System.Windows.Forms.Label
        B_relationship3Label = New System.Windows.Forms.Label
        B_bdate3Label = New System.Windows.Forms.Label
        B_address3Label = New System.Windows.Forms.Label
        B_contact3Label = New System.Windows.Forms.Label
        B_email3Label = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFWRegistrationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.grpBeneficiary.SuspendLayout()
        CType(Me.BeneficiariesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpContract.SuspendLayout()
        CType(Me.ContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddress.SuspendLayout()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A_houseNumLabel
        '
        A_houseNumLabel.AutoSize = True
        A_houseNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_houseNumLabel.Location = New System.Drawing.Point(6, 20)
        A_houseNumLabel.Name = "A_houseNumLabel"
        A_houseNumLabel.Size = New System.Drawing.Size(67, 13)
        A_houseNumLabel.TabIndex = 4
        A_houseNumLabel.Text = "House No."
        '
        'A_lotNumLabel
        '
        A_lotNumLabel.AutoSize = True
        A_lotNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_lotNumLabel.Location = New System.Drawing.Point(6, 46)
        A_lotNumLabel.Name = "A_lotNumLabel"
        A_lotNumLabel.Size = New System.Drawing.Size(49, 13)
        A_lotNumLabel.TabIndex = 6
        A_lotNumLabel.Text = "Lot No."
        '
        'A_blockNumLabel
        '
        A_blockNumLabel.AutoSize = True
        A_blockNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_blockNumLabel.Location = New System.Drawing.Point(6, 72)
        A_blockNumLabel.Name = "A_blockNumLabel"
        A_blockNumLabel.Size = New System.Drawing.Size(63, 13)
        A_blockNumLabel.TabIndex = 8
        A_blockNumLabel.Text = "Block No."
        '
        'A_phaseNumLabel
        '
        A_phaseNumLabel.AutoSize = True
        A_phaseNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_phaseNumLabel.Location = New System.Drawing.Point(6, 98)
        A_phaseNumLabel.Name = "A_phaseNumLabel"
        A_phaseNumLabel.Size = New System.Drawing.Size(66, 13)
        A_phaseNumLabel.TabIndex = 10
        A_phaseNumLabel.Text = "Phase No."
        '
        'A_streetLabel
        '
        A_streetLabel.AutoSize = True
        A_streetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_streetLabel.Location = New System.Drawing.Point(6, 124)
        A_streetLabel.Name = "A_streetLabel"
        A_streetLabel.Size = New System.Drawing.Size(41, 13)
        A_streetLabel.TabIndex = 12
        A_streetLabel.Text = "Street"
        '
        'A_subLabel
        '
        A_subLabel.AutoSize = True
        A_subLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_subLabel.Location = New System.Drawing.Point(6, 150)
        A_subLabel.Name = "A_subLabel"
        A_subLabel.Size = New System.Drawing.Size(72, 13)
        A_subLabel.TabIndex = 14
        A_subLabel.Text = "Subdivision"
        '
        'A_brgyLabel
        '
        A_brgyLabel.AutoSize = True
        A_brgyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_brgyLabel.Location = New System.Drawing.Point(6, 176)
        A_brgyLabel.Name = "A_brgyLabel"
        A_brgyLabel.Size = New System.Drawing.Size(60, 13)
        A_brgyLabel.TabIndex = 16
        A_brgyLabel.Text = "Barangay"
        '
        'A_cityLabel
        '
        A_cityLabel.AutoSize = True
        A_cityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_cityLabel.Location = New System.Drawing.Point(6, 202)
        A_cityLabel.Name = "A_cityLabel"
        A_cityLabel.Size = New System.Drawing.Size(28, 13)
        A_cityLabel.TabIndex = 18
        A_cityLabel.Text = "City"
        '
        'A_provLabel
        '
        A_provLabel.AutoSize = True
        A_provLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_provLabel.Location = New System.Drawing.Point(6, 228)
        A_provLabel.Name = "A_provLabel"
        A_provLabel.Size = New System.Drawing.Size(57, 13)
        A_provLabel.TabIndex = 20
        A_provLabel.Text = "Province"
        '
        'A_zipcodeLabel
        '
        A_zipcodeLabel.AutoSize = True
        A_zipcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_zipcodeLabel.Location = New System.Drawing.Point(6, 254)
        A_zipcodeLabel.Name = "A_zipcodeLabel"
        A_zipcodeLabel.Size = New System.Drawing.Size(53, 13)
        A_zipcodeLabel.TabIndex = 22
        A_zipcodeLabel.Text = "Zipcode"
        '
        'C_nameLabel
        '
        C_nameLabel.AutoSize = True
        C_nameLabel.Location = New System.Drawing.Point(6, 20)
        C_nameLabel.Name = "C_nameLabel"
        C_nameLabel.Size = New System.Drawing.Size(39, 13)
        C_nameLabel.TabIndex = 4
        C_nameLabel.Text = "Name"
        '
        'C_addressLabel
        '
        C_addressLabel.AutoSize = True
        C_addressLabel.Location = New System.Drawing.Point(6, 46)
        C_addressLabel.Name = "C_addressLabel"
        C_addressLabel.Size = New System.Drawing.Size(52, 13)
        C_addressLabel.TabIndex = 6
        C_addressLabel.Text = "Address"
        '
        'C_telephoneLabel
        '
        C_telephoneLabel.AutoSize = True
        C_telephoneLabel.Location = New System.Drawing.Point(6, 72)
        C_telephoneLabel.Name = "C_telephoneLabel"
        C_telephoneLabel.Size = New System.Drawing.Size(67, 13)
        C_telephoneLabel.TabIndex = 8
        C_telephoneLabel.Text = "Telephone"
        '
        'C_countryLabel
        '
        C_countryLabel.AutoSize = True
        C_countryLabel.Location = New System.Drawing.Point(6, 98)
        C_countryLabel.Name = "C_countryLabel"
        C_countryLabel.Size = New System.Drawing.Size(50, 13)
        C_countryLabel.TabIndex = 10
        C_countryLabel.Text = "Country"
        '
        'C_positionLabel
        '
        C_positionLabel.AutoSize = True
        C_positionLabel.Location = New System.Drawing.Point(6, 124)
        C_positionLabel.Name = "C_positionLabel"
        C_positionLabel.Size = New System.Drawing.Size(52, 13)
        C_positionLabel.TabIndex = 12
        C_positionLabel.Text = "Position"
        '
        'C_salaryLabel
        '
        C_salaryLabel.AutoSize = True
        C_salaryLabel.Location = New System.Drawing.Point(6, 150)
        C_salaryLabel.Name = "C_salaryLabel"
        C_salaryLabel.Size = New System.Drawing.Size(42, 13)
        C_salaryLabel.TabIndex = 14
        C_salaryLabel.Text = "Salary"
        '
        'C_contractLabel
        '
        C_contractLabel.AutoSize = True
        C_contractLabel.Location = New System.Drawing.Point(6, 176)
        C_contractLabel.Name = "C_contractLabel"
        C_contractLabel.Size = New System.Drawing.Size(55, 13)
        C_contractLabel.TabIndex = 16
        C_contractLabel.Text = "Contract"
        '
        'C_agencyLabel
        '
        C_agencyLabel.AutoSize = True
        C_agencyLabel.Location = New System.Drawing.Point(6, 202)
        C_agencyLabel.Name = "C_agencyLabel"
        C_agencyLabel.Size = New System.Drawing.Size(49, 13)
        C_agencyLabel.TabIndex = 18
        C_agencyLabel.Text = "Agency"
        '
        'B_name1Label
        '
        B_name1Label.AutoSize = True
        B_name1Label.Location = New System.Drawing.Point(6, 19)
        B_name1Label.Name = "B_name1Label"
        B_name1Label.Size = New System.Drawing.Size(39, 13)
        B_name1Label.TabIndex = 4
        B_name1Label.Text = "Name"
        '
        'B_relationship1Label
        '
        B_relationship1Label.AutoSize = True
        B_relationship1Label.Location = New System.Drawing.Point(257, 19)
        B_relationship1Label.Name = "B_relationship1Label"
        B_relationship1Label.Size = New System.Drawing.Size(77, 13)
        B_relationship1Label.TabIndex = 6
        B_relationship1Label.Text = "Relationship"
        '
        'B_bdate1Label
        '
        B_bdate1Label.AutoSize = True
        B_bdate1Label.Location = New System.Drawing.Point(6, 45)
        B_bdate1Label.Name = "B_bdate1Label"
        B_bdate1Label.Size = New System.Drawing.Size(58, 13)
        B_bdate1Label.TabIndex = 8
        B_bdate1Label.Text = "Birthdate"
        '
        'B_address1Label
        '
        B_address1Label.AutoSize = True
        B_address1Label.Location = New System.Drawing.Point(257, 46)
        B_address1Label.Name = "B_address1Label"
        B_address1Label.Size = New System.Drawing.Size(52, 13)
        B_address1Label.TabIndex = 10
        B_address1Label.Text = "Address"
        '
        'B_contact1Label
        '
        B_contact1Label.AutoSize = True
        B_contact1Label.Location = New System.Drawing.Point(6, 73)
        B_contact1Label.Name = "B_contact1Label"
        B_contact1Label.Size = New System.Drawing.Size(51, 13)
        B_contact1Label.TabIndex = 12
        B_contact1Label.Text = "Contact"
        '
        'B_email1Label
        '
        B_email1Label.AutoSize = True
        B_email1Label.Location = New System.Drawing.Point(257, 72)
        B_email1Label.Name = "B_email1Label"
        B_email1Label.Size = New System.Drawing.Size(41, 13)
        B_email1Label.TabIndex = 14
        B_email1Label.Text = "E-mail"
        '
        'B_name2Label
        '
        B_name2Label.AutoSize = True
        B_name2Label.Location = New System.Drawing.Point(6, 118)
        B_name2Label.Name = "B_name2Label"
        B_name2Label.Size = New System.Drawing.Size(39, 13)
        B_name2Label.TabIndex = 16
        B_name2Label.Text = "Name"
        '
        'B_relationship2Label
        '
        B_relationship2Label.AutoSize = True
        B_relationship2Label.Location = New System.Drawing.Point(257, 115)
        B_relationship2Label.Name = "B_relationship2Label"
        B_relationship2Label.Size = New System.Drawing.Size(77, 13)
        B_relationship2Label.TabIndex = 18
        B_relationship2Label.Text = "Relationship"
        '
        'B_bdate2Label
        '
        B_bdate2Label.AutoSize = True
        B_bdate2Label.Location = New System.Drawing.Point(6, 144)
        B_bdate2Label.Name = "B_bdate2Label"
        B_bdate2Label.Size = New System.Drawing.Size(58, 13)
        B_bdate2Label.TabIndex = 20
        B_bdate2Label.Text = "Birthdate"
        '
        'B_address2Label
        '
        B_address2Label.AutoSize = True
        B_address2Label.Location = New System.Drawing.Point(257, 144)
        B_address2Label.Name = "B_address2Label"
        B_address2Label.Size = New System.Drawing.Size(52, 13)
        B_address2Label.TabIndex = 22
        B_address2Label.Text = "Address"
        '
        'B_contact2Label
        '
        B_contact2Label.AutoSize = True
        B_contact2Label.Location = New System.Drawing.Point(6, 167)
        B_contact2Label.Name = "B_contact2Label"
        B_contact2Label.Size = New System.Drawing.Size(51, 13)
        B_contact2Label.TabIndex = 24
        B_contact2Label.Text = "Contact"
        '
        'B_email2Label
        '
        B_email2Label.AutoSize = True
        B_email2Label.Location = New System.Drawing.Point(257, 169)
        B_email2Label.Name = "B_email2Label"
        B_email2Label.Size = New System.Drawing.Size(41, 13)
        B_email2Label.TabIndex = 26
        B_email2Label.Text = "E-mail"
        '
        'B_name3Label
        '
        B_name3Label.AutoSize = True
        B_name3Label.Location = New System.Drawing.Point(6, 216)
        B_name3Label.Name = "B_name3Label"
        B_name3Label.Size = New System.Drawing.Size(39, 13)
        B_name3Label.TabIndex = 28
        B_name3Label.Text = "Name"
        '
        'B_relationship3Label
        '
        B_relationship3Label.AutoSize = True
        B_relationship3Label.Location = New System.Drawing.Point(256, 214)
        B_relationship3Label.Name = "B_relationship3Label"
        B_relationship3Label.Size = New System.Drawing.Size(77, 13)
        B_relationship3Label.TabIndex = 30
        B_relationship3Label.Text = "Relationship"
        '
        'B_bdate3Label
        '
        B_bdate3Label.AutoSize = True
        B_bdate3Label.Location = New System.Drawing.Point(6, 240)
        B_bdate3Label.Name = "B_bdate3Label"
        B_bdate3Label.Size = New System.Drawing.Size(58, 13)
        B_bdate3Label.TabIndex = 32
        B_bdate3Label.Text = "Birthdate"
        '
        'B_address3Label
        '
        B_address3Label.AutoSize = True
        B_address3Label.Location = New System.Drawing.Point(258, 240)
        B_address3Label.Name = "B_address3Label"
        B_address3Label.Size = New System.Drawing.Size(52, 13)
        B_address3Label.TabIndex = 34
        B_address3Label.Text = "Address"
        '
        'B_contact3Label
        '
        B_contact3Label.AutoSize = True
        B_contact3Label.Location = New System.Drawing.Point(6, 266)
        B_contact3Label.Name = "B_contact3Label"
        B_contact3Label.Size = New System.Drawing.Size(51, 13)
        B_contact3Label.TabIndex = 36
        B_contact3Label.Text = "Contact"
        '
        'B_email3Label
        '
        B_email3Label.AutoSize = True
        B_email3Label.Location = New System.Drawing.Point(257, 266)
        B_email3Label.Name = "B_email3Label"
        B_email3Label.Size = New System.Drawing.Size(41, 13)
        B_email3Label.TabIndex = 38
        B_email3Label.Text = "E-mail"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnFirst)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 46)
        Me.Panel1.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(631, 17)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(60, 13)
        Me.lblSearch.TabIndex = 9
        Me.lblSearch.Text = "First Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(696, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(146, 20)
        Me.txtSearch.TabIndex = 8
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Location = New System.Drawing.Point(890, 12)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 7
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.DarkOrange
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemove.Location = New System.Drawing.Point(1283, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(848, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Go"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.IndianRed
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLast.Location = New System.Drawing.Point(432, 12)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.IndianRed
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(347, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.IndianRed
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrevious.Location = New System.Drawing.Point(266, 12)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.IndianRed
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFirst.Location = New System.Drawing.Point(185, 12)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Brown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(21, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PersonalDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 336)
        Me.Panel2.TabIndex = 1
        '
        'PersonalDataGridView
        '
        Me.PersonalDataGridView.AllowUserToAddRows = False
        Me.PersonalDataGridView.AllowUserToDeleteRows = False
        Me.PersonalDataGridView.AutoGenerateColumns = False
        Me.PersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PersonalDataGridView.DataSource = Me.PersonalBindingSource
        Me.PersonalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PersonalDataGridView.Name = "PersonalDataGridView"
        Me.PersonalDataGridView.ReadOnly = True
        Me.PersonalDataGridView.Size = New System.Drawing.Size(1370, 336)
        Me.PersonalDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "p_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "p_fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "p_lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "p_suffix"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Suffix"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "p_mname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Middle Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "p_edu"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Highest Educational Attainment"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "p_course"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "p_contact"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Contact No."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "p_email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "E-mail Address"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "p_passport"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Passport No."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "p_bdate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Birthdate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "p_sex"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "p_religion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Religion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "p_civil"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Civil Status"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.OFWRegistrationDataSet
        '
        'OFWRegistrationDataSet
        '
        Me.OFWRegistrationDataSet.DataSetName = "OFWRegistrationDataSet"
        Me.OFWRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.grpBeneficiary)
        Me.Panel3.Controls.Add(Me.grpContract)
        Me.Panel3.Controls.Add(Me.grpAddress)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 382)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 344)
        Me.Panel3.TabIndex = 2
        '
        'grpBeneficiary
        '
        Me.grpBeneficiary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBeneficiary.BackColor = System.Drawing.Color.SeaGreen
        Me.grpBeneficiary.Controls.Add(B_name1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_name1TextBox)
        Me.grpBeneficiary.Controls.Add(B_relationship1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_relationship1TextBox)
        Me.grpBeneficiary.Controls.Add(B_bdate1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_bdate1DateTimePicker)
        Me.grpBeneficiary.Controls.Add(B_address1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_address1TextBox)
        Me.grpBeneficiary.Controls.Add(B_contact1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_contact1TextBox)
        Me.grpBeneficiary.Controls.Add(B_email1Label)
        Me.grpBeneficiary.Controls.Add(Me.B_email1TextBox)
        Me.grpBeneficiary.Controls.Add(B_name2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_name2TextBox)
        Me.grpBeneficiary.Controls.Add(B_relationship2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_relationship2TextBox)
        Me.grpBeneficiary.Controls.Add(B_bdate2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_bdate2DateTimePicker)
        Me.grpBeneficiary.Controls.Add(B_address2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_address2TextBox)
        Me.grpBeneficiary.Controls.Add(B_contact2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_contact2TextBox)
        Me.grpBeneficiary.Controls.Add(B_email2Label)
        Me.grpBeneficiary.Controls.Add(Me.B_email2TextBox)
        Me.grpBeneficiary.Controls.Add(B_name3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_name3TextBox)
        Me.grpBeneficiary.Controls.Add(B_relationship3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_relationship3TextBox)
        Me.grpBeneficiary.Controls.Add(B_bdate3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_bdate3DateTimePicker)
        Me.grpBeneficiary.Controls.Add(B_address3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_address3TextBox)
        Me.grpBeneficiary.Controls.Add(B_contact3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_contact3TextBox)
        Me.grpBeneficiary.Controls.Add(B_email3Label)
        Me.grpBeneficiary.Controls.Add(Me.B_email3TextBox)
        Me.grpBeneficiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBeneficiary.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpBeneficiary.Location = New System.Drawing.Point(841, 3)
        Me.grpBeneficiary.Name = "grpBeneficiary"
        Me.grpBeneficiary.Size = New System.Drawing.Size(522, 360)
        Me.grpBeneficiary.TabIndex = 26
        Me.grpBeneficiary.TabStop = False
        Me.grpBeneficiary.Text = "BENEFICIARIES"
        '
        'B_name1TextBox
        '
        Me.B_name1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_name1", True))
        Me.B_name1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_name1TextBox.Location = New System.Drawing.Point(51, 16)
        Me.B_name1TextBox.Name = "B_name1TextBox"
        Me.B_name1TextBox.ReadOnly = True
        Me.B_name1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_name1TextBox.TabIndex = 5
        '
        'BeneficiariesBindingSource
        '
        Me.BeneficiariesBindingSource.DataMember = "Beneficiaries"
        Me.BeneficiariesBindingSource.DataSource = Me.OFWRegistrationDataSet
        '
        'B_relationship1TextBox
        '
        Me.B_relationship1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_relationship1", True))
        Me.B_relationship1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_relationship1TextBox.Location = New System.Drawing.Point(339, 16)
        Me.B_relationship1TextBox.Name = "B_relationship1TextBox"
        Me.B_relationship1TextBox.ReadOnly = True
        Me.B_relationship1TextBox.Size = New System.Drawing.Size(176, 20)
        Me.B_relationship1TextBox.TabIndex = 7
        '
        'B_bdate1DateTimePicker
        '
        Me.B_bdate1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BeneficiariesBindingSource, "b_bdate1", True))
        Me.B_bdate1DateTimePicker.Enabled = False
        Me.B_bdate1DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_bdate1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.B_bdate1DateTimePicker.Location = New System.Drawing.Point(70, 42)
        Me.B_bdate1DateTimePicker.Name = "B_bdate1DateTimePicker"
        Me.B_bdate1DateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.B_bdate1DateTimePicker.TabIndex = 9
        '
        'B_address1TextBox
        '
        Me.B_address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_address1", True))
        Me.B_address1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_address1TextBox.Location = New System.Drawing.Point(315, 42)
        Me.B_address1TextBox.Name = "B_address1TextBox"
        Me.B_address1TextBox.ReadOnly = True
        Me.B_address1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_address1TextBox.TabIndex = 11
        '
        'B_contact1TextBox
        '
        Me.B_contact1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_contact1", True))
        Me.B_contact1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_contact1TextBox.Location = New System.Drawing.Point(70, 68)
        Me.B_contact1TextBox.Name = "B_contact1TextBox"
        Me.B_contact1TextBox.ReadOnly = True
        Me.B_contact1TextBox.Size = New System.Drawing.Size(181, 20)
        Me.B_contact1TextBox.TabIndex = 13
        '
        'B_email1TextBox
        '
        Me.B_email1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_email1", True))
        Me.B_email1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_email1TextBox.Location = New System.Drawing.Point(315, 68)
        Me.B_email1TextBox.Name = "B_email1TextBox"
        Me.B_email1TextBox.ReadOnly = True
        Me.B_email1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_email1TextBox.TabIndex = 15
        '
        'B_name2TextBox
        '
        Me.B_name2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_name2", True))
        Me.B_name2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_name2TextBox.Location = New System.Drawing.Point(51, 114)
        Me.B_name2TextBox.Name = "B_name2TextBox"
        Me.B_name2TextBox.ReadOnly = True
        Me.B_name2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_name2TextBox.TabIndex = 17
        '
        'B_relationship2TextBox
        '
        Me.B_relationship2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_relationship2", True))
        Me.B_relationship2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_relationship2TextBox.Location = New System.Drawing.Point(339, 114)
        Me.B_relationship2TextBox.Name = "B_relationship2TextBox"
        Me.B_relationship2TextBox.ReadOnly = True
        Me.B_relationship2TextBox.Size = New System.Drawing.Size(176, 20)
        Me.B_relationship2TextBox.TabIndex = 19
        '
        'B_bdate2DateTimePicker
        '
        Me.B_bdate2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BeneficiariesBindingSource, "b_bdate2", True))
        Me.B_bdate2DateTimePicker.Enabled = False
        Me.B_bdate2DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_bdate2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.B_bdate2DateTimePicker.Location = New System.Drawing.Point(70, 140)
        Me.B_bdate2DateTimePicker.Name = "B_bdate2DateTimePicker"
        Me.B_bdate2DateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.B_bdate2DateTimePicker.TabIndex = 21
        '
        'B_address2TextBox
        '
        Me.B_address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_address2", True))
        Me.B_address2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_address2TextBox.Location = New System.Drawing.Point(315, 140)
        Me.B_address2TextBox.Name = "B_address2TextBox"
        Me.B_address2TextBox.ReadOnly = True
        Me.B_address2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_address2TextBox.TabIndex = 23
        '
        'B_contact2TextBox
        '
        Me.B_contact2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_contact2", True))
        Me.B_contact2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_contact2TextBox.Location = New System.Drawing.Point(70, 166)
        Me.B_contact2TextBox.Name = "B_contact2TextBox"
        Me.B_contact2TextBox.ReadOnly = True
        Me.B_contact2TextBox.Size = New System.Drawing.Size(181, 20)
        Me.B_contact2TextBox.TabIndex = 25
        '
        'B_email2TextBox
        '
        Me.B_email2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_email2", True))
        Me.B_email2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_email2TextBox.Location = New System.Drawing.Point(315, 166)
        Me.B_email2TextBox.Name = "B_email2TextBox"
        Me.B_email2TextBox.ReadOnly = True
        Me.B_email2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_email2TextBox.TabIndex = 27
        '
        'B_name3TextBox
        '
        Me.B_name3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_name3", True))
        Me.B_name3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_name3TextBox.Location = New System.Drawing.Point(51, 211)
        Me.B_name3TextBox.Name = "B_name3TextBox"
        Me.B_name3TextBox.ReadOnly = True
        Me.B_name3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_name3TextBox.TabIndex = 29
        '
        'B_relationship3TextBox
        '
        Me.B_relationship3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_relationship3", True))
        Me.B_relationship3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_relationship3TextBox.Location = New System.Drawing.Point(339, 211)
        Me.B_relationship3TextBox.Name = "B_relationship3TextBox"
        Me.B_relationship3TextBox.ReadOnly = True
        Me.B_relationship3TextBox.Size = New System.Drawing.Size(176, 20)
        Me.B_relationship3TextBox.TabIndex = 31
        '
        'B_bdate3DateTimePicker
        '
        Me.B_bdate3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BeneficiariesBindingSource, "b_bdate3", True))
        Me.B_bdate3DateTimePicker.Enabled = False
        Me.B_bdate3DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_bdate3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.B_bdate3DateTimePicker.Location = New System.Drawing.Point(70, 237)
        Me.B_bdate3DateTimePicker.Name = "B_bdate3DateTimePicker"
        Me.B_bdate3DateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.B_bdate3DateTimePicker.TabIndex = 33
        '
        'B_address3TextBox
        '
        Me.B_address3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_address3", True))
        Me.B_address3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_address3TextBox.Location = New System.Drawing.Point(316, 237)
        Me.B_address3TextBox.Name = "B_address3TextBox"
        Me.B_address3TextBox.ReadOnly = True
        Me.B_address3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.B_address3TextBox.TabIndex = 35
        '
        'B_contact3TextBox
        '
        Me.B_contact3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_contact3", True))
        Me.B_contact3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_contact3TextBox.Location = New System.Drawing.Point(70, 263)
        Me.B_contact3TextBox.Name = "B_contact3TextBox"
        Me.B_contact3TextBox.ReadOnly = True
        Me.B_contact3TextBox.Size = New System.Drawing.Size(181, 20)
        Me.B_contact3TextBox.TabIndex = 37
        '
        'B_email3TextBox
        '
        Me.B_email3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiariesBindingSource, "b_email3", True))
        Me.B_email3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_email3TextBox.Location = New System.Drawing.Point(316, 263)
        Me.B_email3TextBox.Name = "B_email3TextBox"
        Me.B_email3TextBox.ReadOnly = True
        Me.B_email3TextBox.Size = New System.Drawing.Size(199, 20)
        Me.B_email3TextBox.TabIndex = 39
        '
        'grpContract
        '
        Me.grpContract.BackColor = System.Drawing.Color.SeaGreen
        Me.grpContract.Controls.Add(C_nameLabel)
        Me.grpContract.Controls.Add(Me.C_nameTextBox)
        Me.grpContract.Controls.Add(C_addressLabel)
        Me.grpContract.Controls.Add(Me.C_addressTextBox)
        Me.grpContract.Controls.Add(C_telephoneLabel)
        Me.grpContract.Controls.Add(Me.C_telephoneTextBox)
        Me.grpContract.Controls.Add(C_countryLabel)
        Me.grpContract.Controls.Add(Me.C_countryTextBox)
        Me.grpContract.Controls.Add(C_positionLabel)
        Me.grpContract.Controls.Add(Me.C_positionTextBox)
        Me.grpContract.Controls.Add(C_salaryLabel)
        Me.grpContract.Controls.Add(Me.C_salaryTextBox)
        Me.grpContract.Controls.Add(C_contractLabel)
        Me.grpContract.Controls.Add(Me.C_contractTextBox)
        Me.grpContract.Controls.Add(C_agencyLabel)
        Me.grpContract.Controls.Add(Me.C_agencyTextBox)
        Me.grpContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpContract.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpContract.Location = New System.Drawing.Point(415, 3)
        Me.grpContract.Name = "grpContract"
        Me.grpContract.Size = New System.Drawing.Size(419, 363)
        Me.grpContract.TabIndex = 25
        Me.grpContract.TabStop = False
        Me.grpContract.Text = "CONTRACT PARTICULAR"
        '
        'C_nameTextBox
        '
        Me.C_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_name", True))
        Me.C_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_nameTextBox.Location = New System.Drawing.Point(90, 17)
        Me.C_nameTextBox.Name = "C_nameTextBox"
        Me.C_nameTextBox.ReadOnly = True
        Me.C_nameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_nameTextBox.TabIndex = 5
        '
        'ContractBindingSource
        '
        Me.ContractBindingSource.DataMember = "Contract"
        Me.ContractBindingSource.DataSource = Me.OFWRegistrationDataSet
        '
        'C_addressTextBox
        '
        Me.C_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_address", True))
        Me.C_addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_addressTextBox.Location = New System.Drawing.Point(90, 43)
        Me.C_addressTextBox.Name = "C_addressTextBox"
        Me.C_addressTextBox.ReadOnly = True
        Me.C_addressTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_addressTextBox.TabIndex = 7
        '
        'C_telephoneTextBox
        '
        Me.C_telephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_telephone", True))
        Me.C_telephoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_telephoneTextBox.Location = New System.Drawing.Point(90, 69)
        Me.C_telephoneTextBox.Name = "C_telephoneTextBox"
        Me.C_telephoneTextBox.ReadOnly = True
        Me.C_telephoneTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_telephoneTextBox.TabIndex = 9
        '
        'C_countryTextBox
        '
        Me.C_countryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_country", True))
        Me.C_countryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_countryTextBox.Location = New System.Drawing.Point(90, 95)
        Me.C_countryTextBox.Name = "C_countryTextBox"
        Me.C_countryTextBox.ReadOnly = True
        Me.C_countryTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_countryTextBox.TabIndex = 11
        '
        'C_positionTextBox
        '
        Me.C_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_position", True))
        Me.C_positionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_positionTextBox.Location = New System.Drawing.Point(90, 121)
        Me.C_positionTextBox.Name = "C_positionTextBox"
        Me.C_positionTextBox.ReadOnly = True
        Me.C_positionTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_positionTextBox.TabIndex = 13
        '
        'C_salaryTextBox
        '
        Me.C_salaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_salary", True))
        Me.C_salaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_salaryTextBox.Location = New System.Drawing.Point(90, 147)
        Me.C_salaryTextBox.Name = "C_salaryTextBox"
        Me.C_salaryTextBox.ReadOnly = True
        Me.C_salaryTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_salaryTextBox.TabIndex = 15
        '
        'C_contractTextBox
        '
        Me.C_contractTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_contract", True))
        Me.C_contractTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_contractTextBox.Location = New System.Drawing.Point(90, 173)
        Me.C_contractTextBox.Name = "C_contractTextBox"
        Me.C_contractTextBox.ReadOnly = True
        Me.C_contractTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_contractTextBox.TabIndex = 17
        '
        'C_agencyTextBox
        '
        Me.C_agencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContractBindingSource, "c_agency", True))
        Me.C_agencyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_agencyTextBox.Location = New System.Drawing.Point(90, 199)
        Me.C_agencyTextBox.Name = "C_agencyTextBox"
        Me.C_agencyTextBox.ReadOnly = True
        Me.C_agencyTextBox.Size = New System.Drawing.Size(300, 20)
        Me.C_agencyTextBox.TabIndex = 19
        '
        'grpAddress
        '
        Me.grpAddress.BackColor = System.Drawing.Color.SeaGreen
        Me.grpAddress.Controls.Add(Me.R_dateDateTimePicker)
        Me.grpAddress.Controls.Add(A_houseNumLabel)
        Me.grpAddress.Controls.Add(Me.A_zipcodeTextBox)
        Me.grpAddress.Controls.Add(Me.A_houseNumTextBox)
        Me.grpAddress.Controls.Add(A_zipcodeLabel)
        Me.grpAddress.Controls.Add(A_lotNumLabel)
        Me.grpAddress.Controls.Add(Me.A_provTextBox)
        Me.grpAddress.Controls.Add(Me.A_lotNumTextBox)
        Me.grpAddress.Controls.Add(A_provLabel)
        Me.grpAddress.Controls.Add(A_blockNumLabel)
        Me.grpAddress.Controls.Add(Me.A_cityTextBox)
        Me.grpAddress.Controls.Add(Me.A_blockNumTextBox)
        Me.grpAddress.Controls.Add(A_cityLabel)
        Me.grpAddress.Controls.Add(A_phaseNumLabel)
        Me.grpAddress.Controls.Add(Me.A_brgyTextBox)
        Me.grpAddress.Controls.Add(Me.A_phaseNumTextBox)
        Me.grpAddress.Controls.Add(A_brgyLabel)
        Me.grpAddress.Controls.Add(A_streetLabel)
        Me.grpAddress.Controls.Add(Me.A_subTextBox)
        Me.grpAddress.Controls.Add(Me.A_streetTextBox)
        Me.grpAddress.Controls.Add(A_subLabel)
        Me.grpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpAddress.Location = New System.Drawing.Point(3, 3)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(405, 360)
        Me.grpAddress.TabIndex = 24
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "ADDRESS"
        '
        'R_dateDateTimePicker
        '
        Me.R_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "r_date", True))
        Me.R_dateDateTimePicker.Enabled = False
        Me.R_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_dateDateTimePicker.Location = New System.Drawing.Point(115, 306)
        Me.R_dateDateTimePicker.Name = "R_dateDateTimePicker"
        Me.R_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.R_dateDateTimePicker.TabIndex = 24
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.OFWRegistrationDataSet
        '
        'A_zipcodeTextBox
        '
        Me.A_zipcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_zipcode", True))
        Me.A_zipcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_zipcodeTextBox.Location = New System.Drawing.Point(85, 251)
        Me.A_zipcodeTextBox.Name = "A_zipcodeTextBox"
        Me.A_zipcodeTextBox.ReadOnly = True
        Me.A_zipcodeTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_zipcodeTextBox.TabIndex = 23
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataMember = "Address"
        Me.AddressBindingSource.DataSource = Me.OFWRegistrationDataSet
        '
        'A_houseNumTextBox
        '
        Me.A_houseNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_houseNum", True))
        Me.A_houseNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_houseNumTextBox.Location = New System.Drawing.Point(85, 17)
        Me.A_houseNumTextBox.Name = "A_houseNumTextBox"
        Me.A_houseNumTextBox.ReadOnly = True
        Me.A_houseNumTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_houseNumTextBox.TabIndex = 5
        '
        'A_provTextBox
        '
        Me.A_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_prov", True))
        Me.A_provTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_provTextBox.Location = New System.Drawing.Point(85, 225)
        Me.A_provTextBox.Name = "A_provTextBox"
        Me.A_provTextBox.ReadOnly = True
        Me.A_provTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_provTextBox.TabIndex = 21
        '
        'A_lotNumTextBox
        '
        Me.A_lotNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_lotNum", True))
        Me.A_lotNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_lotNumTextBox.Location = New System.Drawing.Point(85, 43)
        Me.A_lotNumTextBox.Name = "A_lotNumTextBox"
        Me.A_lotNumTextBox.ReadOnly = True
        Me.A_lotNumTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_lotNumTextBox.TabIndex = 7
        '
        'A_cityTextBox
        '
        Me.A_cityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_city", True))
        Me.A_cityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_cityTextBox.Location = New System.Drawing.Point(85, 199)
        Me.A_cityTextBox.Name = "A_cityTextBox"
        Me.A_cityTextBox.ReadOnly = True
        Me.A_cityTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_cityTextBox.TabIndex = 19
        '
        'A_blockNumTextBox
        '
        Me.A_blockNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_blockNum", True))
        Me.A_blockNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_blockNumTextBox.Location = New System.Drawing.Point(85, 69)
        Me.A_blockNumTextBox.Name = "A_blockNumTextBox"
        Me.A_blockNumTextBox.ReadOnly = True
        Me.A_blockNumTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_blockNumTextBox.TabIndex = 9
        '
        'A_brgyTextBox
        '
        Me.A_brgyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_brgy", True))
        Me.A_brgyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_brgyTextBox.Location = New System.Drawing.Point(85, 173)
        Me.A_brgyTextBox.Name = "A_brgyTextBox"
        Me.A_brgyTextBox.ReadOnly = True
        Me.A_brgyTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_brgyTextBox.TabIndex = 17
        '
        'A_phaseNumTextBox
        '
        Me.A_phaseNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_phaseNum", True))
        Me.A_phaseNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_phaseNumTextBox.Location = New System.Drawing.Point(85, 95)
        Me.A_phaseNumTextBox.Name = "A_phaseNumTextBox"
        Me.A_phaseNumTextBox.ReadOnly = True
        Me.A_phaseNumTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_phaseNumTextBox.TabIndex = 11
        '
        'A_subTextBox
        '
        Me.A_subTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_sub", True))
        Me.A_subTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_subTextBox.Location = New System.Drawing.Point(85, 147)
        Me.A_subTextBox.Name = "A_subTextBox"
        Me.A_subTextBox.ReadOnly = True
        Me.A_subTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_subTextBox.TabIndex = 15
        '
        'A_streetTextBox
        '
        Me.A_streetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "a_street", True))
        Me.A_streetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_streetTextBox.Location = New System.Drawing.Point(85, 121)
        Me.A_streetTextBox.Name = "A_streetTextBox"
        Me.A_streetTextBox.ReadOnly = True
        Me.A_streetTextBox.Size = New System.Drawing.Size(300, 20)
        Me.A_streetTextBox.TabIndex = 13
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressTableAdapter = Me.AddressTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiariesTableAdapter = Me.BeneficiariesTableAdapter
        Me.TableAdapterManager.ContractTableAdapter = Me.ContractTableAdapter
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddressTableAdapter
        '
        Me.AddressTableAdapter.ClearBeforeFill = True
        '
        'BeneficiariesTableAdapter
        '
        Me.BeneficiariesTableAdapter.ClearBeforeFill = True
        '
        'ContractTableAdapter
        '
        Me.ContractTableAdapter.ClearBeforeFill = True
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'frmManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 726)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFWRegistrationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.grpBeneficiary.ResumeLayout(False)
        Me.grpBeneficiary.PerformLayout()
        CType(Me.BeneficiariesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpContract.ResumeLayout(False)
        Me.grpContract.PerformLayout()
        CType(Me.ContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents OFWRegistrationDataSet As OFW_Registration0._1.OFWRegistrationDataSet
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalTableAdapter As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressTableAdapter As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.AddressTableAdapter
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpContract As System.Windows.Forms.GroupBox
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
    Friend WithEvents A_zipcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_houseNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_lotNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_blockNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_brgyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_phaseNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_streetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContractTableAdapter As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.ContractTableAdapter
    Friend WithEvents ContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents C_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_telephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_countryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_positionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_salaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_contractTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_agencyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpBeneficiary As System.Windows.Forms.GroupBox
    Friend WithEvents RegistrationTableAdapter As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents R_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BeneficiariesTableAdapter As OFW_Registration0._1.OFWRegistrationDataSetTableAdapters.BeneficiariesTableAdapter
    Friend WithEvents BeneficiariesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents B_name1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_relationship1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_bdate1DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents B_address1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_contact1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_email1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_name2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_relationship2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_bdate2DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents B_address2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_contact2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_email2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_name3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_relationship3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_bdate3DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents B_address3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_contact3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_email3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
End Class
