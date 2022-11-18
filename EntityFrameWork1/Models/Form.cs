using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork1.Models;

public partial class Form
{
    [Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    [Required]
    public string? Course { get; set; }
    [Required]
    public string? PassingYear { get; set; }
}
