using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Hl7.Fhir.Tests;

namespace Hl7.Fhir.Serialization
{
    [TestClass]
    public class TurtleTests
    {
        [TestMethod]
        public void TestOne()
        {
            string inputFile = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\bundle-transaction(bundle-transaction).ttl";
            var turtle = File.ReadAllText(inputFile);
            var resource = FhirParser.ParseResourceFromTurtle(turtle);
        }

        [TestMethod]
        public void RoundTripOneExampleTurtle()
        {
            string inputFile = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\input\bundle-transaction(bundle-transaction).xml";
            string outputFile = @"c:\temp\output.xml";

            var xmlExp = File.ReadAllText(inputFile);
            var resourceXml = FhirParser.ParseResourceFromXml(xmlExp);
            var turtle = FhirSerializer.SerializeResourceToTurtle(resourceXml);

            var resourceTurtle = FhirParser.ParseResourceFromTurtle(turtle);
            var xmlAct = FhirSerializer.SerializeResourceToXml(resourceTurtle);

            File.WriteAllText(outputFile, xmlAct);

            XmlAssert.AreSame("RoundTripOneExampleTurtle", xmlExp, xmlAct);
        }
    }
}
