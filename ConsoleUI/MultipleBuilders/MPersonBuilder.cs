using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.MultipleBuilders
{
    public class MPersonBuilder // Facade
    {
        // It has to be reference type 
        protected MPerson person = new MPerson();

        public MPersonJobBuilder Works => new MPersonJobBuilder(person);
        public MPersonAddressBuilder Lives => new MPersonAddressBuilder(person);

        public MPerson Build() => person;
    }
}
