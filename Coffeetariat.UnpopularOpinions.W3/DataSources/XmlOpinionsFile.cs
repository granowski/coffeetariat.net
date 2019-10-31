using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Coffeetariat.UnpopularOpinions.W3.Collections;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.DataSources
{
    public class XmlOpinionsFile : IOpinionsDataSource
    {
        public Opinions LoadFromFile(string filename)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            FileStream fs = null;
            
            if (File.Exists(path))
            {
                using (fs = File.OpenRead(path))
                {
                    XmlSerializer[] serializers = XmlSerializer.FromTypes(new[] {typeof(Opinions)});
                    Opinions ops = (Opinions) serializers[0].Deserialize(fs);

                    return ops;
                }
            }

            Opinions defaultOpinions = new Opinions();
            defaultOpinions.Add(new Opinion {Id = 0, Message = "Coffee is life."});
            defaultOpinions.Add(new Opinion { Id = 1, Message = "Koala's are nature's gimp-panda."});
            
            using (fs = File.Create(path))
            {
                XmlWriter xw = XmlWriter.Create(fs);
                XmlSerializer xs = new XmlSerializer(typeof(Opinions));
                
                xs.Serialize(fs, defaultOpinions);
                
                xw.Flush();
                xw.Close();
                xw.Dispose();
                
                fs.Flush();
                fs.Close();
            }
            
            return defaultOpinions;
        }
    }
}