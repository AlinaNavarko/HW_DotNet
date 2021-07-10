using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task3
{
    class MusicFile: File
    {
        string _singer;
        float _length;
        public string Singer
        {
            get { return _singer; }
            set { Singer = value; }
        }
        public float Length
        {
            get { return _length; }
            set { Length = value; }
        }

        public void Play()
        {
            Console.WriteLine("Not implemented yet.");
        }

        public override string RetrieveInformation()
        {
            string result = base.RetrieveInformation() +
                $"Singer: {Singer}\n" +
                $"Song Length: {Length} seconds\n";
            return result;
        }
    }
}
