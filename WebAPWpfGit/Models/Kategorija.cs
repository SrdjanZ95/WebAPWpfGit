using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPWpfGit.Models
{
    public class Kategorija
    {
        [Required]
        public int KategorijaId { get; set; }
        [Required(ErrorMessage = "Naziv kategorije je obavezan!")]
        [StringLength(30, ErrorMessage = "Broj karaktera moze biti izmedjuj 5 i 30!", MinimumLength = 5)]
        public string NazivKategorije { get; set; }
        [Required(ErrorMessage = "Opis kategorije je obavezan!")]
        [StringLength(100, ErrorMessage = "Maksimalan broj karaktera je 100!")]
        public string OpisKategorije { get; set; }
    }
}
