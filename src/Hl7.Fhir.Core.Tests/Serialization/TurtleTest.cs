using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Hl7.Fhir.Serialization
{
    [TestClass]
    public class TurtleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputFile = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\basic-adverseevent-example(basic-adverseevent-example).ttl";
            var turtle = File.ReadAllText(inputFile);
            var resource = FhirParser.ParseResourceFromTurtle(turtle);
        }
    }
}
