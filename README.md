Patrones de Diseño

Instructor: Ariel Piñeiro
Email: arielsrv@gmail.com

Manual: https://github.com/arielsrv/educacionit.20190513.pdd/blob/master/patrones.pdf

Expert en Mercado Libre - Desarrollo de Software en Java, NET, Go, React entre otras.
Profe en EducacionIT y Universidad CAECE 

Ademas dicto Entity Framework y LinQ (programación funcional)

Vamos a subir el codigo aqui. https://github.com/arielsrv/educacionit.20190513.pdd/

Vamos a hacer ejercicios tanto en NET como Java
    NET: Visual Studio IDE
	Java: IntelliJ IDEA IDE

Clase 1 13/05/2019
	
¿Que recordamos, que cosas de Programación orientada a Objetos?

Clases. Metodos. Instancias. Constructores. Atributos. 
Variables estaticas
Encapsulamiento
Polimorfismo
Interfaces ¿¿?? ¿En que contexto? implements Interface ó : IInterface (no es esto)
Herencias
Abstraccion
Agregacion / Composicion -> Relaciones

Patrones vistos hasta la fecha

	* Singleton
	* Chain of responsibility
	* Template Method
	* Command
	* Strategy
	* Mediator
	* Factory Method
	* Bridge
	* Iterator
	* Proxy 
	* Observer
	* Builder (en su variante fluent)	
	* Decorator
	* Memento
	* Prototype
	* Composite
	* Adapter
	* Façade
	* Abstract Factory
	* Flyweight
	* Visitor (recuerden que pasaría si hubiera una jerarquía, resolución similar a Piedra Papel Tijera)
	
Ejercicios complementarios
	* Ejercicio de Double Dispatch
	* Ejercicio de uso de Genéricos y cómo se podría relacionar con un Singleton "Generico".
	* Listas enlazadas https://www.monografias.com/trabajos101/las-istas-enlazadas/image002.jpg

Repaso
Ejercicio 1
		Calcular el salario de una jerarquía de empleados
			Administrativo: $10000
			Supervisor: $20000
			Gerente: $50000
			Vendedor: $30000
			
			Nos piden un cambio -> VendedorPorComision: $10000 + $100 c/comision
				10 comision + basico
				$11000
				
Ejercicio 2
	Problematica
		* Tengo un solo balanceador de carga		
			
			
Clase 2
	Ejercicio 1
		Dado un determinado monto para solicitud de un préstamo, asignar un aprobador adecuado en base al monto solicitado.
		Los aprobadores, pueden ser:
			Empleado: 0 < monto < 10000
			Supervisor: 10000 < monto < 50000
			Gerente: 50000 < monto < 500000

	Chain of responsibility		

	Ejercicio 2
		Necesitamos crear DAOs (data access objects) que sean capaces de ejecutar una consulta, y maximizar la reutilización
		de código. 1 DAO de Producto + 1 DAO de Clientes. 
			SELECT * FROM Products
			SELECT * FROM Customers

	Template method

	Ejercicio 3
		Necesitamos crear scripts de linea de comandos que sirven para hacer backups / restores de archivos 
		para OSX y Windows


	Command 
	
Clase 3
	Ejercicio 1
		Tenemos un UserService, que retorna un objeto User. Utilizando un método llamado Get. Y que tenga la posibilidad de obtener al User desde un cache o una base de datos.
		
	Strategy
	
	Ejercicio 2
		Necesitamos hacer un chat. Que tenga participantes, que tenga una sala de chat. Y algunas validaciones minimas.
		
		Resolver el problema de que instancias (participantes en este caso) tengan que conocerse entre sí.
        
	Mediator
		
	Ejercicio 3
		Necesitamos crear estructuras que dependen de otra familia de objetos. Por ej: tenemos que crear
		diferentes tipos de documentos, donde cada uno se compone de páginas, que no necesariamente son del mismo tipo.
		
	Factory Method	
	
	Ejercicio 4
		Queremos conectar diferentes implementaciones a traves de dos o mas niveles de abstracción. Para ello utilizamos el patron.
		
	Ejercicio 5
	
		Necesitmaos crear una mencanismo para acceder a los elementos de una colección.
		
		Iterator.

Clase 4		

	Ejercio 1
		Necesitamos crear un par de entidades de dominio relacionadas entre sí. Que tengas acceso a un origen de datos (como puede ser una db) y debe ser transparente para el cliente.
			Cliente: quien consume nuestros componentes

		Ejemplo de calculadora y un proxy que registra log de las operaciones

		Proxy.

	Ejercicio 2
		Dado una acción, papel o título del Mercado de Valores, necesitamos que nuestros inversores se enteren de las varaciones de precio (para tomar futuras decisiones).

		Observer.

	Ejercicio 3
		Queremos cambiar y facilitar la manera de crear objetos, sin que el cliente utilice los setters y constructores convencionales, por ejemplo para la clase User.

		Builder Pattern (en este caso utilizamos la sintaxis fluent como la gran mayoría de frameworks/sdk del mercado)

		myMessage
		.h().o().l().a()
		.show();

Clase 5
	
	Ejercicio 1
	
		Realizar un piedra/papel/tijera. Dejamos un ejemplo de como evitar if/else "magicos" y comprobaciones de tipos al mejor estilo is instanceOf /  == .GetType().Class()
		
		Double Dispatch	
	
	Ejercicio 2 
		
		Necesitamos crear tipos de tarjetas simples, y agregarle la funcionalidad de que tambien puedan ser combos.
	
		Decorator
		
	Ejercicio 3
	
		Necesitamos modificar el saldo de una cuenta y tener la posiblidad de volver a una estado anterior, si es que ocurre una falla.
	
		Memento
		
	Ejercicio 4 
	
		Necesitamos crear copias de los objetos.
	
		Prototype
		
	Ejercicio 5
	
		Necesitamos crear una una estructura de componentes, los cuales pueden ser simples o compuestos. Un componente simple es terminal, y un componente compuesto puede contener componentes simples o compuestos.
		
		Composite
		
	Ejercicio 6
	
		Necesitamos traducir de alguna manera, una conversacion entre Chewie y un Alumno.
		
		Adapter
		
	Ejercicio 7
		
		Contexto: Mi app usa diferentes modulos de diferentes dominios (microservicios de la AFIP, Servicio SOAP de cuentas bancarias, y GMaps API).
		
		Necesitamos hacer un aprobador de creditos utilizando estos modulos.
		
		Façade
		
Clase 6

	Ejercicio 1 (de Genericos)
	
		Problema: crear e iterar una colección que admita genéricos.
		
	Ejercicio 2
	
		Problema: Quiero crear daos de Productos o Clientes de la misma forma independientemente de un motor de base de datos especifico.
		
		Abstract Factory
	
	Ejercicio 3
	
		Hacer un cache para obtener characteres y no recrearlos todos el tiempo
		
		Flyweight
		
Clase 7

	Ejercicio 1
	
		Implementar algoritmos que operan sobre empleados en clases y no en funciones o métodos.
		
		Visitor
		
	
	
		
		
	
		
		
		



	
	
	
