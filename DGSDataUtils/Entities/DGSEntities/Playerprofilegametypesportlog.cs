﻿namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilegametypesportlog
{
    public short IdProfile { get; set; }

    public int IdGameType { get; set; }

    public string IdSport { get; set; } = null!;

    public byte WagerType { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
