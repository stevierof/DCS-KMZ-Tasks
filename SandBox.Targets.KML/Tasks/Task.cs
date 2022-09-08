using SandBox.KMZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.KMZ.Tasks
{
    public class Task : Marker
    {
        public Task(string name, Coordinates coordinates) : base(name, coordinates)
        {
        }

        public void SetCompleted()
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", new MarkerStyles().CompletedTask.Id), UriKind.Relative);
        }
    }

    public class ActiveTarget : Task
    {
        public ActiveTarget(string name, Coordinates coordinates) : base(name, coordinates)
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", new MarkerStyles().ActiveTarget.Id), UriKind.Relative);
        }
    }

    public class PrimaryTarget : Task
    {
        public PrimaryTarget(string name, Coordinates coordinates) : base(name, coordinates)
        {
            this.Placemark.StyleUrl = new Uri(string.Format("#{0}", new MarkerStyles().PrimaryTarget.Id), UriKind.Relative);
        }
    }

}
