﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models;

[Table("medicaments")]
public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Type { get; set; } = string.Empty;

}