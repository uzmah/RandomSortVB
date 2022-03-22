Public Class frmSortIntegers
    Private Sub frmSortIntegers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    ' Randomly Sorting Integer (list,numberic up down and button) 
    ' SortIntegers Function which return integer

    Public Function SortIntegers(n As Integer) As Integer()
        ' New Integer Array 
        Dim nArray(n) As Integer
        ' Random Object 
        Dim sortRandom As Random = New Random()

        ' for loop to create sorted array of integers
        For i = 0 To n - 1
            nArray(i) = i
        Next

        ' integer temp variable to suffle the numbers
        Dim temp, s As Integer

        ' for loop which move from top to bottom
        For i = n To 1 Step -1
            s = sortRandom.Next(0, i)
            temp = nArray(s)
            nArray(s) = nArray(i - 1)
            nArray(i - 1) = temp
        Next
        ' Return randomly sorted integer array
        Return nArray
    End Function

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ' Declar array size and it's value 
        Dim arraySize As Integer = Convert.ToInt32(nudValue.Value)
        ' Declare interger array of array size
        Dim integerArray(arraySize) As Integer

        ' Clear list value
        lstValues.Items.Clear()
        ' Assign sortInteger value to integerArray
        integerArray = SortIntegers(arraySize)

        ' for loop to array siz-1
        For i = 0 To arraySize - 1

            ' Adding integerArray in the list as string
            lstValues.Items.Add(integerArray(i).ToString())
        Next
    End Sub


End Class
