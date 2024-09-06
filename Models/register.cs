using System.ComponentModel.DataAnnotations;

namespace projectclass.Models
{
    public class register
    {
        [Key]
        public int r_id { get; set; }
        public string r_name { get; set; }

        public string r_email { get; set; }
        public string r_pass { get; set; }


    }
}
