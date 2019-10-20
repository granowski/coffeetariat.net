using System.Xml.Serialization;

namespace Coffeetariat.UnpopularOpinions.W3.Models
{
  public class Opinion
  {
    [XmlAttribute("id")]
    public int Id { get; set; }
    [XmlText]
    public string Message { get; set; }
  }
}