# JobTracker
**A WinForms-based Job Application Tracker

## 🚀 Overview
JobTracker is a work tracking automation system built with C# and WinForms. It allows company staff and administrators to manage user registrations, log daily tasks, view attendance history, and filter reports by person or date. The system supports login functionality based on national ID and password (only available on the desktop version).

## 🛠️ Technologies
- **C#**
- **.NET Framework** (örneğin 4.7.2)
- **Windows Forms (WinForms)**
- **SQLSERVER**

  ## 🎯 Features

- Add, edit, and delete job applications  
- Track application statuses (e.g., “Applied”, “Interviewing”, “Offered”, etc.)  
- Add interview dates, notes, and contact information  
- Search and filter job entries by company name, status, or date  
- User-friendly WinForms interface  
- Database connection for persistent data storage (e.g., SQL Server)


## 📥 Installation

    Clone the repository:
    ```bash
    git clone https://github.com/zulalyildiiz/JobTracker.git
    
    Open the solution file JobTracker.sln with Visual Studio.

    Restore NuGet packages if prompted.

    Build the solution and run the project using:

    F5 (or the Start button in Visual Studio)
    IMPORTANT: Update the connection string in your code according to your database configuration.




   ⚠️ **Notice**
>
> - The user interface and all in-app messages are designed in **Turkish**.
> - Before running the application, make sure to **configure the database connection strings** in the code according to your own environment. Otherwise, the application will not be able to connect to the database.
> - If you are using SQL Server, update fields such as `Data Source`, `Initial Catalog`, and `Integrated Security` to match your setup.
>
> Example connection string format:
> ```csharp
> string connectionString = "Data Source=YOUR_SERVER_NAME; Initial Catalog=YOUR_DATABASE_NAME; Integrated Security=True;";
> ```


[TR]
---

# JobTracker
**WinForms ile geliştirilmiş bir iş başvuru takip uygulaması**

---

## 🚀 Genel Bakış
JobTracker, C# ve WinForms kullanılarak geliştirilmiş bir iş takip otomasyon sistemidir. Sistem, kullanıcıların kaydedilmesini, günlük yapılan işlerin girilmesini, yöneticilerin bu verileri tarihe veya kişiye göre filtreleyerek görüntülemesini sağlar. Giriş işlemleri TC kimlik numarası ve şifre ile yapılır (mobil sürümde bulunmamaktadır).
---

## 🛠️ Kullanılan Teknolojiler
- **C#**
- **.NET Framework** (örneğin 4.7.2)
- **Windows Forms (WinForms)**
- **SQL Server**

---


## 🎯 Özellikler

- **Kullanıcı Modülü:**  
  - Kullanıcılar bir panel üzerinden sisteme kayıt olabilir.  
  - Kayıt alanları: ID, Ad, Soyad, TC Kimlik No, Çalıştığı Alan, Şifre  
  - *(Mobil sürümde şifre işlemleri statik olarak yapılmaktadır.)*

- **Çalışma Modülü:**  
  - Kullanıcılar her gün yaptıkları işleri sisteme girebilir.  
  - Kayıt alanları: ID, Açıklama, KullanıcıID (userID)

- **Yönetici Paneli:**  
  - Yönetici, sisteme girilen günlük verileri görüntüleyebilir.  
  - Verileri tarihe veya kişiye göre filtreleyerek listeleyebilir.

- **Giriş Sistemi:**  
  - Kullanıcılar, TC Kimlik Numarası ve şifre ile giriş yapabilir.  
  - *(Mobil sürümde giriş özelliği bulunmamaktadır.)*

- **Mesai Takibi:**  
  - Yönetici, kullanıcıların hangi günlerde çalıştığını günlük iş kayıtlarına göre görebilir.



---

## 📥 Kurulum

Depoyu klonlayın:
```bash
git clone https://github.com/zulalyildiiz/JobTracker.git
JobTracker.sln çözüm dosyasını Visual Studio ile açın.

Gerekirse NuGet paketlerini geri yükleyin.

Projeyi derleyin ve çalıştırmak için şu adımı izleyin:

F5 tuşuna basın (veya Visual Studio'da Başlat düğmesine tıklayın)

ÖNEMLİ: Uygulamayı çalıştırmadan önce, kodda yer alan connection string kısmını kendi veritabanı yapılandırmanıza uygun şekilde güncelleyin.


⚠️ Uyarı
Uygulamanın arayüzü ve tüm uyarı mesajları Türkçe olarak tasarlanmıştır.

Uygulamayı çalıştırmadan önce, kod içinde bulunan veritabanı bağlantı (connection string) bilgilerini kendi sisteminize göre yapılandırdığınızdan emin olun. Aksi takdirde uygulama veritabanına bağlanamayacaktır.

SQL Server kullanıyorsanız Data Source, Initial Catalog ve Integrated Security gibi alanları kendi ayarlarınıza göre güncelleyin.

---

# Screenshots

**LOGIN SCREEN**
<img width="1907" height="985" alt="Ekran görüntüsü 2025-07-11 091534" src="https://github.com/user-attachments/assets/605c8779-8b53-41b8-ab42-6a92eeadfc90" />

**Registiration Screen**
<img width="1918" height="986" alt="Ekran görüntüsü 2025-07-11 091516" src="https://github.com/user-attachments/assets/dfeac8f6-95b4-409f-b875-e4767ef1d60e" />

**Employee Screen**
<img width="1900" height="1007" alt="Ekran görüntüsü 2025-07-11 091622" src="https://github.com/user-attachments/assets/aad20dc8-c1ae-4745-acda-6a2ba23c0380" />

**Employee Work Log Screen**
<img width="1916" height="1022" alt="Ekran görüntüsü 2025-07-11 091659" src="https://github.com/user-attachments/assets/076536f5-190f-4e1c-b978-fafab34ca60e" />

**Management Screen**
<img width="1897" height="980" alt="Ekran görüntüsü 2025-07-11 091738" src="https://github.com/user-attachments/assets/1ddfd170-b7fb-4e1f-8b56-e817e175cc85" />


**Tables Screen**
<img width="1911" height="972" alt="Ekran görüntüsü 2025-07-11 091838" src="https://github.com/user-attachments/assets/69bf9f7f-768e-428a-a8fc-04d9fc8cae3f" />
