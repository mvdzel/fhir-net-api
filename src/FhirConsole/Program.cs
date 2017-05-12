using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhirConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -t -> Turtle
                -j -> JSON
                -x -> XML
             */

            if (args.Length == 2)
            {
                var outputType = args[0];
                var input = File.ReadAllText(args[1]);
                Resource resource = null;
                if (SerializationUtil.ProbeIsJson(input))
                {
                    resource = FhirParser.ParseResourceFromJson(input);
                }
                else if (SerializationUtil.ProbeIsXml(input))
                {
                    resource = FhirParser.ParseResourceFromXml(input);
                }
                else if (SerializationUtil.ProbeIsTurtle(input))
                {
                    resource = FhirParser.ParseResourceFromTurtle(input);
                }

                switch(outputType)
                {
                    case "-j":
                        Console.WriteLine(FhirSerializer.SerializeResourceToJson(resource));
                        break;
                    case "-x":
                        Console.WriteLine(FhirSerializer.SerializeResourceToXml(resource));
                        break;
                    case "-t":
                        Console.WriteLine(FhirSerializer.SerializeResourceToTurtle(resource));
                        break;
                }
            }
            else
            {
                var pat = new Patient();
                pat.Name.Add(HumanName.ForFamily("World").WithGiven("Hello"));

                Console.WriteLine("---- json ----");
                Console.WriteLine(FhirSerializer.SerializeResourceToJson(pat));

                Console.WriteLine("---- turtle ----");
                Console.WriteLine(FhirSerializer.SerializeResourceToTurtle(pat));
            }
        }
    }
}
