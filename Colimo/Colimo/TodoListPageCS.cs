using Xamarin.Forms;

namespace Colimo
{
    public class TodoListPageCS : ContentPage
    {
        public TodoListPageCS()
        {
            Title = "TodoList Page";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Todolist data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}