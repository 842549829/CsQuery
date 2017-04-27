using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using CsQuery;
using CsQuery.Promises;
using CsQuery.Web;

namespace ProcessNuspec
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Test1();


            //#if DEBUG 
            //            args = new string[] { "d:\\projects\\csharp\\csquery\\build\\csquery.nuspec", "d:\\projects\\csharp\\csquery\\build\\csquery.test.nuspec", "-version", "1" };
            //#endif
            //            if (args.Length < 4 || args.Length % 2 != 0)
            //            {
            //                Console.WriteLine("Call with: ProcessNuspec input output [-param value] [-param value] ...");
            //                Console.WriteLine("e.g. ProcessNuspec../source/project.nuspec.template ../source/project.nuspec -version 1.3.3 -id csquery");
            //            }


            //            string input = Path.GetFullPath(args[0]);
            //            string output = Path.GetFullPath(args[1]);

            //            int argPos = 2;

            //            var dict = new Dictionary<string, string>();
            //            while (argPos < args.Length)
            //            {
            //                var argName = args[argPos++];
            //                var argValue = args[argPos++];
            //                if (!argName.StartsWith("-")) {
            //                    throw new Exception("Every argument must be a -name/value pair.");
            //                }
            //                dict[argName.Substring(1)]=argValue;
            //            }


            //            XmlDocument xDoc = new XmlDocument();
            //            xDoc.Load(input);

            //            foreach (var item in dict) {

            //                var nodes = xDoc.DocumentElement.SelectNodes("//" + item.Key );
            //                if (nodes.Count == 1)
            //                {
            //                    var node = nodes[0];
            //                    if (dict.ContainsKey(node.Name) && node.ChildNodes.Count==1)
            //                    {
            //                        node.ChildNodes[0].Value = item.Value;
            //                    }
            //                }
            //            }
            //            //string outputText = "<?xml version=\"1.0\"?>";
            //            XmlWriter writer = XmlWriter.Create(output);
            //            xDoc.WriteContentTo(writer);
            //            writer.Flush();
            //            writer.Close();
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Test1()
        {
            var html = File.ReadAllText(@"C:\Users\rongbo.720U\Desktop\text.txt");
            var j = CQ.Create(html);
            var dom = CQ.Create("<div />", new
            {
                css = new
                {
                    width = 500,
                    height = 20
                },
                text = "My new div"
            });
            var inputs = j["div table#serchCondition input"];
            List<string> result = new List<string>();
            inputs.Each(item =>
            {
                var val = item.Value;
                result.Add(val);
            });
            var rel = result;
        }

        public static void Test()
        {
            var r = CQ.CreateFromUrlAsync("http://www.xxia.com/site/flight/departFlights1/0/T0",
                success =>
                {

                },
                fail =>
                {

                });
        }


    }
}
