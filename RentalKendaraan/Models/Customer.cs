﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "ID Customer tidak boleh kosong")]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat sesuai dengan KTP")]
        public string Alamat { get; set; }

        [MinLength(10,ErrorMessage ="No HP minimal 10 angka")]
        [MaxLength(13,ErrorMessage ="No HP maksimal 13 angka")]
        public string NoHp { get; set; }

        [Required(ErrorMessage = "ID Gender tidak boleh kosong")]
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
