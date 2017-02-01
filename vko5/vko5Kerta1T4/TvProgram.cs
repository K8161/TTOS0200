using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta1T4
{
    [Serializable]
    class TvProgram
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Info { get; set; }

        /*     IFormatter formatter = new BinaryFormatter();

            public void CreateTvPrograms()
             {   List<TvProgram>  tvPrograms = new List<TvProgram>();
                 tvPrograms.Add(new TvProgram { Name = "Archer", Channel = "Netflix", StartTime = "Whatever you want", EndTime = "About 20 minutes later", Info = "Animated series about special agent" });
                 tvPrograms.Add(new TvProgram { Name = "News", Channel = "MTV3", StartTime = "19:00", EndTime = "19:20", Info = "Information about timely happenings from around the world" });
                 tvPrograms.Add(new TvProgram { Name = "Avara luonto", Channel = "Netflix", StartTime = "18:45", EndTime = "19:35", Info = "Special episode about predators" });
                 SaveTvPrograms();
             }

             public void SaveTvPrograms()
             {
                 IFormatter formatter = new BinaryFormatter();

                 try
                 {
                     Stream writeMultipleStream = new FileStream("TvGuide.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                     formatter.Serialize(writeMultipleStream, tvPrograms);
                 }
                 catch (Exception ex)
                 {
                     //Console.WriteLine("Some exception happened!");
                     Console.WriteLine(ex.Message); // Access denied.
                 }
                 finally
                 {
                     // check for null because OpenWrite might have failed
                     writeMultipleStream.Close();
                 }
             }

             public void ReadTvGuide()
             {
                 // @"D:\K8161\TTOS0200\vko5\vko5Kerta1T1\SavedText.txt"
                 try
                 {
                     Stream openStream = new FileStream("TvGuide.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                     List<TvProgram> readTvPrograms = (List<TvProgram>) formatter.Deserialize(openStream);
                 }
                 catch (FileNotFoundException)
                 {
                     Console.WriteLine("File not found (FileNotFoundException)");
                 }
             } */
    }
}
