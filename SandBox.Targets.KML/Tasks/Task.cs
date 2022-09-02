using SandBox.KML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.KML.Tasks
{
    public class Task : Marker
    {
        public Task(string name, Coordinates coordinates) : base(name, coordinates)
        {
        }

        public void SetCompleted()
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", MarkerStyles.CompletedTask.Id), UriKind.Relative);
        }
    }

    public class ActiveTarget : Task
    {
        public ActiveTarget(string name, Coordinates coordinates) : base(name, coordinates)
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", MarkerStyles.ActiveTarget.Id), UriKind.Relative);
        }
    }

    public class PrimaryTarget : Task
    {
        public PrimaryTarget(string name, Coordinates coordinates) : base(name, coordinates)
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", MarkerStyles.PrimaryTarget.Id), UriKind.Relative);
        }
    }

}
