using System;

namespace HW_07_Task3
{
    class File
    {
        string _name;
        Guid _code;
        string _category;
        double _size;

        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }
        public Guid Code
        {
            get { return _code; }
            set { Code = value; }
        }
        public string Category
        {
            get { return _category; }
            set { Category = value; }
        }

        public double Size
        {
            get { return _size; }
            set { Size = value; }
        }

        public virtual string RetrieveInformation()
        {
            Console.WriteLine("Connecting...");
            string result = $"File type: {this.GetType()}\n" +
                $"File name: {this._name}\n" +
                $"File ID: {this._code}\n" +
                $"Category: {this._category}\n" +
                $"File size: {this._size} bytes\n";
            return result;
        }
    }
}
