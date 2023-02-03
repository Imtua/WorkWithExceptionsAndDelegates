using Task1;

namespace WorkWithExceptionsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions =
            {
                new Exception("Общее исключение"),
                new MyOwnException("Исключение моего уникального типа"),
                new ArgumentException("Недоступный аргумент"),
                new ArgumentNullException("Пустой аргумент"),
                new FormatException("Неверный формат1")
                };

            foreach (var exception in exceptions)
            {

                try 
                {
                    throw exception;
                }
                catch (MyOwnException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType().ToString());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType().ToString());
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType().ToString());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType().ToString());
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
