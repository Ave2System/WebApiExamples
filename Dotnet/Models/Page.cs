namespace Dotnet.Models;

public class Page<T> {
    public int Count { get; set; }
    public int TotalCount { get; set; }
    public IEnumerable<T> PageItems { get; set; } = Array.Empty<T>();
}