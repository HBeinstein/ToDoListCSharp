using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }

    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static int FindItem(string description)
    {
      return _instances.IndexOf(_instances.Find(i => i.Description == description));
    }

    public static void RemoveItem(int found)
    {    
      _instances.RemoveAt(found);
    }
  }
}