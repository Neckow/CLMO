using System;
using Colimo.ViewModel;
using Xamarin.Forms;

namespace Colimo.View
{
    public partial class MasterDetail : MasterDetailPage
    {
        internal MasterPage MasterPage;
        internal ContactDetail ContactDetail;   

        public MasterDetail()
        {


            MasterPage = new MasterPage();
            ContactDetail = new ContactDetail();

            Master = MasterPage;
            Detail = new NavigationPage(ContactDetail);

            MasterPage._listView.ItemSelected += OnItemSelected;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = (Page)Activator.CreateInstance(item.TargetType);
                MasterPage._listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
