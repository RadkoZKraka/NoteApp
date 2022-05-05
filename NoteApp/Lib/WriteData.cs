using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace NoteApp.Lib
{
    public class WriteData
    {
        public int Ret;
        public readonly static string InputFile = File.ReadAllText(Const.FilePath);
        public ReadData Data = JsonSerializer.Deserialize<ReadData>(InputFile);
        

        public void WriteNotes()
        {
            var data = new ReadData()
            {
                Note = new Dictionary<string, List<String>>()
                {
                    {
                        "Radko", new List<string>() {"Pierwsza notatka", "Druga notatka"}
                    },

                    {
                        "Tomasz", new List<string>() {"Pierwsza notatka", "Druga notatka"}
                    }
                }
            };
            
            var jsonData = JsonSerializer.Serialize(data);
            var fileName = @"C:\Notatki\notes.json";
            var outp = JsonSerializer.Deserialize<ReadData>(fileName);
            File.WriteAllText(fileName, jsonData);
        }
    }
}