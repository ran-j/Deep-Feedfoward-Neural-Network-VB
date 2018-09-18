Public Class Matrix
    Private rows, cols As Integer
    Private ReadOnly rnd As New Random()
    Public data

    Sub New(rows, cols)
        Me.rows = rows
        Me.cols = cols

        'Initializing Matrix and Fill Matrix
        Dim numbers(rows - 1, cols - 1) As Integer
        Me.data = numbers
    End Sub

    'Other Stuff
    Public Sub Randomize()

    End Sub

    Public Function Map(m1 As Matrix, func As Object)
        Dim matrix = New Matrix(m1.rows, m1.cols)
        matrix.data = m1.data.Select(Function(v) v.Select(Function(x) x).ToArray()).ToArray()
        Return matrix
    End Function
End Class
