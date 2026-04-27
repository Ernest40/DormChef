using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(SignupViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}