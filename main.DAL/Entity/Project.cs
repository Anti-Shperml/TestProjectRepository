namespace main.DAL.Entity;

public class Project
{
    public Guid ProjectId { get; set; } 
    public string Name { get; set; }
    public string Diskription { get; set; }
    public DateTime Starttime { get; set; }
    public ProjectStatus Status { get; set; }
    
    public ICollection<Task> Tasks { get; set; }  // Несколько задач, колеекция(список) задач
    public ICollection<Employee> Employees { get; set; }
}