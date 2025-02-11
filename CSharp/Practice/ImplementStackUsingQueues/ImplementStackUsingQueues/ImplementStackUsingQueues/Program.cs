namespace ImplementStackUsingQueues
{
    internal class Program
    {
        public class MyStack
        {
            private readonly Queue<int> q;

            public MyStack()
            {
                q = new Queue<int>();
            }

            public void Push(int x)
            {
                q.Enqueue(x);
                for (var i = q.Count - 1; i > 0; i--) 
                {
                    q.Enqueue(q.Dequeue());
                }
            }

            public int Pop()
            {
                return q.Dequeue();
            }

            public int Top()
            {
                return q.Peek();
            }

            public bool Empty()
            {
                return q.Count == 0;
            }
        }

        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Top();
            stack.Empty();
        }
    }
}
