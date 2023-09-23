namespace _3_baseCalledParameterConstructorr
{
    class Base
    {
        public Base(string burayaBasedenStringGelecek)
        {
            Console.WriteLine(burayaBasedenStringGelecek);
        }

    }

    class Derived : Base
    {
        public Derived() : base("Base sınıfının constructor metodu çalıştı")
        // Bu ifade, Derived sınıfının yapıcı metodunun Base sınıfının yapıcı metodunu çağırmasını belirtir. 
        {
            Console.WriteLine("Derived sınıfının constructor metodu çalıştı.");
        }
        
        public Derived(string baseyeGonderilecekString) : base(baseyeGonderilecekString)
        {
            Console.WriteLine("Derived sınıfının constructor metodu çalıştı.");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Derived derivedObject1 = new Derived();
                Console.WriteLine("--------------------------");
                Derived derivedObject2 = new Derived("(BASE) Parametreli constructor çalıştı");

            }
        }
    }
}