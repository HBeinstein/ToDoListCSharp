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
      Console.WriteLine("Would you like to add an item to your list, remove an item from your list or view your list? (add/remove/view)");
      string choice01 = (Console.ReadLine()).ToLower();
      if (choice01 == "add")
      {
        Add();
      }
      else if (choice01 == "view")
      {
        View();
      }
      else if (choice01 == "remove")
      {
        FindAndRemove();
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
      Console.WriteLine("Would you like to add an item to your list, remove an item from your list or view your list? (add/remove/view)");
      string choice02 = (Console.ReadLine()).ToLower();
      if (choice02 == "add")
      {
        Add();
      }
      else if (choice02 == "view")
      {
        View();
      }
      else if (choice02 == "remove")
      {
        FindAndRemove();
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
      if (result.Count >= 1 )
      {
        foreach (Item thisItem in result)
        {
          Console.WriteLine(thisItem.Description);
        }
      }
      else
      {
        Console.WriteLine("Your To Do List is empty.  Congratulations!");
      }
      Console.WriteLine("Would you like to add more items to your list or are you finished? (add/end");
      string choice03 = (Console.ReadLine()).ToLower();
      if (choice03 == "add")
      {
        Add();
      }
      else if (choice03 == "end")
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Main();
      }
    }
    public static void FindAndRemove()
    {
      Console.WriteLine("Enter the description of the task you would like to remove:");
      string locate = Console.ReadLine();
      int found = Item.FindItem(locate);
      Item.RemoveItem(found);
      Console.WriteLine(locate + " has been removed from your To Do list.");
      Console.WriteLine("Would you like to add an item to your list, remove an item from your list or view your list? (add/remove/view/end)");
      string choice04 = (Console.ReadLine()).ToLower();
      if (choice04 == "add")
      {
        Add();
      }
      else if (choice04 == "view")
      {
        View();
      }
      else if (choice04 == "remove")
      {
        FindAndRemove();
      }
      else if (choice04 == "end")
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