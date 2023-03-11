using main.DAL.Enums;

namespace main.DAL.Entity;

public class Task
{
    public Guid TaskId { get; set; } 
    public string Name { get; set; }  // Свойство
    public string Comment { get; set; }
    public int Priority { get; set; }
    public Status Status { get; set; } 
    
    public Guid ProjectId { get; set;  } 
    public Project Projects { get; set; }  // Простое свойство (один проект)
    
    public Guid EmployeeId { get; set;  }
    public Employee Employee { get; set; }
}