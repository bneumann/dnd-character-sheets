namespace DnDCharacterSheets;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

public static class DnDCharacterSheetExtensions
{
    public static IServiceCollection AddDnDCharacterSheets(this IServiceCollection serviceCollection)
    {
        return  serviceCollection
            .AddSingleton<IStringLocalizerFactory, ResourceManagerStringLocalizerFactory>()
            .AddScoped(typeof(IStringLocalizer<>), typeof(StringLocalizer<>));
    }
}