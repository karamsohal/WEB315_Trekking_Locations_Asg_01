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

-----------tutorial completed------------------

8. Creating new componenet 
dotnet new razorcomponent -n ChatPage -o Pages
Added @page "/chat"
linked on Nav menu

9. Edited ChatPage.razor, removed code from index and pasted here and in index we provided link to the chat.

10. Pasted this code with changes in server>Hubs>ChatHubs after method
public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
public async Task SendTyping(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }
public async Task SendAnon(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }

11. Added disabled="@(!IsConnected)" in all the inputs in ChatPage
12. Added maxlength="63" to the username input and changed lebal user to username

13. Added method 
hubConnection.On<string>("UserTyping", (user) =>
        {
            var encodedMsg = $"{user} is typing a message...";
            userTyping = encodedMsg;
            StateHasChanged();
        });

        added <p>@userTyping</p>
        after button

14. Add onclick in the chatPage <input @bind="messageInput" disabled="@(!IsConnected)" size="50" @onclick="(e) => SendTyping()"/>

15. New Method for above - 
async Task SendTyping(){
        
        if (userInput != "" && userInput != null){
            await hubConnection.SendAsync("SendTyping", userInput);
        }
    }

16. Anonymous new method added
hubConnection.On<string>("ReceiveAnonMessage", (message) =>
        {
            var encodedMsg = $"Anonymous: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

17. ChatPage Task Send  -

async Task Send() {
        
        if (userInput != "" && userInput != null){
            await hubConnection.SendAsync("SendMessage", userInput, messageInput);
        }
        else{
            await hubConnection.SendAsync("SendAnon", messageInput);
        }
    }