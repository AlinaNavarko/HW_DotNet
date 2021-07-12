using System;

namespace HW_07_Task3
{
    class VideoFile : File
    {
        string _director;
        string _mainActor;
        string _mainActress;

        public string Director
        {
            get { return _director; }
            set { Director = value; }
        }
        public string MainActor
        {
            get { return _mainActor; }
            set { MainActor = value; }
        }
        public string MainActress
        {
            get { return _mainActress; }
            set { MainActress = value; }
        }
        public void Play()
        {
            Console.WriteLine("Not implemented yet.");
        }

        public override string RetrieveInformation()
        {
            string result = base.RetrieveInformation() +
                $"Director: {Director}\n" +
                $"Main Actor: {MainActor}\n" +
                $"Main Actress: {MainActress}\n";
            return result;
        }
    }
}
