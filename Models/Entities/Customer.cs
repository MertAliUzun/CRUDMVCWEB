using System.ComponentModel.DataAnnotations;

namespace CRUDMVCWEB.Models.Entities
{
    public class Customer
    {
        [Key]
        public int CusId { get; set; }
        public string CusName { get; set; }
        public string CusEmail { get; set; }
        public string CusPhone { get; set; }
        public string CusMessage { get; set; }
        public bool CusAgree { get; set; }  

    }
}
