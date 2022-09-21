/*     UI Logic     */ 
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    // public string CmdInput { get; set; }
    
    // public void CmdProcessor(string input)
    // {
    //   CmdInput = input;
    // }
    
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      
      //Save user input to string variable, run through branch logic to make sure they entered a valid command phrase.
      string userInput = Console.ReadLine().ToLower();
      
      if (userInput == "add") {
        Console.WriteLine("Please enter the description for the new item.");
        string item = Console.ReadLine();
        Item newItem = new Item(item);  //Creates new item, which is automatically aded to the list. 

      } else if (userInput == "view"){
        Console.WriteLine("Your list: ");

        // display list
        List<Item> currentList = new List<Item> { }; 
        currentList = Item.GetAll(); 

        foreach(Item i in currentList) 
        {
          Console.WriteLine(i.Description);
        }

      } else {
        Console.WriteLine("This is not a valid command, please try again");
      }
    }
  }
}