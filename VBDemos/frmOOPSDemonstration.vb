Public Class frmOOPSDemonstration
  
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim khan As New clsSYBCA3
        ' khan.door = 5
        'MsgBox("NO OF DOORS " & khan.door)
        ' khan.course = "MCA"
        'MsgBox("WHAT IS UR COURSE " & khan.course)
        'khan.roomno = 1
        'MsgBox("NEW CLASS LOCATED AT " & khan.roomno)
        MsgBox(khan.status())


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim kapoor As New clsSYBCA3
        Dim str As String = InputBox("YOUR NAME")
        MsgBox(kapoor.status & str)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim kapor As clsSYBCA3
        kapor = New clsSYBCA3
        MsgBox(kapor.door)
        MsgBox(kapor.fans)
    End Sub


    Private Sub btnSubpara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubpara.Click
        Dim obj As New clsSYBCA3
        obj.greetings(InputBox("enter your name"))
    End Sub

    Private Sub btnfunpara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunpara.Click
        Dim Riddhee As New clsSYBCA3
        MsgBox(Riddhee.statuspara("Twinkle"))

    End Sub

    Private Sub btnparaconstructor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnparaconstructor.Click
        Dim payal As New clsSYBCA3(50, "three fan")
        MsgBox("i have " & payal.fans)
        MsgBox("my class have " & payal.door)
    End Sub

    Private Sub btnpoly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpoly.Click
        Dim prachi As New clsSYBCA3
        prachi.greetings()
        prachi.greetings("jenisha")
        prachi.greetings("bhakti", System.DateTime.Now.AddHours(6))


    End Sub

    
    Private Sub btnInheritance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInheritance.Click
        '    Dim nancy As New clsSYBCA3Child
        '    nancy.door = 7
        '    MsgBox(nancy.door)
        '    nancy.fans = "NINE FANS"
        '    MsgBox(nancy.fans)
        '    MsgBox(nancy.roomno)
        '    nancy.greetings("PRAKASH", System.DateTime.Now.AddHours(6))

    End Sub

    'Private Sub btnoverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoverride.Click
    '    Dim asha As New clsSYBCA3Child
    '    asha.finalexam()
    'End Sub


    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim mylistobj As New clsSYBCA3Child
        mylistobj.checkconnection = Not (Me.Visible)
        If mylistobj.checkconnection Then
            MsgBox("YOU ARE CONNECTED TO INTERNET")
        Else
            MsgBox("YOU ARE DISCONNECTED TO INTERNET")
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim newobj As New clsValentine()
        MsgBox("FANS " & newobj.fans)
        MsgBox("DOOR " & newobj.door)



    End Sub

    
   
    Private Sub btnProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProperty.Click
        Dim darshan As New clsSYBCA4
        darshan.clsname = "VIDEO MAKER"
        'MsgBox(darshan.clsname)
        MsgBox(darshan.clsname1)
        darshan.door = "7"
        MsgBox("I HAVE DOORS = " & darshan.door)
        darshan.spname = "GAJANI"
        MsgBox(darshan.spname)


    End Sub

   
   
    Private Sub btnMethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMethod.Click
        Dim dvarkesh As New clsSYBCA4
        dvarkesh.greetings()


        MsgBox(dvarkesh.upload)

    End Sub

    
    Private Sub btnSubpara2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubpara2.Click
        Dim piyush As New clsSYBCA4
        piyush.greetings("SHYAM")


    End Sub

    Private Sub btnFunPara2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFunPara2.Click
        Dim polard As New clsSYBCA4
        MsgBox(polard.upload(InputBox("PLEASE ENTER YOUR HOBBY ", "HOBBY UPDATER")))
    End Sub

   
    Private Sub btnConPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConPara.Click
        Dim sanket As New clsSYBCA4()
        MsgBox("I AM DEFAULT CONTRUCTOR")
        MsgBox("I AM " & sanket.spname)

        Dim drupal As New clsSYBCA4("DHAVAL")
        MsgBox("I AM PARAMETERIZED CONTRUCTOR")
        MsgBox("I AM " & drupal.spname)


    End Sub

    Private Sub btnDesignPoly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesignPoly.Click
        Dim nimesh As New clsSYBCA4
        nimesh.greetings()
        nimesh.greetings("NARENDARA MODI")
        MsgBox(nimesh.upload())
        MsgBox(nimesh.upload("NETAGIRI"))

    End Sub

    Private Sub btnInheritanceDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInheritanceDemo.Click
        Dim gopal As New clsSYBCA4child
        MsgBox("I AM DEMO PARENT CHILD RELATIONSHIP INHERITANCE")
        gopal.door = 100
        MsgBox("I HAVE DOORS =  " & gopal.door)

        Dim haresh As New clsSYBCA4child
        haresh.display()

    End Sub

    Private Sub btnInterface_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterface.Click
        Dim bhavin As New clsSYBCA4
        'bhavin.gotocollege()

    End Sub
End Class