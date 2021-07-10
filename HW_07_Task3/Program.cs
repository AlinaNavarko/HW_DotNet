using System;

namespace HW_07_Task3
{
    class Catalog
    {
        static void Main(string[] args)
        {
            var music = ArrayOfMusicFiles();
            var video = ArrayOfVideoFiles();
            var prog = ArrayOfProgramFiles();
        }
        private static ProgramFile[] ArrayOfProgramFiles()
        {
            int arrayLength = 5;
            ProgramFile[] programs = new ProgramFile[arrayLength];
            for (int i = 0; i < programs.Length; i++)
            {
                var program = new ProgramFile();
                program.Category = "Office";
                program.Code = Guid.NewGuid();
                program.Name = "Excel";
                program.Size = 5_325;
                programs[i] = program;
            }

            return programs;
        }

        private static VideoFile[] ArrayOfVideoFiles()
        {
            int arrayLength = 5;
            VideoFile[] videos = new VideoFile[arrayLength];
            for (int i = 0; i < videos.Length; i++)
            {
                var video = new VideoFile();
                video.Category = "Comedy";
                video.Code = Guid.NewGuid();
                video.Name = "The Mask";
                video.Size = 8_725.25;
                video.Director = "Charles Russell";
                video.MainActor = "Jim Carrey";
                video.MainActress = "Cameron Diaz";
                video.Play();
                video.RetrieveInformation();
                videos[i] = video;
            }
            return videos;
        }

        private static MusicFile[] ArrayOfMusicFiles()
        {
            int arrayLength = 5;
            MusicFile[] musics = new MusicFile[arrayLength];
            for (int i = 0; i < musics.Length; i++)
            {
                var music = new MusicFile();
                music.Category = "Pop";
                music.Code = Guid.NewGuid();
                music.Name = "Paparazzi";
                music.Size = 7.92;
                music.Length = 192;
                music.Singer = "Lady Gaga";
                musics[i] = music;
            }
            return musics;
        }
    }
}
