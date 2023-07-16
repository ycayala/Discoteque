namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>
{
    public string Name { get; set; } = "";
    public int Year { get; set; }
    public Genres Genre { get; set; }
}

    public enum Genres{
        Rock,
        Metal,
        Salsa,
        Merengue,
        Urban,
        Folk,
        Indie,
        Techno,
        Vallenato,
        Pop
    }

