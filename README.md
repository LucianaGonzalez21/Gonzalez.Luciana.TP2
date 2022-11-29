**Titulo**
Aplicación de truco

**Resumen**
Es una aplicación que simula partidas de truco entre dos jugadores previamente registrados. El usuario podrá elegir a los jugadores que se enfrentan en una partida y visualizarla mientras ésta ocurre. Asimismo, se podrá ver información de los jugadores como la cantidad de partidas que ganaron, los jugadores que posean el puntaje mayor entre todos ellos o quiénes son los que más partidas han ganado.

**Diagrama de clases**

![image](https://user-images.githubusercontent.com/86836988/204612342-72320c2f-3769-4c1e-aa3b-fe28bd7ce817.png)


**Funcionamiento**

![image](https://user-images.githubusercontent.com/86836988/204189188-59e0895d-e572-44b0-8dea-00307539926e.png)

En el formulario principal se puede apreciar un DataGrid con la información de las salas creadas: el id de la misma y los nombres de los jugadores que participen de la partida. Para poder comenzar una partida y visualizarla, es necesario seleccionar una sala del DataGrid, con un click sobre la fila deseada, y luego presionar el botón comenzar. Esto hará que se abra un nuevo formulario,  que mostrará la partida en tiempo real:

![image](https://user-images.githubusercontent.com/86836988/204613941-0c757cdf-e105-405c-a666-7bf8d22c8f0c.png)


La partida consta de tres rondas y ganará aquel que más puntos haya logrado en total. Cuando la misma finalice, se verán los puntajes de cada jugador y si hay un ganador, aparecerá un mensaje informandolo:

![image](https://user-images.githubusercontent.com/86836988/204614358-c690969e-dbad-4951-913c-be9daddae593.png)


En el caso de no haber seleccionado una sala del DataGrid y querer comenzar una partida, se mostrará el siguiente mensaje de error: 

![image](https://user-images.githubusercontent.com/86836988/204189358-58a5a57d-1798-47c3-aaaa-f4596b4af3d7.png)

Para registrar un nuevo jugador y que éste pueda participar de una partida, debe hacerse click en el botón Registrar Jugador, que abrirá el siguiente formulario:

![image](https://user-images.githubusercontent.com/86836988/204189403-d1e4b8ee-91a7-4dd0-9210-0c0e2477c5c0.png)

En  el text box se deberá escribir el nombre del nuevo jugador. Si el nombre ya existe, se verá el siguiente mensaje de error:

![image](https://user-images.githubusercontent.com/86836988/204189480-40114c87-ab51-42b5-a463-9785d9d549d5.png)

Si no se ingresa un nombre, se verá el siguiente mensaje de error:

![image](https://user-images.githubusercontent.com/86836988/204189517-70a07797-a9a3-4658-9446-20ca67d92886.png)

Si el nombre ingresado es válido, se cerrará este formulario y volveremos a ver el principal.

Si se desea ver la lista de jugadores registrados, incluido el jugador recientemente añadido, deberá hacerse click sobre el botón Ver Jugadores, el cual abrirá un nuevo formulario, donde hay un rich text box conteniendo toda la información de los jugadores: la cantidad de partidas ganadas y perdidas, el puntaje máximo que hicieron en una partida y la cantidad total de partidas jugadas. Se visualizará en orden alfabético por nombre de los jugadores.

![image](https://user-images.githubusercontent.com/86836988/204189572-8f585868-4202-4ddf-ad33-05e96004f255.png)

Para crear una sala, hacer click en el botón Crear Sala, que nos llevará al siguiente formulario:

![image](https://user-images.githubusercontent.com/86836988/204189617-31cfe21d-0246-42c1-abb9-79d53e0bdc9f.png)

Los botones a la izquierda sirven para poder seleccionar a los jugadores que se desea enfrentar en una partida. Al hacer click sobre uno de ellos, se visualizará el siguiente formulario:

![image](https://user-images.githubusercontent.com/86836988/204612804-fde20304-b3d2-4e25-850f-c1e74781551d.png)


Como se puede apreciar, se pueden ver todos los jugadores registrados con su información. Para poder elegir a uno, debe hacerse click sobre la fila donde está el jugador que queramos para la partida. Si no se hace click y se presiona el botón Elegir, se visualizará el siguiente mensaje de error:

![image](https://user-images.githubusercontent.com/86836988/204612892-682b7772-a7e6-4e22-b812-7d11dbf21610.png)


Si se selecciona correctamente, el nombre aparecerá en pantalla, de la siguiente manera:

![image](https://user-images.githubusercontent.com/86836988/204612971-2a023189-8984-4e86-972c-64b52768565f.png)


Ahora, al clickear el botón elegir, se cerrará este formulario y volveremos al anterior, que ahora se verá así:

![image](https://user-images.githubusercontent.com/86836988/204189776-97268259-28b0-48fa-a85b-f573272743b0.png)

Debe hacerse lo mismo para el otro jugador.
Si por error, se elige dos veces al mismo jugador, al hacer click sobre el botón Crear, aparecerá un mensaje de error en el formulario:

![image](https://user-images.githubusercontent.com/86836988/204189807-f694769f-2dee-412e-b13b-9900ab0dd5e5.png)

Lo mismo ocurre si no se eligen los dos jugadores.
Si se siguieron los pasos correctamente, cuando demos click al botón Crear, se cerrará el formulario actual y volveremos al principal, pudiendo verse en el DataGrid la nueva sala creada:

![image](https://user-images.githubusercontent.com/86836988/204189845-2c2c4c2d-91f6-4020-83d5-fda4798ad1bf.png)

Ahora, la aplicación permite comenzar y visualizar varias partidas al mismo tiempo, cada una desarrollándose a su tiempo. Luego de haber seleccionado una partida y haberla comenzado, puede elegirse otra del menú principal y también comenzarla. Si un jugador ya se encuentra jugando, se visualizará el siguiente mensaje en pantalla: 

![image](https://user-images.githubusercontent.com/86836988/204189955-b98081f0-344d-43a0-a409-388748df96d4.png)

De vuelta en el menú principal, en la parte inferior existen cuatro botones que nos mostrarán información acerca de los jugadores. Con el botón Mayores Ganadores veremos el o los jugadores que más partidas ganadas tengan.

![image](https://user-images.githubusercontent.com/86836988/204190001-1f1d9418-19aa-4260-85a8-1ae51c4c9284.png)

Con el botón Partidas Ganadas veremos el número de partidas ganadas de cada jugador:

![image](https://user-images.githubusercontent.com/86836988/204190041-5a7d6b2d-a4c3-4213-9ced-da725dde4fc7.png)

El botón Partidas Perdidas, nos mostrará el número de partidas que ha perdido cada jugador:

![image](https://user-images.githubusercontent.com/86836988/204190073-97b7fe16-96e8-45b7-b8b9-5986a4e64a50.png)

Con el botón Puntajes Máximos, veremos a el o los jugadores que poseen el máximo puntaje de una partida, de entre todos lo puntajes:

![image](https://user-images.githubusercontent.com/86836988/204190114-86a45f73-fc8c-45c1-9872-6aa4a5079798.png)

**Justificación de temas:**
* Excepciones

Implementé manejo de excepciones principalmente en archivos, serialización y sql, para que el programa no se cierre en plena ejecución si no se encontró la ruta de un archivo o no se pudo conectar con la base de datos.

![image](https://user-images.githubusercontent.com/86836988/204190148-ae34400f-b702-443c-a547-95093e1fbf42.png)

En el caso de lanzar una excepción, el formulario que contenga el catch para dicha excepción mostrará un MessageBox con el mensaje cargado en el constructor. Así se evita una mala experiencia de usuario si se cierra la aplicación por un error.

![image](https://user-images.githubusercontent.com/86836988/204190240-91d660d0-7877-4b7a-a288-a11e576eebf9.png)

Si el formulario principal no pudo deserializar el mazo, se mostrará un mensaje en pantalla, pero luego se cargará. La desventaja de esto es que no podrán jugarse partidas, ya que para eso se necesitan cartas.

![image](https://user-images.githubusercontent.com/86836988/204190292-633df7a8-ecae-461d-a1ed-04ee137c457e.png)

* Pruebas unitarias

Para probar que los métodos declarados en las clases de la biblioteca Entidades funcionan correctamente, creé un proyecto de pruebas llamado Entidades.Test donde se controla el funcionamiento correcto de tales métodos.

![image](https://user-images.githubusercontent.com/86836988/204190331-6a628543-be00-4d2e-a838-912f988e98e7.png)

En los casos donde el retorno de un método puede ser distinto según lo que reciba, creé una prueba pasándole al método diferentes parámetros.

![image](https://user-images.githubusercontent.com/86836988/204190369-c4639739-dcdb-4580-8579-4d3642bdfd37.png)

Así también verifiqué que un método lanzara una excepción cuando debiera.

![image](https://user-images.githubusercontent.com/86836988/204190437-692053c2-f1bf-4ec1-ae34-374d0a398d48.png)

La ventaja que encontré al realizar los unit testing es que pude mejorar algunos de los métodos creados, ya que lanzaban excepciones si recibían algo distinto de lo que esperaban.

* Tipos genéricos

Utilicé genéricos en la clase Serializador para que pueda serializar y deserializar cualquier tipo de objeto 

![image](https://user-images.githubusercontent.com/86836988/204190482-84273b0e-a9dc-467a-83af-17bc49eed536.png)

Al momento de utilizar estos métodos es necesario aclarar el tipo de T. 
En este proyecto, lo implementé para guardar y luego obtener el mazo de cartas leyendo desde el archivo. 

![image](https://user-images.githubusercontent.com/86836988/204190514-4f155c8c-de2e-4106-be85-4f852ea86463.png)

En la llamada al método, el objeto que pretendía leer era de tipo List<Cartas>, y el retorno se guardó en la variable mazo que también es de tipo List<Carta>

* Interfaces

Creé dos interfaces en la biblioteca Entidades:

![image](https://user-images.githubusercontent.com/86836988/204190546-48c02b0b-6267-4c87-a80b-d2212e08a911.png)

Ambas las utilizan las clases FrmPartida y Partida.
![image](https://user-images.githubusercontent.com/86836988/204190581-012cdb1d-d379-42a7-9d74-acfb308d25f0.png)

Así, tanto la clase Partida como la clase FrmPartida incluye diferentes comportamientos. La clase FrmPartida hereda de la clase Form pero a su vez implementa las operaciones de IHilos y de IPartidaFinalizada. 
Las clases que implementan estas interfaces realizan la misma operación, pero cada una le da la implementación adecuada según lo que necesite.

* Archivos

En la clase Partida implementé el método GuardarHistorial que recibe una cadena de texto con el historial de la partida, y éste es guardado en un archivo.

![image](https://user-images.githubusercontent.com/86836988/204190712-4a122869-5884-4bea-861d-f8acc749765f.png)

Al hacer esto, puedo guardar los historiales y se visualizarán uno debajo de otro. Me pareció una manera ordenada de leer información. Si hiciera un archivo por cada partida, habría demasiados.

* Serialización

Ya que la serialización permite guardar el estado de un objeto con un formato específico, lo implementé para guardar el mazo de cartas en un archivo Json y luego recrearlo al momento de utilizar la aplicación. 

![image](https://user-images.githubusercontent.com/86836988/204190754-27fd1c71-9d33-47e9-b792-53ff942886e7.png)

El método Leer busca en la ruta pasada por parámetro el archivo Json para poder convertirlo luego a una List de Cartas.

![image](https://user-images.githubusercontent.com/86836988/204190786-70b298be-7794-4414-9035-0e1583db8057.png)

* SQL

Utilicé bases de datos para persistir en memoria a los jugadores y a las salas creadas. Estos datos quedan almacenados y pueden utilizarse luego. Por ejemplo, una vez creado un jugador y guardado en la base de datos, puedo utilizarlo para que juegue en otra sala. Sus datos (partidas ganadas, perdidas, etc) quedarán también almacenados por lo tanto, podrá observarse las estadísticas que muestran quién ha ganado más partidas, etc. 
La ventaja de utilizar bases de datos fue no tener que cargar jugadores o salas cada vez que abriera la aplicación.
Las clases que implementan SQL son:

![image](https://user-images.githubusercontent.com/86836988/204190815-c2ff2e2f-3506-437b-a8af-e62007a92376.png)

* Delegados

Utilicé un delegado de tipo Action para mostrar los movimientos de los jugadores durante una partida.

![image](https://user-images.githubusercontent.com/86836988/204190864-13a458f7-9106-4a8a-b009-1bc42fb7b784.png)

El método asociado al delegado se encuentra en FrmPartida y es ActualizarRichTextBox.

![image](https://user-images.githubusercontent.com/86836988/204190914-3d51a01f-44da-410a-8708-acad0c90a9ac.png)

Así, cuando invoco al delegado en el método JugarPartida() de la clase Partida, se escribe en el control del formulario.

![image](https://user-images.githubusercontent.com/86836988/204190956-319eeaac-0b36-4ea3-9c98-f26573c73cdf.png)

Hacerlo de esta manera me permitió que los movimientos se puedan ir mostrando de a poco en vez de pasar la partida entera al rich text box.

* Multi Hilo y Concurrencia

Utilicé este tema para que varias partidas se estén dando al mismo tiempo, creando así un hilo por cada partida, independientes entre sí y del hilo que los creó.

![image](https://user-images.githubusercontent.com/86836988/204190997-83e3c321-cc27-4ac4-a277-a9aeffd134f6.png)

La ventaja que esto presenta es no tener que esperar a que una partida termine para que empiece otra. Si asi fuera, para jugar varias partidas, el tiempo total que hay que esperar es la suma de todas ellas. En cambio, al iniciar cada una en un hilo distinto, el tiempo máximo de espera es el de la partida que dure más.

* Eventos

En la clase jugador creé un delegado y un evento para anunciar al ganador de una partida.

![image](https://user-images.githubusercontent.com/86836988/204191032-d79f480b-bdc4-4f2d-8942-dbc80467ccab.png)

Cuando la partida termina, y cambia el estado del jugador de EsGanador = false a EsGanador = true, se dispara el evento EventoEsGanador, que tiene como manejador al método AnunciarGanador de FrmPartida.

![image](https://user-images.githubusercontent.com/86836988/204191063-beee0dae-6471-4957-8caa-40fdcc94c397.png)

![image](https://user-images.githubusercontent.com/86836988/204191092-1f69bd2c-4c79-4935-9279-baa83801da69.png)

Así, cuando el estado de un jugador cambia a EsGanador = true, el método AnunciarGanador escribirá en un label del formulario el nombre del ganador:

![image](https://user-images.githubusercontent.com/86836988/204191126-8ad17903-a9ee-43f7-be21-0de2f6cc0364.png)



