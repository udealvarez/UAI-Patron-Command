# UAI-Patron-Command


# Patrón Command en C# Usando Visual Studio

El Patrón Command es un patrón de diseño de comportamiento que convierte una solicitud en un objeto independiente, lo que permite parametrizar a los clientes con diferentes solicitudes, colas o registros de operaciones. En C#, este patrón es especialmente útil cuando queremos desacoplar el objeto que emite una solicitud del que la recibe y ejecuta.

## Conceptos Clave

- **Command**: Define una interfaz con un método `Execute()`, que encapsula la solicitud.
- **Invoker**: Es el responsable de ejecutar el comando, llamando al método `Execute()`.
- **Receiver**: Es el objeto que realiza la acción real cuando se ejecuta el comando.
- **Client**: Crea el objeto Command y lo asigna al Invoker.

## Beneficios del Patrón Command

1. **Desacoplamiento**: El emisor de la solicitud no necesita conocer los detalles de cómo se ejecuta.
2. **Flexibilidad**: Los comandos pueden ser reutilizados, combinados o almacenados para ejecución futura.
3. **Fácil Extensión**: Es sencillo añadir nuevos comandos sin modificar el código existente.

## Conclusión

El patrón Command es una excelente herramienta para desacoplar solicitudes y acciones en tu aplicación. En Visual Studio, la implementación en C# es simple y facilita el manejo de comandos que pueden ser ejecutados, deshechos o almacenados. Este patrón es ideal cuando necesitas implementar funcionalidad como menús, botones de deshacer, o cualquier interacción donde las solicitudes deben ser manejadas de manera flexible.
