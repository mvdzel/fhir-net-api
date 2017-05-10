using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Hl7.Fhir.Serialization
{
    [TestClass]
    public class TurtleTests
    {
        [TestMethod]
        public void TestOne()
        {
            string inputFile = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\diagnosticreport-examples-general(72ac8493-52ac-41bd-8d5d-7258c289b5ea).ttl";
            var turtle = File.ReadAllText(inputFile);
            var resource = FhirParser.ParseResourceFromTurtle(turtle);
        }
    }
}
