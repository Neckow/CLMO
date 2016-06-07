using Xamarin.Forms;

namespace Colimo.View
{
    public class ContactDetail : ContentPage
    {
        public ContactDetail()
        {
            Title = "Contacts Page";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Contacts data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}