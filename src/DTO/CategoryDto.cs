using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTO;
public class CategoryReadDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

}
public class CategoryCreateDto
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }

}