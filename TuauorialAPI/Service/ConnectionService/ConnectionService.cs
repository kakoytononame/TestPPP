using TuauorialAPI.Interfaces;

namespace TuauorialAPI.Service.ConnectionService
{
    public static class ConnectionService
    {
        /// <summary>
        /// прописывается создание сервисов
        /// </summary>
        /// <param name="builder"></param>
        public static void ConnectService(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITutorialInterface, TutorialService>();
        }
    }
}
