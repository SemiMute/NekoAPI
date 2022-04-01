using System.ComponentModel.DataAnnotations;

namespace NekoQOLWebAPI.Entities;

public class Cape
{
    [Key]
    [Required]
    public string CapeId { get; set; }
}

public class CapeDto
{
    public string CapeId { get; set; }
}