Sub AverageDuration()
	Dim sh As WorkSheet
	Dim rw As Range: Set rw = Application.Range("F2:J132428")
	Dim RowCount As Long
	Dim startLat As Double
	Dim startLong As Double
	Dim endLat As Double
	Dim endLong As Double
	Dim holder As Double
	Dim firstHalf As Double
	Dim secondHalf As Double
	Dim total As Double
	Dim avg As Double
	
	RowCount = 2
	total = 0
	
	Set sh = ActiveSheet
	
	For Each rw In rw.Rows
		startLat = Abs(sh.Cells(RowCount, "F").Value)
		startLong = Abs(sh.Cells(RowCount, "G").Value)
		endLat = Abs(sh.Cells(RowCount, "I").Value)
		endLong = Abs(sh.Cells(RowCount, "J").Value)
		
		firstHalf = Abs(startLat - endLat)
		secondHalf = Abs(startLong - endLong)
		holder = Abs(Sqr(firstHalf + secondHalf))
		
		total = total + holder
		RowCount = RowCount + 1
	Next rw
	
	avg = total/RowCount
	
End Sub