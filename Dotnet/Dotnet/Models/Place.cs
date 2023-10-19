namespace Dotnet.Models;

public class Place
{
    public int Id { get; set; }
    public string Eic { get; set; }
    public string CustomerName { get; set; }
    public string PlaceName { get; set; }
    public string PayerName { get; set; }
    public string PayerId { get; set; }
    public string CustomerId { get; set; }
    public string PlaceId { get; set; }
    public string DeviceLocation { get; set; }
    public bool Terminated { get; set; }
    public string Region { get; set; }
    public int RegionId { get; set; }
    public string ConnectionMethod { get; set; }
    public string PurchaseCategory { get; set; }
    public double ConvertCoefficient { get; set; }
    public string DeviceType { get; set; }
    public string IdentificationNumber { get; set; }
    public string LastData { get; set; }
    public string? DeviceSerialNumber { get; set; }
    public string? PlaceStreet { get; set; }
    public string? PayerStreet { get; set; }
    public string? PlaceCity { get; set; }
    public string? PayerCity { get; set; }
    public string? PlaceZipCode { get; set; }
    public string? PayerZipCode { get; set; }
    public string? Dealer { get; set; }
    public string? ReadingCategory { get; set; }
    public string? ValidatedBy { get; set; }
    public DateTime ValidatedTill { get; set; }
    public bool IsDataValidated { get; set; }
    public string? ValidationNote { get; set; }
    public string? Gps { get; set; }
    public int Device { get; set; }
    public int ReadRequestStatus { get; set; }
    public string? ReadDescription { get; set; }
    public string? Note { get; set; }
    public string? Group { get; set; }
    public string? Workplace { get; set; }
    public bool HasTimeWindows { get; set; }
    public bool HasBattery { get; set; }
    public bool HasGasComposition { get; set; }
    public double BatteryCapacity { get; set; }
    public double BatteryVoltage { get; set; }
    public bool DailyData { get; set; }
    public string? ScadaId { get; set; }
    public string? ParentDevice { get; set; }
}