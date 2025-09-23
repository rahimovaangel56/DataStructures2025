namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = 65495765;
            int[] data = GetArray(1000000, key);
            Console.WriteLine(Search.RecursiveBinarySearch(key, data));
            Console.WriteLine(Search.LinearSearch(key, data));
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
