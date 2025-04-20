using ConfigLibrary.Extension;





// configurationReader'ı çalıştırmak için kendi connectionString'inizi kullanmanız yeterli. Program sizin connstr'nize göre çalışacaktır.

// Ancak Api'yı çalıştırmak için proje içerisinde appsettings.json'ı düzenlemeniz gerekmektedir.


string connStr = "Data source=.;initial catalog=ConfigDb;Trusted_Connection=True;TrustServerCertificate=True";
string applicationName = "SERVICE-A";
int intervalMs = 1000;

var _configurationReader = new ConfigurationReader(applicationName, connStr, intervalMs);

// Value değeri geldikten sonra Admin arayüzü üzerinden ya da sql üzerinden config'i değiştirebilirsiniz. Value değerinin intervalMS'e göre değiştiğini göreceksiniz.

while (true)
{
    Thread.Sleep(1000);
    Console.WriteLine($"Config Value = {_configurationReader.GetValue("SiteName")} - Type = {_configurationReader.GetValue("SiteName").GetType()}");
}


