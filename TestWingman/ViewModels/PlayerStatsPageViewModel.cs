using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestWingman.Models;

namespace TestWingman.ViewModels
{
    public partial class PlayerStatsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        PlayerStats player;

        public async Task GetData(string uri)
        {
            // player = new PlayerStats();

            // AllData.Datas = new List<Data>();
            string apiKey = "1b0e4531-fafa-459f-95a1-b892bc373737";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://public-api.tracker.gg/v2/apex/standard/profile/");
            client.DefaultRequestHeaders.Add("TRN-Api-Key", apiKey);

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                Player = (JsonSerializer.Deserialize<PlayerStats>(responseString)); //Obs! Player med stort P

                //await Task.Delay(1000);
                //player.Data.ToList().ForEach(x => AllData.Datas.Add(x));
                //await Task.Delay(5000);
            }
        }




    }
}
