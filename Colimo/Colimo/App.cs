using Colimo.View;
using Xamarin.Forms;

namespace Colimo
{
    public class App : Application, ILoginManager
    {
        static ILoginManager loginManager;
        public static App Current;
        public App()
        {
            // The root page of your application
            //MainPage = new NavigationPage(new MasterDetail());

            Current = this;

            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") && (bool)Properties["IsLoggedIn"];

            // we remember if they're logged in, and only display the login page if they're not
            if (isLoggedIn)
                MainPage = new MasterDetail();
            else
                MainPage = new LoginModal(this);
        }

        public void ShowMainPage()
        {
            MainPage = new MasterDetail();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
            MainPage = new LoginModal(this);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
