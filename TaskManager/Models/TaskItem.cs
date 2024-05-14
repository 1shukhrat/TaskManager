namespace TaskManager.Models;

public class TaskItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public DateOnly Deadline { get; set; }
}