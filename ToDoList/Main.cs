using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class ToDoList
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the to do list!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addOrView01 = (Console.ReadLine()).ToLower();
      if (addOrView01 == "add")
      {
        Add();
      }
      else if (addOrView01 == "view")
      {
        View();
      }
      else
      {
        Main();
      }
    }
    public static void Add()
    {
      Console.WriteLine("Please enter a description for your task:");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine(description + " has been added to your list.");
      Console.WriteLine("Would you like to add to your list or view your list? (add/view)");
      string addOrView02 = (Console.ReadLine()).ToLower();
      if (addOrView02 == "add")
      {
        Add();
      }
      else if (addOrView02 == "view")
      {
        View();
      }
      else
      {
        Main();
      }
    }
    public static void View()
    {
      Console.WriteLine("Your To Do list:");
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine(thisItem.Description);
      }
      Console.WriteLine("Would you like to add more items to your list or are you finished? (add/end");
      string addOrEnd = (Console.ReadLine()).ToLower();
      if (addOrEnd == add)
      {
        Add();
      }
      else if (addOrEnd == end)
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Main();
      }
    }
  }
}