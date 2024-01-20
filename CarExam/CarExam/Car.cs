using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExam
{
    internal class Car
    {
        string rendszam;
        string marka;
        string modell;
        int gyartasiEv;
        DateTime forgalmiErvenyesseg;
        int vetelAr;
        int kmAllas;
        int hengerUrtartalom;
        int tomeg;
        int teljesitmeny;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int GyartasiEv { get => gyartasiEv; set => gyartasiEv = value; }
        public DateTime ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int VetelAr { get => vetelAr; set => vetelAr = value; }
        public int KmAllas { get => kmAllas; set => kmAllas = value; }
        public int HengerUrtartalom { get => hengerUrtartalom; set => hengerUrtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public Car(string rendszam, string marka, string modell, int gyartasiEv, DateTime forgalmiErvenyesseg, int vetelAr, int kmAllas, int hengerUrtartalom, int tomeg, int teljesitmeny)
        {
            Rendszam = rendszam;
            Marka = marka;
            Modell = modell;
            GyartasiEv = gyartasiEv;
            ForgalmiErvenyesseg = forgalmiErvenyesseg;
            VetelAr = vetelAr;
            KmAllas = kmAllas;
            HengerUrtartalom = hengerUrtartalom;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
        }

        public override string ToString()
        {
            return $"{this.Marka} {this.rendszam} {this.vetelAr}";
        }
    }
}
