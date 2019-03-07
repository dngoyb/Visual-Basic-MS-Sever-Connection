<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiEditUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miInventory, Me.ManageUsersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "msMain"
        '
        'miInventory
        '
        Me.miInventory.Name = "miInventory"
        Me.miInventory.Size = New System.Drawing.Size(82, 24)
        Me.miInventory.Text = "Inventory"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiNewUser, Me.msiDeleteUser, Me.msiEditUser})
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'msiNewUser
        '
        Me.msiNewUser.Name = "msiNewUser"
        Me.msiNewUser.Size = New System.Drawing.Size(216, 26)
        Me.msiNewUser.Text = "New User"
        '
        'msiDeleteUser
        '
        Me.msiDeleteUser.Name = "msiDeleteUser"
        Me.msiDeleteUser.Size = New System.Drawing.Size(216, 26)
        Me.msiDeleteUser.Text = "Delete User"
        '
        'msiEditUser
        '
        Me.msiEditUser.Name = "msiEditUser"
        Me.msiEditUser.Size = New System.Drawing.Size(216, 26)
        Me.msiEditUser.Text = "Edit User"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 475)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents miInventory As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msiNewUser As ToolStripMenuItem
    Friend WithEvents msiDeleteUser As ToolStripMenuItem
    Friend WithEvents msiEditUser As ToolStripMenuItem
End Class
