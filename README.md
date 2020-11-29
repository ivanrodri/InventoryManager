# Inventory Manager
Inventory manager aplication en arquitectura DDD que permite la funcionalidad del inventario de elementos.

Se compone de las diferentes capas Dominio, Aplicación y Infraestructura. También se compone de la Api y la UI en MVC.

Para poder ejecutar la Api es necesario setearla como proyecto de inicio. De l amisma manera para la UI en MVC.


AutoMapper : Utilizada para mapear clases automaticamente.

Swagger : Libreria que permite documentar la Api siguiendo el "openapi": "3.0.1".   

ruta del fichero json con la documentación.
https://localhost:5001/swagger/v1/swagger.json

ruta de la UI de Swagger
https://localhost:5001/swagger/index.html

Dto: Los dtos los utilizamos para la comunicación de datos entre la Api y la capa de Aplicación.

Interfaces : Permiten definir los un contrato en el que definir que tendran que cumplir las clases que lo implementen.

Specification : Este patrón permite difinir las reglas de negocio de modo que podemos saber si se cumple la regla mediante una variable boolean.
 
Test: Permiten el testeo tanto de métodso como de sevicios de forma individual.

Moq: Se utiliza para poder imitar las interfacen que dan acceso a los datos.

Authentication Basic : Permite securizar la Api aunque hay maneras mucho mas seguras como los tokens JWT.