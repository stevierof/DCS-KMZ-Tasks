using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using System.Diagnostics;
using Tasks = SandBox.KMZ.Tasks;

namespace SandBox.KMZ.Models
{
    public class TaskBuilder
    {
        private Document _document;
        
        public TaskBuilder()
        {
            _document = new Document();

            // add global styles here
            _document.AddStyle(MarkerStyles.ActiveTarget);
            _document.AddStyle(MarkerStyles.PrimaryTarget);
            _document.AddStyle(MarkerStyles.CompletedTask);
        }

        public void AddTask(Tasks.Task task)
        {
            _document.AddFeature(task.Placemark);
        }

        public string GetXML()
        {
            var serializer = new Serializer();
            serializer.Serialize(_document);
            return serializer.Xml;

        }

        public void SaveKML(string filename)
        {
            KmlFile kml = KmlFile.Create(_document, false);
            using (FileStream stream = File.Create(string.Format("{0}.kml", filename)))
                kml.Save(stream);
        }

        public void SaveKMZ(string filename)
        {
            KmlFile kml = KmlFile.Create(_document, false);
            KmzFile kmz = KmzFile.Create(kml);

            var links = new LinkResolver(kml);

            foreach (string relativePath in links.Links.Where(x => !x.OriginalString.StartsWith("#")).Select(x => x.OriginalString))
            {
                
                string path = Path.GetDirectoryName(Environment.ProcessPath) ?? "";
                string fullPath = Path.Combine(path, relativePath);
                
                using (var file = File.OpenRead(fullPath))
                {
                    kmz.AddFile(relativePath, file);
                }
            }

            using (Stream output = File.Create(string.Format("{0}.kmz", filename)))
            {
                kmz.Save(output);
                Console.WriteLine("Saved to '{0}'.", filename);
            }

        }
    }
}
