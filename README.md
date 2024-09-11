# UAI-Patron-Command


Patrón Command en C# Usando Visual Studio

El Patrón Command es un patrón de diseño de comportamiento que convierte una solicitud en un objeto independiente, lo que permite parametrizar a los clientes con diferentes solicitudes, colas o registros de operaciones. En C#, este patrón es especialmente útil cuando queremos desacoplar el objeto que emite una solicitud del que la recibe y ejecuta.

Conceptos Clave
Command: Define una interfaz con un método Execute(), que encapsula la solicitud.
Invoker: Es el responsable de ejecutar el comando, llamando al método Execute().
Receiver: Es el objeto que realiza la acción real cuando se ejecuta el comando.
Client: Crea el objeto Command y lo asigna al Invoker.
