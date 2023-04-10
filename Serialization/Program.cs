using Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

var account = new Account {Id = 1, Name = "Central", Balnce = 50000 };


/*  Serialize
 *      Plain Text
 *          XML
 *                  <Acccount>
                        <Id>2</Id>
                           ...
                    </Acccount>
              SOAP
 *          JSON - 
 *                {
 *                  "Id" : 2,
 *                  "Name", "Central",
 *                  "Balance": 50000
 *                }  
 *                  
 *                  
 *          YAML
 *          TOML - ini
 *          ...
 *      Binary
 *          c#
            ProtoBuf


 */

//XML
var xmlSer = new XmlSerializer(typeof(Account));

//XML Serialize
var xmlWriter = new StreamWriter(AppContext.BaseDirectory + "/account.xml");
xmlSer.Serialize(xmlWriter, account);
xmlWriter.Close();
Console.WriteLine("XML Serialize");


//XML Deserialize
var xmlReader = new StreamReader(AppContext.BaseDirectory + "/account.xml");
var accountDesr = xmlSer.Deserialize(xmlReader) as Account;
Console.WriteLine($"XML Deserialize {accountDesr.Id} - {accountDesr.Balnce}");



//JSOM
// NewtonSoft
// System.Text.JSON 💘
var json = JsonSerializer.Serialize(account);
File.WriteAllText(AppContext.BaseDirectory + "/account.json", json);
Console.WriteLine("JSON Serialize");

var accountDesrJSON = JsonSerializer.Deserialize<Account>(json);
Console.WriteLine($"JSON Deserialize {accountDesrJSON.Id} - {accountDesrJSON.Balnce}");


#pragma warning disable SYSLIB0011
//Binary c#
var binaryFormatter = new BinaryFormatter();
var binWriter = new FileStream(AppContext.BaseDirectory + "/account.bin", FileMode.Create);
binaryFormatter.Serialize(binWriter, account);
binWriter.Close();

Console.ReadLine();