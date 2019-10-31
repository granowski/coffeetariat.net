using System;
using System.IO;

namespace Coffeetariat.UnpopularOpinions.Database
{
    public class Configurator
    {
        public struct Configuration
        {
            private string host;
            private string owner;
            private string password;
            private string dbname;

            public Configuration(string host, string owner, string password, string dbname)
            {
                this.host = host;
                this.owner = owner;
                this.password = password;
                this.dbname = dbname;
            }

            public string Host => host;
            public string Owner => owner;
            public string Password => password;

            public string DbName =>
                Configurator.DatabaseNameGenerate(dbname);

            public bool EnsureValidOrThrow()
            {
                if (string.IsNullOrEmpty(host)) throw new Exception("host is not configured");
                if (string.IsNullOrEmpty(owner)) throw new Exception("username is not configured");
                if (string.IsNullOrEmpty(password)) throw new Exception("password is not configured");
                if (string.IsNullOrEmpty(dbname)) throw new Exception("dbname is not configured");

                return true;
            }
        }

        public static void WriteConfigurationToOut(Stream s, Configuration configuration)
        {
            if (s.CanWrite)
            {
                using (StreamWriter w = new StreamWriter(s))
                {
                    w.Write(Configurator.GenerateConnectionString(configuration) + Environment.NewLine);
                    w.Close();
                }
            }
            else
            {
                throw new Exception("can not write to output");
            }
        }

        public static void WriteConfigurationToFile(string filename, Configuration configuration)
        {
//            string fn = filename;
//            if (string.IsNullOrEmpty(filename))
//            {
//                fn = "db-configuration.txt";
//            }
//
//            fn += '-' + DateTime
//                      .Now.ToString("s")
//                      .Replace(":", "_")
//                      .Replace("T", "_");
            
//            string outputPath = Directory.GetCurrentDirectory();

//            string outpath = Path.Combine(fn, outputPath);
            
            var fs = File.OpenWrite(filename);
            var sw = new StreamWriter(fs);
//            StreamWriter fs = File.OpenWrite(filename);
            
            sw.Write(Configurator.GenerateConnectionString(configuration));
            sw.WriteLine();
            
            sw.Flush();
            sw.Dispose();
            
            fs.Close();
            fs.Dispose();
        }
        
        public static string GenerateConnectionString(Configuration configuration)
        {
            string connectionString =
                $"Host={configuration.Host};" +
                $"Database={configuration.DbName};" +
                $"Username={configuration.Owner};" +
                $"Password={configuration.Password}";
            
            return connectionString;
        }
        
        public static string DatabaseNameGenerate(string dbname)
        {
            string formattedDbName = dbname + '-' +
                                     DateTime
                                         .Now.ToString("s")
                                         .Replace(":", "_")
                                         .Replace("T", "_");
            return formattedDbName;
        }
    }
}