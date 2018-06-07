using System;
using System.Collections.Generic;

namespace HW51_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            List<Signature> signatureList = new List<Signature>();

            peopleList.Add(GetPerson("Bob Arnold", true));
            peopleList.Add(GetPerson("Alice Avery", true));
            peopleList.Add(GetPerson("Albert Bailey", true));
            peopleList.Add(GetPerson("Matt Baker", true));
            peopleList.Add(GetPerson("Carol Campbell", true));
            peopleList.Add(GetPerson("Kevin Brown", true));
            peopleList.Add(GetPerson("Lisa Bower", true));

            peopleList[0].SigningEvent += (x) => x.ToLower();
            peopleList[1].SigningEvent += (x) => x.Replace(" ", "");
            peopleList[2].SigningEvent += (x) => x[0].ToString() + x[x.IndexOf(" ") + 1];
            peopleList[3].SigningEvent += (x) => x[0].ToString() + x.Substring(x.IndexOf(" ")+1);
            peopleList[4].SigningEvent += (x) => x.ToUpper();
            peopleList[5].SigningEvent += (x) => x.Split(' ')[1]+"."+ x.Split(' ')[0];
            peopleList[6].SigningEvent += (x) => x.Substring(0,x.IndexOf(" ")).ToLower();
                        
            foreach (Person item in peopleList)
            {
                signatureList.Add(new Signature(item.FullName, item.SignAction()));
            }
            


            foreach (Signature sign in signatureList)
            {
                Console.WriteLine("Full name: " + sign.FullName + " signature: " + sign.FullSignature);
                
            }

            Console.ReadLine();
        }


        private static Person GetPerson(string name, bool wantsToSign)
        {
            Person p = new Person();
            p.FullName = name;
            p.WantToSign = wantsToSign;

            return p;
        }


    }
}
