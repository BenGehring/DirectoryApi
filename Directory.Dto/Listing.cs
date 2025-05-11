using Directory.Dto.Base;

namespace Directory.Dto;

public class Listing : DtoBase
{
    public string? BusinessName { get; set; }
    public string? Slug { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? WebsiteUrl { get; set; }
    public string? SocialFacebook { get; set; }
    public string? SocialInstagram { get; set; }
    public string? SocialTwitter { get; set; }
    public string? LogoUrl { get; set; }
    public List<string>? Images { get; set; }  // Use List<string> for multiple image URLs
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public bool IsVerified { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? Status { get; set; } // Could be enum-backed
    public int? OwnerUserId { get; set; }
}