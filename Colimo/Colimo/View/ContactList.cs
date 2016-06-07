using System.IO;
using System.Reflection;
using Colimo.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Colimo.View
{
    public class ContactList : ContentPage
    {
        public ContactList()
        {
            /* Don't forget : Right-Click on the resource file, Properties => Generation Action : Embedded Resource */

            var assembly = typeof(ContactList).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Colimo.DataSource.json");

           /*   
            *   DataSource test 
            ObservableCollection<Person> people = new ObservableCollection<Person>();

            people.Add(new Person { username = "Rob Finnerty" });
            people.Add(new Person { username = "Bill Wrestler" });
            people.Add(new Person { username = "Dr. Geri-Beth Hooper" });
            people.Add(new Person { username = "Dr. Keith Joyce-Purdy" });
            people.Add(new Person { username = "Sheri Spruce" });
            people.Add(new Person { username = "Burt Indybrick" });
            
            */

            Person[] people;
            using (var reader = new StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);

                people = rootobject.people;
            }



            var listView = new ListView
            {
                ItemsSource = people,					// people est une List
                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "username");     // username est un attribut d'objet person
                    textCell.SetBinding(TextCell.DetailProperty, "name");   
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