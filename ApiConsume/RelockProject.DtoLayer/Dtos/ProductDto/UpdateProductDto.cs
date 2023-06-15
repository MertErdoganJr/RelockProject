using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelockProject.DtoLayer.Dtos.ProductDto
{
    public class UpdateProductDto
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel Yolu Belirtiniz")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        [StringLength(50, ErrorMessage ="Lütfen en fazla 100 karakter giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen Adres Bilgisi Giriniz")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak Odası Bilgisi Giriniz")]
        public string Bedroom { get; set; }

        [Required(ErrorMessage = "Lütfen Banyo Bilgisi Giriniz")]
        public string Bathroom { get; set; }

        [Required(ErrorMessage = "Lütfen Alan Bilgisi Giriniz")]
        public string Area { get; set; }

        public string Category { get; set; }
    }
}
