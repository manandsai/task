using System;
using System .Collections .Generic ;

namespace task
{
    public class Phonebook 
    {
        public List<Person> people = new List<Person>();
      FileHandler filehandler = new FileHandler();
       ConsoleHandler consoleHandler= new ConsoleHandler(); 
     
     Person person = new Person();
     
     public void AddPerson()
        {
          
           consoleHandler.AddPersoninConsole(person);
            people.Add(person);
            filehandler.WritingFile(people);
        }

        public void ListPeople()
        {
            int count = people.Count;
           consoleHandler.Write("****************");  
           consoleHandler.Listpersoninconsole( count,person);
          
            foreach (var person in people)
                {   
                    consoleHandler.PrintContact(person);
                }
     
                consoleHandler.Write("\nPress any key to continue.");
                Console.ReadKey();

        }

        public void DeletePerson()
        {
            if (people.Count != 0)
            {
                consoleHandler. DeletePersoninConsole();
                string nameYouWantToDelete = consoleHandler.Read();
                foreach (var item in people)
                {
                    if (item.FirstName == nameYouWantToDelete)
                    {
                        people.Remove(item);
                        return;
                    }
                }
            }
            
        }

        public void searchperson()
        {
            if (people.Count != 0)
            {
                consoleHandler.Write("Enter the firstname you wnat to search");
                string nameYouWantToSearch = consoleHandler.Read();
                foreach (var item in people)
                {
                    if (item.FirstName == nameYouWantToSearch)
                    {
                       consoleHandler.PrintContact(item);
                        return;
                    }
                }
            }
           
        }
    public void ReadFromFile(){
         filehandler.ReadFromFile();
    }
    }
}