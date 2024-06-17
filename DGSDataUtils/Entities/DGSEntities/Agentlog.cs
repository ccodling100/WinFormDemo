﻿namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentlog
{
    public int IdAgentLog { get; set; }

    public int IdAgent { get; set; }

    public string? Agent { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}