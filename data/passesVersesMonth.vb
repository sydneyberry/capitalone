Sub avgDuration()
    Dim sh As Worksheet
    Dim rw As Range: Set rw = Application.Range("N118523:N132428")
    Dim RowCount As Long
    RowCount = 118523

    Dim monthPass As String
    Dim monthCount As Integer
    monthPass = "Monthly Pass"
    monthCount = 0
    
    Dim flexPass As String
    Dim flexCount As Integer
    flexPass = "Flex Pass"
    flexCount = 0
    
    Dim walkPass As String
    Dim walkCount As Integer
    walkPass = "Walk-Up"
    walkCount = 0
    
    Dim staffPass As String
    Dim staffCount As Integer
    staffPass = "Staff Annual"
    staffCount = 0
       
    Set sh = ActiveSheet
    For Each rw In rw.Rows
        If (StrComp(monthPass, Cells(RowCount, "N").Text, vbTextCompare) = 0) Then
            monthCount = monthCount + 1
        End If
        If (StrComp(flexPass, Cells(RowCount, "N").Text, vbTextCompare) = 0) Then
            flexCount = flexCount + 1
        End If
        If (StrComp(walkPass, Cells(RowCount, "N").Text, vbTextCompare) = 0) Then
            walkCount = walkCount + 1
        End If
        If (StrComp(staffPass, Cells(RowCount, "N").Text, vbTextCompare) = 0) Then
            staffCount = staffCount + 1
        End If
        
        RowCount = RowCount + 1
        
    Next rw
    
    MsgBox (monthCount)
    MsgBox (flexCount)
    MsgBox (walkCount)
    MsgBox (staffCount)
    
End Sub
