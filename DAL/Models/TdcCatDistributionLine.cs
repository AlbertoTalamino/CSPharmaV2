using System;
using System.Collections.Generic;

namespace DAL.Models;

/// <summary>
/// Catalogue type entity that collects the information of the distribution lines.
/// </summary>
public partial class TdcCatDistributionLine
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
    /// Unique identifier of the distribution line in the system.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Code uniquely identifying the road distribution line followed by the consignment:
    /// codprovince-codmunicipality-codistrict.
    /// </summary>
    public string CodLine { get; set; } = null!;

    /// <summary>
    /// Code that uniquely identifies the province.
    /// </summary>
    public string CodProvince { get; set; } = null!;

    /// <summary>
    /// Code that uniquely identifies the municipality.
    /// </summary>
    public string CodMunicipality { get; set; } = null!;

    /// <summary>
    /// Code that uniquely identifies the neighbourhood.
    /// </summary>
    public string CodNeighbourhood { get; set; } = null!;

    public virtual ICollection<TdcTchOrderStatus> TdcTchOrderStatuses { get; } = new List<TdcTchOrderStatus>();
}
