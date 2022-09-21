using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    
    public static void Main()
    {
      welcome(); 
      
      int loop = 0;
      bool repeatLoop = true;
      while (repeatLoop)
      {
        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View) or end? (End)");
        string userInput = Console.ReadLine().ToLower();
        
        if (userInput == "add") {
          Console.WriteLine("Please enter the description for the new item.");
          string item = Console.ReadLine();
          Item newItem = new Item(item); 

        } else if (userInput == "view"){
          Console.WriteLine("Your list: ");
          List<Item> currentList = Item.GetAll();

          foreach(Item i in currentList) 
          {
            loop += 1;
            Console.WriteLine(loop + ") " + i.Description + \n);
          }

        } else if (userInput == "end"){
          repeatLoop = false;

        } else {
          Console.WriteLine("This is not a valid command, please try again");
        }
      }

      void welcome(){
        Console.WriteLine("Welcome to the To Do List");       
      }
    }
  }
}