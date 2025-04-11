using System;
using System.Collections.Generic;

namespace taskUser.DBModels;

public partial class AdminInfo
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
