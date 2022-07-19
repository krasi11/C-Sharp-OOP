using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Encapsulation_Exc
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleAndTheirMoney = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            string[] productsAndTheirCost = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Product> product = new Dictionary<string, Product>();
            string input;
            try
            {
                foreach (var person in peopleAndTheirMoney)
                {
                    string[] personInfo = person.Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);
                    Person currPerson = new Person(name, money);
                    if (!people.ContainsKey(name))
                    {
                        people.Add(name,currPerson);
                    }
                }
                foreach (var item in productsAndTheirCost)
                {
                    string[] productInfo = item.Split('=');
                    string name = productInfo[0];
                    decimal money = decimal.Parse(productInfo[1]);
                    Product currProduct = new Product(name, money);
                    if (!product.ContainsKey(name))
                    {
                        product.Add(name, currProduct);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            while ((input = Console.ReadLine())!="END")
            {
                string[] personBuysProduct = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = personBuysProduct[0];
                string productName = personBuysProduct[1];
                if (people.ContainsKey(personName)&&product.ContainsKey(productName))
                {
                    try
                    {
                        people[personName].Buy(product[productName]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            foreach (var person in people)
            {
                Console.WriteLine(person.Value);
            }
        }
    }
}
