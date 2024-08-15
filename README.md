# TechStore TR || ENG

## BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarından miras oluşturdum. (Inheritance)
- Bilgisayar için Usb giriş sayısı 2 veya 4 atanabilir, aksi durumda bir uyarı mesajı verilerek -1 değeri atanıyor.Encapsulation)
- Üretim Tarihi değeri bir nesne oluşturulduğu anda otomatik olarak atansın. Telefon için de Bilgisayar için de geçerli.
- Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi gibi ortak olan bilgileri yazdıran bir BilgileriYazdir() metodu tanımlansın. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.   (Polymorphism)
- UrunAdiGetir() diye abstract bir metot tanımlayarak Telefon ve Bilgisayar için ayrı ayrı ezerek
- "Telefonunuzun adı ---> ......"
- "Bilgisayarınızın adı ---> ......" şeklinde konsol mesajları yazdırılabilsin.  (Abstraction)
  
---

  ## I created a Telefon and Bilgisayar class that inherit from a BaseMakine BaseClass (Inheritance).
- For Bilgisayar, the number of USB ports can be set to either 2 or 4. If any other value is provided, a warning message is given, and the value is set to -1 (Encapsulation).
- The production date should be automatically assigned at the time an object is created. This applies to both Telefon and Bilgisayar.
- In the BaseMakine BaseClass, define a BilgileriYazdir() method that prints common information such as Production Date, Serial Number, Name, Description, and Operating System. In the derived classes (Telefon, Bilgisayar), this method should be overridden to include their own specific properties in addition to the base functionality (Polymorphism).
- Define an abstract method called UrunAdiGetir() and override it in Telefon and Bilgisayar to print messages on the console like:
- "The name of your phone ---> ......"
- "The name of your computer ---> ......" (Abstraction)
