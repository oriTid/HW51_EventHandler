namespace HW51_EventHandler
{
    delegate string SigningDelegate(string fullName);
     class Person

    {

        public event SigningDelegate SigningEvent;
        public string FullName { get; set; }
        public bool WantToSign { get; set; }


        public string SignAction()
        {
            if (WantToSign)
            {
                if (SigningEvent != null)
                {
                    return SigningEvent(FullName);
                }
            }
            return "";
        }
    }
}
