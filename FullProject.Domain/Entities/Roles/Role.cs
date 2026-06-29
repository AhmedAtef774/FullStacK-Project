using FullProject.Domain.Entities;

namespace FullProject.Domain.Entities.Roles;

public class Role : BaseEntity<Guid> {
    
    public string Name { get; set; } = string.Empty;

    public string NormalizedName { get; set; } = string.Empty;

    public Permission Permission { get; set; }
    
}