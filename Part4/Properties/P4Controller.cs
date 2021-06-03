using System;
using System.Text;

namespace Part4.Properties
{
    public class P4Controller
    {
        public static Boolean CheckSin()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hay nhap SIN :");
            string sin = Console.ReadLine();
            Char[] mangSin = sin.ToCharArray();
            int checkTongSin = 0;
            string strChan = "";
            string strLe = "";
            int tongChan = 0;
            int tongLe =0 ;
            for (int i = 0; i < mangSin.Length; i++)
            {
                checkTongSin += int.Parse(mangSin[i].ToString());
                if ((i+1)%2==0)
                {
                    strChan += (int.Parse(mangSin[i].ToString()) * 2);
                }
                else
                {
                    strLe += (int.Parse(mangSin[i].ToString())).ToString();
                }
            }
            Char[] mangChan = strChan.ToCharArray();
            Char[] mangLe = strLe.ToCharArray();
            for (int i = 0; i < mangChan.Length; i++)
            {
                tongChan += int.Parse(mangChan[i].ToString());
            }     
            for (int i = 0; i < mangLe.Length-1; i++)
            {
                tongLe += int.Parse(mangLe[i].ToString());
            }
            int checkSoCuoiSin = 10 - ((tongChan + tongLe) % 10);
            int SoCuoiSin = int.Parse(mangSin[mangSin.Length-1].ToString());
            if (checkTongSin % 10 != 0 || SoCuoiSin != checkSoCuoiSin )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}