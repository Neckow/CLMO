using FormsGallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Colimo
{
    public partial class HomePage : MasterDetailPage
    {
        MasterPageCS masterPageCS;
        ContactsPageCS contactsPageCS;

        public HomePage()
        {

            masterPageCS = new MasterPageCS();
            contactsPageCS = new ContactsPageCS();

            Master = masterPageCS;
            Detail = contactsPageCS;

            masterPageCS.ListView.ItemSelected += OnItemSelected;


            //Label header = new Label
            //{
            //    Text = "Colimo",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    HorizontalOptions = LayoutOptions.Center
            //};

            //var masterDetailItems = new List<MasterDetailItem>
            //{
            //    new MasterDetailItem("Menu 1",typeof(Menu1)),
            //    new MasterDetailItem("Menu 2",typeof(Menu2))
            //};

            //// Create ListView for the master page.
            //ListView listView = new ListView
            //{
            //    ItemsSource = masterDetailItems,

            //    ItemTemplate = new DataTemplate(() =>
            //    {
            //        Label nameLabel = new Label();
            //        nameLabel.SetBinding(Label.TextProperty, "Title");
            //        return nameLabel;
            //    })
            //};

            //// Create the master page with the ListView.
            //this.Master = new ContentPage
            //{
            //    Title = header.Text,        
            //    Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            header,
            //            listView
            //        }
            //    }
            //};

            // Create the detail page using NamedColorPage and wrap it in a
            // navigation page to provide a NavigationBar and Toggle button

            //NamedColorPage detailPage = new NamedColorPage(true);
            //Menu1 detailPage = new Menu1();

            //this.Detail = detailPage;


            //// For Android & Windows Phone, provide a way to get back to the master page.
            //if (Device.OS != TargetPlatform.iOS)
            //{
            //    TapGestureRecognizer tap = new TapGestureRecognizer();
            //    tap.Tapped += (sender, args) =>
            //    {
            //        this.IsPresented = true;
            //    };

            //    detailPage.Content.BackgroundColor = Color.Transparent;
            //    detailPage.Content.GestureRecognizers.Add(tap);
            //}

            //// Define a selected handler for the ListView.
            //listView.ItemSelected += (sender, args) =>
            //{
            //    // Set the BindingContext of the detail page.
            //    this.Detail.BindingContext = args.SelectedItem;

            //    // Show the detail page.
            //    this.IsPresented = false;
            //};

            //// Initialize the ListView selection.
            //listView.SelectedItem = masterDetailItems[0];



        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = (Page)Activator.CreateInstance(item.TargetType);
                masterPageCS.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
