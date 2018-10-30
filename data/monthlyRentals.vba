Sub amountPerMonth()
	Dim sh As Worksheet
	Dim rw As Range: Set rw = Application.Range("B118523:B132428")
	Dim RowCount As Long
	Dim totalDuration As Long
	Dim avgDuration As Double
	
	totalDuration = 0
	RowCount = 118523
	
	Set sh = ActiveSheet
		For Each rw In rw.Rows
			totalDuration = totalDuration + sh.Cells(RowCount, "B").Value
			RowCount = RowCount + 1
		Next rw
		
		avgDuration = totalDuration / RowCount
		
	MsgBox(avgDuration)
End Sub