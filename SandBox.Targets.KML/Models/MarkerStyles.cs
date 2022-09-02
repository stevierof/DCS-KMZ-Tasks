using SharpKml.Base;
using SharpKml.Dom;

namespace SandBox.KML.Models
{
    public static class MarkerStyles
    {
        private static Style? _targetStyle;
        public static Style ActiveTarget
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

        private static Style? _primaryTargetStyle;
        public static Style PrimaryTarget
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

        private static Style? _completedTask;
        public static Style CompletedTask
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
