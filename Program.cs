// See https://aka.ms/new-console-template for more information

using patronSingleton;


Console.WriteLine(Singleton.Instance.mensaje);
Singleton.Instance.mensaje = "Hola Marte";
Console.WriteLine(Singleton.Instance.mensaje);

