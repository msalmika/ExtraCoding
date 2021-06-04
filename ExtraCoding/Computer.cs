using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCoding
{
    class Computer
    {

        public Computer(string manufName, int screenSize, string oS, int mhz = 100, int memory = 2, int hdsize = 240, int usbports = 2, string comptype = "Unknown", int purchaseprice = 0, int saleprice = 0)
        {
            ManufName = manufName;
            ScreenSize = screenSize;
            OS = oS;
            MHz = mhz;
            Memory = memory;
            HDSize = hdsize;
            USBports = usbports;
            Type = comptype;
            PurchasePrice = purchaseprice;
            SalePrice = saleprice;
            
        }

        public string ManufName {get; set;}

        public int MHz { get; set; }

        public int Memory { get; set; }

        public int HDSize { get; set; }

        public int USBports { get; set; }

        public int ScreenSize { get; set; }

        public string Type { get; set; }

        public string OS { get; set; }

        public int PurchasePrice { get; set; }

        public int SalePrice { get; set; }

        public string Profit()
        {
            return $"Total profit: {SalePrice - PurchasePrice} USD";

        }

        public override string ToString()
        {
            return $"Manufacturer: {ManufName}\n" +
                $"MHz: {MHz}\n" +
                $"Memory: {Memory}gb\n" +
                $"Hard drive size: {HDSize}gb\n" +
                $"USB ports: {USBports}\n" +
                $"Screen size: {ScreenSize} inches\n" +
                $"Desktop or laptop: {Type}\n" +
                $"Preinstalled OS: {OS}\n" +
                $"Price: {SalePrice}\n";

        }

        
    }
}
