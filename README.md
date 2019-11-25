# BackendProducto
Api en Net Core para la el CRUD de tabla producto

Se creo un proyecto con arquitecura orientada a dominio con inversion de dependencias.
se hizo uso del AutoMaper para el uso de Dtos.

## Como montar el proyecto

Para poder ejecutar este proyecto es necesario tener:

+ Net Core 3.0 <br>
+ Visual Studio 2019 <br>

Clone y baje el proyecto y ejecute la siguiente sintaxi en la terminal:
```cs
Update-Database -Context ProductoContexto
```
## Metodos del API

Una vez actualizada la base de datos, puede poner en marcha la aplicación.

Podra acceder a la Api con las siguientes rutas:

```cs
https://localhost:5001/api/Producto   -> (GET) Obtiene la lista de todos los productos.

https://localhost:5001/api/Producto   -> (POST) Crea un nuevo producto.

https://localhost:5001/api/Producto   -> (PUT) Actualiza un  producto.

https://localhost:5001/api/Producto   -> (DELETE) Elimina un  producto.
```

Este proyecto trabaja en conjunto con el proyecto FrontEnd en Angular 8
este se encuentra en: https://github.com/GedGonz/FrontEndAngular
