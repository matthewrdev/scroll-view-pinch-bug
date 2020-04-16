using System.Collections.Generic;

namespace PinchScrollViewTest
{
    public class ItemCollection
    {

        public List<string> Values
        {
            get;
            set;
        } = new List<string>()
        {
            "The", "Quick", "Brown", "Fox", "Jumped", "Over", "The", "Lazy", "Dog"
        };
    }

    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public string PinchStatus { get; set; }

        public List<ItemCollection> Items
        {
            get;
            set;
        } = new List<ItemCollection>()
        {
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
            new ItemCollection(),
        };
    }
}
