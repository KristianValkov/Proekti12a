using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Код
{
    internal class Program
    {
        public const string FILLE_NAME = "example.bin";
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(FILLE_NAME, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            BinaryReader br = new BinaryReader(fs);
            using (fs)
            {
                for (int i = 0; i < 11; i++)
                {
                    bw.Write((int)i);
                }
                for (int i = 0; i<11;i++)
                {
                    fs = new FileStream(FILLE_NAME, FileMode.Open, FileAccess.Read);
                    Console.WriteLine(br.ReadInt32());
                }
                //br.Close();  //fs.Close();
            }
        }
    }
}
