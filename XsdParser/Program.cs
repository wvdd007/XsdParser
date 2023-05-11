using System.Xml;
using System.Xml.Serialization;
using XsdTool;

namespace XsdParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ser = new XmlSerializer(typeof(Vergeylen.FinancialFixedAssetsCarriedAmountExcessFairValueAmountIndivualAssetsAppropriateGroupingsAssets));
            var stream = new StreamReader("input.xml");
            var input =(Vergeylen.xbrl)ser.Deserialize(stream)!;
        }
    }
}