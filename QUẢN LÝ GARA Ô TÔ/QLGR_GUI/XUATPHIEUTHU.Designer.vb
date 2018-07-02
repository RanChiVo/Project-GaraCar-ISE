<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XUATPHIEUTHU
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
        Me.QlgrDataSet1 = New QLGR_GUI.QLGRDataSet()
        Me.PhieuthutienTableAdapter1 = New QLGR_GUI.QLGRDataSetTableAdapters.PHIEUTHUTIENTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRYRPLAPPHIEUTHUTIEN1 = New QLGR_GUI.CRYRPLAPPHIEUTHUTIEN()
        Me.cryrplapphieuthutien2 = New QLGR_GUI.CRYRPLAPPHIEUTHUTIEN()
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QlgrDataSet1
        '
        Me.QlgrDataSet1.DataSetName = "QLGRDataSet"
        Me.QlgrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhieuthutienTableAdapter1
        '
        Me.PhieuthutienTableAdapter1.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'XUATPHIEUTHU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "XUATPHIEUTHU"
        Me.Text = "XUATPHIEUTHU"
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QlgrDataSet1 As QLGRDataSet
    Friend WithEvents PhieuthutienTableAdapter1 As QLGRDataSetTableAdapters.PHIEUTHUTIENTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRYRPLAPPHIEUTHUTIEN1 As CRYRPLAPPHIEUTHUTIEN
    Friend WithEvents cryrplapphieuthutien2 As CRYRPLAPPHIEUTHUTIEN
End Class
