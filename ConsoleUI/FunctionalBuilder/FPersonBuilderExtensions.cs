namespace ConsoleUI.FunctionalBuilder
{
    public static class FPersonBuilderExtensions
    {
        public static FPersonBuilder WorksAs(
            this FPersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }
}
