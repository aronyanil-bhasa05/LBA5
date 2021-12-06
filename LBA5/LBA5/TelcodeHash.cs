using System;
using System.Collections;

namespace LBA5
{
    class TelcodeHash
    {
        static void Main()
        {

            Hashtable hashtable = new Hashtable();
            String ch = ""; 
            String cname;
            int ctel;

            while (ch != "EXIT")
            {
                Console.Write("ADD/VIEW/EXIT ENTER CHOICE = ");
                ch = Console.ReadLine();
                if (ch == "ADD")
                {
                    Console.Write("ENTER COUNTRY = ");
                    cname = Console.ReadLine();
                    Console.Write("ENTER TEL CODE = ");
                    ctel = Convert.ToInt32(Console.ReadLine());
                    hashtable.Add(cname, ctel);
                }
                else if (ch == "VIEW")
                {
                    Console.WriteLine("TABLE ");
                    foreach (var key in hashtable.Keys)
                        Console.WriteLine($"Key={key} and Value={hashtable[key]}");
                }
                else if (ch == "EXIT")
                    break;
            }
            Console.ReadLine();
        }
    }
}
