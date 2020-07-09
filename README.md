<h1>Dev Test sobre proyecto Karting MicroGame para GetaClub<h1>


<h2>1.Crear un modo de juego en el que haya un temporizador inicial. Cuando este temporizador llegue a cero, es Game Over y el jugador vuelve a la pantalla principal. El objetivo es agarrar objetos que te dan tiempo adicional y poder llegar a la meta antes de que se acabe el tiempo.<h2>


  <b>Parte de este ejercicio ya estaba desarrollado en el proyecto inicialmente. Agregue cubos (están en Prefabs/PowerUps) que actúan como powerups que al pasar por ellos añaden un tiempo extra determinado por un ScriptableObject (Donde el diseñador puede modificar a conveniencia) que se puede manejar y crear desde la carpeta de proyecto. Para esto tuve que modificar el código ya hecho ya que el acceso al tiempo restante de la carrera estaba como un setter privado.</b>


<h2>2.Crear un sistema de estadísticas a los carros en los que se puedan cambiar su velocidad máxima, aceleración, tiempo de frenado, sensibilidad al tomar curvas. Estos cambios deben poder hacerse dentro del inspector.<h2>


  <b>Parte de este ejercicio también ya estaba desarrollado los stats de los carros en la clase ArcadeKart pero quise ir un poco mas allá y le añadi la opción de poder crear perfiles para diferentes tipos de autos que se puedan crear en el futuro y que estos también puedan ser modificados por el diseñador creando scriptable objects en la carpeta ScriptableObjects/KartStatProfiles</b>


<h2>3.Crear una IA que corra contra el jugador y tenga 3 niveles de dificultas diferentes.</h2>


  <b>Este sistema también ya lo tiene añadido el proyecto por el cual fue omitido.</b>


<h2>4.Crear un sistema de personalización de carros en los que se puedan agregar nuevas llantas, nuevas texturas y cambiar la estética del carro en general.</h2>


  <b>Cree la clase KartAppareance donde se encuentra arrays para sus respectivas partes a personalizar de manera publica para que el diseñador pueda modificar los colores y texturas sin ingresar al código.</b>

<h2>5.Implementar un sistema de editor en el que un Level Designer pueda diseñar una pista diferente a la que ya existe y agregar modelos 3D fácilmente.</h2>

  <b>Omitido</b>



<h2>6.Crear e implementar 3 mecánicas de suelo (Turbo, pérdida de control del vehículo, salto, etc) en las que cuando el carro pase por encima de ellos se active la mecánica en específico.</h2>


  <b>Para este ejercicio tuve que añadir nuevos powerups usando ya la clase que cree en el primer ejercicio y para el turbo le aumente la velocidad máxima que puede alcanzar mediante sus stats base desde la clase Arcade Kart. Para la perdida de control del vehiculo igualmente modifique la clase Arcade Kart y aumente la sensibilidad en la que el usuario mueve el timon para dar una sensación de perdida de control. Para el salto use el rigidbody del personaje principal para añadirle una fuerza de impulso hacia arriba. Todos estos valores pueden ser modificados mediante los scriptables object del primer ejercicio.</b>


<h2>7.Cambiar la mecánica de giro (control) del vehículo para que solamente pueda moverse entre carriles y no libremente como lo hace actualmente. Piense en esta opción como si fuera un Subway Surfer.</h2>

  <b>Omitido</b>

<h2>8.Desarrollar una mecánica de derrape para que el carro se deslice por el suelo cuando las curvas sean muy pronunciadas.</h2>

  <b>Omitido</b>
