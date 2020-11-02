using System.IO;
using Newtonsoft.Json;
using YOYOTest.Business.Interface;
using YOYOTest.Models;
using System.Collections.Generic;

namespace YOYOTest.Business.Implementation
{
    public class HomeService : IHomeService
    {
        public YOYOTestTrack AssignData(string path)
        {            
            YOYOTestTrack yoyoTestTrack  = new YOYOTestTrack();
            yoyoTestTrack.players = JsonConvert.DeserializeObject<List<Players>>(File.ReadAllText(path+"\\Common\\Players.json"));
            yoyoTestTrack.fitnessratings = JsonConvert.DeserializeObject<List<Fitnessrating>>(File.ReadAllText(path+"\\Common\\Fitnessratings.json"));

            return yoyoTestTrack;
        }
    }
}