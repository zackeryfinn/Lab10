using System;

namespace Lab10
{
    public class WindowPop
    {
        public void WindowOpen()
        {
            for (int i = 1; i < 40; i++)
            {
                Console.SetWindowSize(i * 2, i);
                System.Threading.Thread.Sleep(60);
            }
            Console.WriteLine();
        }
    }
}
    

