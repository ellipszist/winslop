using System.Threading.Tasks;

/// <summary>
/// Defines actions a page can expose to the shell (Analyze/Fix).
/// </summary>
public interface IMainActions
{
    Task AnalyzeAsync();
    Task FixAsync();
}

/// <summary>
/// Exposes a simple search API for views that support filtering.
/// </summary>
public interface ISearchable
{
    /// <summary>
    /// Applies a search query (empty/null should reset the filter).
    /// </summary>
    void ApplySearch(string query);
}

