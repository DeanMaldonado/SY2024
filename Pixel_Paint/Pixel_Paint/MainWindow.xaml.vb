Class MainWindow
    Private Sub Fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Fill1.MouseDown, Fill2.MouseDown, Fill3.MouseDown, Fill4.MouseDown, Fill5.MouseDown, Fill6.MouseDown, Fill7.MouseDown, Fill8.MouseDown, Fill9.MouseDown, Fill10.MouseDown, Fill11.MouseDown, Fill12.MouseDown, Fill13.MouseDown, Fill14.MouseDown, Fill15.MouseDown, Fill16.MouseDown
        Brush1.Fill = sender.fill
    End Sub
    Private Sub p00_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles P00.MouseDown, P01.MouseDown, P02.MouseDown, P03.MouseDown, P04.MouseDown, P05.MouseDown, P06.MouseDown, P07.MouseDown, P08.MouseDown, P09.MouseDown, P10.MouseDown, P11.MouseDown, P12.MouseDown, P13.MouseDown, P14.MouseDown, P15.MouseDown, P16.MouseDown, P17.MouseDown, P18.MouseDown, P19.MouseDown, P20.MouseDown, P21.MouseDown, P22.MouseDown, P23.MouseDown, P24.MouseDown, P25.MouseDown, P26.MouseDown, P27.MouseDown, P28.MouseDown, P29.MouseDown, P30.MouseDown, P31.MouseDown, P32.MouseDown, P33.MouseDown, P34.MouseDown, P35.MouseDown, P36.MouseDown, P37.MouseDown, P38.MouseDown, P39.MouseDown, P40.MouseDown, P41.MouseDown, P42.MouseDown, P43.MouseDown, P44.MouseDown, P45.MouseDown, P46.MouseDown, P47.MouseDown, P48.MouseDown, P49.MouseDown, P50.MouseDown, P51.MouseDown, P52.MouseDown, P53.MouseDown, P54.MouseDown, P55.MouseDown, P56.MouseDown, P57.MouseDown, P58.MouseDown, P59.MouseDown, P60.MouseDown, P61.MouseDown, P62.MouseDown, P63.MouseDown, P64.MouseDown, P65.MouseDown, P66.MouseDown, P67.MouseDown, P68.MouseDown, P69.MouseDown, P70.MouseDown, P71.MouseDown, P72.MouseDown, P73.MouseDown, P74.MouseDown, P75.MouseDown, P76.MouseDown, P77.MouseDown, P78.MouseDown, P79.MouseDown, P80.MouseDown, P81.MouseDown, P82.MouseDown, P83.MouseDown, P84.MouseDown, P85.MouseDown, P86.MouseDown, P87.MouseDown, P88.MouseDown, P89.MouseDown, P90.MouseDown, P91.MouseDown, P92.MouseDown, P93.MouseDown, P94.MouseDown, P95.MouseDown, P96.MouseDown, P97.MouseDown, P98.MouseDown, P99.MouseDown
        sender.fill = Brush1.Fill
    End Sub

    Private Sub P00_MouseMove(sender As Object, e As MouseEventArgs) Handles P00.MouseMove, P01.MouseMove, P02.MouseMove, P03.MouseMove, P04.MouseMove, P05.MouseMove, P06.MouseMove, P07.MouseMove, P08.MouseMove, P09.MouseMove, P10.MouseMove, P11.MouseMove, P12.MouseMove, P13.MouseMove, P14.MouseMove, P15.MouseMove, P16.MouseMove, P17.MouseMove, P18.MouseMove, P19.MouseMove, P20.MouseMove, P21.MouseMove, P22.MouseMove, P23.MouseMove, P24.MouseMove, P25.MouseMove, P26.MouseMove, P27.MouseMove, P28.MouseMove, P29.MouseMove, P30.MouseMove, P31.MouseMove, P32.MouseMove, P33.MouseMove, P34.MouseMove, P35.MouseMove, P36.MouseMove, P37.MouseMove, P38.MouseMove, P39.MouseMove, P40.MouseMove, P41.MouseMove, P42.MouseMove, P43.MouseMove, P44.MouseMove, P45.MouseMove, P46.MouseMove, P47.MouseMove, P48.MouseMove, P49.MouseMove, P50.MouseMove, P51.MouseMove, P52.MouseMove, P53.MouseMove, P54.MouseMove, P55.MouseMove, P56.MouseMove, P57.MouseMove, P58.MouseMove, P59.MouseMove, P60.MouseMove, P61.MouseMove, P62.MouseMove, P63.MouseMove, P64.MouseMove, P65.MouseMove, P66.MouseMove, P67.MouseMove, P68.MouseMove, P69.MouseMove, P70.MouseMove, P71.MouseMove, P72.MouseMove, P73.MouseMove, P74.MouseMove, P75.MouseMove, P76.MouseMove, P77.MouseMove, P78.MouseMove, P79.MouseMove, P80.MouseMove, P81.MouseMove, P82.MouseMove, P83.MouseMove, P84.MouseMove, P85.MouseMove, P86.MouseMove, P87.MouseMove, P88.MouseMove, P89.MouseMove, P90.MouseMove, P91.MouseMove, P92.MouseMove, P93.MouseMove, P94.MouseMove, P95.MouseMove, P96.MouseMove, P97.MouseMove, P98.MouseMove, P99.MouseMove
        If ChkDrag.IsChecked Then
            sender.fill = Brush1.Fill
        End If
    End Sub
    Private Function getRect(i As Integer) As Rectangle
        Dim s As String
        If i < 10 Then
            s = "P0" & i
        Else
            s = "P" & i
        End If
        For Each u In grid1.Children

            If u.name.Startswith(s) Then
                Return u
            End If
        Next
        Return Nothing
    End Function

    Private Sub Reset_Click(sender As Object, e As RoutedEventArgs) Handles Reset.Click
        For index = 0 To 99
            getRect(index).Fill = New SolidColorBrush(Colors.Black)
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        For index = 0 To 49
            getRect(index).Fill = Brush1.Fill
        Next
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        For index = 50 To 99
            getRect(index).Fill = Brush1.Fill
        Next
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        For row = 0 To 9
            For col = 0 To 4
                getRect(row * 10 + col).Fill = Brush1.Fill
            Next
        Next

    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        For row = 0 To 9
            For col = 5 To 9
                getRect(row * 10 + col).Fill = Brush1.Fill
            Next
        Next
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        For row = 0 To 9 Step 2
            For col = 0 To 9
                getRect(row * 10 + col).Fill = Brush1.Fill
            Next
        Next
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        For index = 0 To 99 Step 2
            getRect(index).Fill = Brush1.Fill
        Next
    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        For row = 5 To 9
            For col = 5 To 9
                getRect(row * 10 + col).Fill = Brush1.Fill
            Next
        Next
    End Sub

    Private Sub Button_Click_7(sender As Object, e As RoutedEventArgs)
        For row = 0 To 9
            For col = 0 To 9
                If row >= col Then
                    getRect(row * 10 + col).Fill = Brush1.Fill
                End If
            Next
        Next
    End Sub
End Class
