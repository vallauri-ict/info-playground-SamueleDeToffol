using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es06_Classe_Indexata
{
    class MiaIndexClasse
    {
        private string[] element;

        public MiaIndexClasse(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int  length()
        {
            return element.Length;
        }
    }
}
