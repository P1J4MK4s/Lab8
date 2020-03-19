using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Train
    {
        public string Nomer_poezda;
        public string Soobshenit;
        public int Kolvo_vagonov;
        public enum typeTrain { skTrain, pasTrain, tTrain}
        public typeTrain tType;

        public Train(string newNomer_poezda, string newSoobshenie, int newKolvo_vagonov, int type)
        {
            Nomer_poezda = newNomer_poezda;
            Soobshenit = newSoobshenie;
            Kolvo_vagonov = newKolvo_vagonov;
            if (type == 0) tType = typeTrain.skTrain;
            else if (type == 1) tType = typeTrain.pasTrain;
            else if (type == 2) tType = typeTrain.tTrain;
            else tType = 0;
        }
        public override string ToString()
        {
            string probel = " ";
            string result = Nomer_poezda + probel + Soobshenit + probel + Kolvo_vagonov.ToString() + probel + tType.ToString();
            return result;
        }
    }

    internal class FirmTrain : Train
    {
        public string nameFirm;
        public double kPrice;
        public FirmTrain(string newNomer_poezda, string newSoobshenie, int newKolvo_vagonov, int type, string newnameFirm,double newkPrice) : base(newNomer_poezda, newSoobshenie, newKolvo_vagonov, type)
        {
            nameFirm = newnameFirm;
            kPrice = newkPrice;
        }
        public override string ToString()
        {
            string probel = " ";
            string result = Nomer_poezda + probel + Soobshenit + probel + Kolvo_vagonov.ToString() + probel + tType.ToString() + probel + nameFirm + probel + kPrice.ToString();
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FirmTrain train = new FirmTrain("ANBC232", "Tuuuu-Tuuu", 13, 1,"TokioCity",1.32);
            Console.WriteLine(train);

        }
    }
}
