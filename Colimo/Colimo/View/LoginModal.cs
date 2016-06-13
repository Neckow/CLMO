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
        ContentPage login, create;

        public LoginModal(ILoginManager ilm)
        {
            login = new Login(ilm);
            create = new CreateAccount(ilm);
            this.Children.Add(login);
            this.Children.Add(create);

            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) => {
                                                                                  this.SelectedItem = login;
            });
            MessagingCenter.Subscribe<ContentPage>(this, "Create", (sender) => {
                                                                                   this.SelectedItem = create;
            });
        }
    }
}
