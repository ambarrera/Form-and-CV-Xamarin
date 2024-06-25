using Xamarin.Forms;

namespace TuApp
{
    public partial class CVPage : ContentPage
    {
        public CVPage(CVModel cv)
        {
            InitializeComponent();
            BindingContext = cv;
        }
    }
}