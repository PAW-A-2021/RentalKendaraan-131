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

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Nama jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraans { get; set; }
    }
}
