using HW_11.Task1.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace HW_11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new("Requiem", 60, "Mozart", 1800, Interactions.GenreInput("1"));
            
            var track = Interactions.GetSongData(song);

            JsonServices test = new();
            test.NewtosoftService(track);
            test.SystemTextService(track);
        }
    }
}
