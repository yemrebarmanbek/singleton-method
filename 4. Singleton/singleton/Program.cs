using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customerManager=new CustomerManager(new LoggerFactorr()); //ana fonksiyonda çağırma işlemini yaptığımız zaman bize ne ile çalışacağımızı sorar

        }
    }

//singleton yapısında private bir nesne oluşturarak kullanıcının her defasında bize nesne alması için izin ister
    class CustomerManager
    {   
        private static CustomerManager _customerManager;
        static object _lockObject=new object(); //bu objeyi tanımlama sebebi eğer programda aynı anda 2 tane nesne istenirse bunun oluşumunu engellemek

        private CustomerManager()
        {
          //customer manager nesnesi oluşturmak için bu yapıyı yazarı
          var customerManager=CustomerManager.CreateAssSingleton();
          customerManager.Save();
        }
        public static CustomerManager CreateAssSingleton()
        {
            lock (_lockObject) //lock çoklu programda işlem kesiti sağlar
            {
                if(_customerManager=null)
            {
                _customerManager=new CustomerManager();
            }

            }
           
            return _customerManager();
        }

        public void Save()
        {
            Console.WriteLine("Saved!!");
        }
    }
    // singleton yapısı kısaca bu şekilde 
}
