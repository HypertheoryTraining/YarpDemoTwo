namespace Backend.Api.Statistics;

public record CalculateStatisticsRequest
{
    public required List<float> Values { get; init; }
}

public record CalculateStatisticsResponse
{
    public double Mean { get; init; }
    public double Median { get; init; }
    public double StandardDeviation { get; init; }
}