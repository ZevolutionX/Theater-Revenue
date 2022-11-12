<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ashley_TheaterRevenue1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ashley_TheaterRevenue1))
        Me.gbxAdultTicketSales = New System.Windows.Forms.GroupBox()
        Me.ATS_TS_Box = New System.Windows.Forms.TextBox()
        Me.ATS_PPT_Box = New System.Windows.Forms.TextBox()
        Me.lblPPT_TS = New System.Windows.Forms.Label()
        Me.lblATS_PPT = New System.Windows.Forms.Label()
        Me.gbxChildTicketSales = New System.Windows.Forms.GroupBox()
        Me.CTS_TS_Box = New System.Windows.Forms.TextBox()
        Me.CTS_PPT_Box = New System.Windows.Forms.TextBox()
        Me.lblCTS_TS = New System.Windows.Forms.Label()
        Me.lblPPT_CTS = New System.Windows.Forms.Label()
        Me.gbxGrossTicketRevenue = New System.Windows.Forms.GroupBox()
        Me.GTR_TGRTS = New System.Windows.Forms.Label()
        Me.GTR_CTS_Box = New System.Windows.Forms.Label()
        Me.GTR_ATS_Box = New System.Windows.Forms.Label()
        Me.lblTGR_TS = New System.Windows.Forms.Label()
        Me.lbl_GTR_CTS = New System.Windows.Forms.Label()
        Me.lblGTR_ATS = New System.Windows.Forms.Label()
        Me.gbxNetTicketRevenue = New System.Windows.Forms.GroupBox()
        Me.NTR_TNRTS = New System.Windows.Forms.Label()
        Me.NTR_CTS_Box = New System.Windows.Forms.Label()
        Me.NTR_ATS_Box = New System.Windows.Forms.Label()
        Me.lblTNR_TS = New System.Windows.Forms.Label()
        Me.lblCTS_NTR = New System.Windows.Forms.Label()
        Me.lbNTS_NTR = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tdyDate = New System.Windows.Forms.Label()
        Me.TT_ST = New System.Windows.Forms.Label()
        Me.ctrButton = New System.Windows.Forms.Button()
        Me.clrButton = New System.Windows.Forms.Button()
        Me.extButton = New System.Windows.Forms.Button()
        Me.gbxAdultTicketSales.SuspendLayout()
        Me.gbxChildTicketSales.SuspendLayout()
        Me.gbxGrossTicketRevenue.SuspendLayout()
        Me.gbxNetTicketRevenue.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxAdultTicketSales
        '
        Me.gbxAdultTicketSales.Controls.Add(Me.ATS_TS_Box)
        Me.gbxAdultTicketSales.Controls.Add(Me.ATS_PPT_Box)
        Me.gbxAdultTicketSales.Controls.Add(Me.lblPPT_TS)
        Me.gbxAdultTicketSales.Controls.Add(Me.lblATS_PPT)
        Me.gbxAdultTicketSales.Location = New System.Drawing.Point(12, 12)
        Me.gbxAdultTicketSales.Name = "gbxAdultTicketSales"
        Me.gbxAdultTicketSales.Size = New System.Drawing.Size(331, 172)
        Me.gbxAdultTicketSales.TabIndex = 0
        Me.gbxAdultTicketSales.TabStop = False
        Me.gbxAdultTicketSales.Text = "Adult Ticket Sales"
        '
        'ATS_TS_Box
        '
        Me.ATS_TS_Box.Location = New System.Drawing.Point(222, 105)
        Me.ATS_TS_Box.Name = "ATS_TS_Box"
        Me.ATS_TS_Box.Size = New System.Drawing.Size(100, 20)
        Me.ATS_TS_Box.TabIndex = 1
        '
        'ATS_PPT_Box
        '
        Me.ATS_PPT_Box.Location = New System.Drawing.Point(222, 32)
        Me.ATS_PPT_Box.Name = "ATS_PPT_Box"
        Me.ATS_PPT_Box.Size = New System.Drawing.Size(100, 20)
        Me.ATS_PPT_Box.TabIndex = 0
        '
        'lblPPT_TS
        '
        Me.lblPPT_TS.AutoSize = True
        Me.lblPPT_TS.Location = New System.Drawing.Point(6, 108)
        Me.lblPPT_TS.Name = "lblPPT_TS"
        Me.lblPPT_TS.Size = New System.Drawing.Size(66, 13)
        Me.lblPPT_TS.TabIndex = 6
        Me.lblPPT_TS.Text = "Tickets Sold"
        '
        'lblATS_PPT
        '
        Me.lblATS_PPT.AutoSize = True
        Me.lblATS_PPT.Location = New System.Drawing.Point(6, 35)
        Me.lblATS_PPT.Name = "lblATS_PPT"
        Me.lblATS_PPT.Size = New System.Drawing.Size(83, 13)
        Me.lblATS_PPT.TabIndex = 5
        Me.lblATS_PPT.Text = "Price Per Ticket"
        '
        'gbxChildTicketSales
        '
        Me.gbxChildTicketSales.AccessibleDescription = ""
        Me.gbxChildTicketSales.Controls.Add(Me.CTS_TS_Box)
        Me.gbxChildTicketSales.Controls.Add(Me.CTS_PPT_Box)
        Me.gbxChildTicketSales.Controls.Add(Me.lblCTS_TS)
        Me.gbxChildTicketSales.Controls.Add(Me.lblPPT_CTS)
        Me.gbxChildTicketSales.Location = New System.Drawing.Point(457, 12)
        Me.gbxChildTicketSales.Name = "gbxChildTicketSales"
        Me.gbxChildTicketSales.Size = New System.Drawing.Size(331, 172)
        Me.gbxChildTicketSales.TabIndex = 1
        Me.gbxChildTicketSales.TabStop = False
        Me.gbxChildTicketSales.Text = "Child Ticket Sales"
        '
        'CTS_TS_Box
        '
        Me.CTS_TS_Box.Location = New System.Drawing.Point(215, 105)
        Me.CTS_TS_Box.Name = "CTS_TS_Box"
        Me.CTS_TS_Box.Size = New System.Drawing.Size(100, 20)
        Me.CTS_TS_Box.TabIndex = 3
        '
        'CTS_PPT_Box
        '
        Me.CTS_PPT_Box.Location = New System.Drawing.Point(215, 28)
        Me.CTS_PPT_Box.Name = "CTS_PPT_Box"
        Me.CTS_PPT_Box.Size = New System.Drawing.Size(100, 20)
        Me.CTS_PPT_Box.TabIndex = 2
        '
        'lblCTS_TS
        '
        Me.lblCTS_TS.AutoSize = True
        Me.lblCTS_TS.Location = New System.Drawing.Point(6, 108)
        Me.lblCTS_TS.Name = "lblCTS_TS"
        Me.lblCTS_TS.Size = New System.Drawing.Size(66, 13)
        Me.lblCTS_TS.TabIndex = 7
        Me.lblCTS_TS.Text = "Tickets Sold"
        '
        'lblPPT_CTS
        '
        Me.lblPPT_CTS.AutoSize = True
        Me.lblPPT_CTS.Location = New System.Drawing.Point(6, 35)
        Me.lblPPT_CTS.Name = "lblPPT_CTS"
        Me.lblPPT_CTS.Size = New System.Drawing.Size(83, 13)
        Me.lblPPT_CTS.TabIndex = 6
        Me.lblPPT_CTS.Text = "Price Per Ticket"
        '
        'gbxGrossTicketRevenue
        '
        Me.gbxGrossTicketRevenue.Controls.Add(Me.GTR_TGRTS)
        Me.gbxGrossTicketRevenue.Controls.Add(Me.GTR_CTS_Box)
        Me.gbxGrossTicketRevenue.Controls.Add(Me.GTR_ATS_Box)
        Me.gbxGrossTicketRevenue.Controls.Add(Me.lblTGR_TS)
        Me.gbxGrossTicketRevenue.Controls.Add(Me.lbl_GTR_CTS)
        Me.gbxGrossTicketRevenue.Controls.Add(Me.lblGTR_ATS)
        Me.gbxGrossTicketRevenue.Location = New System.Drawing.Point(12, 190)
        Me.gbxGrossTicketRevenue.Name = "gbxGrossTicketRevenue"
        Me.gbxGrossTicketRevenue.Size = New System.Drawing.Size(331, 172)
        Me.gbxGrossTicketRevenue.TabIndex = 2
        Me.gbxGrossTicketRevenue.TabStop = False
        Me.gbxGrossTicketRevenue.Text = "Gross Ticket Revenue"
        '
        'GTR_TGRTS
        '
        Me.GTR_TGRTS.AutoSize = True
        Me.GTR_TGRTS.Location = New System.Drawing.Point(229, 111)
        Me.GTR_TGRTS.Name = "GTR_TGRTS"
        Me.GTR_TGRTS.Size = New System.Drawing.Size(0, 13)
        Me.GTR_TGRTS.TabIndex = 10
        '
        'GTR_CTS_Box
        '
        Me.GTR_CTS_Box.AutoSize = True
        Me.GTR_CTS_Box.Location = New System.Drawing.Point(229, 73)
        Me.GTR_CTS_Box.Name = "GTR_CTS_Box"
        Me.GTR_CTS_Box.Size = New System.Drawing.Size(0, 13)
        Me.GTR_CTS_Box.TabIndex = 9
        '
        'GTR_ATS_Box
        '
        Me.GTR_ATS_Box.AutoSize = True
        Me.GTR_ATS_Box.Location = New System.Drawing.Point(229, 36)
        Me.GTR_ATS_Box.Name = "GTR_ATS_Box"
        Me.GTR_ATS_Box.Size = New System.Drawing.Size(0, 13)
        Me.GTR_ATS_Box.TabIndex = 8
        '
        'lblTGR_TS
        '
        Me.lblTGR_TS.AutoSize = True
        Me.lblTGR_TS.Location = New System.Drawing.Point(6, 111)
        Me.lblTGR_TS.Name = "lblTGR_TS"
        Me.lblTGR_TS.Size = New System.Drawing.Size(188, 13)
        Me.lblTGR_TS.TabIndex = 7
        Me.lblTGR_TS.Text = "Total Gross Revenue For Ticket Sales"
        '
        'lbl_GTR_CTS
        '
        Me.lbl_GTR_CTS.AutoSize = True
        Me.lbl_GTR_CTS.Location = New System.Drawing.Point(6, 73)
        Me.lbl_GTR_CTS.Name = "lbl_GTR_CTS"
        Me.lbl_GTR_CTS.Size = New System.Drawing.Size(92, 13)
        Me.lbl_GTR_CTS.TabIndex = 6
        Me.lbl_GTR_CTS.Text = "Child Ticket Sales"
        '
        'lblGTR_ATS
        '
        Me.lblGTR_ATS.AutoSize = True
        Me.lblGTR_ATS.Location = New System.Drawing.Point(6, 36)
        Me.lblGTR_ATS.Name = "lblGTR_ATS"
        Me.lblGTR_ATS.Size = New System.Drawing.Size(93, 13)
        Me.lblGTR_ATS.TabIndex = 6
        Me.lblGTR_ATS.Text = "Adult Ticket Sales"
        '
        'gbxNetTicketRevenue
        '
        Me.gbxNetTicketRevenue.Controls.Add(Me.NTR_TNRTS)
        Me.gbxNetTicketRevenue.Controls.Add(Me.NTR_CTS_Box)
        Me.gbxNetTicketRevenue.Controls.Add(Me.NTR_ATS_Box)
        Me.gbxNetTicketRevenue.Controls.Add(Me.lblTNR_TS)
        Me.gbxNetTicketRevenue.Controls.Add(Me.lblCTS_NTR)
        Me.gbxNetTicketRevenue.Controls.Add(Me.lbNTS_NTR)
        Me.gbxNetTicketRevenue.Location = New System.Drawing.Point(457, 190)
        Me.gbxNetTicketRevenue.Name = "gbxNetTicketRevenue"
        Me.gbxNetTicketRevenue.Size = New System.Drawing.Size(331, 172)
        Me.gbxNetTicketRevenue.TabIndex = 3
        Me.gbxNetTicketRevenue.TabStop = False
        Me.gbxNetTicketRevenue.Text = "Net Ticket Revenue"
        '
        'NTR_TNRTS
        '
        Me.NTR_TNRTS.AutoSize = True
        Me.NTR_TNRTS.Location = New System.Drawing.Point(222, 111)
        Me.NTR_TNRTS.Name = "NTR_TNRTS"
        Me.NTR_TNRTS.Size = New System.Drawing.Size(0, 13)
        Me.NTR_TNRTS.TabIndex = 12
        '
        'NTR_CTS_Box
        '
        Me.NTR_CTS_Box.AutoSize = True
        Me.NTR_CTS_Box.Location = New System.Drawing.Point(222, 73)
        Me.NTR_CTS_Box.Name = "NTR_CTS_Box"
        Me.NTR_CTS_Box.Size = New System.Drawing.Size(0, 13)
        Me.NTR_CTS_Box.TabIndex = 11
        '
        'NTR_ATS_Box
        '
        Me.NTR_ATS_Box.AutoSize = True
        Me.NTR_ATS_Box.Location = New System.Drawing.Point(222, 36)
        Me.NTR_ATS_Box.Name = "NTR_ATS_Box"
        Me.NTR_ATS_Box.Size = New System.Drawing.Size(0, 13)
        Me.NTR_ATS_Box.TabIndex = 10
        '
        'lblTNR_TS
        '
        Me.lblTNR_TS.AutoSize = True
        Me.lblTNR_TS.Location = New System.Drawing.Point(6, 111)
        Me.lblTNR_TS.Name = "lblTNR_TS"
        Me.lblTNR_TS.Size = New System.Drawing.Size(178, 13)
        Me.lblTNR_TS.TabIndex = 9
        Me.lblTNR_TS.Text = "Total Net Revenue For Ticket Sales"
        '
        'lblCTS_NTR
        '
        Me.lblCTS_NTR.AutoSize = True
        Me.lblCTS_NTR.Location = New System.Drawing.Point(6, 73)
        Me.lblCTS_NTR.Name = "lblCTS_NTR"
        Me.lblCTS_NTR.Size = New System.Drawing.Size(92, 13)
        Me.lblCTS_NTR.TabIndex = 8
        Me.lblCTS_NTR.Text = "Child Ticket Sales"
        '
        'lbNTS_NTR
        '
        Me.lbNTS_NTR.AutoSize = True
        Me.lbNTS_NTR.Location = New System.Drawing.Point(6, 36)
        Me.lbNTS_NTR.Name = "lbNTS_NTR"
        Me.lbNTS_NTR.Size = New System.Drawing.Size(93, 13)
        Me.lbNTS_NTR.TabIndex = 7
        Me.lbNTS_NTR.Text = "Adult Ticket Sales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(349, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 193)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'tdyDate
        '
        Me.tdyDate.AutoSize = True
        Me.tdyDate.Location = New System.Drawing.Point(18, 365)
        Me.tdyDate.Name = "tdyDate"
        Me.tdyDate.Size = New System.Drawing.Size(68, 13)
        Me.tdyDate.TabIndex = 10
        Me.tdyDate.Text = "Todays Date"
        '
        'TT_ST
        '
        Me.TT_ST.AutoSize = True
        Me.TT_ST.Location = New System.Drawing.Point(463, 365)
        Me.TT_ST.Name = "TT_ST"
        Me.TT_ST.Size = New System.Drawing.Size(93, 13)
        Me.TT_ST.TabIndex = 11
        Me.TT_ST.Text = "Total Ticket Sales"
        '
        'ctrButton
        '
        Me.ctrButton.Location = New System.Drawing.Point(21, 394)
        Me.ctrButton.Name = "ctrButton"
        Me.ctrButton.Size = New System.Drawing.Size(151, 34)
        Me.ctrButton.TabIndex = 4
        Me.ctrButton.Text = "&Calculate Ticket Revenue"
        Me.ctrButton.UseVisualStyleBackColor = True
        '
        'clrButton
        '
        Me.clrButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clrButton.Location = New System.Drawing.Point(514, 394)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(127, 34)
        Me.clrButton.TabIndex = 5
        Me.clrButton.Text = "Cl&ear"
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'extButton
        '
        Me.extButton.Location = New System.Drawing.Point(661, 394)
        Me.extButton.Name = "extButton"
        Me.extButton.Size = New System.Drawing.Size(127, 34)
        Me.extButton.TabIndex = 6
        Me.extButton.Text = "E&xit"
        Me.extButton.UseVisualStyleBackColor = True
        '
        'Ashley_TheaterRevenue1
        '
        Me.AcceptButton = Me.ctrButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.clrButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.extButton)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.ctrButton)
        Me.Controls.Add(Me.TT_ST)
        Me.Controls.Add(Me.tdyDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxNetTicketRevenue)
        Me.Controls.Add(Me.gbxGrossTicketRevenue)
        Me.Controls.Add(Me.gbxChildTicketSales)
        Me.Controls.Add(Me.gbxAdultTicketSales)
        Me.Name = "Ashley_TheaterRevenue1"
        Me.Text = "Theater Revenue by Alfred Ashley"
        Me.gbxAdultTicketSales.ResumeLayout(False)
        Me.gbxAdultTicketSales.PerformLayout()
        Me.gbxChildTicketSales.ResumeLayout(False)
        Me.gbxChildTicketSales.PerformLayout()
        Me.gbxGrossTicketRevenue.ResumeLayout(False)
        Me.gbxGrossTicketRevenue.PerformLayout()
        Me.gbxNetTicketRevenue.ResumeLayout(False)
        Me.gbxNetTicketRevenue.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxAdultTicketSales As GroupBox
    Friend WithEvents gbxChildTicketSales As GroupBox
    Friend WithEvents gbxGrossTicketRevenue As GroupBox
    Friend WithEvents gbxNetTicketRevenue As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblATS_PPT As Label
    Friend WithEvents lblPPT_TS As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblATS_PPT.Click

    End Sub

    Friend WithEvents lblCTS_TS As Label
    Friend WithEvents lblPPT_CTS As Label
    Friend WithEvents lbl_GTR_CTS As Label
    Friend WithEvents lblGTR_ATS As Label
    Friend WithEvents lblTGR_TS As Label
    Friend WithEvents ATS_TS_Box As TextBox
    Friend WithEvents ATS_PPT_Box As TextBox
    Friend WithEvents CTS_TS_Box As TextBox
    Friend WithEvents CTS_PPT_Box As TextBox
    Friend WithEvents GTR_TGRTS As Label
    Friend WithEvents GTR_CTS_Box As Label
    Friend WithEvents GTR_ATS_Box As Label
    Friend WithEvents NTR_TNRTS As Label
    Friend WithEvents NTR_CTS_Box As Label
    Friend WithEvents NTR_ATS_Box As Label
    Friend WithEvents lblTNR_TS As Label
    Friend WithEvents lblCTS_NTR As Label
    Friend WithEvents lbNTS_NTR As Label
    Friend WithEvents tdyDate As Label
    Friend WithEvents TT_ST As Label
    Friend WithEvents ctrButton As Button
    Friend WithEvents clrButton As Button
    Friend WithEvents extButton As Button

    Private Sub gbxAdultTicketSales_Enter(sender As Object, e As EventArgs) Handles gbxAdultTicketSales.Enter

    End Sub

    Private Sub Ashley_TheaterRevenue1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
