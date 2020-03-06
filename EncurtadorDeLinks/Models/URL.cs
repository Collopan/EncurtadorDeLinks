using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncurtadorDeLinks.Models
{
    public class URL
    {
        [Key]
        public string _URL { get; set; }
        public int Time_URL { get; set; }
        public string Short_URL { get; set; }
        public string Adicionar(string _URL)
        {
            return _URL + "qwes";
        }
    }
}
