Class MainWindow 
    Public Event Arrêter(ByVal sender As Object, ByVal e As System.EventArgs)




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Close()
        End
    End Sub
End Class
