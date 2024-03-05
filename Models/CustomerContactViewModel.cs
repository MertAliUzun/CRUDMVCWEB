using System.ComponentModel.DataAnnotations;

namespace CRUDMVCWEB.Models
{
    public class CustomerContactViewModel
    {
        public string CusName { get; set; }
        public string CusEmail { get; set; }
        public string CusPhone { get; set; }
        public string CusMessage { get; set; }
        public bool CusAgree { get; set; }
    }
}
