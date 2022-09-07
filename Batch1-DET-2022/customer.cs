using Batch1_DET_2022.Models;

namespace Batch1_DET_2022
{
    internal class customer
    {
        internal static string Name;

        public static int ID { get; internal set; }
        public static int Age { get; internal set; }

        public static implicit operator customer(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}