using System.ComponentModel.DataAnnotations;

namespace Pixoo16Lib.Models
{
    public class GifRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "PicId moet groter dan 0 zijn.")]
        public int PicId { get; set; }

        [Required(ErrorMessage = "PicData is verplicht.")]
        public string PicData { get; set; }
    }
}
