builder.Services.AddApplicationInsightsTelemetry("YOUR_INSTRUMENTATION_KEY");

private readonly TelemetryClient _telemetry;

public HomeController(TelemetryClient telemetry)
{
    _telemetry = telemetry;
}

public IActionResult Index()
{
    _telemetry.TrackEvent("HomepageVisited");
    return View();
}
