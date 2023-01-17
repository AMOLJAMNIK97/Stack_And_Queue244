using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Problem
    {
        static void Main(string[] args)
        {

            //Stack st = new Stack();
            //st.Push(70);
            //st.Push(30);
            //st.Push(56);
            //st.display();
            //st.Peek();
            //st.Pop();
            //st.display();
            //st.Peek();
            //st.Pop();
            //st.display();
            //st.Peek();
            //st.Pop();
            //st.display();

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            
        }
    }
}