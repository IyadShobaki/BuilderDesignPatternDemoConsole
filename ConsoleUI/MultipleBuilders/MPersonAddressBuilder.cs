using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.MultipleBuilders
{
    public class MPersonAddressBuilder : MPersonBuilder
    {
        // might not work with a value type
        public MPersonAddressBuilder(MPerson person)
        {
            this.person = person;
        }
        public MPersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }
        public MPersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }
        public MPersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }
}
