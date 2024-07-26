Imports System
Imports System.IO
'Imports System.Deployment
'Imports System.Deployment.Application
Public Class frmMYMDIPARENT
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

    Private m_Rnd As New Random

    ' Return a random QB color.
    Public Function RandomQBColor() As Color
        Dim color_num As Integer = m_Rnd.Next(0, 15)
        Return Color.FromArgb(QBColor(color_num) + &HFF000000)
    End Function

    ' Return a random RGB color.
    Public Function RandomRGBColor() As Color
        Return Color.FromArgb(255, _
            m_Rnd.Next(0, 255), _
            m_Rnd.Next(0, 255), _
            m_Rnd.Next(0, 255))
    End Function

    Private Sub frmMYMDIPARENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'DEMO OF DYNAMIC DATE FUNCTION 
        'TITLE CHANGES TO DYNAMIC DATE YEAR (CURRENT YEAR i.e 2018-19)
        Dim dt As DateTime = Now.Date
        Dim str As String = ""
        If dt.Month > 6 And dt.Month <= 12 Then
            str += dt.Year.ToString
            str += " - " & dt.AddYears(1).ToString("yyyy")

        Else

            str += dt.AddYears(-1).ToString("yyyy")
            str += " - " & dt.Year.ToString

        End If

        'Also add Version Number if Possible
        'Me.ProductVersion.ToString()
        Me.Text = "VBDemos™ For Year : " & str & "         By: Hitesh Patel (For Version See About.)"

        'done

        'FOR RUNTIME MENU ITEMS
        '''''''''''''''''''''''''
        'Dim tsmi As New ToolStripMenuItem
        'tsmi.Text = "RUNTIME"


        'Dim cn As New System.Data.SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Demos;Integrated Security=True")
        'Dim cmd As New System.Data.SqlClient.SqlCommand("select * from hitlist", cn)
        'Dim da As New System.Data.SqlClient.SqlDataAdapter(cmd)
        'Dim ds As New System.Data.DataSet
        'da.Fill(ds)
        'Dim i As Integer = 0
        ''MenuStrip1.Items

        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    tsmi.DropDownItems.Add(ds.Tables(0).Rows(i).Item(1).ToString)

        'Next
        'MenuStrip1.Items.Insert(5, tsmi)
        'FOR RUNTIME MENU ITEMS
        '''''''''''''''''''''''''

        'MsgBox("HELLO ")
        'Dim frm As New frmListboxDemo
        'frm.MdiParent = Me
        'frm.Show()

        'Dim frm1 As New frmComboBoxDemo
        'frm1.MdiParent = Me
        'frm1.Show()

        'Dim frm2 As New frmCheckedlistBoxDemo
        'frm2.MdiParent = Me
        'frm2.Show()

        'Dim frm3 As New frmArithmaticOperation
        'frm3.MdiParent = Me
        'frm3.ShowInTaskbar = False
        'frm3.Show()

        'demo code for status bar

        'Create a StatusBar
        Dim statusBarMain As New StatusBar
        statusBarMain.Name = "StatusBar"
        statusBarMain.ShowPanels = True

        'Create the panels
        Dim statusBarDate = New StatusBarPanel
        statusBarDate.Name = "StatusBarDate"
        statusBarDate.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        statusBarDate.AutoSize = StatusBarPanelAutoSize.Contents
        statusBarMain.Panels.Add(statusBarDate)

        Dim statusBarTime = New StatusBarPanel
        statusBarTime.Name = "StatusBarTime"
        statusBarTime.Text = FormatDateTime(Now(), DateFormat.LongTime)
        statusBarTime.AutoSize = StatusBarPanelAutoSize.Contents
        statusBarMain.Panels.Add(statusBarTime)

        Dim statusBarCAPS = New StatusBarPanel
        statusBarCAPS.Name = "StatusBarCAPS"

        If GetKeyState(Keys.CapsLock) = 1 Then
            statusBarCAPS.Text = "CAPS ON"
        Else
            statusBarCAPS.Text = "CAPS OFF"
        End If

        statusBarCAPS.AutoSize = StatusBarPanelAutoSize.Contents
        statusBarMain.Panels.Add(statusBarCAPS)

        Dim statusBarNUMS = New StatusBarPanel
        statusBarNUMS.Name = "StatusBarNUMS"

        If GetKeyState(Keys.NumLock) = 1 Then
            statusBarNUMS.Text = "NumLock ON"
        Else
            statusBarNUMS.Text = "NumLock OFF"
        End If

        statusBarNUMS.AutoSize = StatusBarPanelAutoSize.Contents
        statusBarMain.Panels.Add(statusBarNUMS)

        'Add all teh controls to the form
        Me.Controls.Add(statusBarMain)

        'Set up a refresh timer
        Dim timer As New Timer
        timer.Interval = 1000
        timer.Start()
        Beep()
        AddHandler timer.Tick, AddressOf timer_Tick

        '-----------------------------------------------------
        '-----------------------------------------------------
        'DEMO CODE FOR OPENING FORM AUTOMATICALLY WHICH IS UNDER DEVELOPMENT

    End Sub

    Private Sub timer_Tick()

        Dim status As StatusBar = CType(Me.Controls.Find("statusBar", True)(0), StatusBar)

        status.Panels("statusBarDate").Text = FormatDateTime(Now(), DateFormat.ShortDate)
        status.Panels("statusBarTime").Text = FormatDateTime(Now(), DateFormat.LongTime)
        
        'Rather than set up message listeners etc, are you really going to notice much if the caps lock/nums lock is
        'upto 1 seconds out from true state?? doubt it much. (you decrease the timer tick of course.
        If GetKeyState(Keys.NumLock) = 1 Then
            status.Panels("statusBarNUMS").Text = "NumLock ON"
        Else
            status.Panels("statusBarNUMS").Text = "NumLock OFF"
        End If

        If GetKeyState(Keys.CapsLock) = 1 Then
            status.Panels("statusBarCAPS").Text = "CAPS ON"
        Else
            status.Panels("statusBarCAPS").Text = "CAPS OFF"
        End If

        'NOTE: IN .Net Version 3.5 and above you can use the;
        '        My.Computer.Keyboard.CapsLock
        '        My.Computer.Keyboard.NumLock
        ' to read the status without an unmanaged call

        'This code is for Random Colors changing
        Dim icou As Integer = 0
        For icou = 0 To Me.Controls.Count - 1
            If RandomColorsToolStripMenuItem.Checked Then
                Me.Controls.Item(icou).BackColor = RandomRGBColor()
            Else

            End If

        Next
    End Sub




    Private Sub HiTechDemosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HiTechDemosToolStripMenuItem.Click
        Dim frm As New AboutDemos
        ' frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub ListBoxDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frmlst As New frmListboxDemo
        'frmlst.MdiParent = Me
        'frmlst.Show()
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ViewCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCodeToolStripMenuItem.Click
        'Dim line As String
        'For Each frm In Application.OpenForms
        '    'MessageBox.Show(frm.Name)
        '    Try
        '        ' Open the file using a stream reader.
        '        Dim strname As String = frm.Name & ".vb"
        '        Dim newstr As String = Application.StartupPath.ToString
        '        Dim couchar As Integer = Application.StartupPath.Length - 9
        '        Dim finalname As String = newstr.Remove(couchar) & strname

        '        Using sr As New StreamReader(finalname)

        '            ' Read the stream to a string and write the string to the console.
        '            line = sr.ReadToEnd()

        '            'MsgBox(line)

        '        End Using
        '    Catch ex As Exception
        '        MsgBox("The file could not be read:")
        '        MsgBox(ex.Message)
        '    End Try
        'Next
        'Dim frmcode As New frmCodeViewer
        'frmcode.MdiParent = Me
        'frmcode.RichTextBox1.Text = line
        'frmcode.Show()

        Dim url As String = "http://172.30.58.221/CodeViewer.aspx"
        Process.Start(url)
    End Sub

    Private Sub frmMYMDIPARENT_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.WindowState = FormWindowState.Normal Then
            e.Cancel = True
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            NotifyIcon1.Text = "To Exit Right Click Me..."
            NotifyIcon1.ShowBalloonTip(1000, "VBDemos by HPP", "Demos are Still Running !!!", ToolTipIcon.Info)
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            e.Cancel = True
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            NotifyIcon1.Text = "To Exit Right Click Me..."
            NotifyIcon1.ShowBalloonTip(1000, "VBDemos by HPP", "Demos are Still Running !!!", ToolTipIcon.Info)

        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub PersonalDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmPersonalDetails
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub ListboPart2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmListBoxPart2
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub ListBoxDemoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmListboxDemo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CheckedListBoxDemoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmCheckedListBoxDemoNew
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CheckedListBoxDemoOldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmCheckedListBoxDemo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub


    Private Sub FrmComboBoxDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmComboBoxDemo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmWebBrowserDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmWebBrowser
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub MouseEventsDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmMouseEventsDemo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub MaskedTextBoxDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmMaskedTextBox
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmNotepadDemo
        ''frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmContainerControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmContainerControls
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub Form1DemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New Form1
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmWindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmWindowsExplorer
        'frm.MdiParent = Me
        'frm.Show()
    End Sub
    Private Sub FrmBindingNavigatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmBindingNavigatorToolStripMenuItem.Click
        Dim frm As New frmNavigationDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FrmExcedptionDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmExceptionDemo
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmOOPSDemonstrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmOOPSDemonstration
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmADOplusOOPSDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmADOplusOOPSDemoToolStripMenuItem.Click
        'Dim frm As New frmADOplusOOPS
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmNotifyDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmNotifyDemo
        '' frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub FrmWindowsExplorerNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmNewWindowsExplorer
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub PersonalDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalDetailsToolStripMenuItem1.Click
        Dim frm As New frmPerDetails

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SimpleInterestCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleInterestCalculatorToolStripMenuItem.Click
        Dim frm As New Form2
        frm.BackColor = RandomRGBColor()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InputBoxDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputBoxDemoToolStripMenuItem.Click
        Dim frm As New frmInputBoxDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxDemoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxDemoToolStripMenuItem2.Click
        Dim frm As New frmListBoxDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxOperationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxOperationsToolStripMenuItem.Click
        Dim frm As New frmListBoxOperation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NOtepadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOtepadToolStripMenuItem1.Click
        Dim frm As New frmNotepadDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim frm As New frmCheckedListBoxDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MultiSelectDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiSelectDemoToolStripMenuItem.Click
        Dim frm As New frmOpenFileDialogFileNamesDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MULTIERRORHELPNOTIFYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTIERRORHELPNOTIFYToolStripMenuItem.Click
        Dim frm As New frmErrorHelpNotifyDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WebBrowserDemoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowserDemoToolStripMenuItem1.Click
        Dim frm As New frmWebBrowserDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Dim frm As New frmWindowsExplorer
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub DisplayRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayRecordsToolStripMenuItem.Click
        Dim frm As New frmDataEntry
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FrmSQLDataEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmSQLDataEntryToolStripMenuItem.Click
        Dim frm As New frmDataEntry1
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FrmSQLMasterChildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmSQLMasterChildToolStripMenuItem.Click
        Dim frm As New frmSQLMasterChild
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ExceptionHandlimgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExceptionHandlimgToolStripMenuItem.Click
        Dim frm As New frmExceptionHandlingDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub OOPSDEMOSTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OOPSDEMOSTRATIONToolStripMenuItem.Click
        Dim frm As New frmOOPSDemonstration
        frm.MdiParent = Me
        frm.Show()

    End Sub
    Private Sub FrmSQLDataEntrythroughClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmSQLDataEntrythroughClassToolStripMenuItem.Click
        Dim frm As New frmSQLDataEntrythroughClass
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ContainerCOntrolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainerCOntrolsToolStripMenuItem.Click
        Dim frm As New frmContainerControls
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub WindowsExplorerAdvancedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerAdvancedToolStripMenuItem.Click
        Dim frm As New frmWinExplore
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub FrmSQLDataEntryWithCassSYBCA4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmSQLDataEntryWithCassSYBCA4ToolStripMenuItem.Click
        Dim frm As New frmSQLDataEntryWithCassSYBCA4
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub MouseKeyBordEventsDemoProgressBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseKeyBordEventsDemoProgressBarToolStripMenuItem.Click
        Dim frm As New frmMouseEventsDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub OptionStatementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionStatementsToolStripMenuItem.Click
        Dim frm As New frmVBDefaultsOptionStatements
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub InBuiltFunctionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InBuiltFunctionsToolStripMenuItem.Click
        Dim frm As New frmInbuiltFunctions
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub FrmDataboundControlsDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmDataboundControlsDemoToolStripMenuItem.Click
        Dim frm As New frmDataboundControlDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ComboBoxSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectionToolStripMenuItem.Click
        Dim frm As New frmMultiComboBox
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub NoduleDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoduleDemoToolStripMenuItem.Click
        Dim frm As New frmModuleDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub SearchDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchDataToolStripMenuItem.Click
        Dim frm As New frmSearchDataReader
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        'InstallUpdateSyncWithInfo()
    End Sub
    'Private Sub InstallUpdateSyncWithInfo()
    '    Dim info As UpdateCheckInfo = Nothing

    '    If (ApplicationDeployment.IsNetworkDeployed) Then
    '        Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

    '        Try
    '            info = AD.CheckForDetailedUpdate()
    '        Catch dde As DeploymentDownloadException
    '            MessageBox.Show("The new version of the application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
    '            Return
    '        Catch ioe As InvalidOperationException
    '            MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
    '            Return
    '        End Try

    '        If (info.UpdateAvailable) Then
    '            Dim doUpdate As Boolean = True

    '            If (Not info.IsUpdateRequired) Then
    '                Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
    '                If (Not System.Windows.Forms.DialogResult.OK = dr) Then
    '                    doUpdate = False
    '                End If
    '            Else
    '                 Display a message that the app MUST reboot. Display the minimum required version.
    '                MessageBox.Show("This application has detected a mandatory update from your current " & _
    '                    "version to version " & info.MinimumRequiredVersion.ToString() & _
    '                    ". The application will now install the update and restart.", _
    '                    "Update Available", MessageBoxButtons.OK, _
    '                    MessageBoxIcon.Information)
    '            End If

    '            If (doUpdate) Then
    '                Try
    '                    AD.Update()
    '                    MessageBox.Show("The application has been upgraded, and will now restart.")
    '                    Application.Restart()
    '                Catch dde As DeploymentDownloadException
    '                    MessageBox.Show("Cannot install the latest version of the application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
    '                    Return
    '                End Try
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub ComboBox201819ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox201819ToolStripMenuItem.Click
        Dim frm As New frmComboBoxDemo
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub COMPONENTDEMOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPONENTDEMOToolStripMenuItem.Click

        Dim frm As New frmComponentsDemo
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub PersonalDetailsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalDetailsToolStripMenuItem2.Click
        Dim frm As New frmPerDetails
        frm.MdiParent = Me
        frm.Show()
    End Sub

 

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        'Dim frm As New frmMaskedTextBox
        'frm.MdiParent = Me
        'frm.Show()
    End Sub
    Private Sub SYBCA2NAVIGATORDEMOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYBCA2NAVIGATORDEMOToolStripMenuItem.Click
        Dim frm As New frmNavigatorDemo4SYBCA2
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub OracleCOnnectionStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OracleCOnnectionStatusToolStripMenuItem.Click
        Dim frm As New frmOracleConnectionDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    
    Private Sub PersonalDetailsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalDetailsToolStripMenuItem.Click
        Dim frm As New frmPerDetails
        frm.MdiParent = Me
        frm.Show()
    End Sub

    

    Private Sub PersonalDetailsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalDetailsToolStripMenuItem3.Click
        Dim frm As New frmPerDetails
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InpuitBoxDemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InpuitBoxDemoToolStripMenuItem.Click
        Dim frm As New frmInputBoxDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxDemoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxDemoToolStripMenuItem.Click
        Dim frm As New frmListBoxDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxDemo2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxDemo2ToolStripMenuItem.Click
        Dim frm As New frmListBoxOperation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SPECIALLYFORSYBCA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPECIALLYFORSYBCA1ToolStripMenuItem.Click
        Dim frm As New frmTabControlDemo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PicnicDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PicnicDayToolStripMenuItem.Click
        Dim objname As New frmjalsakaro
        objname.MdiParent = Me
        objname.Show()
    End Sub

    Private Sub NOTEPADDEMOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NOTEPADDEMOToolStripMenuItem1.Click
        Dim objname As New frmNotepadDemo2024
        objname.MdiParent = Me
        objname.Show()
    End Sub

    Private Sub PersonalDetailsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles PersonalDetailsToolStripMenuItem4.Click
        Dim frm As New frmPerDetails

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SimpleInterestCalculatorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SimpleInterestCalculatorToolStripMenuItem2.Click
        Dim frm As New Form2

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InputBoxDemoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InputBoxDemoToolStripMenuItem2.Click
        Dim frm As New frmInputBoxDemo

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxDemoToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ListBoxDemoToolStripMenuItem1.Click
        Dim frm As New frmListBoxDemo

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListBoxDemo2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListBoxDemo2ToolStripMenuItem1.Click
        Dim frm As New frmListBoxOperation

        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class