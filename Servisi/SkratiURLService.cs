using Microsoft.EntityFrameworkCore;

public class SkratiURLService
{
    private readonly IUTContext _context;

    public SkratiURLService(IUTContext context)
    {
        _context = context;
    }

    public async Task<UrlAdresa> DodajUrlAdresu(UrlAdresa urlAdresa)
    {
        urlAdresa.DatumKreiranja = DateTime.Now;
        urlAdresa.IsAktivan = true;
        urlAdresa.IsObrisan = false;
        _context.UrlAdrese.Add(urlAdresa);
        await _context.SaveChangesAsync();
        return urlAdresa;
    }

    public async Task<UrlAdresa> DodajUrlAdresu(string urlAddr)
    {
        UrlAdresa urlAdresa = new UrlAdresa
        {
            DestinacijaUrl = urlAddr,
            SkraceniUrl = Guid.NewGuid().ToString().Substring(0, 8),
            DatumKreiranja = DateTime.Now,
            IsAktivan = true,
            IsObrisan = false
        };

        _context.UrlAdrese.Add(urlAdresa);

        await _context.SaveChangesAsync();
        return urlAdresa;
    }

    public async Task<UrlAdresa> EditUrlAdresa(UrlAdresa urlAdresa)
    {
        _context.UrlAdrese.Update(urlAdresa);
        await _context.SaveChangesAsync();
        return urlAdresa;
    }

    public async Task<List<UrlAdresa>> GetAllUrlAdrese() => await _context.UrlAdrese.ToListAsync();
}