using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI.FunctionalBuilder
{
    public sealed class FPersonBuilder 
        : FunctionalBuilder<FPerson, FPersonBuilder>
    {
        public FPersonBuilder Called(string name)
             => Do(p => p.Name = name);
    }
    //public sealed class FPersonBuilder
    //{
    //    private readonly List<Func<FPerson, FPerson>> actions
    //        = new List<Func<FPerson, FPerson>>();

    //    public FPersonBuilder Called(string name)
    //        => Do(p => p.Name = name);
    //    public FPersonBuilder Do(Action<FPerson> action)
    //        => AddAction(action);
    //    public FPerson Build()
    //        => actions.Aggregate(new FPerson(), (p, f) => f(p));

    //    private FPersonBuilder AddAction(Action<FPerson> action)
    //    {
    //        actions.Add(p =>
    //        {
    //            action(p);
    //            return p;
    //        });
    //        return this;
    //    }
    //}
}
