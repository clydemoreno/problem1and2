using System;
using System.Collections.Generic;
namespace NonRepeatingSubString
{
    class BuildList{
    
        public void Start(String list){

            list = list + " ";
            String sub = null;
            int current = 0;
            for(int i=0;i<list.Length - 1;i++){
                if(list[i]  != list[i + 1]){
                    sub = sub + list[i];
                    current = i;
                }
                else
                {
                    sub = "";
                }

            }
            Console.WriteLine("Problem 1");

            Console.WriteLine("Output: Substring..{0}",sub);

        }

        public void Run(int[] array)
        {


            Dictionary<int, int> map = new Dictionary<int, int>();

            int count = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (map.ContainsKey(array[i]))
                {
                    //Console.WriteLine("yes");
                    map[array[i]] = map[array[i]] + 1;


                }
                else{
                    map[array[i]] = 1;

                }

                if (count < map[array[i]])
                {
                    count = map[array[i]];
                }

            }


            Console.WriteLine("Problem 2");

            Console.WriteLine("Output: Count is..{0}",count);


        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            BuildList b = new BuildList();
            String list = "pxxkfx";
            b.Start(list);

            list = "pxmaldfjandaldaufdnljlda";
            b.Start(list);

            list = "xxxxa";
            b.Start(list);

            int[] array = new int[6];
            array[0] = 4;
            array[1] = 3;
            array[2] = 2;
            array[3] = 4;
            array[4] = 3;
            array[5] = 4;

            b.Run(array);


            int[] array2 = new int[6];
            array[0] = 1;
            array[1] = 1;
            array[2] = 2;
            array[3] = 1;
            array[4] = 3;
            array[5] = 1;

            b.Run(array);

        }

    }
}
