﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace News.Model
{
    public class NewsManager
    {
        // haal de data uit de verschillende newsources
        public async static Task<GetSources> GetSourcesBI()
        {
            HttpClient client = new HttpClient();
            string urlBussinessInsider = ("https://newsapi.org/v2/top-headlines?sources=business-insider&apiKey=c99873ebeaf54194bb8c89dc97c53f0a");

            string resultBI = await client.GetStringAsync(urlBussinessInsider);
            if (resultBI == null)
            {
                return null;
            }
            GetSources alldata = JsonConvert.DeserializeObject<GetSources>(resultBI);
            return alldata;
        }

        public async static Task<List<GetSources>> GetSourcesTime()
        {
            HttpClient client = new HttpClient();
            string urlTime = ("https://newsapi.org/v2/top-headlines?sources=time&apiKey=c99873ebeaf54194bb8c89dc97c53f0a");

            string resultTime = await client.GetStringAsync(urlTime);
            if (resultTime == null)
            {
                return null;
            }
            List<GetSources> alldata = JsonConvert.DeserializeObject<List<GetSources>>(resultTime);
            return alldata;

        }

        public async static Task<List<GetSources>> GetSourcesWired()
        {
            HttpClient client = new HttpClient();
            string urlwired = ("https://newsapi.org/v2/top-headlines?sources=wired&apiKey=c99873ebeaf54194bb8c89dc97c53f0a");

            string resultWired = await client.GetStringAsync(urlwired);
            if (resultWired == null)
            {
                return null;
            }
            List<GetSources> alldata = JsonConvert.DeserializeObject<List<GetSources>>(resultWired);
            return alldata;

        }

        public async static Task<List<GetSources>> GetSourcesNYT()
        {
            HttpClient client = new HttpClient();
            string urlNYT = ("https://newsapi.org/v2/top-headlines?sources=the-new-york-times&apiKey=c99873ebeaf54194bb8c89dc97c53f0a");

            string resultNYT = await client.GetStringAsync(urlNYT);
            if (resultNYT == null)
            {
                return null;
            }
            List<GetSources> alldata = JsonConvert.DeserializeObject<List<GetSources>>(resultNYT);
            return alldata;

        }

        public NewsManager()
        {
        }
    }
}