using OrderManagement.CsvsToXmlGenerator.CsvToXmlConversion;

List<string> csvPaths = new List<string>
{
    "C:\\Users\\Om Misal\\source\\repos\\Order files\\Order1.txt",
    "C:\\Users\\Om Misal\\source\\repos\\Order files\\Order2.txt",
    "C:\\Users\\Om Misal\\source\\repos\\Order files\\Order3.txt"
};
string xmlPath = "C:\\Users\\Om Misal\\source\\repos\\Order files\\OutputXml.txt";

CsvParser parser = new CsvParser();//Created new instance of the class.
var xmlc = parser.ConvertCsvsToXml(csvPaths);//using that instance access the method of csv to xml conversion.
xmlc.Save(xmlPath);

Console.WriteLine("CSV files converted to a single XML successfully!");