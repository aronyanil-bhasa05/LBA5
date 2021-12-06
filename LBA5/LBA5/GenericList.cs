using System;
using System.Collections.Generic;


namespace LBA5
{
    class ProdList
    {
        static void Main()
        {
            Console.WriteLine("PLANET SPORTS PVT LTD PRODUCT LIST ");
            List<Product> prods = new List<Product>();

            String ch,pn,pcat;
            ch = "";
            int pc;
            Console.WriteLine("TO ENTER TYPE ADD\nTO VIEW TYPE VIEW\nTO EXIT TYPE EXIT\n");
            while (ch != "EXIT")
            {
                Console.Write("ENTER CHOICE = ");
                ch = Console.ReadLine();

                switch (ch)
                {
                    case "ADD":
                        Console.Write("ENTER PRODUCT CODE = ");
                        pc = Convert.ToInt32(Console.ReadLine());
                        Console.Write("ENTER PRODUCT NAME = ");
                        pn = Console.ReadLine();
                        Console.Write("ENTER PRODUCT CATEGORY = ");
                        pcat = Console.ReadLine();
                        Product padd = new Product { PCode = pc, PName = pn, PCategory = pcat };
                        prods.Add(padd);
                        Console.WriteLine("ADDED ");
                        break;
                                            
                    case "VIEW":
                        Console.WriteLine("PRODUCT LIST ");
                        foreach (var emp in prods)
                            Console.WriteLine($"Code={emp.PCode}\tName={emp.PName}\tCategory={emp.PCategory}");
                        break;

                    case "EXIT":
                        break;

                    default:
                        Console.WriteLine("ERROR ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

    class Product
    {
        public int PCode { get; set; }
        public string PName { get; set; }
        public string PCategory { get; set; }
    }
}
