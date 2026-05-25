using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

namespace MauiAppHotelAgenda14
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>();
                
               
            return builder.Build();
        }
    }
}