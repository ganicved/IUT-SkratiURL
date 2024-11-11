using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("ADRESE_URL")]
public class UrlAdresa
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(2000)]
    public string DestinacijaUrl { get; set; }
    [MaxLength(255)]
    public string SkraceniUrl { get; set; }
    public DateTime DatumKreiranja { get; set; }
    public bool IsAktivan { get; set; }
    public bool IsObrisan { get; set; }
}