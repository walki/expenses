namespace Expenses.Data
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category DefaultCategory { get; set; }

        public Account Account { get; set; }
    }
}