using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        [Key]
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "Tanggal pengembalian tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }
        [Required(ErrorMessage = "Peminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Kondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda tidak boleh kosong")]
        public int? Denda { get; set; }

        public virtual KondisiKendaraan IdKondisiNavigation { get; set; }
        public virtual Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
