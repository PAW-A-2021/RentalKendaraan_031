using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraans = new HashSet<Kendaraan>();
        }

        [Key]
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraans { get; set; }
    }
}
