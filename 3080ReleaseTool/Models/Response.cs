using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nsomnic

namespace _3080ReleaseTool.Models
{
    public class Product
    {
        public int availableQuantity { get; set; }
    }

    public class Response
    {
        public Product product { get; set; }
    }
}
