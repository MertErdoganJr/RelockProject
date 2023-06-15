using System.ComponentModel.DataAnnotations;

namespace RelockProject.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }

        [Required(ErrorMessage = "Lütfen Başlık Giriniz")]
        public string Title1 { get; set; }

        [Required(ErrorMessage = "Lütfen 2.Başlığı Giriniz")]
        public string Title2 { get; set; }

        [Required(ErrorMessage = "Lütfen Açıklama Giriniz")]
        [StringLength(100, ErrorMessage = "Açıklama en fazla 100 karakter olabilir.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel Yolu Belirtiniz")]
        public string AboutImage { get; set; }
    }
}
