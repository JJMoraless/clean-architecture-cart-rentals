using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Shared;
using CleanArchitecture.Domain.Vehicles;

namespace CleanArchitecture.Domain.Rentals;

public class Rental : Entity
{
    public Guid VegihicleId { get; private set; }
    public RentalStatus Status { get; private set; }
    public Currency? PricePerPeriod { get; private set; }
    public Currency? PriceMaintenance { get; private set; }
    public Currency? PriceAccessories { get; private set; }
    public Currency? TotalPrice { get; private set; }
    public DateRange? Duration { get; private set; }
    public DateTime? DateCreated { get; private set; }
    public DateTime? DateConfirmation { get; private set; }
    public DateTime? DateDenied { get; private set; }
    public DateTime? DateCompleted { get; private set; }
    public DateTime? DateCalled { get; private set; }

    // Constructor privado
    private Rental(
        Guid id,
        Guid vegihicleId,
        RentalStatus status,
        Currency? pricePerPeriod,
        Currency? priceMaintenance,
        Currency? priceAccessories,
        Currency? totalPrice,
        DateRange? duration,
        DateTime? dateCreated,
        DateTime? dateConfirmation,
        DateTime? dateDenied,
        DateTime? dateCompleted,
        DateTime? dateCalled
    )
        : base(id)
    {
        VegihicleId = vegihicleId;
        Status = status;
        PricePerPeriod = pricePerPeriod;
        PriceMaintenance = priceMaintenance;
        PriceAccessories = priceAccessories;
        TotalPrice = totalPrice;
        Duration = duration;

        DateCreated = dateCreated;
        DateConfirmation = dateConfirmation;
        DateDenied = dateDenied;
        DateCompleted = dateCompleted;
        DateCalled = dateCalled;
    }

    public static Rental Reserve(
        Vehicle vehicle,
        Guid userId,
        DateRange duration,
        DateTime dateCreated
    ) { }
}
