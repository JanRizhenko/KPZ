using System.Collections.Generic;
using System.Text;

public class Character
{
    public string Role { get; }
    public string Name { get; set; }
    public string Height { get; set; }
    public string BodyType { get; set; }
    public string EyeColor { get; set; }
    public List<string> Clothes { get; set; } = new List<string>();
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Abilities { get; set; } = new List<string>();
    public List<string> GoodDeeds { get; set; } = new List<string>();
    public List<string> EvilDeeds { get; set; } = new List<string>();

    public Character(string role)
    {
        Role = role;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Role}: {Name}");
        sb.AppendLine($"{Height}cm");
        sb.AppendLine($"Body Type: {BodyType}");
        sb.AppendLine($"Abilities: {string.Join(", ", Abilities)}");
        sb.AppendLine($"Clothes: {string.Join(", ", Clothes)}");
        sb.AppendLine($"Inventory: {string.Join(", ", Inventory)}");

        if (Role == "Hero" || GoodDeeds.Count > 0)
            sb.AppendLine($"Good deeds: {string.Join(", ", GoodDeeds)}");

        if (Role == "Enemy" || EvilDeeds.Count > 0)
            sb.AppendLine($"Evil deeds: {string.Join(", ", EvilDeeds)}");

        return sb.ToString();
    }
}