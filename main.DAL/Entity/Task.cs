using main.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace main.DAL.Entity;

public class Task
{
    [Key]
    public Guid TaskId { get; set; }
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public string Name { get; set; }  // Свойство
    [Required]
    [MaxLength(250)]
    public string Comment { get; set; }
    [Range(0,5)]
    public int Priority { get; set; }
    public Status Status { get; set; } 
    
    public Guid ProjectId { get; set;  } 
    public Project Project { get; set; }  // Простое свойство (один проект)
    
    public Guid EmployeeId { get; set;  }
    public Employee Employee { get; set; }
}