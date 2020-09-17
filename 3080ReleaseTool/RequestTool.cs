using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3080ReleaseTool.Models;
using Newtonsoft.Json;
using System.Diagnostics;

//Nsomnic

namespace _3080ReleaseTool
{
    public class RequestTool
    {
        string urlUS = "https://in-and-ru-store-api.uk-e1.cloudhub.io/DR/get-inventory/en_us/5438481700?format=json&expand=availablequantity";
        string urlUK = "https://in-and-ru-store-api.uk-e1.cloudhub.io/DR/get-inventory/en_gb/5438792800?format=json&expand=availablequantity";
        public RegionQuantities GetStockLevels()
        {
            int ukQty = getProductQuantity(urlUK);
            int usQty = getProductQuantity(urlUS);

            Debug.WriteLine(ukQty);
            Debug.WriteLine(usQty);

            RegionQuantities quantities = new RegionQuantities(ukQty, usQty);

            return quantities;
        }

        public int getProductQuantity(string url)
        {
            int Quantity;

            if (url != "")
            {
                Debug.WriteLine(url);
                
                WebClient wc = new WebClient();
                string json = wc.DownloadString(url);

                Debug.WriteLine(json);

                var response = JsonConvert.DeserializeObject<Response>(json);

                Quantity = response.product.availableQuantity;

                Debug.WriteLine("QTY = " + Quantity);

                return Quantity;
            }
            else
            {
                return 0;
            }
        }
    }
}
