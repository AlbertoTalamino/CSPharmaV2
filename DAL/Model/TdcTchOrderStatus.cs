using System;
using System.Collections.Generic;

namespace DAL.Model;

/// <summary>
/// Entity type fact which stores order information.
/// </summary>
public partial class TdcTchOrderStatus
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
    /// Unique order identifier in the system.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Code that uniquely identifies the shipping status of an order.
    /// </summary>
    public string? CodOrderStatus { get; set; }

    /// <summary>
    /// Code that uniquely identifies the payment status of an order.
    /// </summary>
    public string? CodPaymentStatus { get; set; }

    /// <summary>
    /// Code uniquely identifying the return status of an order.
    /// </summary>
    public string? CodDevolutionStatus { get; set; }

    /// <summary>
    /// Code that uniquely identifies an order. It is constructed with:
    /// province-codpharmacy-id.
    /// </summary>
    public string CodOrder { get; set; } = null!;

    /// <summary>
    /// Code uniquely identifying the road distribution line followed by the consignment:
    /// codprovince-codmunicipality-codistrict.
    /// </summary>
    public string CodLine { get; set; } = null!;

    public virtual TdcCatOrderDevolutionStatus? CodDevolutionStatusNavigation { get; set; }

    public virtual TdcCatDistributionLine CodLineNavigation { get; set; } = null!;

    public virtual TdcCatOrderShipmentStatus? CodOrderStatusNavigation { get; set; }

    public virtual TdcCatOrderPaymentStatus? CodPaymentStatusNavigation { get; set; }
}
