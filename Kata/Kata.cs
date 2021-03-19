using System;
using System.Linq;

namespace Kata
{
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            if (num <= 0)
                return 0;

            IOrderedEnumerable<int> intList = num.ToString().Select(digit => int.Parse(digit.ToString()))
              .OrderByDescending(elm => elm);

            var response = "";
            foreach (var data in intList)
                response += data;

            return Convert.ToInt32(response);
        }

        public static int DescendingOrderCodewar(int num)
            => num <= 0 ? 0 : int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }
}
