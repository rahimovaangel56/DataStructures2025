namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            /* tree.AddNode("Tom");
             tree.AddNode("Mag");
             tree.AddNode("Bob");*/

            tree.Root = tree.CreateBalancedTree(5);
            var result = tree.TreeTraversal();


            tree.AddNode("0");
            foreach (var item in result) 
                Console.WriteLine(item);
            Console.ReadKey();
           
        }
    }
}
