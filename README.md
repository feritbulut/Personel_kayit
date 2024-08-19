# Personel Kayıt ve Yönetim Sistemi

Bu proje, SQL Server tabanlı bir personel kayıt ve yönetim sistemidir. Uygulama, personel bilgilerini ekleyebilir, güncelleyebilir, silebilir ve listeleyebilir. Ayrıca, personel verilerini analiz etmek için istatistiksel verilere ve grafiksel raporlara erişim sağlar.

## Özellikler

- **Personel Ekleme:** Yeni personel bilgilerini sisteme kaydedebilirsiniz.
- **Personel Güncelleme:** Kayıtlı personel bilgilerini güncelleyebilirsiniz.
- **Personel Silme:** Seçili personel kaydını sistemden kaldırabilirsiniz.
- **Personel Listeleme:** Tüm personelleri listeleyebilir ve detaylarını görebilirsiniz.
- **İstatistikler:** Personel bilgilerine dayalı çeşitli istatistikleri görüntüleyebilirsiniz.
- **Grafikler:** Personel verilerine dayalı grafiksel raporları inceleyebilirsiniz.

## Kullanılan Teknolojiler

- **C# .NET Framework**
- **Windows Forms**
- **SQL Server**
- **ADO.NET**

## Kurulum

1. **Depoyu Klonlayın:**
    ```bash
    git clone https://github.com/feritbulut/personel-kayit-sistemi.git
    ```

2. **SQL Server Bağlantısını Yapılandırın:**
   - `SqlConnection` nesnesinde bulunan bağlantı dizesini (`ConnectionString`) kendi SQL Server ayarlarınıza göre güncelleyin.

3. **Veritabanını Oluşturun:**
   - `personelVeriTabanı` adında bir veritabanı oluşturun ve gerekli tabloları oluşturun.

4. **Projeyi Çalıştırın:**
   - Visual Studio 2022 ile projeyi açın ve çalıştırın.

## Geliştirici

- [Ferit Bulut](https://www.linkedin.com/in/feritbulut/)

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyin.
