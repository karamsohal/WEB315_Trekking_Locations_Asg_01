1. dotnet new blazorwasm --framework net5.0 -ho -o KaramjitSohalChat
2. dotnet add Client package Microsoft.AspNetCore.SignalR.Client --version 5.0
(we ran cd KaramjitSohalClient and hit enter and then ran the command)
3. we create folder by the name Hubs and cs file by the name ChatHub.cs and paste the below code

using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

we also replace name space BlazorWebAssemblySignalRApp by the app name as KaramjitSohalChat

4. Add in startup.cs "using KaramjitSohalChat.Server.Hubs;"
5. Past the code in public void ConfigureServices(IServiceCollection services)
services.AddSignalR();
services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

6. Add codes in between as per tutorial the one highlighted in green
app.UseResponseCompression();
endpoints.MapHub<ChatHub>("/chathub");
7. In Pages/Index.razor, replace the codes from tutorial