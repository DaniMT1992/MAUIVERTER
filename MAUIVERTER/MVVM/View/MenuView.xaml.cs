using MAUIVERTER.MVVM.ViewModels;

namespace MAUIVERTER.MVVM.View;

public partial class MenuView : ContentPage
{
    public MenuView()
    {
        InitializeComponent();
        BindingContext = new MenuViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var element =
             (Grid)sender;
        var option =
             ((Label)element.Children
             .LastOrDefault()).Text;
        var converterView =
             new ConverterView
             {
                 BindingContext = new ConverterViewModel(option)
             };
        Navigation.PushAsync(converterView);
    }
}