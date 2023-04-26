<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ファイルFToolStripMenuItem = New ToolStripMenuItem()
        WPSaveFolderOToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        終了XToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        ListView1 = New ListView()
        SaveId = New ColumnHeader()
        WPDate = New ColumnHeader()
        WPName = New ColumnHeader()
        Money = New ColumnHeader()
        Farms = New ColumnHeader()
        Blue = New ColumnHeader()
        Bronze = New ColumnHeader()
        Silver = New ColumnHeader()
        Gold = New ColumnHeader()
        Rainbow = New ColumnHeader()
        Difficulty = New ColumnHeader()
        IsVirtual = New ColumnHeader()
        StartYear = New ColumnHeader()
        SaveDate = New ColumnHeader()
        SplitContainer2 = New SplitContainer()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ListView2 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        BindingSource1 = New BindingSource(components)
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ファイルFToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1147, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ファイルFToolStripMenuItem
        ' 
        ファイルFToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WPSaveFolderOToolStripMenuItem, ToolStripMenuItem1, 終了XToolStripMenuItem})
        ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        ファイルFToolStripMenuItem.Size = New Size(67, 20)
        ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        ' 
        ' WPSaveFolderOToolStripMenuItem
        ' 
        WPSaveFolderOToolStripMenuItem.Name = "WPSaveFolderOToolStripMenuItem"
        WPSaveFolderOToolStripMenuItem.Size = New Size(202, 22)
        WPSaveFolderOToolStripMenuItem.Text = "WPセーブフォルダを選ぶ(&O)"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(199, 6)
        ' 
        ' 終了XToolStripMenuItem
        ' 
        終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        終了XToolStripMenuItem.Size = New Size(202, 22)
        終了XToolStripMenuItem.Text = "終了(&X)"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ListView1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(1147, 627)
        SplitContainer1.SplitterDistance = 538
        SplitContainer1.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {SaveId, WPDate, WPName, Money, Farms, Blue, Bronze, Silver, Gold, Rainbow, Difficulty, IsVirtual, StartYear, SaveDate})
        ListView1.Dock = DockStyle.Fill
        ListView1.Font = New Font("Noto Sans CJK JP Regular", 8.999999F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 0)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(538, 627)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' SaveId
        ' 
        SaveId.Text = "ID"
        ' 
        ' WPDate
        ' 
        WPDate.Text = "年月週"
        ' 
        ' WPName
        ' 
        WPName.Text = "馬主名"
        ' 
        ' Money
        ' 
        Money.Text = "所持金"
        ' 
        ' Farms
        ' 
        Farms.DisplayIndex = 9
        Farms.Text = "ファーム"
        ' 
        ' Blue
        ' 
        Blue.DisplayIndex = 8
        Blue.Text = "青"
        Blue.Width = 30
        ' 
        ' Bronze
        ' 
        Bronze.DisplayIndex = 7
        Bronze.Text = "銅"
        Bronze.Width = 30
        ' 
        ' Silver
        ' 
        Silver.DisplayIndex = 6
        Silver.Text = "銀"
        Silver.Width = 30
        ' 
        ' Gold
        ' 
        Gold.DisplayIndex = 5
        Gold.Text = "金"
        Gold.Width = 30
        ' 
        ' Rainbow
        ' 
        Rainbow.DisplayIndex = 4
        Rainbow.Text = "虹"
        Rainbow.Width = 30
        ' 
        ' Difficulty
        ' 
        Difficulty.DisplayIndex = 11
        Difficulty.Text = "難易度"
        ' 
        ' IsVirtual
        ' 
        IsVirtual.DisplayIndex = 13
        IsVirtual.Text = "史/仮"
        ' 
        ' StartYear
        ' 
        StartYear.Text = "開始年"
        ' 
        ' SaveDate
        ' 
        SaveDate.DisplayIndex = 10
        SaveDate.Text = "セーブ日時"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(Button3)
        SplitContainer2.Panel1.Controls.Add(Button2)
        SplitContainer2.Panel1.Controls.Add(Button1)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(ListView2)
        SplitContainer2.Size = New Size(605, 627)
        SplitContainer2.SplitterDistance = 43
        SplitContainer2.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("BIZ UDゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(3, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 39)
        Button3.TabIndex = 2
        Button3.Text = "🔄"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("BIZ UDゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(1, 294)
        Button2.Name = "Button2"
        Button2.Size = New Size(41, 39)
        Button2.TabIndex = 1
        Button2.Text = "<"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("BIZ UDゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1, 249)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 39)
        Button1.TabIndex = 0
        Button1.Text = ">"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14})
        ListView2.Dock = DockStyle.Fill
        ListView2.Font = New Font("Noto Sans CJK JP Regular", 8.999999F, FontStyle.Regular, GraphicsUnit.Point)
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(0, 0)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(558, 627)
        ListView2.TabIndex = 1
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "年月週"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "馬主名"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "所持金"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.DisplayIndex = 9
        ColumnHeader5.Text = "ファーム"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.DisplayIndex = 8
        ColumnHeader6.Text = "青"
        ColumnHeader6.Width = 30
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.DisplayIndex = 7
        ColumnHeader7.Text = "銅"
        ColumnHeader7.Width = 30
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.DisplayIndex = 6
        ColumnHeader8.Text = "銀"
        ColumnHeader8.Width = 30
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.DisplayIndex = 5
        ColumnHeader9.Text = "金"
        ColumnHeader9.Width = 30
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.DisplayIndex = 4
        ColumnHeader10.Text = "虹"
        ColumnHeader10.Width = 30
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.DisplayIndex = 11
        ColumnHeader11.Text = "難易度"
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.DisplayIndex = 13
        ColumnHeader12.Text = "史/仮"
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "開始年"
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.DisplayIndex = 10
        ColumnHeader14.Text = "セーブ日時"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 30000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 651)
        Controls.Add(SplitContainer1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WPSaveFolderOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents WPDate As ColumnHeader
    Friend WithEvents WPName As ColumnHeader
    Friend WithEvents Difficulty As ColumnHeader
    Friend WithEvents IsVirtual As ColumnHeader
    Friend WithEvents StartYear As ColumnHeader
    Friend WithEvents Blue As ColumnHeader
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Money As ColumnHeader
    Friend WithEvents Bronze As ColumnHeader
    Friend WithEvents Silver As ColumnHeader
    Friend WithEvents Gold As ColumnHeader
    Friend WithEvents Rainbow As ColumnHeader
    Friend WithEvents Farms As ColumnHeader
    Friend WithEvents SaveDate As ColumnHeader
    Friend WithEvents SaveId As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
End Class
