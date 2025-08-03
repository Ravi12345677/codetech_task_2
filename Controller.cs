public class DashboardController : Controller
{
    public async Task<IActionResult> Index()
    {
        var metrics = new List<PerformanceMetric>
        {
            new PerformanceMetric { MetricName = "Requests per Minute", Value = 75 },
            new PerformanceMetric { MetricName = "Server Response Time (ms)", Value = 180 },
            new PerformanceMetric { MetricName = "Failed Requests", Value = 3 }
        };

        return View(metrics);
    }
}
