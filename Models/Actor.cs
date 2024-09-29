namespace SoLoMo.Models;

public class Actor
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public List<Movie> Movies { get; set; } = new();
    public List<MovieActor> MovieActors { get; set; } = new();
}