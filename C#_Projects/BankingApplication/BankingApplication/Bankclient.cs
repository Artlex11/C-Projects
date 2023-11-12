using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Bankclient
    {
        public string Username, Creditsum, Contribution, 
            Period, Percent, Dol, Euro, Funt, Metall, Gram;

        private string Password;


        public Bankclient(string usr, string pas, string crsum, string cont,
            string yea, string p, string d, string eu, string f, string met, string g)
        {
            Username = usr;
            Password = pas;
            Creditsum = crsum;
            Contribution = cont;
            Period = yea;
            Percent = p;
            Dol = d;
            Euro = eu;
            Funt = f;
            Metall = met;
            Gram = g;
        }

        public string Info()
        {
            string b =  Username + " " + Password + " " + Creditsum + " " + Contribution +" " +  Period + " "+ Percent + " " + Dol + " " + Euro + " " + Funt + " " + Metall + " " + Gram;
            return b;
        }
    }
}
