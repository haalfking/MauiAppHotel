namespace MauiAppHotel.views;

public partial class Hospedagemcontratada : ContentPage
{
	public Hospedagemcontratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "ok");
		}
    }
}