namespace Ohce
{
    public class Echo
    {
        private readonly string _name;

        public Echo(string name)
        {
            _name = name;
        }

        public string Answer()
            => $"¡Buenas tardes {_name}!";
    }
}