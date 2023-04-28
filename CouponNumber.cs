using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class CouponNumber
    {
        public static void Coupon()
        {
            Console.WriteLine("Enter no of distinct coupon you want to generate ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] couponCollection = new int[N];
            for (int i = 0; i <= N - 1;)
            {
                int coupon = random.Next(10001, 100001);
                {
                    if ((coupon.CompareTo(couponCollection[i])) == 0)
                    {
                        continue;
                    }
                    else if ((coupon.CompareTo(couponCollection[i])) != 0)
                    {
                        int[] coupomCollection = new int[i];
                        couponCollection[i] = coupon;
                        i++;
                    }
                }
            }
            foreach (int i in couponCollection)
            {
                Console.WriteLine("Coupon Number " + i + " ");
            }
        }
    }
}