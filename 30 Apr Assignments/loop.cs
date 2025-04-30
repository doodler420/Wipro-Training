using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //for
        for(int i=1;i=5;i++){
            Console.WriteLine(i);
        }

        int j=5;
        //while
        while(int j>=1){
            Console.WriteLine(i);
            i--;
        }

        //do-while
        do{
            Console.WriteLine(i);
            i++;
        }while(i<=5);

        //building grid using loop
        for (int row = 1; row <= 3; row++)
            {   
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
    }
}