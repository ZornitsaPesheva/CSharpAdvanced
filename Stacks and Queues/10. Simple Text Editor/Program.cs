using System;
using System.Collections.Generic;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> text = new Stack<char>();
            Stack<string> operations = new Stack<string>();
            Stack<string> erased = new Stack<string>();
            Stack<string> added = new Stack<string>();
            Queue<char> toPrint = new Queue<char>();

            int countOps = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOps; i++)
            {
                string[] input = Console.ReadLine().Split(' '); 
                int numOp = int.Parse(input[0]);
                switch (numOp)
                {
                    case 1: //add chars to the stack
                        for (int j = 0; j < input[1].Length; j++)
                        {
                            text.Push(input[1][j]);
                        }                      
                        operations.Push("add");
                        added.Push(input[1]);


                        break;
                    case 2: //erase count chars from the stack
                        string erasedString = "";
                        for (int j = 1; j <= int.Parse(input[1]); j++)
                        {
                            erasedString += text.Pop();
                        }
                        operations.Push("erase");
                        erased.Push(erasedString);
                        break;
                    case 3: //returns the elementy at position index
                        int index = int.Parse(input[1]);
                        //char element = text.ElementAt(index - 1);

                        Stack<char> tempText = new Stack<char>(new Stack<char>(text));

                        while (tempText.Count > index)
                        {
                            tempText.Pop();
                        }
                        char element = tempText.Pop();
                        toPrint.Enqueue(element);
                        break;
                    case 4:
                        string command = operations.Pop();
                        if (command == "add")
                        {
                            string txtToErase = added.Pop();
                            for (int j = 0; j < txtToErase.Length; j++)
                            {
                                text.Pop();
                            }
                        }
                        else
                        {
                            string txtToAdd = erased.Pop();
                            for (int j = txtToAdd.Length - 1; j >= 0; j--)
                            {
                                text.Push(txtToAdd[j]);
                            }
                        }
                        break;
                }

            }

            while (toPrint.Count > 0)
            {
                Console.WriteLine(toPrint.Dequeue());
            }
        }
    }
}
