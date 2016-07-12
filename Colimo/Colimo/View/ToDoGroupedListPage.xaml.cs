using System.Collections.ObjectModel;
using Colimo.ViewModel;
using Xamarin.Forms;

namespace Colimo.View
{
    public partial class ToDoGroupedListPage
    {
        private ObservableCollection<GroupedVeggieModel> grouped { get; set; }
        public ToDoGroupedListPage()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedVeggieModel>();

            // 2 groups model
            var veggieGroup = new GroupedVeggieModel() { LongName = "Vegetables", ShortName = "v" };
            var fruitGroup = new GroupedVeggieModel() { LongName = "Fruit", ShortName = "f" };

            veggieGroup.Add(new VeggieModel() { Name = "Celery", IsReallyAVeggie = true, Comment = "Try ants on a log" });
            veggieGroup.Add(new VeggieModel() { Name = "Tomato", IsReallyAVeggie = false, Comment = "Pairs well with basil" });
            veggieGroup.Add(new VeggieModel() { Name = "Zucchini", IsReallyAVeggie = true, Comment = "Zucchini bread > bannana bread" });
            veggieGroup.Add(new VeggieModel() { Name = "Peas", IsReallyAVeggie = true, Comment = "Like peas in a pod" });

            fruitGroup.Add(new VeggieModel() { Name = "Banana", IsReallyAVeggie = false, Comment = "Available in chip form factor" });
            fruitGroup.Add(new VeggieModel() { Name = "Strawberry", IsReallyAVeggie = false, Comment = "Spring plant" });
            fruitGroup.Add(new VeggieModel() { Name = "Cherry", IsReallyAVeggie = false, Comment = "Topper for icecream" });

            grouped.Add(veggieGroup);
            grouped.Add(fruitGroup);

            listView.ItemsSource = grouped;     // Data Binding is magical 
        }
    }
}
