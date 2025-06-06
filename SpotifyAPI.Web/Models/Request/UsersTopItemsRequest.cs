using System;

namespace SpotifyAPI.Web
{
  public class UsersTopItemsRequest : RequestParams
  {
    public UsersTopItemsRequest(TimeRange timeRange)
    {
      Ensure.ArgumentNotNull(timeRange, nameof(TimeRange));

      TimeRangeParam = timeRange;
    }

    /// <summary>
    /// The TimeRange Param : How far to look back for the top items.
    /// </summary>
    /// <value></value>
    [QueryParam("time_range")]
    public TimeRange TimeRangeParam { get; } = TimeRange.MediumTerm;


    /// <summary>
    /// The maximum number of objects to return. Default: 20. Minimum: 1. Maximum: 50.
    /// </summary>
    /// <value></value>
    [QueryParam("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// The index of the first object to return. Default: 0 (i.e., the first object).
    /// Use with limit to get the next set of objects.
    /// </summary>
    /// <value></value>
    [QueryParam("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// The desired language, consisting of an ISO 639-1 language code and an ISO 3166-1 alpha-2 country code,
    /// joined by an underscore. For example: es_MX, meaning "Spanish (Mexico)".
    /// Provide this parameter if you want the category strings returned in a particular language.
    /// Note that, if locale is not supplied, or if the specified language is not available,
    /// the category strings returned will be in the Spotify default language (American English).
    /// </summary>
    /// <value></value>
    [QueryParam("locale")]
    public string? Locale { get; set; }

  }
  public enum TimeRange
  {
    [String("short_term")]
    ShortTerm,
    [String("medium_term")]
    MediumTerm,
    [String("long_term")]
    LongTerm
  }
}
