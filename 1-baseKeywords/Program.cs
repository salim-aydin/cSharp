namespace _1_baseKeywords
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base");
        }
    }
    public class DerivedClass : BaseClass
    {
        private string message = "DERİVEDDDDDDDDDDDDD";

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.message);
            // 'this' anahtar kelimesini kullanarak sınıfın mevcut örneğindeki 'message' üyesine başvurduk
        }

        // Bu bir örnek metod. Parametre ismiyle sınıf üyesi aynı isme sahip.
        public void SetMessage(string message)
        {
            this.message = message; 
            // 'this' kullanımıyla sınıfın mevcut örneğindeki 'message' üyesini güncelliyoruz.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();

            baseObj.Print();
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            derivedObj.Print();
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
            derivedObj.SetMessage("YENİ MESAJ"); // 'SetMessage' metodunu kullanarak 'message' üyesini değiştiriyoruz.
            derivedObj.Print();  // Şimdi "Base" ve "YENİ MESAJ" çıktılarını alacaksınız.
        }
    }
}