using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace FinalOrm
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public List<Updates> Updates { get; set; }
    }
}