using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Colimo
{
    public class MasterPageCS : ContentPage
    {
        public ListView ListView => listView;

        ListView listView;

        public MasterPageCS()
        {
            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Contacts",
                    TargetType = typeof(ContactsPageCS)
                },
                new MasterPageItem
                {
                    Title = "TodoList",
                    TargetType = typeof(TodoListPageCS)
                }
            };

            listView = new ListView
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
                    listView
                }
            };
            Title = "Personal Organiser";
        }
    }
}

