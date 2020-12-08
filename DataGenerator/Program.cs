﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Note_pad;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write count of notes: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write output filename ");
            string filename = Console.ReadLine();
            Console.WriteLine("Write format of ouput file ");
            string format = Console.ReadLine();
            GenerateForTables(count, filename, format);
        }

        static void GenerateForTables(int count, string filename, string format)
        {
            List<NoteData> notes = new List<NoteData>();

            for (int i = 0; i < count; i++)
            {
                notes.Add(new NoteData(GenerateRandomString(10)));
            }
            

            if (format == "xml")
            {
                StreamWriter writer = new StreamWriter(filename);
                WriteGroupsToXmlFile(notes, writer);
                writer.Close();
            }
            else
            {
                System.Console.Out.Write("Unrecognized format" + format);
            }
            
        }
        
        static void WriteGroupsToXmlFile(List<NoteData> tables, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<NoteData>)).Serialize(writer, tables);
        }
        static string GenerateRandomString(int length)
        {
            StringBuilder str_build = new StringBuilder();  
            Random random = new Random();  

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
    }
}