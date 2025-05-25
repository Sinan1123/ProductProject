using Products;

namespace ProductProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "16GB RAM, 512GB SSD, Intel i7", Price = 14999.99, StockQuantity = 15, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-10), UpdatedAt = DateTime.Now },
                new Product { Id = 2, Name = "Kablosuz Mouse", Description = "Ergonomik tasarım, USB alıcı", Price = 299.99, StockQuantity = 120, Category = "Elektronik", IsActive = false, CreatedAt = DateTime.Now.AddDays(-20), UpdatedAt = DateTime.Now },
                new Product { Id = 3, Name = "Bluetooth Kulaklık", Description = "Gürültü engelleyici özellik", Price = 499.50, StockQuantity = 50, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-15), UpdatedAt = DateTime.Now },
                new Product { Id = 4, Name = "Ofis Masası", Description = "Ahşap, 120x60 cm ölçülerinde", Price = 899.00, StockQuantity = 25, Category = "Mobilya", IsActive = true, CreatedAt = DateTime.Now.AddDays(-30), UpdatedAt = DateTime.Now },
                new Product { Id = 5, Name = "Yemek Takımı", Description = "24 parça porselen set", Price = 799.99, StockQuantity = 40, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 6, Name = "Koşu Ayakkabısı", Description = "Hafif taban, erkek modeli", Price = 599.00, StockQuantity = 75, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-12), UpdatedAt = DateTime.Now },
                new Product { Id = 7, Name = "Kahve Makinesi", Description = "Filtre kahve için, 1.5L hazne", Price = 649.90, StockQuantity = 30, Category = "Elektronik", IsActive = false, CreatedAt = DateTime.Now.AddDays(-8), UpdatedAt = DateTime.Now },
                new Product { Id = 8, Name = "Akıllı Saat", Description = "Adım sayar, kalori hesaplayıcı", Price = 899.90, StockQuantity = 60, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-18), UpdatedAt = DateTime.Now },
                new Product { Id = 9, Name = "Kadın Çanta", Description = "Omuz çantası, deri görünümlü", Price = 249.99, StockQuantity = 80, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-14), UpdatedAt = DateTime.Now },
                new Product { Id = 10, Name = "Çocuk Oyuncak Seti", Description = "Eğitici bloklar, 3+ yaş", Price = 199.90, StockQuantity = 90, Category = "Oyuncak", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 11, Name = "Masa Lambası", Description = "LED ışıklı, 3 kademeli parlaklık", Price = 179.99, StockQuantity = 35, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 12, Name = "Sırt Çantası", Description = "Laptop bölmeli, su geçirmez", Price = 349.99, StockQuantity = 45, Category = "Giyim", IsActive = false, CreatedAt = DateTime.Now.AddDays(-9), UpdatedAt = DateTime.Now },
                new Product { Id = 13, Name = "Yoga Matı", Description = "Kaymaz yüzeyli, 6mm kalınlık", Price = 129.90, StockQuantity = 100, Category = "Spor", IsActive = true, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 14, Name = "Tablet", Description = "10 inç ekran, 64GB hafıza", Price = 2199.00, StockQuantity = 20, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-11), UpdatedAt = DateTime.Now },
                new Product { Id = 15, Name = "Elektrikli Süpürge", Description = "Toz torbasız, güçlü çekiş", Price = 1499.90, StockQuantity = 25, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-17), UpdatedAt = DateTime.Now },
                new Product { Id = 16, Name = "Kurutma Makinesi", Description = "Saç kurutma, 3 ısı ayarı", Price = 299.00, StockQuantity = 55, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-13), UpdatedAt = DateTime.Now },
                new Product { Id = 17, Name = "Koltuk Takımı", Description = "3+2+1 oturum, kumaş kaplama", Price = 8999.00, StockQuantity = 10, Category = "Mobilya", IsActive = true, CreatedAt = DateTime.Now.AddDays(-40), UpdatedAt = DateTime.Now },
                new Product { Id = 18, Name = "Bebek Bezi", Description = "5 numara, 60'lı paket", Price = 179.99, StockQuantity = 100, Category = "Bebek", IsActive = false, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 19, Name = "Erkek Tişört", Description = "Pamuklu, düz renk", Price = 99.90, StockQuantity = 150, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 20, Name = "Kedi Maması", Description = "Somonlu, 2kg paket", Price = 89.90, StockQuantity = 70, Category = "Evcil Hayvan", IsActive = true, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now },
                new Product { Id = 21, Name = "Akıllı Bileklik", Description = "Adım sayar, kalp atışı ve uyku takibi", Price = 399.99, StockQuantity = 50, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-8), UpdatedAt = DateTime.Now },
                new Product { Id = 22, Name = "Organik Türk Kahvesi", Description = "250g öğütülmüş taze Türk kahvesi", Price = 59.00, StockQuantity = 120, Category = "Gıda", IsActive = false, CreatedAt = DateTime.Now.AddDays(-10), UpdatedAt = DateTime.Now },
                new Product { Id = 23, Name = "Çelik Termos 1L", Description = "12 saat sıcak-soğuk tutan termos", Price = 139.99, StockQuantity = 80, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-12), UpdatedAt = DateTime.Now },
                new Product { Id = 24, Name = "Kadın Spor Taytı", Description = "Esnek kumaş, yüksek bel", Price = 189.00, StockQuantity = 60, Category = "Giyim", IsActive = false, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 25, Name = "Bulaşık Makinesi Tableti (60'lı)", Description = "Limon aromalı, güçlü temizlik", Price = 89.90, StockQuantity = 100, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 26, Name = "Akıllı Ampul", Description = "Renk değiştiren, uzaktan kumandalı", Price = 119.90, StockQuantity = 75, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now },
                new Product { Id = 27, Name = "Çocuk Masal Kitabı", Description = "Renkli resimli, 3-6 yaş arası", Price = 39.99, StockQuantity = 200, Category = "Kitap", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 28, Name = "Kanvas Tablo - Doğa", Description = "60x90cm yüksek çözünürlüklü tablo", Price = 249.00, StockQuantity = 20, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 29, Name = "USB-C - HDMI Dönüştürücü", Description = "4K destekli, yüksek hızlı", Price = 99.90, StockQuantity = 85, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 30, Name = "Yazlık Sandalet", Description = "Kadınlar için rahat tabanlı", Price = 179.90, StockQuantity = 45, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 31, Name = "Akıllı Telefon Standı", Description = "Ayarlanabilir masaüstü stand", Price = 69.90, StockQuantity = 95, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 32, Name = "Deri Cüzdan", Description = "Erkekler için çok gözlü cüzdan", Price = 149.00, StockQuantity = 30, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-9), UpdatedAt = DateTime.Now },
                new Product { Id = 33, Name = "Mutfak Bıçağı Seti (5'li)", Description = "Paslanmaz çelik keskin bıçaklar", Price = 299.00, StockQuantity = 40, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-10), UpdatedAt = DateTime.Now },
                new Product { Id = 34, Name = "Mini Bluetooth Hoparlör", Description = "Taşınabilir, su geçirmez", Price = 259.90, StockQuantity = 50, Category = "Elektronik", IsActive = false, CreatedAt = DateTime.Now.AddDays(-11), UpdatedAt = DateTime.Now },
                new Product { Id = 35, Name = "Silikon Kek Kalıbı", Description = "Yapışmaz, esnek, fırın dostu", Price = 49.90, StockQuantity = 110, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-12), UpdatedAt = DateTime.Now },
                new Product { Id = 36, Name = "İngilizce Dil Kartları", Description = "1000 kelime içeren eğitim kartları", Price = 89.99, StockQuantity = 90, Category = "Kitap", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 37, Name = "Oyun Mousepad", Description = "Geniş yüzeyli, kaymaz tabanlı", Price = 129.00, StockQuantity = 70, Category = "Elektronik", IsActive = false, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 38, Name = "Yüz Temizleme Cihazı", Description = "Titreşimli, su geçirmez", Price = 199.90, StockQuantity = 55, Category = "Kozmetik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 39, Name = "Şarjlı Saç Kesme Makinesi", Description = "USB ile şarj edilebilir, sessiz motor", Price = 329.00, StockQuantity = 35, Category = "Kozmetik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 40, Name = "Cep Defteri", Description = "Sert kapaklı, çizgili sayfa", Price = 34.90, StockQuantity = 200, Category = "Kitap", IsActive = false, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 41, Name = "Oyun Klavyesi", Description = "RGB aydınlatmalı, mekanik tuşlar", Price = 849.99, StockQuantity = 35, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-9), UpdatedAt = DateTime.Now },
                new Product { Id = 42, Name = "Çay Makinesi", Description = "1.8L kapasiteli, çift katlı", Price = 599.90, StockQuantity = 20, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-12), UpdatedAt = DateTime.Now },
                new Product { Id = 43, Name = "Spor Taytı", Description = "Yüksek bel, esnek kumaş", Price = 179.00, StockQuantity = 50, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now },
                new Product { Id = 44, Name = "Ayakkabı Rafı", Description = "5 katlı, metal gövde", Price = 229.90, StockQuantity = 25, Category = "Ev & Yaşam", IsActive = false, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 45, Name = "Kalem Seti", Description = "12 adet renkli jel kalem", Price = 59.90, StockQuantity = 200, Category = "Kırtasiye", IsActive = true, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 46, Name = "Bebek Arabası", Description = "Katlanabilir, konforlu oturum", Price = 1799.00, StockQuantity = 10, Category = "Bebek", IsActive = true, CreatedAt = DateTime.Now.AddDays(-15), UpdatedAt = DateTime.Now },
                new Product { Id = 47, Name = "Dambıl Seti", Description = "2x5kg ağırlık, kauçuk kaplı", Price = 349.99, StockQuantity = 30, Category = "Spor", IsActive = true, CreatedAt = DateTime.Now.AddDays(-8), UpdatedAt = DateTime.Now },
                new Product { Id = 48, Name = "Saç Şekillendirici", Description = "3'ü 1 arada, düzleştirici + maşa", Price = 429.90, StockQuantity = 40, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 49, Name = "Kadın Cüzdanı", Description = "Fermuarlı, bölmeli tasarım", Price = 149.90, StockQuantity = 60, Category = "Giyim", IsActive = false, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 50, Name = "Oyuncu Kulaklığı", Description = "Mikrofonlu, surround ses", Price = 649.99, StockQuantity = 45, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-10), UpdatedAt = DateTime.Now },
                new Product { Id = 51, Name = "Kamp Çadırı", Description = "4 kişilik, su geçirmez kumaş", Price = 1249.00, StockQuantity = 15, Category = "Outdoor", IsActive = true, CreatedAt = DateTime.Now.AddDays(-11), UpdatedAt = DateTime.Now },
                new Product { Id = 52, Name = "Banyo Seti", Description = "Sabunluk, diş fırçalık ve bardak", Price = 199.00, StockQuantity = 70, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 53, Name = "Şemsiye", Description = "Rüzgar geçirmez, otomatik açılır", Price = 99.90, StockQuantity = 90, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 54, Name = "Kablolu Kulaklık", Description = "3.5mm jack, mikrofonlu", Price = 89.99, StockQuantity = 110, Category = "Elektronik", IsActive = false, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now },
                new Product { Id = 55, Name = "Kitap: Yüzüklerin Efendisi", Description = "3 cilt tek kitap", Price = 349.90, StockQuantity = 100, Category = "Kitap", IsActive = true, CreatedAt = DateTime.Now.AddDays(-20), UpdatedAt = DateTime.Now },
                new Product { Id = 56, Name = "Laptop Soğutucu", Description = "5 fanlı, LED aydınlatmalı", Price = 229.90, StockQuantity = 25, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-13), UpdatedAt = DateTime.Now },
                new Product { Id = 57, Name = "Aydınlatmalı Makyaj Aynası", Description = "Ledli, dokunmatik", Price = 289.00, StockQuantity = 33, Category = "Ev & Yaşam", IsActive = true, CreatedAt = DateTime.Now.AddDays(-9), UpdatedAt = DateTime.Now },
                new Product { Id = 58, Name = "Erkek Deri Kemer", Description = "Hakiki deri, metal toka", Price = 159.90, StockQuantity = 70, Category = "Giyim", IsActive = false, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 59, Name = "Evcil Hayvan Taşıma Çantası", Description = "Havalandırmalı, sırt tipi", Price = 449.00, StockQuantity = 22, Category = "Evcil Hayvan", IsActive = true, CreatedAt = DateTime.Now.AddDays(-16), UpdatedAt = DateTime.Now },
                new Product { Id = 60, Name = "Kamp Lambası", Description = "USB şarjlı, 3 modlu ışık", Price = 119.90, StockQuantity = 48, Category = "Outdoor", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 61, Name = "Güneş Gözlüğü", Description = "UV korumalı, unisex tasarım", Price = 1249.90, StockQuantity = 60, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 62, Name = "Bluetooth Hoparlör", Description = "Taşınabilir, su geçirmez", Price = 399.00, StockQuantity = 45, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 63, Name = "Şapka", Description = "Pamuklu, ayarlanabilir beden", Price = 89.99, StockQuantity = 80, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 64, Name = "Erkek Kol Saati", Description = "Klasik tasarım, deri kayış", Price = 1749.90, StockQuantity = 20, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-10), UpdatedAt = DateTime.Now },
                new Product { Id = 65, Name = "Yoga Matı", Description = "Kaymaz taban, 6mm kalınlık", Price = 219.90, StockQuantity = 35, Category = "Spor", IsActive = true, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 66, Name = "Kadın Sırt Çantası", Description = "Fermuarlı, suya dayanıklı", Price = 1329.00, StockQuantity = 25, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now },
                new Product { Id = 67, Name = "Tablet Kalemi", Description = "Dokunmatik ekranlar için", Price = 99.90, StockQuantity = 90, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 68, Name = "Laptop Çantası", Description = "15.6'' uyumlu, çok gözlü", Price = 289.90, StockQuantity = 40, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 69, Name = "Ev Terliği", Description = "Yumuşak taban, unisex", Price = 129.90, StockQuantity = 50, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 70, Name = "Kolye", Description = "Altın kaplama, zarif tasarım", Price = 189.90, StockQuantity = 30, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-2), UpdatedAt = DateTime.Now },
                new Product { Id = 71, Name = "Mini Projektör", Description = "HD çözünürlük, HDMI destekli", Price = 1149.00, StockQuantity = 15, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-9), UpdatedAt = DateTime.Now },
                new Product { Id = 72, Name = "Çorap Seti (5'li)", Description = "Pamuklu, farklı renkler", Price = 59.90, StockQuantity = 100, Category = "Giyim", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 73, Name = "Kadın Küpe Seti", Description = "4 farklı model, nikel içermeyen", Price = 89.99, StockQuantity = 60, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 74, Name = "Spor Gözlük", Description = "UV400 koruma, kırılmaz cam", Price = 179.00, StockQuantity = 40, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-8), UpdatedAt = DateTime.Now },
                new Product { Id = 75, Name = "Bluetooth Takip Cihazı", Description = "Anahtarlık şeklinde, uygulama destekli", Price = 129.00, StockQuantity = 70, Category = "Elektronik", IsActive = true, CreatedAt = DateTime.Now.AddDays(-7), UpdatedAt = DateTime.Now },
                new Product { Id = 76, Name = "Kadın Bel Çantası", Description = "Fermuarlı, spor tasarım", Price = 199.90, StockQuantity = 45, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-3), UpdatedAt = DateTime.Now },
                new Product { Id = 77, Name = "Seyahat Cüzdanı", Description = "Pasaport ve kartlar için özel bölmeli", Price = 139.00, StockQuantity = 55, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-6), UpdatedAt = DateTime.Now },
                new Product { Id = 78, Name = "Bileklik", Description = "Deri görünümlü, mıknatıslı", Price = 89.90, StockQuantity = 80, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-5), UpdatedAt = DateTime.Now },
                new Product { Id = 79, Name = "Kitap Ayracı", Description = "Ahşap, lazer kesim desenli", Price = 29.90, StockQuantity = 200, Category = "Kırtasiye", IsActive = true, CreatedAt = DateTime.Now.AddDays(-1), UpdatedAt = DateTime.Now },
                new Product { Id = 80, Name = "Kanvas Cüzdan", Description = "Çok gözlü, RFID korumalı", Price = 159.90, StockQuantity = 60, Category = "Aksesuar", IsActive = true, CreatedAt = DateTime.Now.AddDays(-4), UpdatedAt = DateTime.Now }

            };

            bool proccess = true;

            while (proccess)
            {
                Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1 - Fiyatı 100 TL ve üzeri ürünleri listele");
                Console.WriteLine("2 - Aktif ürünlerin adlarını listele");
                Console.WriteLine("3 - En pahalı ürünü göster");
                Console.WriteLine("4 - Aksesuar kategorisinde fiyatı 1000 TL'nin altındaki ürünleri göster");
                Console.WriteLine("5 - Kategori bazında ürünleri ve sayılarını listele");
                Console.WriteLine("6 - Toplam ürün fiyatını göster");
                Console.WriteLine("7 - Toplam aktif ürün sayısını göster");
                Console.WriteLine("8 - 'Laptop' adlı ürünleri göster");
                Console.WriteLine("9 - Fiyatı 500 ile 1000 TL arasında olan ürünleri kategori ve isme göre sırala");
                Console.WriteLine("10 - En pahalı 3 ürünü göster");
                Console.WriteLine("11 - Ürün adında arama yap");
                Console.WriteLine("0 - Çıkış");

                Console.Write("Seçiminiz: ");
                bool isInt = int.TryParse(Console.ReadLine(), out int choose);

                if (!isInt)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    continue;
                }

                switch (choose)
                {
                    case 1:
                        var filteredPrices = products.Where(p => p.Price >= 100).ToList();
                        Console.WriteLine("\nFiyatı 100 TL ve üzeri ürünler:");
                        foreach (var product in filteredPrices)
                            Console.WriteLine(product.Name + " | " + product.Price + "TL");
                        break;

                    case 2:
                        var actives = products.Where(p => p.IsActive).Select(p => p.Name).ToList();
                        Console.WriteLine("\nAktif ürünlerin adları:");
                        foreach (var product in actives)
                            Console.WriteLine(product);
                        break;

                    case 3:
                        var mostExpensive = products.OrderByDescending(p => p.Price).FirstOrDefault();
                        if (mostExpensive != null)
                            Console.WriteLine($"En pahalı ürün | {mostExpensive.Name} | {mostExpensive.Price} TL");
                        else
                            Console.WriteLine("Ürün bulunamadı.");
                        break;

                    case 4:
                        var filteredCategory = products.Where(p => p.Category.ToLower().Contains("aksesuar") && p.Price <= 1000).ToList();
                        Console.WriteLine("\nAksesuar kategorisindeki fiyatı 1000 TL'nin altındaki ürünler:");
                        foreach (var product in filteredCategory)
                            Console.WriteLine($"{product.Name} | {product.Price} TL");
                        break;

                    case 5:
                        var categoryGroup = products.GroupBy(p => p.Category).ToList();
                        Console.WriteLine();
                        foreach (var group in categoryGroup)
                        {
                            Console.WriteLine($"\nKategori: {group.Key} - Ürün Sayısı: {group.Count()}");
                            foreach (var product in group)
                            {
                                Console.WriteLine($"- {product.Name} ({product.Price} TL)");
                            }
                        }
                        break;

                    case 6:
                        var totalprice = products.Sum(p => p.TotalPrice());
                        Console.WriteLine($"\nToplam ürün fiyatı: {totalprice:F2} TL");
                        break;

                    case 7:
                        var activesCount = products.Count(p => p.IsActive);
                        Console.WriteLine($"\nToplam aktif ürün sayısı: {activesCount}");
                        break;

                    case 8:
                        var laptops = products.Where(p => p.Name.Equals("Laptop", StringComparison.OrdinalIgnoreCase)).ToList();
                        if (laptops.Count == 0)
                            Console.WriteLine("Aradığınız ada sahip bir ürün bulunamadı!");
                        else
                        {
                            Console.WriteLine("\nBulunan Laptop ürünleri:");
                            foreach (var item in laptops)
                            {
                                Console.WriteLine($"- {item.Name}, Fiyat: {item.Price} TL, Açıklama: {item.Description}, Stok: {item.StockQuantity}");
                            }
                        }
                        break;

                    case 9:
                        var advancedorder = products
                            .Where(p => p.Price >= 500 && p.Price <= 1000)
                            .OrderBy(p => p.Category)
                            .ThenBy(p => p.Name);
                        Console.WriteLine("\nFiyatı 500 ile 1000 TL arasında olan ürünler:");
                        foreach (var item in advancedorder)
                        {
                            Console.WriteLine($"{item.Category} - {item.Name} - {item.Price} TL");
                        }
                        break;

                    case 10:
                        var threeExpensive = products.OrderByDescending(p => p.Price).Take(3);
                        Console.WriteLine("\nEn pahalı 3 ürün:");
                        foreach (var item in threeExpensive)
                            Console.WriteLine($"{item.Name} | {item.Price} TL");
                        break;

                    case 11:
                        Console.Write("Aramak istediğiniz kelimeyi girin: ");
                        string searchedword = Console.ReadLine();
                        var result = Search(products, searchedword);
                        Console.WriteLine($"\n\"{searchedword}\" kelimesine göre arama sonucu:");
                        if (result.Any())
                        {
                            foreach (var item in result)
                            {
                                Console.WriteLine($"- {item.Name} ({item.Category}) - Fiyat: {item.Price} TL");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arama kriterlerine uygun ürün bulunamadı.");
                        }
                        break;

                    case 0:
                        proccess = false;
                        Console.WriteLine("Programdan çıkılıyor...");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }
        }



        static List<Product> Search(List<Product> products, string word)
        {
            return products
                .Where(p => p.Name.ToLower().Contains(word.ToLower()))
                .ToList();
        }
    }
}
