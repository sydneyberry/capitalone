Sub avgDuration()
    Dim sh As Worksheet
    Dim rw As Range: Set rw = Application.Range("B2:B132428")
    Dim RowCount As Long
    RowCount = 2

    Dim duration As Long
    Dim rate As Integer ' In MPH
    Dim temp As Double
    Dim distance As Double
    Dim totalDist As Double
    Dim avgDist As Double
    
    rate = 12
    totalDist = 0
    
    Set sh = ActiveSheet
    For Each rw In rw.Rows
        duration = sh.Cells(RowCount, "B").Value
        temp = duration / 60
        distance = temp * rate
        
        totalDist = totalDist + distance
        
        RowCount = RowCount + 1
    Next rw
    
    RowCount = RowCount - 2
    avgDist = totalDist / RowCount
    
    MsgBox (avgDist)

End Sub
