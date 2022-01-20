using System;
using System.Collections.Generic;
using System.IO;

namespace BarcodeManagerParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var exePath = System.Reflection.Assembly.GetEntryAssembly()?.Location;
            var exeName = System.AppDomain.CurrentDomain.FriendlyName;
            var exeLocation = exePath.Replace(exeName, "");
            var barcodeListName = "Log.txt";
            var barcodeListPath = exePath.Replace(exeName, barcodeListName);

            searchedCode = ReadOnFile(barcodeListPath);
        }



        public static void ReadOnFile(string path)
        {
            var searchedCode = new Dictionary<string, HashSet<string>>();

            foreach (var codeType in Enum.GetNames(typeof(BarcodeTypes)))
            {
                searchedCode.Add(codeType, new HashSet<string>());
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string currentLine;
                // currentLine will be null when the StreamReader reaches the end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    var splitedString = currentLine.Split(';');
                    switch (splitedString[0])
                    {
                        case "EAN":
                        case "Ean":
                        case "ean":
                            {
                                searchedCode[BarcodeTypes.EAN.ToString()].Add(splitedString[1]);
                                break;
                            }
                        case "UPC":
                        case "Upc":
                        case "upc":
                            {
                                searchedCode[BarcodeTypes.UPC.ToString()].Add(splitedString[1]);
                                break;
                            }
                        case "ITF":
                        case "Itf":
                        case "itf":
                            {
                                searchedCode[BarcodeTypes.ITF.ToString()].Add(splitedString[1]);
                                break;
                            }
                        case "DataMatrix":
                        case "datamatrix":
                        case "Datamatrix":
                            {
                                searchedCode[BarcodeTypes.DataMatrix.ToString()].Add(splitedString[1]);
                                break;
                            }
                    }
                }
            }
            return searchedCode;
        }
    }
}
