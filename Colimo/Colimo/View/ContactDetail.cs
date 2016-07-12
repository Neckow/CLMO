using Xamarin.Forms;

namespace Colimo.View
{
    public class ContactDetail : TabbedPage
    {
        public ContactDetail()
        {
            Title = "Contacts Page";
            var logoutBtn = new Button { Text = "Logout" };
            logoutBtn.Clicked += (sender, e) => {
                App.Current.Logout();
            };

            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label {
            //            Text = "Contacts data goes here",
            //            HorizontalOptions = LayoutOptions.Center,
            //            VerticalOptions = LayoutOptions.CenterAndExpand
            //        },
            //        logoutBtn
            //    }
            //};

            Children.Add(new BobPage());
            Children.Add(new JeanPage());
        }
    }
}