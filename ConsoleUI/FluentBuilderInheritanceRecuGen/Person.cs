﻿namespace ConsoleUI.FluentBuilderInheritanceRecuGen
{
    // Fluent Builder Inheritance with Recursive Generics
    public class Person
    {
        public string Name;
        public string Position;

        public class Builder : PersonJobBuilder<Builder>
        {

        }
        public static Builder New => new Builder();
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}