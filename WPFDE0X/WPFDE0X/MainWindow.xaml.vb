Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Label.Content = "Evolution = Raichu, Pre Evolution = Pichu, Generation 1, Electric"
        Pikachu.Visibility = Visibility.Visible
        Pichu.Visibility = Visibility.Hidden
        Raichu.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Label.Content = "Evolution = Pikachu, Pre Evolution = None, Generation 2, Electric"
        Pikachu.Visibility = Visibility.Hidden
        Pichu.Visibility = Visibility.Visible
        Raichu.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Label.Content = "Evolution = None, Pre Evolution = Pikachu, Generation 1, Electric"
        Pikachu.Visibility = Visibility.Hidden
        Pichu.Visibility = Visibility.Hidden
        Raichu.Visibility = Visibility.Visible
    End Sub
End Class
