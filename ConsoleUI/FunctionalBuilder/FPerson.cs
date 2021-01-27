namespace ConsoleUI.FunctionalBuilder
{
    public class FPerson
    {
        public string Name, Position;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
