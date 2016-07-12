using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Colimo.View
{
    public class BobPage : ContentPage
    {
        public BobPage()
        {
            Title = "BobPage Title";
           
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Bob Page" }
                }
            };
        }
    }
}
