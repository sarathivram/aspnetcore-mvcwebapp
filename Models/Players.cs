using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YOYOTest.Models
{
    public class Players
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isWarned { get; set; }
        public bool isStopped { get; set; }
        public Fitnessrating fitnessrating { get; set; }
    }
}