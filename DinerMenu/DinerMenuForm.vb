'Isabella Dougherty
'RCET0265
'Spring 2023
'Diner Menu
'https://github.com/IsabellaDougherty/DinerMenu

Public Class Form1
    Dim dailySpecial As String
    Dim blob As Integer

    'Uses the dailySpecial variable to assign a string describing the daily soup special. Then assigns the DailySpecialLabel to that string
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        dailySpecial = "- Lobster Bisque - 
Our rich and creamy bisque is made with fresh, succulent 
lobster meat and slow-cooked to perfection with aromatic vegetables, 
herbs, and spices. Served with a dollop of crème fraîche and a sprinkle 
of chopped chives, this classic French soup is the ultimate indulgence. 
Perfect as a starter or a light meal on its own."
        DailySpecialLabel.Text = dailySpecial
        blob = 0
        BlobFishPictureBox.Visible = False
    End Sub

    'Uses the dailySpecial variable to assign a string describing the daily salad special. Then assigns the DailySpecialLabel to that string
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        dailySpecial = "- Caprese Salad - 
A light and refreshing salad made with vine-ripe tomatoes, 
creamy fresh mozzarella, and fragrant basil leaves. Drizzled 
with extra-virgin olive oil and a balsamic glaze, this classic 
Italian dish is a perfect appetizer or light lunch."
        DailySpecialLabel.Text = dailySpecial
        blob = 0
        BlobFishPictureBox.Visible = False
    End Sub

    'Uses the dailySpecial variable to assign a string describing the daily fish special. Then assigns the DailySpecialLabel to that string
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        dailySpecial = "- Linguine alle Vongole - 
Our classic pasta dish features linguine tossed with fresh clams, garlic, 
white wine, and parsley, all sautéed to perfection. Served with a sprinkle of 
red pepper flakes for a touch of heat and a squeeze of lemon juice, this simple 
and flavorful dish is a crowd-pleaser. Perfect for seafood lovers or anyone looking 
for a taste of Italy."
        DailySpecialLabel.Text = dailySpecial
        blob += 1
        If blob >= 10 Then
            BlobFishPictureBox.Visible = True
        Else
            BlobFishPictureBox.Visible = False
        End If
    End Sub

    'Ends the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
