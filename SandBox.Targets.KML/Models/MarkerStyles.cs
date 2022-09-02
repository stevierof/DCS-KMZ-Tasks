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
                        Color = Color32.Parse("ff1427a5"),
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
                        Color = Color32.Parse("ff00d6ff"),
                        Icon = new IconStyle.IconLink(new Uri("images/task-factory.png", UriKind.Relative)),
                        Scale = 1
                    };
                }
                return _primaryTargetStyle;
            }
        }

    }
}
