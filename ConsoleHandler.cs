using System;
using System.Collections.Generic;
namespace task
{
    public  class ConsoleHandler :newinterface
    {
      
public Person AddPersoninConsole( Person person){
       Write("Enter First Name: ");
            person.FirstName = Read();

            Write("Enter Last Name: ");
            person.LastName = Read();

         
            while (true)
            {
                Write("Enter Phone Number: ");
                var number =   Read();
                Regex isNumbervalid =  new Regex(@"^[0-9]{10}$");
                if (isNumbervalid .IsMatch(number))
                {
                    person.PhoneNumber = number;
                    break;
                }
                else 
                {
                    Console.WriteLine("Please enter the correct number");

                }
            }

            Write("Enter Email: ");
            person.Email =   Read();
    
return person;
}
public Person Listpersoninconsole(int count,Person person){
     if (count == 0)
            {
                Console.WriteLine("Your phone book is empty. Press any key to continue.");
                Console.ReadKey();
                return null;
            }
            else
            {
                  return person ;
            }
 
}
  public void PrintContact(Person person)
        {
           Console.WriteLine("First Name: " + person.FirstName);
           Console.WriteLine("Last Name: " + person.LastName);
           Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email: " + person.Email);
           Console.WriteLine("-------------------------------------------");
        }
public  void DeletePersoninConsole( ){
    Console.WriteLine("Enter the firstname you wnat to delete");
    

}


        public void Write(string text)
        {
            Console.WriteLine(text);
        }
        public string Read()
        {
         return Console.ReadLine();
        }
    }
}
