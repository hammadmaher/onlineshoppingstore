using System.ComponentModel.DataAnnotations;

namespace Hammad.Models
{
    public class formdata
    {

        public string fname { get; set; }

        public string lname { get; set; }
        public string classificaton { get; set; }

        [Key]

        public string email { get; set; }

        public string phone { get; set; }

        public string course { get; set; }

        public string language { get; set; }
    }
}
