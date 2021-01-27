using System;
using System.Collections.Generic;
using System.Text;

// Faceted Builder 
namespace ConsoleUI.MultipleBuilders
{
    public class MPerson
    {
        // Builder for personal info
        public string StreetAddress, Postcode, City;

        // Builder for job info
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}," +
                $" {nameof(Postcode)}: {Postcode}"+
                $" {nameof(City)}: {City}"+
                $" {nameof(CompanyName)}: {CompanyName}"+
                $" {nameof(Position)}: {Position}" +
                $" {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
