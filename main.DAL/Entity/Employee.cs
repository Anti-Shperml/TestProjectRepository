using System.ComponentModel.DataAnnotations;

namespace main.DAL.Entity;

public class Employee
{
    [Key]
    public Guid EmployeeId { get; set;  } // primary key
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public string Surname { get; set; }
    public Post Post { get; set; }
    public bool IsFree { get; set; }
    //[System.ComponentModel.DataAnnotations.]
    public double Experience { get; set; }
    
    public ICollection<Task> Tasks { get; set; }
    public ICollection<Project> Projects { get; set; }
}