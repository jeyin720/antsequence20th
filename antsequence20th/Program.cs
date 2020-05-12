using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            String n = "11";
            String num=n;
            int cnt = 1;
            Console.WriteLine(cnt + "번째 수열: 1");
            while (cnt< 20)
            {
                cnt++;
                Console.WriteLine(cnt+"번째 수열: "+num);
                
                k = 0;
                
                n = num;
                char n1 = n[0];
                num = "";
                for (int i = 0; i < n.Length; i++)
                {
                    
                    if (n1 == n[i])
                    {
                        k++;
                    }
                    else
                    {
                        num += n1 + "" + k;
                        k = 1;
                        n1 = n[i];
                    }
                    
                }
                num += n1 + "" + k;
            }
            
        }
    }
}
