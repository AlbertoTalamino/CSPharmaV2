using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DlkCatAccEmployee
{
    /// <summary>
    /// Metadata metadata code indicating the group insertion group to which which belongs to record belongs to.
    /// </summary>
    public string MdUuid { get; set; } = null!;

    /// <summary>
    /// Date on which is group is defined insertion.
    /// </summary>
    public DateTime MdDate { get; set; }

    /// <summary>
    /// Unique identifier of the employee in the system.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Code that univocally identifies the employee, consisting of 7 alphanumericals.
    /// </summary>
    public string CodEmployee { get; set; } = null!;

    /// <summary>
    /// Employee&apos;s access code.
    /// </summary>
    public string KeyEmployee { get; set; } = null!;

    /// <summary>
    /// Level of employee access.
    /// </summary>
    public short LevelAccessEmployed { get; set; }
}
