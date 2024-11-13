using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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
    [DefaultValue(0)]
    public int BrojPreusmjeravanja { get; set; }
    [MaxLength(255)]
    public string? Naziv { get; set; }
    [MaxLength(1000)]
    public string? Opis { get; set; }
}