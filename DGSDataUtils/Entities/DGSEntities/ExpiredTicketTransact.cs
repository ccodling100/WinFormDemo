namespace DGSDataUtils.Entities.DGSEntities;

public partial class ExpiredTicketTransact
{
    public int TransactId { get; set; }

    public int TicketNumber { get; set; }

    public DateTime OpDate { get; set; }

    public DateTime TransactDateTime { get; set; }

    public decimal Amount { get; set; }

    public int ManagerId { get; set; }
}
