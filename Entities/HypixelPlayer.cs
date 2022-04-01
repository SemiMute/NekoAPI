using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace NekoQOLWebAPI.Entities;

public class HypixelPlayer
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string DisplayName { get; set; }

    [Required]
    public ICollection<Cape> Capes { get; set; }
}

public  class HypixelPlayerDisplayNameDto
{
    public string DisplayName { get; set; }
}