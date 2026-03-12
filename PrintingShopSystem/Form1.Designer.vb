<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewTransactionToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        ClearFormToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutSystemToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtCustomerName = New TextBox()
        cmbServiceType = New ComboBox()
        cmbUrgency = New ComboBox()
        txtQuantity = New TextBox()
        btnCalculate = New Button()
        txtReceipt = New TextBox()
        btnSave = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(634, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTransactionToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewTransactionToolStripMenuItem
        ' 
        NewTransactionToolStripMenuItem.Name = "NewTransactionToolStripMenuItem"
        NewTransactionToolStripMenuItem.Size = New Size(162, 22)
        NewTransactionToolStripMenuItem.Text = "New Transaction"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(162, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearFormToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(47, 20)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' ClearFormToolStripMenuItem
        ' 
        ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        ClearFormToolStripMenuItem.Size = New Size(132, 22)
        ClearFormToolStripMenuItem.Text = "Clear Form"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutSystemToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutSystemToolStripMenuItem
        ' 
        AboutSystemToolStripMenuItem.Name = "AboutSystemToolStripMenuItem"
        AboutSystemToolStripMenuItem.Size = New Size(180, 22)
        AboutSystemToolStripMenuItem.Text = "About"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 7
        Label1.Text = "Customer Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 8
        Label2.Text = "Type of Service"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(332, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 9
        Label3.Text = "Urgency Level"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(332, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 10
        Label4.Text = "Number of Copies"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(136, 39)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(178, 23)
        txtCustomerName.TabIndex = 11
        ' 
        ' cmbServiceType
        ' 
        cmbServiceType.FormattingEnabled = True
        cmbServiceType.Items.AddRange(New Object() {"Business Cards", "Flyers", "Banners", "Stickers", "T-Shirts"})
        cmbServiceType.Location = New Point(136, 75)
        cmbServiceType.Name = "cmbServiceType"
        cmbServiceType.Size = New Size(178, 23)
        cmbServiceType.TabIndex = 12
        ' 
        ' cmbUrgency
        ' 
        cmbUrgency.FormattingEnabled = True
        cmbUrgency.Items.AddRange(New Object() {"Normal", "Express"})
        cmbUrgency.Location = New Point(447, 39)
        cmbUrgency.Name = "cmbUrgency"
        cmbUrgency.Size = New Size(131, 23)
        cmbUrgency.TabIndex = 13
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(447, 77)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(84, 23)
        txtQuantity.TabIndex = 14
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(90, 130)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(267, 41)
        btnCalculate.TabIndex = 15
        btnCalculate.Text = "Calculate and Show Receipt"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtReceipt
        ' 
        txtReceipt.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReceipt.Location = New Point(44, 189)
        txtReceipt.Multiline = True
        txtReceipt.Name = "txtReceipt"
        txtReceipt.ReadOnly = True
        txtReceipt.ScrollBars = ScrollBars.Vertical
        txtReceipt.Size = New Size(547, 236)
        txtReceipt.TabIndex = 16
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(421, 130)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 41)
        btnSave.TabIndex = 17
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 461)
        Controls.Add(btnSave)
        Controls.Add(txtReceipt)
        Controls.Add(btnCalculate)
        Controls.Add(txtQuantity)
        Controls.Add(cmbUrgency)
        Controls.Add(cmbServiceType)
        Controls.Add(txtCustomerName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Printing and Branding Shop System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSystemToolStripMenuItem As ToolStripMenuItem

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cmbServiceType As ComboBox
    Friend WithEvents cmbUrgency As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtReceipt As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents btnSave As Button
End Class
