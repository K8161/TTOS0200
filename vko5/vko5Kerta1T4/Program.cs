﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta1T4
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();

            // creating list for tv programs
            List<TvProgram> tvPrograms = new List<TvProgram>();
            tvPrograms.Add(new TvProgram { Name = "Archer", Channel = "Netflix", StartTime = "Whatever you want", EndTime = "About 20 minutes later", Info = "Animated series about special agent" });
            tvPrograms.Add(new TvProgram { Name = "News", Channel = "MTV3", StartTime = "19:00", EndTime = "19:20", Info = "Information about timely happenings from around the world" });
            tvPrograms.Add(new TvProgram { Name = "Avara luonto", Channel = "Netflix", StartTime = "18:45", EndTime = "19:35", Info = "Special episode about predators" });


            Stream writeMultipleStream = null;

            // create file for tv programs
            try
            {
                writeMultipleStream = new FileStream("TvGuide.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                formatter.Serialize(writeMultipleStream, tvPrograms);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (writeMultipleStream != null)
                {
                    writeMultipleStream.Close();
                }

            }

            Stream openStream = null;
            List<TvProgram> readTvPrograms = null;

            // reading from file
            try
            {
                openStream = new FileStream("TvGuide.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                readTvPrograms = (List<TvProgram>)formatter.Deserialize(openStream);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (openStream != null)
                {
                    // close stream
                    openStream.Close();
                }
            }

            // show contents of file
                foreach (TvProgram t in readTvPrograms)
                {
                    Console.WriteLine("Show {0} Channel {1} StartTime {2} EndTime {3} Info {4}", t.Name, t.Channel, t.StartTime, t.EndTime, t.Info);
                }


        }
    }
}

