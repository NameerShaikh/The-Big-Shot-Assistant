<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        BtnBaseTotal = New Button()
        BtnAddRow = New Button()
        BtnStrikeRow = New Button()
        GroupBox1 = New GroupBox()
        BtnClearRevenue = New Button()
        BtnCalculateRevenue = New Button()
        BtnStartTime = New Button()
        BtnEndTime = New Button()
        TotalRevenueLabel1 = New Label()
        BtnCalculate = New Button()
        BtnTotal = New Button()
        BtnExport = New Button()
        TotalTableChargeLabel = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        DataGridView1 = New DataGridView()
        TabPage2 = New TabPage()
        ExpiredMemberLabel = New Label()
        ActiveMemberLabel = New Label()
        BtnCheckExpired = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        BtnCheckActive = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        BtnDetails = New Button()
        BtnAddMember = New Button()
        MembershipDataGrid = New DataGridView()
        TabPage4 = New TabPage()
        BtnSaveNotes = New Button()
        RichTextBox1 = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        TabPage3 = New TabPage()
        TableLayoutPanel3 = New TableLayoutPanel()
        BtnSaveInventory = New Button()
        BtnSetDateTime = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        RichTextBox2 = New RichTextBox()
        Label11 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(MembershipDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TabPage3.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.ShowToolTips = True
        TabControl1.Size = New Size(1607, 769)
        TabControl1.SizeMode = TabSizeMode.FillToRight
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.ForestGreen
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Controls.Add(FlowLayoutPanel1)
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Location = New Point(4, 40)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1599, 725)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Entry Manager"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1290359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1290321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1290321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1290321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.1290321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.35484F))
        TableLayoutPanel1.Controls.Add(BtnBaseTotal, 4, 1)
        TableLayoutPanel1.Controls.Add(BtnAddRow, 0, 0)
        TableLayoutPanel1.Controls.Add(BtnStrikeRow, 0, 1)
        TableLayoutPanel1.Controls.Add(GroupBox1, 5, 1)
        TableLayoutPanel1.Controls.Add(BtnStartTime, 1, 0)
        TableLayoutPanel1.Controls.Add(BtnEndTime, 1, 1)
        TableLayoutPanel1.Controls.Add(TotalRevenueLabel1, 5, 0)
        TableLayoutPanel1.Controls.Add(BtnCalculate, 2, 0)
        TableLayoutPanel1.Controls.Add(BtnTotal, 2, 1)
        TableLayoutPanel1.Controls.Add(BtnExport, 3, 1)
        TableLayoutPanel1.Controls.Add(TotalTableChargeLabel, 4, 0)
        TableLayoutPanel1.Location = New Point(21, 614)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1556, 105)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' BtnBaseTotal
        ' 
        BtnBaseTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnBaseTotal.AutoSize = True
        BtnBaseTotal.BackColor = Color.Black
        BtnBaseTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnBaseTotal.ForeColor = Color.White
        BtnBaseTotal.Location = New Point(1003, 61)
        BtnBaseTotal.Name = "BtnBaseTotal"
        BtnBaseTotal.Size = New Size(244, 41)
        BtnBaseTotal.TabIndex = 13
        BtnBaseTotal.Text = "Base Total"
        BtnBaseTotal.UseVisualStyleBackColor = False
        ' 
        ' BtnAddRow
        ' 
        BtnAddRow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnAddRow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnAddRow.BackColor = Color.Black
        BtnAddRow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAddRow.ForeColor = Color.White
        BtnAddRow.Location = New Point(3, 9)
        BtnAddRow.Name = "BtnAddRow"
        BtnAddRow.Size = New Size(244, 40)
        BtnAddRow.TabIndex = 1
        BtnAddRow.Text = "Add Row"
        BtnAddRow.UseVisualStyleBackColor = False
        ' 
        ' BtnStrikeRow
        ' 
        BtnStrikeRow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnStrikeRow.BackColor = Color.Black
        BtnStrikeRow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnStrikeRow.ForeColor = Color.White
        BtnStrikeRow.Location = New Point(3, 62)
        BtnStrikeRow.Name = "BtnStrikeRow"
        BtnStrikeRow.Size = New Size(244, 40)
        BtnStrikeRow.TabIndex = 2
        BtnStrikeRow.Text = "StrikeOut"
        BtnStrikeRow.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(BtnClearRevenue)
        GroupBox1.Controls.Add(BtnCalculateRevenue)
        GroupBox1.Location = New Point(1277, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(251, 47)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' BtnClearRevenue
        ' 
        BtnClearRevenue.Anchor = AnchorStyles.Right
        BtnClearRevenue.AutoSize = True
        BtnClearRevenue.BackColor = Color.Black
        BtnClearRevenue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnClearRevenue.ForeColor = Color.White
        BtnClearRevenue.Location = New Point(160, 7)
        BtnClearRevenue.Name = "BtnClearRevenue"
        BtnClearRevenue.Size = New Size(85, 40)
        BtnClearRevenue.TabIndex = 13
        BtnClearRevenue.Text = "Clear"
        BtnClearRevenue.UseVisualStyleBackColor = False
        ' 
        ' BtnCalculateRevenue
        ' 
        BtnCalculateRevenue.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        BtnCalculateRevenue.AutoSize = True
        BtnCalculateRevenue.BackColor = Color.Black
        BtnCalculateRevenue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnCalculateRevenue.ForeColor = Color.White
        BtnCalculateRevenue.Location = New Point(0, 7)
        BtnCalculateRevenue.Name = "BtnCalculateRevenue"
        BtnCalculateRevenue.Size = New Size(156, 41)
        BtnCalculateRevenue.TabIndex = 12
        BtnCalculateRevenue.Text = "Total Revenue"
        BtnCalculateRevenue.UseVisualStyleBackColor = False
        ' 
        ' BtnStartTime
        ' 
        BtnStartTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnStartTime.BackColor = Color.Black
        BtnStartTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnStartTime.ForeColor = SystemColors.ButtonHighlight
        BtnStartTime.Location = New Point(253, 9)
        BtnStartTime.Name = "BtnStartTime"
        BtnStartTime.Size = New Size(244, 40)
        BtnStartTime.TabIndex = 5
        BtnStartTime.Text = "Start Time"
        BtnStartTime.UseVisualStyleBackColor = False
        ' 
        ' BtnEndTime
        ' 
        BtnEndTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnEndTime.BackColor = Color.Black
        BtnEndTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnEndTime.ForeColor = Color.White
        BtnEndTime.Location = New Point(253, 62)
        BtnEndTime.Name = "BtnEndTime"
        BtnEndTime.Size = New Size(244, 40)
        BtnEndTime.TabIndex = 6
        BtnEndTime.Text = "End Time"
        BtnEndTime.UseVisualStyleBackColor = False
        ' 
        ' TotalRevenueLabel1
        ' 
        TotalRevenueLabel1.Anchor = AnchorStyles.Bottom
        TotalRevenueLabel1.BackColor = Color.Black
        TotalRevenueLabel1.BorderStyle = BorderStyle.FixedSingle
        TotalRevenueLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TotalRevenueLabel1.ForeColor = Color.White
        TotalRevenueLabel1.Location = New Point(1277, 14)
        TotalRevenueLabel1.Name = "TotalRevenueLabel1"
        TotalRevenueLabel1.Size = New Size(251, 38)
        TotalRevenueLabel1.TabIndex = 11
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnCalculate.BackColor = Color.Black
        BtnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnCalculate.ForeColor = Color.White
        BtnCalculate.Location = New Point(503, 9)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(244, 40)
        BtnCalculate.TabIndex = 7
        BtnCalculate.Text = "Calculate Table Charge"
        BtnCalculate.UseVisualStyleBackColor = False
        ' 
        ' BtnTotal
        ' 
        BtnTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnTotal.AutoSize = True
        BtnTotal.BackColor = Color.Black
        BtnTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnTotal.ForeColor = Color.White
        BtnTotal.Location = New Point(503, 62)
        BtnTotal.Name = "BtnTotal"
        BtnTotal.Size = New Size(244, 40)
        BtnTotal.TabIndex = 13
        BtnTotal.Text = "Calculate Total"
        BtnTotal.UseVisualStyleBackColor = False
        ' 
        ' BtnExport
        ' 
        BtnExport.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnExport.BackColor = Color.Black
        BtnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BtnExport.ForeColor = Color.White
        BtnExport.Location = New Point(753, 62)
        BtnExport.Name = "BtnExport"
        BtnExport.Size = New Size(244, 40)
        BtnExport.TabIndex = 3
        BtnExport.Text = "Export"
        BtnExport.UseVisualStyleBackColor = False
        ' 
        ' TotalTableChargeLabel
        ' 
        TotalTableChargeLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TotalTableChargeLabel.BackColor = Color.Black
        TotalTableChargeLabel.BorderStyle = BorderStyle.FixedSingle
        TotalTableChargeLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TotalTableChargeLabel.ForeColor = Color.White
        TotalTableChargeLabel.Location = New Point(1003, 14)
        TotalTableChargeLabel.Name = "TotalTableChargeLabel"
        TotalTableChargeLabel.Size = New Size(244, 38)
        TotalTableChargeLabel.TabIndex = 14
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Location = New Point(802, 452)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(0, 0)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(28, 20)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Size = New Size(1549, 577)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Green
        TabPage2.Controls.Add(ExpiredMemberLabel)
        TabPage2.Controls.Add(ActiveMemberLabel)
        TabPage2.Controls.Add(BtnCheckExpired)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Controls.Add(BtnCheckActive)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(BtnDetails)
        TabPage2.Controls.Add(BtnAddMember)
        TabPage2.Controls.Add(MembershipDataGrid)
        TabPage2.Location = New Point(4, 40)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1599, 725)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Membership Manager"
        ' 
        ' ExpiredMemberLabel
        ' 
        ExpiredMemberLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ExpiredMemberLabel.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExpiredMemberLabel.Location = New Point(1338, 466)
        ExpiredMemberLabel.Name = "ExpiredMemberLabel"
        ExpiredMemberLabel.Size = New Size(177, 114)
        ExpiredMemberLabel.TabIndex = 13
        ExpiredMemberLabel.Text = "5"
        ExpiredMemberLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ActiveMemberLabel
        ' 
        ActiveMemberLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ActiveMemberLabel.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ActiveMemberLabel.Location = New Point(1338, 183)
        ActiveMemberLabel.Name = "ActiveMemberLabel"
        ActiveMemberLabel.Size = New Size(177, 114)
        ActiveMemberLabel.TabIndex = 12
        ActiveMemberLabel.Text = "1"
        ActiveMemberLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnCheckExpired
        ' 
        BtnCheckExpired.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnCheckExpired.BackColor = Color.Black
        BtnCheckExpired.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        BtnCheckExpired.ForeColor = Color.White
        BtnCheckExpired.Location = New Point(1383, 620)
        BtnCheckExpired.Name = "BtnCheckExpired"
        BtnCheckExpired.Size = New Size(88, 44)
        BtnCheckExpired.TabIndex = 11
        BtnCheckExpired.Text = "Check"
        BtnCheckExpired.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1293, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(280, 31)
        Label4.TabIndex = 9
        Label4.Text = "Membership Active Count"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(1078, 409)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(194, 230)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' BtnCheckActive
        ' 
        BtnCheckActive.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnCheckActive.BackColor = Color.Black
        BtnCheckActive.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        BtnCheckActive.ForeColor = Color.White
        BtnCheckActive.Location = New Point(1383, 318)
        BtnCheckActive.Name = "BtnCheckActive"
        BtnCheckActive.Size = New Size(88, 44)
        BtnCheckActive.TabIndex = 7
        BtnCheckActive.Text = "Check"
        BtnCheckActive.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1293, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 31)
        Label2.TabIndex = 5
        Label2.Text = "Membership Expired Count"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1078, 135)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 230)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1213, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 60)
        Label1.TabIndex = 3
        Label1.Text = "Statistics"
        ' 
        ' BtnDetails
        ' 
        BtnDetails.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnDetails.BackColor = Color.Black
        BtnDetails.ForeColor = Color.White
        BtnDetails.Location = New Point(632, 609)
        BtnDetails.Name = "BtnDetails"
        BtnDetails.Size = New Size(324, 66)
        BtnDetails.TabIndex = 2
        BtnDetails.Text = "Details"
        BtnDetails.UseVisualStyleBackColor = False
        ' 
        ' BtnAddMember
        ' 
        BtnAddMember.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnAddMember.BackColor = Color.Black
        BtnAddMember.ForeColor = Color.White
        BtnAddMember.Location = New Point(139, 609)
        BtnAddMember.Name = "BtnAddMember"
        BtnAddMember.Size = New Size(324, 66)
        BtnAddMember.TabIndex = 1
        BtnAddMember.Text = "Add Member"
        BtnAddMember.UseVisualStyleBackColor = False
        ' 
        ' MembershipDataGrid
        ' 
        MembershipDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MembershipDataGrid.BackgroundColor = SystemColors.ActiveCaption
        MembershipDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MembershipDataGrid.Location = New Point(42, 34)
        MembershipDataGrid.Name = "MembershipDataGrid"
        MembershipDataGrid.ReadOnly = True
        MembershipDataGrid.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        MembershipDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        MembershipDataGrid.ShowCellToolTips = False
        MembershipDataGrid.Size = New Size(993, 532)
        MembershipDataGrid.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(BtnSaveNotes)
        TabPage4.Controls.Add(RichTextBox1)
        TabPage4.Controls.Add(TableLayoutPanel2)
        TabPage4.Location = New Point(4, 40)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1599, 725)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Notes Ans AddOns"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveNotes
        ' 
        BtnSaveNotes.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnSaveNotes.BackColor = Color.Black
        BtnSaveNotes.ForeColor = Color.White
        BtnSaveNotes.Location = New Point(675, 646)
        BtnSaveNotes.Name = "BtnSaveNotes"
        BtnSaveNotes.Size = New Size(244, 60)
        BtnSaveNotes.TabIndex = 1
        BtnSaveNotes.Text = "Save Notes"
        BtnSaveNotes.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.AcceptsTab = True
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.AutoWordSelection = True
        RichTextBox1.BackColor = SystemColors.Info
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Franklin Gothic Heavy", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Location = New Point(30, 49)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1549, 572)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Green
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        TableLayoutPanel2.Location = New Point(12, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1581, 707)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.RosyBrown
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 31)
        Label3.TabIndex = 0
        Label3.Text = "Notes and AddOns Section :"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Green
        TabPage3.Controls.Add(TableLayoutPanel3)
        TabPage3.Controls.Add(RichTextBox2)
        TabPage3.Controls.Add(Label11)
        TabPage3.Location = New Point(4, 40)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1599, 725)
        TabPage3.TabIndex = 4
        TabPage3.Text = "Inventory Manager"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.BackColor = Color.SkyBlue
        TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(BtnSaveInventory, 1, 6)
        TableLayoutPanel3.Controls.Add(BtnSetDateTime, 0, 6)
        TableLayoutPanel3.Controls.Add(TextBox6, 1, 5)
        TableLayoutPanel3.Controls.Add(TextBox5, 1, 4)
        TableLayoutPanel3.Controls.Add(TextBox4, 1, 3)
        TableLayoutPanel3.Controls.Add(TextBox3, 1, 2)
        TableLayoutPanel3.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel3.Controls.Add(Label8, 0, 3)
        TableLayoutPanel3.Controls.Add(Label9, 0, 4)
        TableLayoutPanel3.Controls.Add(Label10, 0, 5)
        TableLayoutPanel3.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel3.Controls.Add(Label6, 0, 0)
        TableLayoutPanel3.Controls.Add(Label5, 0, 2)
        TableLayoutPanel3.Controls.Add(Label7, 0, 1)
        TableLayoutPanel3.Location = New Point(52, 20)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 7
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.Size = New Size(722, 678)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' BtnSaveInventory
        ' 
        BtnSaveInventory.Anchor = AnchorStyles.None
        BtnSaveInventory.BackColor = Color.Black
        BtnSaveInventory.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        BtnSaveInventory.ForeColor = Color.White
        BtnSaveInventory.Location = New Point(382, 592)
        BtnSaveInventory.Name = "BtnSaveInventory"
        BtnSaveInventory.Size = New Size(318, 69)
        BtnSaveInventory.TabIndex = 1
        BtnSaveInventory.Text = "Save Inventory"
        BtnSaveInventory.UseVisualStyleBackColor = False
        ' 
        ' BtnSetDateTime
        ' 
        BtnSetDateTime.Anchor = AnchorStyles.None
        BtnSetDateTime.BackColor = Color.Black
        BtnSetDateTime.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        BtnSetDateTime.ForeColor = Color.White
        BtnSetDateTime.Location = New Point(75, 591)
        BtnSetDateTime.Name = "BtnSetDateTime"
        BtnSetDateTime.Size = New Size(211, 72)
        BtnSetDateTime.TabIndex = 2
        BtnSetDateTime.Text = "Set Date & Time"
        BtnSetDateTime.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        TextBox6.Location = New Point(388, 507)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(305, 43)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        TextBox5.Location = New Point(388, 411)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(305, 43)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        TextBox4.Location = New Point(388, 315)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(305, 43)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        TextBox3.Location = New Point(388, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(305, 43)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        TextBox2.Location = New Point(388, 123)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(305, 43)
        TextBox2.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label8.Location = New Point(5, 318)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 38)
        Label8.TabIndex = 3
        Label8.Text = "Quantity"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label9.Location = New Point(5, 414)
        Label9.Name = "Label9"
        Label9.Size = New Size(254, 38)
        Label9.TabIndex = 4
        Label9.Text = "Price Per Quantity"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label10.Location = New Point(5, 510)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 38)
        Label10.TabIndex = 5
        Label10.Text = "Total"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(388, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(305, 43)
        TextBox1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label6.Location = New Point(5, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 38)
        Label6.TabIndex = 1
        Label6.Text = "Date"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(5, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 38)
        Label5.TabIndex = 0
        Label5.Text = "Item"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(5, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 38)
        Label7.TabIndex = 2
        Label7.Text = "Time"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.AcceptsTab = True
        RichTextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        RichTextBox2.AutoWordSelection = True
        RichTextBox2.BackColor = SystemColors.Info
        RichTextBox2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        RichTextBox2.Location = New Point(906, 73)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(642, 532)
        RichTextBox2.TabIndex = 13
        RichTextBox2.Text = ""
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.RosyBrown
        Label11.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label11.Location = New Point(866, 20)
        Label11.Name = "Label11"
        Label11.Size = New Size(145, 38)
        Label11.TabIndex = 6
        Label11.Text = "Remarks :"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(1631, 793)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Form"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(MembershipDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAddRow As Button
    Friend WithEvents BtnStrikeRow As Button
    Friend WithEvents TotalRevenueLabel1 As Label
    Friend WithEvents BtnEndTime As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents BtnStartTime As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnClearRevenue As Button
    Friend WithEvents BtnCalculateRevenue As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MembershipDataGrid As DataGridView
    Friend WithEvents BtnAddMember As Button
    Friend WithEvents BtnDetails As Button
    Friend WithEvents BtnCheckExpired As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnCheckActive As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnSaveNotes As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnTotal As Button
    Friend WithEvents ExpiredMemberLabel As Label
    Friend WithEvents ActiveMemberLabel As Label
    Friend WithEvents BtnBaseTotal As Button
    Friend WithEvents TotalTableChargeLabel As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSetDateTime As Button
    Friend WithEvents BtnSaveInventory As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox

End Class
