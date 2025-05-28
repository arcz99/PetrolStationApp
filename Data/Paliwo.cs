using System.ComponentModel.DataAnnotations;

namespace StacjaBenzynowaApp.Data
{
    public class Paliwo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "TESTPodaj nazwę paliwa!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Podaj cenę paliwa!")]
        [Range(0.01, 99.99, ErrorMessage = "Cena musi być większa od zera.")]
        public decimal Cena { get; set; }
    }
}