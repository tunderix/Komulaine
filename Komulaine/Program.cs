using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.EventArgs;

namespace Komulaine
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var discordClient = new DiscordClient(new DiscordConfiguration
            {
                Token = "ODY5MTA4NzMwMDUzMTYwOTcw.YP5alA.2wQSDVdwP7YAz6XiUKmIUCW8_uQ",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            discordClient.MessageCreated += OnMessageCreated;

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }
        
        private static async Task OnMessageCreated(DiscordClient client, MessageCreateEventArgs e)
        {
            if(string.Equals(e.Message.Content, "hello", StringComparison.OrdinalIgnoreCase))
            {
                await e.Message.RespondAsync(e.Message.Author.Username);
            }
        }
    }
}