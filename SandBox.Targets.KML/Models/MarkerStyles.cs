using SharpKml.Base;
using SharpKml.Dom;

namespace SandBox.KMZ.Models
{
    public class MarkerStyles
    {
        private Style? _targetStyle;
        public Style ActiveTarget
        {
            get
            {
                if (_targetStyle == null)
                {
                    _targetStyle = new Style();
                    _targetStyle.Id = "targetIcon";
                    _targetStyle.Icon = new IconStyle
                    {
                        Icon = new IconStyle.IconLink(new Uri("images/task-destroy.png", UriKind.Relative)),
                        Scale = 1
                    };
                }
                return _targetStyle;
            }
        }

        private Style? _primaryTargetStyle;
        public Style PrimaryTarget
        {
            get
            {
                if (_primaryTargetStyle == null)
                {
                    _primaryTargetStyle = new Style();
                    _primaryTargetStyle.Id = "primaryTargetIcon";
                    _primaryTargetStyle.Icon = new IconStyle
                    {
                        Icon = new IconStyle.IconLink(new Uri("images/task-factory.png", UriKind.Relative)),
                        Scale = 1
                    };
                }
                return _primaryTargetStyle;
            }
        }

        private Style? _strategicTargetStyle;
        public Style StrategicTarget
        {
            get
            {
                if (_strategicTargetStyle == null)
                {
                    _strategicTargetStyle = new Style();
                    _strategicTargetStyle.Id = "strategicTargetIcon";
                    _strategicTargetStyle.Icon = new IconStyle
                    {
                        Icon = new IconStyle.IconLink(new Uri("images/task-strategic.png", UriKind.Relative)),
                        Scale = 1
                    };
                }
                return _strategicTargetStyle;
            }
        }

        private Style? _completedTask;
        public Style CompletedTask
        {
            get
            {
                if (_completedTask == null)
                {
                    _completedTask = new Style();
                    _completedTask.Id = "completedTargetIcon";
                    _completedTask.Icon = new IconStyle
                    {
                        Icon = new IconStyle.IconLink(new Uri("images/task-complete.png", UriKind.Relative)),
                        Scale = 1
                    };
                }
                return _completedTask;
            }
        }

    }
}
