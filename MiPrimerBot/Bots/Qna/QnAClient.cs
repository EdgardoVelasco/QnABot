using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.AI.QnA;

namespace MiPrimerBot.Bots.Qna
{
    public class QnAClient
    {
        private static readonly string KBID = "defcfac0-35eb-482c-b0c2-048e2da3822d";
        private static readonly string HOST = "https://qnaenvf.azurewebsites.net/qnamaker";
        private static readonly string APIKEY = "522c7998-0943-4c27-ba5c-d37294e26c3b";

        public static QnAMaker Qna { get; private set; }

        static QnAClient() { InitQnA(); }

        private static void InitQnA() {
            var credencial = new QnAMakerEndpoint() { 
               EndpointKey=APIKEY, KnowledgeBaseId=KBID,Host=HOST
            };
            Qna = new QnAMaker(credencial);
        }

    }
}
