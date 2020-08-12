using System;
using Xamarin.Forms;

namespace xamarin.forms_project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            int index = 1;

            var image = new Image()
            {
                Source = ImageSource.FromResource("xamarin.forms_project.images.image" + String.Format("{0:D3}", index) + ".jpg"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 100,
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (sender, e) =>
            {
                index++;
                if (index == 4)
                {
                    index = 1;
                }
                image.Source = ImageSource.FromResource("xamarin.forms_project.images.image" + String.Format("{0:D3}", index) + ".jpg");
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);

            Layout.Children.Add(image);
        }
    }
}
