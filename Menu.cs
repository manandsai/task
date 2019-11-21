using System;

namespace task
{
    public class Menu
    {
        ConsoleHandler consoleHandler= new ConsoleHandler();
        Phonebook phonebook = new Phonebook();
        public void MenuList()
        {
              string command = " " ;
              
         while (command != "exit"){
             consoleHandler.Write("Please enter a command: ");
            command = consoleHandler.Read().ToLower();
            switch (command )
            {
                case "add":
                   phonebook .AddPerson();
                    break;
                case "list":
                    phonebook.ListPeople();
                    
                    break;
                case "delete":
                    phonebook.DeletePerson();
                    break;
                case "search":
                    phonebook.searchperson();
                    break;
                    case "exit":
                      consoleHandler.Write("The End ");
                       System.Environment.Exit(0);  
                      break;
                      case "data":
                       consoleHandler.Write("data in the file:  ");
                        phonebook.ReadFromFile();
                        break;

                default:
                   consoleHandler.Write("Enter Correct Command  ");
                    break;
            }
        
        } 
        
    }
}
}