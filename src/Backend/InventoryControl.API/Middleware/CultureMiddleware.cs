using System.Globalization;

namespace InventoryControl.API.Middleware;

public class CultureMiddleware
{
    private readonly RequestDelegate _netx;

    public CultureMiddleware(RequestDelegate next)
    {
        _netx = next;
    }

    public async Task Invoke(HttpContext context)
    {
        // pegando todas as linguagens suportadas pelo visual studio
        var suportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();

        // pega o valor enviado na request no header de acceptlanguage
        var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();
        var cultureInfo = new CultureInfo("en");

        // verificando se a cultura informada não é vazia ou inexistente
        if (!string.IsNullOrWhiteSpace(requestedCulture) && suportedLanguages.Exists(c => c.Name.Equals(requestedCulture)))
            cultureInfo = new CultureInfo(requestedCulture);

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        // permite a request continuar o seu fluxo
        await _netx(context);
    }
}
