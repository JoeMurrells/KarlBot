using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace karlbot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("fact")]
        public async Task fact()
        {
            Random r = new Random();
            int genRand = r.Next(1, 6);

            string[] karlFacts = {
                "My best-known titles are the 1848 pamphlet The Communist Manifesto and the three-volume Das Kapital (1867–1883).",
                "I was born in Trier, Germany, and studied law and philosophy at the universities of Bonn and Berlin.",
                "My critical theories about society, economics, and politics, collectively understood as Marxism, hold that human societies develop through class conflict.",
                "In the capitalist mode of production, class conflict manifests itself in the conflict between the ruling classes (known as the bourgeoisie) that control the means of production and the working classes (known as the proletariat) that enable these means by selling their labour-power in return for wages.",
                "I believe, class antagonisms under capitalism—owing in part to its instability and crisis-prone nature—would eventuate the working class's development of class consciousness, leading to their conquest of political power and eventually the establishment of a classless, communist society constituted by a free association of producers.",
                "Ready my book Das Kapital here : https://www.marxists.org/archive/marx/works/download/pdf/Capital-Volume-I.pdf"

            };

            await ReplyAsync(karlFacts[genRand]);
        }
        [Command("socialism")]
        public async Task location()
        {
            await ReplyAsync("https://www.socialism101.com/basic");
        }


        [Command("doc")]
        public async Task doc()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=fSQgCy_iIcc");
        }

        [Command("manifesto")]
        public async Task manifesto()
        {
            await ReplyAsync("https://www.marxists.org/admin/books/manifesto/Manifesto.pdf");
        }
    }
}
