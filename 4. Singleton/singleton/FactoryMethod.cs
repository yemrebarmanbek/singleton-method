namespace FactoryMethod //factory method dizayn paketinde amaç değişimi kontrol altına tutmaktır
{
    class program {

         static void FactoryMethodsınıf 
        {
           
        }
    }
      public class LoggerFactory:ILoggerFactory
      {
         public Ilogger CreateLogger()
         {
            return new Edlogger();
         }
      }

      public class LoggerFactory2:ILoggerFactory
      {  //başka bir logger factory türü
         public Ilogger CreateLogger()
         {
            return new Edlogger();
         }
      }
       
       
      public interface ILoggerFactory
      {
         Ilogger CreateLogger(); //başka bir factory implement yapması için kullanılır
      }
      public interface Ilogger
      {
          void log();
      }

      public class Edlogger : Ilogger
      {
         public void log()
         {
             console.WriteLine("logger with edlogger");
         }
      }

      public class CustomerManager
      {
          private ILoggerFactory _loggerFactory;
          public CustomerManager(ILoggerFactory loggerFactory)
          {
              _loggerFactory=loggerFactory;
          }
          public void Save()
          {
              console.WriteLine("saved!");
              Ilogger logger =new LoggerFactory().CreateLogger();
              logger.log();
          }
      }



}