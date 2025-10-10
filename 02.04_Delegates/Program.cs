namespace _02._04_Delegates
{
    public delegate bool FilterStringDelegate(string text);

    internal class Program
    {
        //переписать код для коллекции строк и произвести фильтрацию строк (вывести в результат только
        //те строки, в которых нет спецсимволов)
        static void Main(string[] args)
        {
            List<string> strings = new() { "user", "client", "admin", "test@email.com", "user_name" };

            Console.WriteLine("Исходные строки:");
            foreach (var str in strings)
                Console.WriteLine(str);

            Console.WriteLine("\nФильтрация строк");

            var filteredStrings = FilterStrings(strings, s => !HasSpecialCharacters(s));

            Console.WriteLine("Строки без спецсимволов:");
            foreach (var str in filteredStrings)
                Console.WriteLine(str);
        }

        public static List<string> FilterStrings(List<string> data, FilterStringDelegate filter)
        {
            var result = new List<string>();
            foreach (string d in data)
            {
                if (filter(d))
                    result.Add(d);
            }
            return result;
        }

        public static bool HasSpecialCharacters(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                    return true;
            }
            return false;
        }
    }
}