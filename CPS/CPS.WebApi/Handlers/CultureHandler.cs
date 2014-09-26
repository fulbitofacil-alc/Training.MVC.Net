using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CPS.WebApi.Handlers
{
    public class CultureHandler : DelegatingHandler
    {
        private ISet<string> supportedCultures = new HashSet<string>() { "en-us", "en", "es-pe", "es","fr-fr","fr","de-de","de" };
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
        {
            var list = request.Headers.AcceptLanguage;
            if (list != null && list.Count > 0)
            {
                var headerValue =
                    list.OrderByDescending(e => e.Quality ?? 1.0D)
                        .Where(e => !e.Quality.HasValue || e.Quality.Value > 0.0D)
                        .FirstOrDefault(e => supportedCultures.Contains(e.Value, StringComparer.OrdinalIgnoreCase));
                // Caso 1: podemos manejar lo que el cliente esta pidiendo
                if (headerValue != null)
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(headerValue.Value);
                    Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
                }
                
                if (list.Any(e => e.Value == "*" && (!e.Quality.HasValue || e.Quality.Value > 0.0D)))
                {
                    var culture =
                        supportedCultures.FirstOrDefault(sc => !list.Any(
                            e =>
                                e.Value.Equals(sc, StringComparison.OrdinalIgnoreCase) && e.Quality.HasValue &&
                                e.Quality.Value == 0.0D));

                    if (culture != null)
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
                }
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}