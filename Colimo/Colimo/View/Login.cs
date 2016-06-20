using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Colimo.View
{
    public class Login : ContentPage
    {
        Entry username, password;

        public Login(ILoginManager ilm)
        {
            var loginBtn = new Button {Text = "Login"};

            loginBtn.Clicked += (sender, e) =>
            {
                if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
                {
                    DisplayAlert("Validation Error", "Username and Password are required", "Re-try");
                }
                else
                {
                    // REMEMBER LOGIN STATUS!
                    App.Current.Properties["IsLoggedIn"] = true;
                    ilm.ShowMainPage();
                }
            };

            username = new Entry {Text = ""};
            password = new Entry {Text = "", IsPassword = true};

            Content = new StackLayout
            {
                Padding = new Thickness(10, 40, 10, 10),
                Children =
                {
                    new Label {Text = "Login", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))},
                    new Label {Text = "Username"},
                    username,
                    new Label {Text = "Password"},
                    password,
                    loginBtn
                }
            };
        }
    }
}
