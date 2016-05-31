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
        public ListView ListView { get { return listView; } }

        ListView listView;

        public MasterPageCS()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                TargetType = typeof(ContactsPageCS)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                TargetType = typeof(TodoListPageCS)
            });

        }
    }
}

