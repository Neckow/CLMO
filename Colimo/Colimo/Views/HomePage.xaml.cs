using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Colimo.Views
{
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            var menuPage = new MenuPage();

            menuPage.Menu.itemSelected += (sender, e) = NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;
            Detail = new NavigationPage(new ContractsPage());
        }

        void NavigateTo(MenuItem menu)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            IsPresented = false;
        }
        //InitializeComponent();

        public enum MasterBehavior
        {
            Default,
            Popover,
            Split,
            SplitOnLandscape,
            SplitOnPortrait
        }
    }
}
