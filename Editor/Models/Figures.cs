using Editor.Models;
using System.Xml.Serialization;

namespace Editor.Models
{
    [XmlInclude(typeof(LineElement))]
    [XmlInclude(typeof(PolylineElement))]
    [XmlInclude(typeof(PolygonElement))]        
    [XmlInclude(typeof(RectangleElement))]
    [XmlInclude(typeof(EllipseElement))]
    [XmlInclude(typeof(PathElement))]
    public class Figures
    {
        public string Name { get; set; }
    }
}