using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook bestFriend = new PhoneBook();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("ad:");
            //    string nm = Console.ReadLine();

            //    Console.WriteLine("nomre:");
            //    string num = Console.ReadLine();

            //    bestFriend.AddPerson(nm, num); 
            //}

            bestFriend.AddPerson("Xeyal", "054335436");
            bestFriend.AddPerson("Sadiq", "869543656");
            bestFriend.AddPerson("Nurlan", "433853823");
            bestFriend.AddPerson("Rasim", "62910210");
            bestFriend.AddPerson("Xeyal", "54546565335436");
            bestFriend.List();
            bestFriend.GetNumberByName("Sadiq");
            bestFriend.GetNameByNumber("054335436");
            bestFriend.RemoveByName("Rasim");
            bestFriend.RemoveByNumber("433853823");
            bestFriend.List();
        }
    }

    class PhoneBook
    {
        private readonly Dictionary<string, string> phonebook;
        public PhoneBook()
        {
            phonebook = new Dictionary<string, string>();
        }
        
        public void AddPerson(string name,string number)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} is exist");

                Console.WriteLine($"Select option:\n 1.Keep the number \n 2.Update");

                string select = Console.ReadLine();
                while (select != "1" && select != "2" )
                {
                    Console.WriteLine($"Pls select valid number");
                    select=Console.ReadLine();
                }
                if (select=="2")
                {
                    phonebook[name] = number;
                    Console.WriteLine($"{name} in nomresi {number}");
                    
                }
            }
            else
            {
                phonebook.Add(name, number);
                Console.WriteLine($"{name} with {number} added");
            }
        }
        public void List()
        {
            Console.WriteLine("All people");
            foreach (var item in phonebook.Keys)
            {
                Console.WriteLine($"{item}={phonebook[item]}");
            }
        }

        public void GetNumberByName(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name}  {phonebook[name]}");
            }
            else
            {
                Console.WriteLine("Nobody exist this contact");
            }
        }

        public void GetNameByNumber(string number)
        {
            if (phonebook.ContainsKey(number))
            {
                foreach (var item in phonebook.Keys)
                {
                    if (phonebook[item]==number)
                    {
                        Console.WriteLine(number+" "+item);
                    }
                }
            }
      
        }

        public void RemoveByName(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                phonebook.Remove(name);
                Console.WriteLine(name + " is deleted");
            }
            else
            {
                Console.WriteLine("this person doesnt exist");
            }
        }

        public void RemoveByNumber(string number)
        {
            if (phonebook.ContainsKey(number))
            {
                foreach (var item in phonebook.Keys)
                {
                    if (phonebook[item] == number)
                    {
                       phonebook.Remove(item);
                       break;
                    }
                }
            }
            else
            {
                Console.WriteLine("this person doesnt exist");
            }
        }
    }
    
}
