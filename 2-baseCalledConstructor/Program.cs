namespace _2_baseCalledConstructor
{
    // base kelimesi, türetilmiş (alt) sınıf içindeki bir üye veya yapılandırıcıyı çağırırken kullanılır. 
    // base kelimesi, aynı zamanda üst sınıfın yapılandırıcısını çağırırken kullanılır.
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base sınıfının constructor metodu çalıştı.");
        }

        public void NormalBasePrint(string options)
        {
            Console.WriteLine("Base Class'ı base.NormalBasePrint keyword'u ile çağrıldı : ???" + options);
        }

        
    }

    class Derived : Base
    {
        public Derived() : base() 
        // Bu ifade, Derived sınıfının yapıcı metodunun Base sınıfının yapıcı metodunu çağırmasını belirtir. 
        {
            base.NormalBasePrint("salim");
            Console.WriteLine("Derived sınıfının constructor metodu çalıştı.");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derivedObj = new Derived();
        }
    }
}