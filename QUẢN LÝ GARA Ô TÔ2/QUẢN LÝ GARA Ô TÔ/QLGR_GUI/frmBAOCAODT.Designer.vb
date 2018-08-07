<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBAOCAODT
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalRPBAOCAODT1 = New QLGR_GUI.CrystalRPBAOCAODT()
        Me.CbThang = New System.Windows.Forms.ComboBox()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.QlgrDataSet1 = New QLGR_GUI.QLGRDataSet()
        Me.BaocaodoanhthuTableAdapter1 = New QLGR_GUI.QLGRDataSetTableAdapters.BAOCAODOANHTHUTableAdapter()
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 37)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalRPBAOCAODT1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(795, 413)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'CbThang
        '
        Me.CbThang.FormattingEnabled = True
        Me.CbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CbThang.Location = New System.Drawing.Point(240, 4)
        Me.CbThang.Name = "CbThang"
        Me.CbThang.Size = New System.Drawing.Size(47, 21)
        Me.CbThang.TabIndex = 1
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(413, 5)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(57, 20)
        Me.txtNam.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tháng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Năm:"
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(543, 4)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(75, 23)
        Me.btnThongKe.TabIndex = 5
        Me.btnThongKe.Text = "Thống kê:"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'QlgrDataSet1
        '
        Me.QlgrDataSet1.DataSetName = "QLGRDataSet"
        Me.QlgrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaocaodoanhthuTableAdapter1
        '
        Me.BaocaodoanhthuTableAdapter1.ClearBeforeFill = True
        '
        'frmBAOCAODT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.CbThang)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmBAOCAODT"
        Me.Text = "frmBAOCAODT"
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalRPBAOCAODT1 As CrystalRPBAOCAODT
    Friend WithEvents CbThang As ComboBox
    Friend WithEvents txtNam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThongKe As Button
    Friend WithEvents QlgrDataSet1 As QLGRDataSet
    Friend WithEvents BaocaodoanhthuTableAdapter1 As QLGRDataSetTableAdapters.BAOCAODOANHTHUTableAdapter
End Class
