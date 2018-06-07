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

            //הוספת אנשים לרשימת האנשים, שכוללת את השם המלא והאם הוא מוכן לחתום
            peopleList.Add(GetNewPerson("Bob Arnold", true));
            peopleList.Add(GetNewPerson("Alice Avery", true));
            peopleList.Add(GetNewPerson("Albert Bailey", true));
            peopleList.Add(GetNewPerson("Matt Baker", true));
            peopleList.Add(GetNewPerson("Carol Campbell", true));
            peopleList.Add(GetNewPerson("Kevin Brown", true));
            peopleList.Add(GetNewPerson("Lisa Bower", true));

            //רישום לארוע של החתימה, והגדרת היישום שלו
            peopleList[0].SigningEvent += (x) => x.ToLower();
            peopleList[1].SigningEvent += (x) => x.Replace(" ", "");
            peopleList[2].SigningEvent += (x) => x[0].ToString() + x[x.IndexOf(" ") + 1];
            peopleList[3].SigningEvent += (x) => x[0].ToString() + x.Substring(x.IndexOf(" ") + 1);
            peopleList[4].SigningEvent += (x) => x.ToUpper();
            peopleList[5].SigningEvent += (x) => x.Split(' ')[1] + "." + x.Split(' ')[0];
            peopleList[6].SigningEvent += (x) => x.Substring(0, x.IndexOf(" ")).ToLower();

            //ריצה בלולאה שמוסיפה לרשימת החתימות את השם  וכמו כן מפעילה פונקציה 
            foreach (Person item in peopleList)
            {
                signatureList.Add(new Signature(item.FullName, item.SignAction()));
            }

            //ריצה בלולאה להצגת החתימות בקונסול 
            foreach (Signature sign in signatureList)
            {
                Console.WriteLine("Full name: " + sign.FullName + " signature: " + sign.FullSignature);

            }

            Console.ReadLine();
        }

        //פונקציה שיוצרת פרסון חדש. מקבלת שם והאם מוכן לחתום, ומחזירה אוביקט מאותחל מסוג פרסון 
        private static Person GetNewPerson(string name, bool wantsToSign)
        {
            Person p = new Person();
            p.FullName = name;
            p.WantToSign = wantsToSign;

            return p;
        }


    }
}
