Module Module1

    Sub Main()
        Dim nElems = 0
        Console.Clear()
        Console.WriteLine("Input a count of elements")
        Int32.TryParse(Console.ReadLine(), nElems)
        Dim iArray(nElems) As Integer
        Dim oRnd = New Random()
        For i = 0 To nElems - 1
            Dim nItem = oRnd.Next(1, 50)
            iArray(i) = nItem
        Next
        Dim nSum = 0
        For i = 0 To nElems - 1
            nSum += iArray(i)
            Console.Write(Str(iArray(i)) + " ")
        Next
        Console.WriteLine(vbCrLf + $"The Sum of {nElems} elements of the array is:{nSum}")
        Console.Read()
    End Sub

End Module
