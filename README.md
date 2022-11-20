**Titulo**: aplicacion de truco

**Resumen**: es una aplicación que simula partidas de truco entre dos jugadores. Pueden registrarse nuevos jugadores solo con un nombre, que será único. Se elegirán los jugadores para la partida y con el botón "Comenzar" del formulario principal se abrirá un nuevo formulario donde se verá a través de un rich text box los movimientos de cada jugador.
El botón "Ver Jugadores" mostrará los jugadores registrados en la base de datos, ordenados por nombre, y pudiendose visualizar el número de partidas totales que ha jugado y en cuántas ha ganado.
El botón "Mayores ganadores"  mostrará aquellos jugadores que mayor cantidad de partidas hayan ganado.
"Crear sala" abre un nuevo formulario donde se pide elegir dos jugadores para que se enfrenten en una partida. 
Para comenzar a ver una partida, es necesario hacer click sobre la primer columna del DataGridView y luego hacer click sobre el botón "Comenzar".
Al finalizar la partida, se anunciará al ganador.

**Justificación de técnica**: 
* Pruebas unitarias: de algunos métodos de las clases Truco y Jugador.
* Tipos genéricos: en la clase Serializador contiene métodos que reciben o devuelven un dato de tipo genérico. 
* Archivos: creación de un archivo para guardar el  historial de una partida al final de la misma.
* Sql: para persistir en memoria a los jugadores y las salas creadas.
* Hilos: Cada partida creada correrá en un hilo distinto para así poder visualizar varias al mismo tiempo
* Eventos: creación de un evento en la clase Jugador para invocarlo cuando el estado del mismo pase de EsGanador = false a EsGanador = true, que avisará al método manejador para que éste escriba en el label del formulario el nombre del jugador ganador.
* 
* 