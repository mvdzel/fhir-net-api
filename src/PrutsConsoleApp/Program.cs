using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.IO;
using System.Net.Http;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Writing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PrutsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FHIR ModelInfo.Version: {0}", ModelInfo.Version);

            var prg = new Program();
            //prg.resourceFromFhirTurtleTest();
            prg.TurtleShexTest();
            //prg.fhirTestWriteTurtle();
        }

        /**
         * Test the generated turtle against the ShEx using the REST service
         */
        private void TurtleShexTest()
        {
            //const string turtleFileName = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\observation-example-bloodpressure(blood-pressure).ttl";
            //const string turtleFileName = @"C:\Box Sync\HL7\FHIR Turtle\observation-example-bloodpressureGG.ttl";
            const string turtleFileName = @"C:\Box Sync\HL7\FHIR Turtle\observation-example-bloodpressure(blood-pressure).ttl";
            //const string turtleFileName = @"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\allergyintolerance-example(example).ttl";

            IGraph g = new Graph();
            g.NamespaceMap.AddNamespace("fhir", UriFactory.Create("http://hl7.org/fhir/"));
            g.NamespaceMap.AddNamespace("sct", UriFactory.Create("http://snomed.info/id/"));
            g.NamespaceMap.AddNamespace("loinc", UriFactory.Create("http://loinc.org/"));

            TurtleParser turtleParse = new TurtleParser();
            turtleParse.Load(g, turtleFileName);

            IUriNode pred = g.CreateUriNode("rdf:type");

            System.Collections.Generic.Stack<Triple> tl = new System.Collections.Generic.Stack<Triple>(g.GetTriplesWithPredicate(pred));

            // TODO: pass subject as focus!
            Triple mainTriple = tl.Pop();
            string resourceType = mainTriple.Object.ToString();
            string start = resourceType;
            string focus = mainTriple.Subject.ToString();
            string ShexUri = string.Format("https://hl7-fhir.github.io/{0}.shex", resourceType.Substring(resourceType.LastIndexOf('/')+1).ToLower());

            Console.WriteLine("ShexUri: {0}", ShexUri);
            Console.WriteLine("Start/ResourceType: {0}", start);
            Console.WriteLine("Focus: {0}", focus);

            //var web = new System.Net.WebClient();
            //string schema = web.DownloadString(ShexUri);
            string schema = File.ReadAllText(@"C:\Box Sync\HL7\FHIR Turtle\observation.shex");
            string data = File.ReadAllText(turtleFileName);
            string shexValidator = "http://labs.5value.nl:4290/validate";

            var client = new HttpClient();
            var content = new MultipartFormDataContent();
            var schemaContent = new StringContent(schema);
            schemaContent.Headers.Add("Content-Disposition", "form-data; name=\"schema\"; filename=\"schema.shex\"");
            content.Add(schemaContent);
            content.Add(new StringContent(start), "start"); // START is in the ShEx
            var dataContent = new StringContent(data);
            dataContent.Headers.Add("Content-Disposition", "form-data; name=\"data\"; filename=\"data.ttl\"");
            content.Add(dataContent);
            content.Add(new StringContent(focus), "focus");
            content.Add(new StringContent(""), "focusType");
            content.Add(new StringContent("raw"), "output");
            var result = client.PostAsync(shexValidator, content);
            Console.WriteLine(result.Result.ToString());
            var jsonresult = result.Result.Content.ReadAsStringAsync().Result;

            File.WriteAllText(@"c:\temp\shexresult.js", jsonresult);

            var root = JObject.Parse(jsonresult);
            if ("failure".Equals(root.GetValue("type").ToString()))
            {
                RecurseShexErrors(root);
            }
            else
            {
                Console.WriteLine("SUCCES!");
            }
            Console.ReadLine();
        }

        private void RecurseShexErrors(JObject obj)
        {
            /** NB This does not work yet!!!!
             */
            Console.WriteLine("failure on {0}", obj.GetValue("node"));
            int cnt = 0;
            var errors = obj.GetValue("errors");
            foreach (var error in errors.Children())
            {
                Console.WriteLine("#{0} {1}", cnt, error.Type.ToString());
                if (error.Type == JTokenType.Object)
                {
                    var errorobj = (JObject)error;
                    RecurseShexErrors(errorobj);
                }
                cnt++;
            }
        }

        private void inspectorTest()
        {
            ModelInspector insp = new ModelInspector();
            insp.Import(typeof(Resource).Assembly);

            ClassMapping clsMap = insp.FindClassMappingForResource("Patient");

            PropertyMapping prtMap = clsMap.FindMappedElementByName("name");

            Console.WriteLine(prtMap.ElementType);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void resourceFromFhirTurtleTest()
        {
            SerializationConfig.AcceptUnknownMembers = false;
            string turtle = File.ReadAllText(@"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\intermediate1\account.profile.ttl");
            var resource = FhirParser.ParseResourceFromTurtle(turtle);

            var xml = FhirSerializer.SerializeToXml(resource);
            File.WriteAllText(@"c:\temp\output.xml", xml);

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void findRdfTypeInTurtle()
        {
            IGraph g = new Graph();
            g.NamespaceMap.AddNamespace("fhir", UriFactory.Create("http://hl7.org/fhir/"));
            g.NamespaceMap.AddNamespace("sct", UriFactory.Create("http://snomed.info/id/"));
            g.NamespaceMap.AddNamespace("loinc", UriFactory.Create("http://loinc.org/"));

            TurtleParser turtleParse = new TurtleParser();
            turtleParse.Load(g, @"C:\VisualStudio Projects\fhir-net-api\src\Hl7.Fhir.Core.Tests\TestData\observation-example-bloodpressure.ttl");

            IUriNode pred = g.CreateUriNode("rdf:type");

            foreach (Triple t in g.Triples)
            {
                if (pred.Equals(t.Predicate))
                {
                    Console.WriteLine(t.ToString());
                }
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void fhirTestPatient()
        {
            var pat = new Patient();
            pat.Name.Add(HumanName.ForFamily("Kramer").WithGiven("Ewout"));

            Console.WriteLine("---- json ----");
            Console.WriteLine(FhirSerializer.SerializeResourceToJson(pat));

            Console.WriteLine("---- turtle ----");
            Console.WriteLine(FhirSerializer.SerializeToTurtle(pat));
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void fhirTestWriteTurtle()
        {
            Console.WriteLine("---- read XML resource and write as turtle to file ----");
            var resource = FhirParser.ParseFromXml(System.IO.File.ReadAllText(@"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\input\observation-example-bloodpressure(blood-pressure).xml"));
            //var resource = FhirParser.ParseFromXml(System.IO.File.ReadAllText(@"C:\Temp\diagnosticreport-examples-general(72ac8493-52ac-41bd-8d5d-7258c289b5ea).xml"));
            //var resource = FhirParser.ParseFromXml(System.IO.File.ReadAllText(@"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\input\diagnosticorder-example(example).xml"));
            //var resource = FhirParser.ParseFromXml(System.IO.File.ReadAllText(@"C:\Users\zelm\AppData\Local\Temp\FHIRRoundTripTest\FromXml\input\bundle-response(bundle-response).xml"));

            var turtle = FhirSerializer.SerializeToTurtle(resource);
            File.WriteAllText(@"c:\temp\output2.ttl", turtle);

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void readTurtleWriteN3()
        {
            IGraph g = new Graph();

            TurtleParser turtleParse = new TurtleParser();
            turtleParse.Load(g, @"C:\VisualStudio Projects\fhir-net-api\src\Hl7.Fhir.Core.Tests\TestData\observation-example-bloodpressure.ttl");

/*            foreach (Triple t in g.Triples)
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();*/

            NTriplesWriter n3Writer = new NTriplesWriter();
            n3Writer.Save(g, @"c:\temp\output.n3");
        }
    }
}
