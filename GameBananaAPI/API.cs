using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GameBananaAPI.Data;
using Newtonsoft.Json;

namespace GameBananaAPI
{
    public static class API
    {
        public static int gameId = -1;

        public static void SetCurrentGame(int gameId)
        {
            API.gameId = gameId;
        }

        public static async Task<SubfeedData> GetSubfeedData(int page, string sort, string includeSections, string excludeSections)
        {
            if (gameId == -1)
                return default;

            try
            {
                HttpClient client = new HttpClient();

                string baseUrl = APIPaths.BaseGameUrl + gameId;
                if(sort != string.Empty)
                    baseUrl += $"/Subfeed?_sSort={sort}";
                else
                    baseUrl += $"/Subfeed?_sSort=default";
                if (includeSections != string.Empty)
                    baseUrl += $"&_csvModelInclusions={includeSections}";
                if (excludeSections != string.Empty)
                    baseUrl += $"&_csvModelExclusions={excludeSections}";

                var result = await client.GetStringAsync(new Uri(baseUrl));
                SubfeedData data = JsonConvert.DeserializeObject<SubfeedData>(result);

                client.Dispose();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<ProfilePageData> GetModProfilePage(int modId)
        {
            if (gameId == -1)
                return default;

            try
            {
                HttpClient client = new HttpClient();

                string baseUrl = APIPaths.GetModProfileUrl(modId);
                var result = await client.GetStringAsync(new Uri(baseUrl));
                ProfilePageData data = JsonConvert.DeserializeObject<ProfilePageData>(result);

                client.Dispose();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string GetCompleteImageURL(string imageFileName)
        {
            return $"{APIPaths.BaseImageUrl}{imageFileName}";
        }

        public static string GetDownloadURL(int modId)
        {
            return $"{APIPaths.BaseDownloadUrl}{modId}";
        }
    }
}
