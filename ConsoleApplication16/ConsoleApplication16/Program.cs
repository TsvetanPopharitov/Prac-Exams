using System;
using System.Collections;
namespace MyCollections
{

    class ShipDamage
    {
        static void Main()
        {
            int SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, CY3;

            SX1 = Int32.Parse(Console.ReadLine());
            SY1 = Int32.Parse(Console.ReadLine());
            SX2 = Int32.Parse(Console.ReadLine());
            SY2 = Int32.Parse(Console.ReadLine());
            H = Int32.Parse(Console.ReadLine());
            CX1 = Int32.Parse(Console.ReadLine());
            CY1 = Int32.Parse(Console.ReadLine());
            CX2 = Int32.Parse(Console.ReadLine());
            CY2 = Int32.Parse(Console.ReadLine());
            CX3 = Int32.Parse(Console.ReadLine());
            CY3 = Int32.Parse(Console.ReadLine());

            
            SY1 -= H;
            SY2 -= H;
            CY1 -= H;
            CY2 -= H;
            CY3 -= H;

            int damage = 0;
            
            //za Rybovete 25 dmg
            if (((CX1 == SX1) || (CX1 == SX2)) && ((CY1 + SY1 == 0) || (CY1 + SY2 == 0)))
            {
                damage += 25;
               
            }
            if (((CX2 == SX1) || (CX2 == SX2)) && ((CY2 + SY1 == 0) || (CY2 + SY2 == 0)))
            {
                damage += 25;
             
            }
            if (((CX3 == SX1) || (CX3 == SX2)) && ((CY3 + SY1 == 0) || (CY3 + SY2 == 0)))
            {
                damage += 25;
               
            }


            //za Stranite 50dmg
            if ((((CX1 == SX1)) || (CX1 == SX2)) && ((-CY1 > Math.Min(SY1, SY2)) && (-CY1 <Math.Max(SY1,SY2))))
            {
                damage += 50;
            }
            if ((((CX2 == SX1)) || (CX2 == SX2)) && ((-CY2 > Math.Min(SY1,SY2)) && (-CY2 < Math.Max(SY1, SY2))))
            {
                damage += 50;
            }
            if ((((CX3 == SX1)) || (CX3 == SX2)) && ((-CY3 > Math.Min(SY1, SY2)) && (-CY3 < Math.Max(SY1, SY2))))
            {
                damage += 50;
            }
            if ((((-CY1 == SY1) || (-CY1 == SY2)) && (CX1 > Math.Min(SX1,SX2)) && (CX1 < Math.Max(SX1,SX2))))
            {
                damage += 50;
            }
            if ((((-CY2 == SY1) || (-CY2 == SY2)) && (CX2 > Math.Min(SX1, SX2)) && (CX2 < Math.Max(SX1, SX2))))
            {
                damage += 50;
            }
            if ((((-CY3 == SY1) || (-CY3 == SY2)) && (CX3 > Math.Min(SX1, SX2)) && (CX3 < Math.Max(SX1, SX2))))
            {
                damage += 50;
            }

            //Vytre  100dmg
            if (((CX1 > Math.Min(SX1, SX2)) && (CX1 < Math.Max(SX1, SX2))) && ((-CY1 > Math.Min(SY1, SY2)) && (-CY1 < Math.Max(SY1, SY2))))
            {
                damage += 100;
            }
            if (((CX2 > Math.Min(SX1, SX2)) && (CX2 < Math.Max(SX1, SX2))) && ((-CY2 > Math.Min(SY1, SY2)) && (-CY2 < Math.Max(SY1, SY2))))
            {
                damage += 100;
            }
            if (((CX3 > Math.Min(SX1, SX2)) && (CX3 < Math.Max(SX1, SX2))) && ((-CY3 > Math.Min(SY1, SY2)) && (-CY3 < Math.Max(SY1, SY2))))
            {
                damage += 100;
            }
                Console.WriteLine(damage + "%");

        }
    }
}
