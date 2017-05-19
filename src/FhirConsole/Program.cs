﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
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
                var command = args[0];
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

                switch(command)
                {
                    case "-oj":
                        Console.Error.WriteLine(">> Output JSON");
                        Console.WriteLine(FhirSerializer.SerializeResourceToJson(resource));
                        break;
                    case "-ox":
                        Console.Error.WriteLine(">> Output XML");
                        Console.WriteLine(FhirSerializer.SerializeResourceToXml(resource));
                        break;
                    case "-ot":
                        Console.Error.WriteLine(">> Output Turtle");
                        Console.WriteLine(FhirSerializer.SerializeResourceToTurtle(resource));
                        break;
                    /**
                     * When <fhir:id> is set use update!!!
                     * For the ZIB LoMo this is the case.
                     */
                    case "-hu":
                        Console.Error.WriteLine(">> Update @HAPI");
                        FhirClient client = new FhirClient("http://fhirtest.uhn.ca/baseDstu2");
                        var response = client.Update(resource);
                        Console.WriteLine(FhirSerializer.SerializeResourceToXml(response));
                        break;
                    case "-hc":
                        Console.Error.WriteLine(">> Create @HAPI");
                        client = new FhirClient("http://fhirtest.uhn.ca/baseDstu2");
                        response = client.Create(resource);
                        Console.WriteLine(FhirSerializer.SerializeResourceToXml(response));
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
