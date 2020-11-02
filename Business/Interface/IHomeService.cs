using System;
using YOYOTest.Models;
using System.Collections.Generic;
using System.Linq;

namespace YOYOTest.Business.Interface
{
    public interface IHomeService
    {
        public YOYOTestTrack AssignData(string path);
    }
}