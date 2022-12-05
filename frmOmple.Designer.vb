<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOmple
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bt = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lb1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lb2 = New MaterialSkin.Controls.MaterialLabel()
        Me.pb1 = New PictureBoxExtended.PictureBoxExtended()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pb2 = New PictureBoxExtended.PictureBoxExtended()
        Me.lb3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1lb4 = New MaterialSkin.Controls.MaterialLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.bt, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lb2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pb1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pb2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialLabel1lb4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2810, 1457)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'bt
        '
        Me.bt.AutoSize = True
        Me.bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.SetColumnSpan(Me.bt, 2)
        Me.bt.Depth = 0
        Me.bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bt.Location = New System.Drawing.Point(4, 6)
        Me.bt.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.bt.MouseState = MaterialSkin.MouseState.HOVER
        Me.bt.Name = "bt"
        Me.bt.Primary = False
        Me.bt.Size = New System.Drawing.Size(2802, 88)
        Me.bt.TabIndex = 0
        Me.bt.Text = "Omple i Verifica la BD p2003"
        Me.bt.UseVisualStyleBackColor = True
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Depth = 0
        Me.lb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb1.Location = New System.Drawing.Point(3, 150)
        Me.lb1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(1399, 50)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "MaterialLabel1"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Depth = 0
        Me.lb2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb2.Location = New System.Drawing.Point(1408, 150)
        Me.lb2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(266, 46)
        Me.lb2.TabIndex = 2
        Me.lb2.Text = "MaterialLabel2"
        '
        'pb1
        '
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb1.Location = New System.Drawing.Point(3, 203)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(1399, 1201)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 3
        Me.pb1.TabStop = False
        Me.pb1.WaitOnLoad = True
        '
        'ProgressBar1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ProgressBar1, 2)
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 1410)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(2804, 44)
        Me.ProgressBar1.TabIndex = 5
        '
        'pb2
        '
        Me.pb2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb2.Location = New System.Drawing.Point(1408, 203)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(1399, 1201)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb2.TabIndex = 6
        Me.pb2.TabStop = False
        Me.pb2.WaitOnLoad = True
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Depth = 0
        Me.lb3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb3.Location = New System.Drawing.Point(3, 100)
        Me.lb3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(1399, 50)
        Me.lb3.TabIndex = 7
        Me.lb3.Text = "lb3"
        '
        'MaterialLabel1lb4
        '
        Me.MaterialLabel1lb4.AutoSize = True
        Me.MaterialLabel1lb4.Depth = 0
        Me.MaterialLabel1lb4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1lb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1lb4.Location = New System.Drawing.Point(1408, 100)
        Me.MaterialLabel1lb4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1lb4.Name = "MaterialLabel1lb4"
        Me.MaterialLabel1lb4.Size = New System.Drawing.Size(71, 46)
        Me.MaterialLabel1lb4.TabIndex = 8
        Me.MaterialLabel1lb4.Text = "lb4"
        '
        'frmOmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2810, 1457)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmOmple"
        Me.Text = "Omple BD p2023"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents bt As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lb1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lb2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pb1 As PictureBoxExtended.PictureBoxExtended
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents pb2 As PictureBoxExtended.PictureBoxExtended
    Friend WithEvents lb3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1lb4 As MaterialSkin.Controls.MaterialLabel
End Class
