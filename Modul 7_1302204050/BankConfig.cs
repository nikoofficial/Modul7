using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Modul 7_1302204050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankConfig bankConfig = new BankConfig();

            dynamic conf = bankConfig.ReadJson();

            if (conf.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else if (conf.lang == "id")
            {
                Console.WriteLine("Enter amount to deposit in the account:");
            }
            string Transaction = Console.ReadLine();

            int Transaction = int.Parse(Transaction);

            int Transaction;

            if (Transaction <= (int)conf.Transaction.threshold)
            {
                Transaction = conf.Transaction.low_fee;
            }
            else
            {
                Transaction = conf.Transaction.high_fee;
            }

            if (conf.lang == "en")
            {
                Console.WriteLine("Transfer fee = " + Transaction);
                Console.WriteLine("Total amount = " + (Transaction) + "\n");
                Console.WriteLine("Select transfer method");
            }
            else if (conf.lang == "id")
            {
                Console.WriteLine("Biaya Transaction = " + Transaction);
                Console.WriteLine("Total Transaction = " + (Transactionr) + "\n");
                Console.WriteLine("Pilih metode Transaction");
            }
            int index = 0;

            foreach (var mthd in conf.methods)
            {
                index++;
                Console.WriteLine(index + ". " + mthd);
            }

            Console.WriteLine();
            string confirm;
            if (conf.lang == "en")
            {
                Console.WriteLine("Please type '" + conf.confirmation.en + "' to confirm the transaction:");

                confirm = Console.ReadLine();

                if (confirm == (string)conf.confirmation.en)
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }
            else if (conf.lang == "id")
            {
                Console.WriteLine("Ketik '" + conf.confirmation.id + "' untuk mengkonfirmasi transaksi:");

                confirm = Console.ReadLine();

                if (confirm == (string)conf.confirmation.id)
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }

        }
    }
}
