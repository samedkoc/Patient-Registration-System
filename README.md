# Patient Registration System / Hasta Kayıt Sistemi 🏥💻

### [English]
A web-based healthcare management application built with **ASP.NET Core**. This project focuses on data integrity, secure CRUD operations, and advanced backend business logic—such as preventing duplicate patient entries and validating unique TR Identity Numbers (TC Kimlik No). The database setup is fully included within the repository for ready deployment.

### [Türkçe]
**ASP.NET Core** ile geliştirilmiş, web tabanlı bir hasta kayıt ve yönetim uygulamasıdır. Bu proje; veri bütünlüğü, güvenli CRUD işlemleri ve arka planda çalışan gelişmiş iş mantıklarına (aynı kullanıcıların veya aynı TC Kimlik Numarasının mükerrer olarak eklenmesini engelleme, dinamik uyarı sistemleri) odaklanmaktadır. Projenin yerelde hemen çalıştırılabilmesi için veritabanı altyapısı repoya dahil edilmiştir.

---

## 📸 Screenshots & UI Modules / Ekran Görüntüleri ve Modüller

### 1. Main Menu / Ana Menü
The central dashboard providing a clean overview and navigation link to all healthcare management modules.
*(Uygulamanın genel paneline ve tüm yönetim modüllerine erişim sağlayan ana menü ekranı.)*
![Main Menu](https://i.hizliresim.com/ipg5cjh.png)

### 2. Patient List / Hasta Listesi
A responsive data table component displaying all registered records with real-time tracking.
*(Kayıtlı tüm hastaların listelendiği, duyarlı ve dinamik veri tablosu ekranı.)*
![Patient List](https://i.hizliresim.com/ka3r5n6.png)

### 3. Patient Operations / Hasta İşlemleri
The management hub designed to execute advanced filters, views, and system actions on patient records.
*(Hasta kayıtları üzerinde gelişmiş filtreleme, detay görüntüleme ve aksiyonların yönetildiği modül.)*
![Patient Operations](https://i.hizliresim.com/tm7wjsk.png)

### 4. Add New Record / Yeni Kayıt Ekle
The core creation form empowered with backend model validations to prevent identical inputs and duplicate TR Identity Numbers.
*(Aynı kullanıcıların veya mükerrer TC Kimlik numaralarının sisteme girilmesini engelleyen, iş mantığı ve doğrulama kurallarıyla donatılmış yeni kayıt ekranı.)*
![Add New Record](https://i.hizliresim.com/1txugdc.png)

### 5. Edit Patient / Hasta Düzenle
Secure data update interface tailored to modify patient records without violating relational database integrity.
*(İlişkisel veritabanı mimarisini bozmadan, mevcut hasta bilgilerinin güvenli bir şekilde güncellendiği arayüz.)*
![Edit Patient](https://i.hizliresim.com/pfuh8kt.png)

---

## ⚡ Key Features / Öne Çıkan Özellikler

*   **Advanced Validation Logic:** Strictly blocks identical user creations and duplicate TR Identity Numbers (TC No).
*   **Gelişmiş Doğrulama Mantığı:** Aynı kullanıcıların ve mükerrer TC Kimlik numaralarının sisteme kaydedilmesini kesin olarak engeller.
*   **Dynamic Alert Notifications:** Real-time warning mechanisms triggered on illegal or duplicated inputs.
*   **Dinamik Uyarı Sistemleri:** Hatalı veya mükerrer veri girişlerinde kullanıcıyı anlık olarak bilgilendiren uyarı mekanizmaları.
*   **Full CRUD Lifecycle:** Seamless handling of creating, reading, updating, and deleting patient records.
*   **Tam CRUD Döngüsü:** Hasta bilgilerini oluşturma, okuma, güncelleme ve silme süreçlerinin kusursuz yönetimi.

---

## 🛠️ Built With / Teknolojiler

*   **Framework:** ASP.NET Core (MVC Architecture)
*   **Backend Language:** C# (.NET)
*   **Database & ORM:** Microsoft SQL Server & Entity Framework Core

---
*Developed with dedication by Samed Koç 🚀*
