using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommandLineParser.Arguments;
using Flurl.Http;
using Impinj.OctaneSdk;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Reader.Data;

namespace Reader
{
    class Program
    {

        // Create an instance of the ImpinjReader class.
        private static Dictionary<string, MyTagData> TagsToReport = new Dictionary<string, MyTagData>();
        private static readonly HttpClient client = new HttpClient();
        private static RaceSettings _raceSettings;
        private static readonly DataContext _context = new DataContext();
        private static CommandLineParser.CommandLineParser parser = new CommandLineParser.CommandLineParser();
        static SwitchArgument rerunArgument = new SwitchArgument('r', "rerun", "Runs pro program again from text file", true);
        static ValueArgument<string> pathToDataArgument = new ValueArgument<string>('i', "input", "Path to input file");

        static void Main(string[] args)
        {
            ParserInit();

            parser.ParseCommandLine(args);
            parser.ShowUsageHeader = "Here is how you use the app: ";
            parser.ShowUsageFooter = "Have fun!";
            parser.ShowUsage();
            
            if (rerunArgument.Parsed)
            {
                if (!pathToDataArgument.Parsed) { Console.WriteLine("Please provide path to input file."); return; }
                RerunFromFile();
                Console.WriteLine("Success!");
                return;
            }

            var json = File.ReadAllText("E:/Diplomka/Reader/RaceSettings.json");
            _raceSettings = JsonConvert.DeserializeObject<RaceSettings>(json);

            var reader = Reader.InitReader();

            reader.TagsReported += OnTagsReported;
            reader.TagsReported += SaveToLocalCsvFile;
            // Wait for the user to press enter.
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

            // Stop reading.
            reader.Stop();

            // Disconnect from the reader.
            reader.Disconnect();
            Console.ReadLine();
        }

        private static void SaveToLocalCsvFile(ImpinjReader reader, TagReport report)
        {
            try
            {
                using (StreamWriter sw = File.AppendText($"{_raceSettings.Name}.csv"))
                {
                    foreach (var tag in report.Tags)
                    {
                        sw.WriteLine($"{tag.Epc};{tag.LastSeenTime}");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Couldn't fine or create .csv file for backup data.");
            }
        }

        private static void RerunFromFile()
        {
            var json = File.ReadAllText("E:/Diplomka/Reader/RaceSettings.json");
            _raceSettings = JsonConvert.DeserializeObject<RaceSettings>(json);
            try
            {
                using (TextFieldParser csvParser = new TextFieldParser(pathToDataArgument.StringValue))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { ";" });
                    csvParser.HasFieldsEnclosedInQuotes = false;

                    // Skip the row with the column names
                    //csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();

                        ProcessTag(Epc: fields[0], LastSeenTime: Convert.ToUInt64(fields[1]));

                    }
                }
                _context.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Input file not found. Please double check your path.");
            }

        }

        private static void ParserInit()
        {
            parser.Arguments.Add(rerunArgument);
            parser.Arguments.Add(pathToDataArgument);
        }

        private static void OnTagsReported(ImpinjReader reader, TagReport report)
        {
            foreach (Tag tag in report)
            {
                ProcessTag(tag.Epc.ToString(), Convert.ToUInt64(tag.LastSeenTime.ToString()));
            }
            _context.SaveChangesAsync();

        }

        private static void ProcessTag(string Epc, ulong LastSeenTime)
        {
            if (Epc.StartsWith(_raceSettings.EPCPrefix))
            {
                var lastSeenTime = LastSeenTime;
                //local save
                try
                {
                    TagsToReport.Add(Epc, new MyTagData()
                    {
                        LastSeenTime = lastSeenTime,
                        Laps = 1,
                    });
                }
                catch
                {
                    //Tag exists
                }
                var currentTag = TagsToReport[Epc];
                var diff = lastSeenTime - currentTag.LastSeenTime;
                if ((diff == 0
                || diff > (_raceSettings.LapTime.TotalMilliseconds * 1000))
                && currentTag.Laps <= _raceSettings.Laps)
                {
                    //DB save
                    _context.Tags.Add(new Entity.Tag()
                    {
                        Epc = Epc,
                        LastSeenTime = lastSeenTime,
                        Antenna = -1,
                        RaceName = _raceSettings.Name
                    });
                    Console.WriteLine($"Database: {Epc}, Lap {currentTag.Laps}, Time: {lastSeenTime}");
                    currentTag.Laps++;
                    
                }
            }
        }
    }
    public class MyTagData
    {
        public ulong LastSeenTime { get; set; }
        public int Laps { get; set; }
        public string RaceName { get; set; }

    }
}

