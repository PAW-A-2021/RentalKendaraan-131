using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Nama Kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
