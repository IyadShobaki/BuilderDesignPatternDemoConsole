using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.MultipleBuilders
{
    public class MPersonJobBuilder : MPersonBuilder
    {
        public MPersonJobBuilder(MPerson person)
        {
            this.person = person;
        }
        public MPersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }
        public MPersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }
        public MPersonJobBuilder Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }
}
