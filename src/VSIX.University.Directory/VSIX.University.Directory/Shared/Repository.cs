namespace VSIX.University.Directory.Shared;

public class Repository
{
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public string Url { get; set; } = null!;
	public IList<string> Tags { get; set; } = new List<string>();
}