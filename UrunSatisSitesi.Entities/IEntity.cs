

namespace UrunSatisSitesi.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
    }
}

// Katmanlı mimari ssiteminde katman oluşturmak için Solution a sağ tıklayıp Add new project menüsünden Açılan pencereden Filtre kısmından "c#-windows-Library" seçeneklerini seçerek aşağıdaki listeden Class Library proje türünü seçip next diyoruz.
//Gelen ekranda projeye bir isim veriyoruz (UrunSitesi.Entities) gibi. Sonrasında .net 6 sürümünü seçip create diyerek projeyi oluşturuyoruz.
/*
 * Veritabanı ilişki türleri
 * 1 e 1 ilişki:Mesela 1 markanın sadece 1 tane ürünü olabilir
 * 1 e çok ilişki : 1 markanın veya kategorinin 1 den çok ürünü olabilir
 * Çoka çok ilişki : 1 kategorinin 1 den çok ürünü olabilir, 1 ürünün 1 den çok kategorisi olabilir
 */
