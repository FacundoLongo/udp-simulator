# UDP Simulator in C#

Este proyecto es una aplicación en C# diseñada para analizar el comportamiento y la estructura de paquetes transmitidos a través del protocolo UDP (User Datagram Protocol). La solución está organizada en dos proyectos de Windows Forms:

- **Transmisor:** Envía datos en forma de paquetes UDP a un receptor.
- **Receptor:** Recibe los paquetes UDP enviados por el transmisor y los procesa.

## Descripción

El proyecto tiene como objetivo explorar las características de UDP, un protocolo de la capa de transporte que no garantiza la entrega ni el orden de los paquetes. Para complementar estas limitaciones, se han implementado mecanismos adicionales como:

- **Numeración de paquetes** para mantener el orden de los datos.
- **Timeouts y retransmisión** para manejar paquetes perdidos.
- **Ventanas deslizantes** para optimizar la transmisión y recepción de paquetes.

### Características principales

- Envío de datos en paquetes numerados de tamaño configurable.
- Recepción de paquetes con validación de integridad y confirmaciones de recepción (ACK).
- Manejo de errores mediante retransmisión de paquetes no confirmados.
- Visualización de paquetes enviados y recibidos en tiempo real.

