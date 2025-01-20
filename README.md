# Componente Pokémon en C#

## 📝 Descripción
Este repositorio contiene un **componente modular y reutilizable** diseñado en C# para la gestión de datos de Pokémon. Se basa en los principios de **SOLID** y sigue las principales reglas de diseño de componentes, como **REP**, **CCP**, **CRP**, **ADP**, **SDP** y **SAP**, asegurando una arquitectura limpia y mantenible. El proyecto incluye diagramas UML para documentar y visualizar la arquitectura.

## 🎯 Características
- **Gestión de datos de Pokémon**: Crear, consultar y manejar Pokémon con atributos como ID, Nombre, Tipo, Nivel, Ataque y Defensa.
- **Almacenamiento en memoria**: Implementación de repositorio de ejemplo para almacenar Pokémon en memoria.
- **Inversión de dependencias**: Utiliza una abstracción (`IPokemonRepository`) para separar la lógica de la implementación.
- **Extensibilidad**: Permite reemplazar fácilmente el repositorio con otra implementación (por ejemplo, una base de datos).


## 🚀 Empezando
Requisitos previos
.NET 6.0 o superior
Visual Studio o Visual Studio Code
Instalación
Clona el repositorio:

```bash

git clone https://github.com/TuUsuario/ComponentePokemon.git
cd ComponentePokemon
```
Abre el archivo de solución en Visual Studio.

## 📜 Documentación
Este repositorio incluye:

Diagramas UML:
Diagrama de Clases:

![image](https://github.com/user-attachments/assets/c3e39548-21a3-466c-bd70-83a3ba088510)

Diagrama de Componentes: 

![image](https://github.com/user-attachments/assets/54b8aa3f-f233-426b-a423-65e0a4b9fbcd)

Código bien estructurado siguiendo los principios de diseño.
Pruebas unitarias para validar el comportamiento del componente.

## 📌 Versionamiento
El proyecto sigue un esquema de versionamiento semántico:

Mayor: Cambios que rompen compatibilidad.
Menor: Nuevas características que son compatibles.
Parche: Corrección de errores y ajustes menores.
Esta versión es la 1.0.0

## 🛠️ Contribuir
Si deseas contribuir:

Realiza un fork del repositorio.
Crea una rama con tu función o corrección:
```bash

git checkout -b feature/nueva-funcion
```
Haz un pull request.

## 📄 Licencia
Este proyecto está bajo la Licencia MIT. 


