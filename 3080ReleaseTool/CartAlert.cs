using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _3080ReleaseTool
{
    public class CartAlert
    {
        string ukUrl = "https://www.nvidia.com/en-gb/geforce/graphics-cards/30-series/rtx-3080/";

        public Boolean checkForCartButton(string region)
        {
            if(region == "UK")
            {
                string responseString = getWebsiteData(ukUrl);

                if(responseString != "ERROR")
                {
                    if(responseString.Contains("Out Of Stock"))
                    {
                        return false;
                    }
                    else if(responseString.Contains("ADD TO CART") || responseString.Contains("Add To Cart") || responseString.Contains("Add to Cart"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Region Invalid");
                return false;
            }
        }

        public string getWebsiteData(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseString = reader.ReadToEnd();
            reader.Close();
            
            if(responseString != "")
            {
                return responseString;
            }
            else
            {
                return "ERROR";
            }
        }
    }

}
