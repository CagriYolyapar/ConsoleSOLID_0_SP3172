using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.Models.Entities
{
    public class Karakter
    {

        //Bizzat Karakter'in ne oldugunu programa anlatan idea

        public Karakter()
        {
            _strategies = new List<IStrategy>();
        }
        public void AddStrategy(IStrategy strategy)
        {
            _strategies.Add(strategy);
        }

        public string Ismi { get; set; }
        public int Can { get; set; }
        public int Enerjisi { get; set; }
        List<IStrategy> _strategies;

        public void YemekYe()
        {

        }


      
    }

   
}
