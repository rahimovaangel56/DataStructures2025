using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Sort
    {
        public static void BubbleSort(ref int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

        }

        public static void SelectionSort(ref int[] data)
        {
            for( int i = 0; i < data.Length - 1; i++)
            {
                int minInd = i; //предполагаем что текущий элемент - минимальный
                for(int j = i + 1; j < data.Length; j++)
                {
                    //если в оставшемся диапазоне встречаем значение меньще текущего
                    if(data[j] < data[minInd])
                        minInd = j;//то значение индекса минимального значения меняем
                }
                //если нашли что то меньше текущего - то меняем значения местами
                if(minInd != i)
                {
                    int temp = data[i];
                    data[i] = data[minInd];
                    data[minInd] = temp;
                }
            }
        }

        public static void InsertionSort(ref int[] data)
        {
            for(int i =  1; i < data.Length; i++)
            {
                int key = data[i];
                int j = i - 1;

                while(j >= 0 && data[j] > key)
                {
                    data[j+1] = data[j];
                    j--;
                }
                data[j + 1] = key;
            }
        }
    }
}
