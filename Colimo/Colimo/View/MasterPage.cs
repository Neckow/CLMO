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
                    TargetType = typeof(ContactDetail)
                },
                new MasterPageItem
                {
                    Title = "Contact List",
                    TargetType = typeof(ContactList)
                },
                new MasterPageItem
                {
                    Title = "TodoGroupedList",
                    TargetType = typeof(ToDoGroupedListPage)
                }
            };

            _listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "Title");
                    return textCell;
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
            Title = "Personal Organiser";
        }
    }
}

