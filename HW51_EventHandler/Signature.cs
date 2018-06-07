using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW51_EventHandler
{
    public class Signature
    {
        public string FullName { get; }
        public string FullSignature { get;}

        public Signature(string fullName, string fullSignature)
        {
            FullName = fullName;
            FullSignature = fullSignature;
        }

    }
}
