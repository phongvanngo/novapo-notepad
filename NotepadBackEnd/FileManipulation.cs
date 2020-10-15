using System;
using System.IO;

namespace NotepadBackEnd
{
    public class FileManipulation
    {
        private string filename;
        private bool isFileSaved;
        private string fileLocation;

        public string Filename { get => filename; set => filename = value; }
        public bool IsFileSaved { get => isFileSaved; set => isFileSaved = value; }
        public string FileLocation { get => fileLocation; set => fileLocation = value; }

        public void InitializeNewFile()
        {
            this.Filename = "Untitled.txt";
            this.IsFileSaved = true;
            this.FileLocation = "";
        }


        public string OpenFile(string fileLocation)
        {
            string content;
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.Open, FileAccess.ReadWrite);
            using (StreamReader streamReader = new StreamReader(stream))
            {
                content = streamReader.ReadToEnd();
            }
            UpdateFileStatus();
            return content;
        }

        private void UpdateFileStatus()
        {
            // get name of the file open
            string filename = FileLocation.Substring(FileLocation.LastIndexOf("\\") + 1);
            this.Filename = filename;
            this.IsFileSaved = true;
        }
        public void SaveFile(string fileLocation, string[] lines)
        {
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter streamwriter = new StreamWriter(stream))
            {
                foreach (string line in lines)
                {
                    streamwriter.WriteLine(line);
                }
            }
            UpdateFileStatus();
        }


    }
}
