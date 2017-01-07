using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var db_acc = new DB_ACCEntities();

            foreach (var accCostSharingSequence in db_acc.AccCostSharingSequence)
            {
                Console.WriteLine(accCostSharingSequence.chCostToShare + ";" + accCostSharingSequence.nvSharingMethodName);
                foreach (var accSharingPercent in accCostSharingSequence.AccSharingPercent)
                {
                    Console.WriteLine("     " + accSharingPercent.chShareToCostID + ";" + accSharingPercent.dePercent.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
