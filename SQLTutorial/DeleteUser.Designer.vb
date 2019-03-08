<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
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
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.lbUsers = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(96, 57)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(230, 22)
        Me.txtFilter.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(96, 351)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(230, 23)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'lbUsers
        '
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(96, 85)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(230, 259)
        Me.lbUsers.TabIndex = 2
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 450)
        Me.Controls.Add(Me.lbUsers)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilter As TextBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents lbUsers As CheckedListBox
End Class
