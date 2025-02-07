namespace Assignment03__ADV
{
    internal class Program
    {
        #region Q01 :  implement a function to reverse the elements of a queue using a stack.Given a Queue

        public static void ReverseQueue<T>(Queue<T> queue)
        {
            if (queue is null) return;
            Stack<T> Stack = new Stack<T>();
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                Stack.Push(queue.Dequeue());

            }
            size = Stack.Count;
            for (int J = 0; J < size; J++)
            {
                queue.Enqueue(Stack.Pop());
            }

        }

        #endregion

        #region Q02 : Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        //Ex:
        //Input:
        //    [()] { }
        //Output:
        //    Balanced


        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                    return false;
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                    return false;
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                    return false;

            }
            return stack.Count == 0;
        }



        #endregion

        static void Main(string[] args)
        {

            #region Q01 :  implement a function to reverse the elements of a queue using a stack.Given a Queue

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine("Before ");
            //foreach (int i in queue)
            //    Console.Write($"{i} ");

            //ReverseQueue(queue);
            //Console.WriteLine("\nAfter ");
            //foreach (int i in queue)
            //    Console.Write($"{i} ");


            #endregion


            #region Q02 : Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            ////Ex:
            ////Input:
            ////    [()] { }
            ////Output:
            ////    Balanced


            //string input = "[()]{}";

            //string IsBalance = IsBalanced(input) ? "Balanced" : "Not Balanced";

            //Console.WriteLine(IsBalance);

            #endregion




        }
    }
}
