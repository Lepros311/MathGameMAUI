namespace MathGameMAUI;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}
}