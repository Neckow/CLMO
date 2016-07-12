using System.Collections.Generic;
using Colimo.ViewModel;
using Xamarin.Forms;

namespace Colimo.View
{
    public class MasterPage : ContentPage
    {
        internal ListView _listView { get; }

        public MasterPage()
        {
           

            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Contact Detail",
                    IconSource = "contacts.png",
                    TargetType = typeof(ContactDetail)
                },
                new MasterPageItem
                {
                    Title = "Contact List",
                    IconSource = "contacts.png",
                    TargetType = typeof(ContactList)
                },
                new MasterPageItem
                {
                    Title = "TodoGroupedList",
                    IconSource = "contacts.png",
                    TargetType = typeof(ToDoGroupedListPage)
                }
            };

            _listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    //var textCell = new TextCell();
                    //textCell.SetBinding(TextCell.TextProperty, "Title");
                    //return textCell;
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    _listView
                }
            };
            Padding = new Thickness(0, 40, 0, 0);
            //Icon = "menu.png";
            Title = "Personal Organiser";

        }
    }
}

