namespace MauiAppHotelAgenda14.Views;

public partial class Desenvolvedor : ContentPage
{
    public Desenvolvedor()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}