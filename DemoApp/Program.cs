

namespace CoreApplication
{
    using System;
    using System.Threading.Tasks;
    public class Program
    {
        
        private int total;

                public int AddNumbers(int first, int second)
        {
            this.total = first + second;
            return this.total;
        }
    }
}