# 📚 C#-BookService Form
* Bu proje [golang-BookService](https://github.com/grkmkly/golang-bookservice) projesinin API servisini kullanarak JSON dosyası alıp işleme yapmaktadır. Bu işlemi bir C# Windows Form Applicatiın ile sunarak bir ön yüz sağlamaktadır.

## Özellikler
* Bu C# Form uygulaması API'den gelen JSON dosyalarını işleyerek uygun sınıf yapılarına dönüştürerek işlem yapabilmektedir.
* Form uygulamasında ilk olarak girilen kullanıcı adı ve şifreyi API servis sistemiyle göndererek onu Hashlenmiş şifre ile karşılaştırarak doğru olup olmadığını söyleyerek giriş yapmaktadır.
* API servisinin bağlı olduğu veri tabanında kayıtlı olan okuduğunuz kitapları listenize ekleyebilirsiniz.
* Eğer API servisinin bağlı olduğu veri tabanından kayıtlı olmayan bir kitabı veri tabanına eklemek isterseniz onu da ekleyebilirsiniz. Bu ekleme kitabı listenize eklemez. Listenize tekrar eklemeniz gerekmektedir.
* Veri tabanında tutulan kitaplara erişim sağlar.
* Bu Form uygulamasının çalışması için arka tarafta çalışan [golang-BookService](https://github.com/grkmkly/golang-bookservice) API servisini çalıştırarak bu formla birlikte işlemlerinizi yapabilirsiniz.

## Kullanılan Teknolojiler
* C# : HTTP ile iletişim ve JSON dosyası işlemleri
* Windows Forms : Form uygulaması geliştirme

### 1. Gereksinimler
* .NET Framework 4.x veya .NET 5/6+
* Visual Studio 2022 veya daha güncel bir sürüm
* [golang-BookService](https://github.com/grkmkly/golang-bookservice) 

### 2. Kurulum Adımları

#### 1. Proje Deposunu Klonlayın:

   ```bash
   git clone https://github.com/grkmkly/cSharp-BookServiceForm.git
   ```
#### 2. **Proje Dosyasını Açın**:  
* Visual Studio ile `cSharp-BookServiceForm.sln` dosyasını açın.

#### 3. **Projeyi Çalıştırın**:
* F5 tuşuna basarak veya Visual Studio'daki "Başlat" butonuna tıklayarak uygulamayı çalıştırın.

# 📫 İLETİŞİM

Herhangi bir sorunuz varsa veya katkıda bulunmak isterseniz

* E-posta: [kolaygorkem@outlook.com]
