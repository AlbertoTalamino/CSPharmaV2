using System;
using System.Collections.Generic;

namespace DAL.Model;

/// <summary>
/// Catalogue type entity that collects the status of the shipments.
/// </summary>
public partial class TdcCatOrderShipmentStatus
{
    /// <summary>
    /// Metadata code indicating the insertion group to which the record belongs.
    /// </summary>
    public string MdUuid { get; set; } = null!;

    /// <summary>
    /// Date on which the insertion group is defined.
    /// </summary>
    public DateTime MdDate { get; set; }

    /// <summary>
    /// Unique identifier of the shipping status of the order in the system.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Code that uniquely identifies the shipping status of an order.
    /// </summary>
    public string CodShipmentStatus { get; set; } = null!;

    /// <summary>
    /// Description of the shipping status of the order.
    /// </summary>
    public string? DesShipmentStatus { get; set; }

    public virtual ICollection<TdcTchOrderStatus> TdcTchOrderStatuses { get; } = new List<TdcTchOrderStatus>();
}
