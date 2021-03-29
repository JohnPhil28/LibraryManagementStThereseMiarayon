Module utils

    Public Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 60, 60), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub


    Public Sub clickAnimation(btnObject As Button, ByRef clicks As Integer)
        If clicks = 1 Then
            btnObject.Image = My.Resources.Polygon_2
        ElseIf clicks = 2 Then
            btnObject.Image = My.Resources.Polygon3
            clicks = 0
        End If
    End Sub

    Public Sub dropDownAnimationNewTitle(panel As Panel, tailObj1 As Button, tailObj2 As Button, tailObj3 As Button)
        Main.Timer1.Start()
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.Timer1.Enabled = False
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
            tailObj2.Location = New Point(tailObj2.Location.X, tailObj2.Location.Y - 127)
            tailObj3.Location = New Point(tailObj3.Location.X, tailObj3.Location.Y - 127)
        End If

    End Sub


    Public Sub dropDownAnimationauthBtn(panel As Panel, tailObj1 As Button, tailObj2 As Button)
        Main.Timer2.Start()
        panel.Location = New Point(panel.Location.X, Main.authBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.Timer2.Enabled = False
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
            tailObj2.Location = New Point(tailObj2.Location.X, tailObj2.Location.Y - 127)
        End If
    End Sub

    Public Sub dropDownAnimationpy(panel As Panel, tailObj1 As Button)
        Main.Timer3.Start()
        panel.Location = New Point(panel.Location.X, Main.pbBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.Timer3.Enabled = False
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
        End If
    End Sub

    Public Sub dropDownAnimationpub(panel As Panel)
        Main.Timer4.Start()
        panel.Location = New Point(panel.Location.X, Main.publisherBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.Timer4.Enabled = False
        End If
    End Sub


End Module
