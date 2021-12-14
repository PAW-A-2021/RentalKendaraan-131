using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }

        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
