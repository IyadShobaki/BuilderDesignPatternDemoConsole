using ConsoleUI.FluentBuilder;
using ConsoleUI.FluentBuilderInheritanceRecuGen;
using ConsoleUI.FunctionalBuilder;
using ConsoleUI.MultipleBuilders;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faceted Builder:
            var pb = new MPersonBuilder();
            var person = pb.Works.At("Fabrikam")
                                 .AsA("Engineer")
                                 .Earning(123000)
                            .Lives.At("123 Main St")
                                  .In("Cleveland")
                                  .WithPostcode("12345")
                            .Build();
            Console.WriteLine(person);

            // Functional Builder:
            //var person = new FPersonBuilder()
            //    .Called("Iyad")
            //    .WorksAs("Developer")
            //    .Build();
            //Console.WriteLine(person);

            // Fluent Builder Inheritance with Recursive Generics:

            ////PersonJobBuilder<Person.Builder> me = Person.New
            ////    .Called("Iyad");
            //var me = Person.New
            //    .Called("Iyad")
            //    .WorkAsA("Developer")
            //    .Build();
            //Console.WriteLine(me);

            // Fluent Builder:

            //var htmlBuilder = new HtmlBuilder("ul");
            //htmlBuilder.AddChild("li", "Hello").AddChild("li", "World");

            //Console.WriteLine(htmlBuilder);
            Console.ReadKey();
        }
    }
}
