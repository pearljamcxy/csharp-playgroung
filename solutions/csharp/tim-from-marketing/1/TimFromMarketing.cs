static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return $"{(id.HasValue? $"[{id}] - " : "")}{name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
