using FullProject.Domain.Entities;

namespace FullProject.Domain.Entities.Account;

public class User : BaseEntity<Guid> {
    
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public bool IsLocked { get; set; } = false;

    public string PhoneNumber {get;set;}

    public bool EmailConfirmed {get;set;} = false;

    public bool PhoneNumberConfirmed {get;set;} = false;

    public Gender Gender { get; set; }
}