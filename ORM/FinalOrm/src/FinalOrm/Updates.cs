using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalOrm
{
    public class Updates
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description {get; set; }
        public string Url { get; set; }
        
        public int ProdId { get; set; }        
        public Product Product { get; set; }
    }
}