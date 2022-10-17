using System;

public class Task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value:");
        var strintArray = Console.ReadLine();                        
        int counter = 0;                                            

        for (int i = 0; i < strintArray.Length - 1; i++)          
        {
            if (strintArray[i] != strintArray[i + 1])           
            {
                counter++;                                    
            }
        }
        Console.WriteLine("You have " + counter + " unequal characters");    
    }
}