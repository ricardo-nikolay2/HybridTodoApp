using System.Threading.Tasks;

namespace HybridTodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Add your button click logic here
            await DisplayAlert("Button Clicked", "You clicked the button!", "OK");
        }
    }
}
