Proje Adı: CodeCase_Test_Project

Proje Açıklaması:
CodeCase_Test_Project, ConfigLibrary'deki ConfigurationReader sınıfının doğru çalışıp çalışmadığını test etmek amacıyla oluşturulmuş bir test projesidir. Bu proje, veritabanından veri çekme, cache yönetimi ve verilerin doğru şekilde güncellenip saklanıp saklanmadığını kontrol eder.

Kurulum:
Projeyi açın: CodeCase_Test_App.sln.

Gerekli NuGet paketlerini yükleyin.
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer

ConfigServiceCase Solutionu içerisinde bulunan ConfigLibrary.dll'i projenize referans olarak ekleyin.

Program.cs içinde ConfigurationReader sınıfını test edin.

Kullanım:
ConfigurationReader sınıfını kullanarak veritabanından konfigürasyonları çekin ve cache üzerinde testler yapın.
Testler, verilerin doğru şekilde alınıp cache'e atılmasını kontrol eder. 
Bu sırada Api'yı veya DB'yi kullanarak configler üzerinde değişikler yapın ve cahce mekanizmasının veriyi güncellediğini test edin.
