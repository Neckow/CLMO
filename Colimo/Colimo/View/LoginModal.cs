using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Colimo.View
{
    public class LoginModal : CarouselPage
    {
        ContentPage login;

        public LoginModal(ILoginManager ilm)
        {
            login = new Login(ilm);
            this.Children.Add(login);

            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) => {
                this.SelectedItem = login;
            });
        }
    }
}
