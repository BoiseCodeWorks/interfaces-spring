namespace console_library.Interfaces
{
  public interface ICheckout
  {
      bool Available { get; set; }
      string ISBN { get; set; }

      bool isAvailable();

  }
}