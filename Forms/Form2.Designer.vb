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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        BtnAddRow = New Button()
        BtnStrikeRow = New Button()
        GroupBox1 = New GroupBox()
        BtnClearRevenue = New Button()
        BtnCalculateRevenue = New Button()
        BtnStartTime = New Button()
        BtnEndTime = New Button()
        Button7 = New Button()
        Button3 = New Button()
        BtnExit = New Button()
        TotalRevenueLabel1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        DataGridView1 = New DataGridView()
        TabPage2 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1358, 769)
        TabControl1.SizeMode = TabSizeMode.FillToRight
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Controls.Add(FlowLayoutPanel1)
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Location = New Point(4, 37)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1350, 728)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Entry Manager"
        TabPage1.UseVisualStyleBackColor = True
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
        TableLayoutPanel1.Controls.Add(BtnAddRow, 0, 0)
        TableLayoutPanel1.Controls.Add(BtnStrikeRow, 0, 1)
        TableLayoutPanel1.Controls.Add(GroupBox1, 5, 1)
        TableLayoutPanel1.Controls.Add(BtnStartTime, 1, 0)
        TableLayoutPanel1.Controls.Add(BtnEndTime, 1, 1)
        TableLayoutPanel1.Controls.Add(Button7, 2, 1)
        TableLayoutPanel1.Controls.Add(Button3, 3, 1)
        TableLayoutPanel1.Controls.Add(BtnExit, 4, 1)
        TableLayoutPanel1.Controls.Add(TotalRevenueLabel1, 5, 0)
        TableLayoutPanel1.Location = New Point(21, 617)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1307, 105)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' BtnAddRow
        ' 
        BtnAddRow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnAddRow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnAddRow.Location = New Point(3, 9)
        BtnAddRow.Name = "BtnAddRow"
        BtnAddRow.Size = New Size(204, 40)
        BtnAddRow.TabIndex = 1
        BtnAddRow.Text = "Add Row"
        BtnAddRow.UseVisualStyleBackColor = True
        ' 
        ' BtnStrikeRow
        ' 
        BtnStrikeRow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnStrikeRow.Location = New Point(3, 62)
        BtnStrikeRow.Name = "BtnStrikeRow"
        BtnStrikeRow.Size = New Size(204, 40)
        BtnStrikeRow.TabIndex = 2
        BtnStrikeRow.Text = "StrikeOut"
        BtnStrikeRow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(BtnClearRevenue)
        GroupBox1.Controls.Add(BtnCalculateRevenue)
        GroupBox1.Location = New Point(1053, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(251, 47)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' BtnClearRevenue
        ' 
        BtnClearRevenue.Anchor = AnchorStyles.Right
        BtnClearRevenue.AutoSize = True
        BtnClearRevenue.Location = New Point(160, 7)
        BtnClearRevenue.Name = "BtnClearRevenue"
        BtnClearRevenue.Size = New Size(85, 40)
        BtnClearRevenue.TabIndex = 13
        BtnClearRevenue.Text = "Clear"
        BtnClearRevenue.UseVisualStyleBackColor = True
        ' 
        ' BtnCalculateRevenue
        ' 
        BtnCalculateRevenue.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        BtnCalculateRevenue.AutoSize = True
        BtnCalculateRevenue.Location = New Point(0, 7)
        BtnCalculateRevenue.Name = "BtnCalculateRevenue"
        BtnCalculateRevenue.Size = New Size(154, 41)
        BtnCalculateRevenue.TabIndex = 12
        BtnCalculateRevenue.Text = "Total Revenue"
        BtnCalculateRevenue.UseVisualStyleBackColor = True
        ' 
        ' BtnStartTime
        ' 
        BtnStartTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnStartTime.Location = New Point(213, 9)
        BtnStartTime.Name = "BtnStartTime"
        BtnStartTime.Size = New Size(204, 40)
        BtnStartTime.TabIndex = 5
        BtnStartTime.Text = "Start Time"
        BtnStartTime.UseVisualStyleBackColor = True
        ' 
        ' BtnEndTime
        ' 
        BtnEndTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnEndTime.Location = New Point(213, 62)
        BtnEndTime.Name = "BtnEndTime"
        BtnEndTime.Size = New Size(204, 40)
        BtnEndTime.TabIndex = 6
        BtnEndTime.Text = "End Time"
        BtnEndTime.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button7.Location = New Point(423, 62)
        Button7.Name = "Button7"
        Button7.Size = New Size(204, 40)
        Button7.TabIndex = 7
        Button7.Text = "Calculate"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.Location = New Point(633, 62)
        Button3.Name = "Button3"
        Button3.Size = New Size(204, 40)
        Button3.TabIndex = 3
        Button3.Text = "Export"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnExit.Location = New Point(843, 62)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(204, 40)
        BtnExit.TabIndex = 4
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' TotalRevenueLabel1
        ' 
        TotalRevenueLabel1.Anchor = AnchorStyles.Bottom
        TotalRevenueLabel1.BackColor = SystemColors.Control
        TotalRevenueLabel1.BorderStyle = BorderStyle.FixedSingle
        TotalRevenueLabel1.Location = New Point(1053, 14)
        TotalRevenueLabel1.Name = "TotalRevenueLabel1"
        TotalRevenueLabel1.Size = New Size(251, 38)
        TotalRevenueLabel1.TabIndex = 11
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Location = New Point(802, 455)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(0, 0)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 20)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1300, 580)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 37)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1350, 728)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Membership Manager"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 793)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Form"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnStartTime As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnClearRevenue As Button
    Friend WithEvents BtnCalculateRevenue As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox

End Class
