using System;
using Xamarin.Forms;

namespace xamarin.forms_project
{
    public partial class MainPage : ContentPage
    {
        int index = 1;
        public MainPage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("xamarin.forms_project.images.image" + String.Format("{0:D3}", index) + ".jpg");
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            index++;
            if (index == 4)
            {
                index = 1;
            }
            image.Source = ImageSource.FromResource("xamarin.forms_project.images.image" + String.Format("{0:D3}", index) + ".jpg");
        }
    }
}
