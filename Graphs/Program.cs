using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] a = { { 0,0,0,0},
                         { 0,0,1,0},
                         { 1,0,0,0},
                         { 1,0,1,0}
                        };

            GraphByMatrix graph = new GraphByMatrix(a);
            graph.Depth(0);*/

            GraphByList graph = new GraphByList("Москва");
            Node n1 = graph.AddNode("Санкт-Петербург");
            Node n2 = graph.AddNode("Оренбург", n1);

            graph.Width();
        }
    }
}
