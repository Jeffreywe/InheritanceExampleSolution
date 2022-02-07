using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample {
    public class Pug : Dog { // Inheritence, specified with : copies dog into Pug and specifies whats different in Pug class

        public Pug() {
            Name = "Puggy";
            Size = "Small";
            NbrOfLegs = 1;
            
        }        
    }
}
