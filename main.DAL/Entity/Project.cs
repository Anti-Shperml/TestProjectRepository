using System.ComponentModel.DataAnnotations;

namespace main.DAL.Entity;

public class Project
{
    [Key]
    public Guid ProjectId { get; set; }
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public string Name { get; set; }
    [MaxLength(250)]
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public ProjectStatus Status { get; set; }
    
    public ICollection<Task> Tasks { get; set; }  // Несколько задач, колеекция(список) задач
    public ICollection<Employee> Employees { get; set; }
}