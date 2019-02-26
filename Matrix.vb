Public Class Matrix
    Public rows, cols As Integer
    Private ReadOnly rnd As New Random()
    Public data

    Sub New(rows, cols)
        Me.rows = rows
        Me.cols = cols
        'Initializing Matrix and Fill Matrix
        Me.data = MatrixCreate(rows, cols)
    End Sub

    Public Function map(matrix As Matrix)
        Dim mtx = New Matrix(matrix.rows, matrix.cols)

        Return mtx
    End Function

    Public Function FromArray(arr)
        Return New Matrix(arr.Count, 1)
    End Function

    Public Function Copy() As Matrix
        Return New Matrix(rows, cols) With {
            .data = MatrixCreate(rows, cols)
        }
    End Function

    Private Function MatrixCreate(ByVal rows As Integer, ByVal cols As Integer) As Double()()

        Dim result(0 To rows - 1)() As Double
        Dim i As Integer
        For i = 0 To rows - 1
            Dim col(0 To cols - 1) As Double
            result(i) = col
        Next i

        Return result

    End Function

End Class

