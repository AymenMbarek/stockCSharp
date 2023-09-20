Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button_article_Click(sender As Object, e As EventArgs) Handles button_article.Click
        Dim articleForm As New ArticleForm4() ' Remplacez "ArticleForm4" par le nom de la classe de votre formulaire Article
        articleForm.Show()
    End Sub

    Private Sub button_vente_Click(sender As Object, e As EventArgs) Handles Button_vente.Click
        Dim venteForm As New vente() ' Remplacez "Vente" par le nom de la classe de votre formulaire de vente
        venteForm.Show()
    End Sub

    Private Sub button_achat_Click(sender As Object, e As EventArgs) Handles Button_achat.Click
        Dim achatForm As New achat() ' Remplacez "Achat" par le nom de la classe de votre formulaire d'achat
        achatForm.Show()
    End Sub

    Private Sub button_client_Click(sender As Object, e As EventArgs) Handles Button_client.Click
        Dim clientForm As New client() ' Remplacez "Client" par le nom de la classe de votre formulaire de client
        clientForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1() ' Remplacez "Form2" par le nom de votre autre interface
        form1.Show()
        Me.Hide() ' Pour masquer la fenêtre actuelle si nécessaire
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Formp As New produit_fini() ' Remplacez "AutreForm" par le nom de la classe de votre autre formulaire
        Formp.Show()
        Me.Hide() ' Pour masquer la fenêtre actuelle si nécessaire
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Formst As New stockpf() ' Remplacez "AutreForm" par le nom de la classe de votre autre formulaire
        Formst.Show()
        Me.Hide() ' Pour masquer la fenêtre actuelle si nécessaire
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim transformationForm As New ButtonModifier() ' Remplacez "transformation" par le nom de la classe de votre formulaire de transformation
        transformationForm.Show()
        Me.Hide() ' Masquez la fenêtre actuelle si nécessaire
    End Sub
End Class
