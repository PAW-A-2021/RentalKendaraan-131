using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tanggal tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        public int? Biaya { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual Jaminan IdJaminanNavigation { get; set; }
        public virtual Kendaraan IdKendaraanNavigation { get; set; }
        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
