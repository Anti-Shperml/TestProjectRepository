namespace main.DAL.Entity;

public class Employee
{
    public Guid EmployeeId { get; set;  } // primary key
    public string Name { get; set; }
    public string Surname { get; set; }
    public Post Post { get; set; }
    public bool IsFree { get; set; }
    public double Experience { get; set; }
    
    public ICollection<Task> Tasks { get; set; }
    public ICollection<Project> Projects { get; set; }
}