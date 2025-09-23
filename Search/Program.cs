namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 5;
            int[] data = GetArray(10, key);
            Console.WriteLine(Search.RecursiveBinarySearch(77, data));
            Console.WriteLine(Search.LinearSearch(77, data));
            Console.WriteLine(Search.InterpolateSearch(77, data));
        }

        static int[] GetArray(int count, int key)
        {
            int[] array = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, key);
            }
            array[count - 1] = key;
            return array;
        }
       
    }
}
