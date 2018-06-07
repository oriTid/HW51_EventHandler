namespace HW51_EventHandler
{
    //יצירת דלגייט 
    delegate string SigningDelegate(string fullName);
     class Person

    {
       
        public event SigningDelegate SigningEvent;  //יצירת ארוע מסוג הדלגייט 
        public string FullName { get; set; }
        public bool WantToSign { get; set; }


        public string SignAction()   //יצירת פונקציה שבמידה ועומדת בכל התנאים מפעילה את הארוע מסוג הדלגייט 
        {
            if (WantToSign)
            {
                if (SigningEvent != null)
                {
                    return SigningEvent(FullName);  //הפעלת הארוע 
                }
            }
            return "";
        }
    }
}
