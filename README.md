# Reporte de Proyecto: Formulario de Login Seguro con SOLID y MySQL
**Estudiante:** Irving A. Sanchez R.  
**Materia:** Ciberinfraestructura  

## 1. Introducción
Este proyecto consiste en la implementación de un sistema de inicio de sesión (Login) y visualización de datos desarrollado en C# .NET. Se enfoca en la aplicación de principios de diseño de software (SOLID), Clean Code y la integración con bases de datos MySQL.

## 2. Arquitectura y Estructura del Proyecto
El código ha sido organizado siguiendo una estructura de carpetas profesional para separar las responsabilidades (SRP):

*   **Models/**: Contiene las entidades de datos (ej. `Personal.cs`).
*   **Services/**: Contiene la lógica de negocio y acceso a datos, desacoplada mediante interfaces (`IAuthenticationService`, `IPersonalService`).
*   **UI/**: Contiene los formularios de la interfaz de usuario (`Form1`, `DatabaseConfigForm`) con un diseño oscuro y responsivo.

### Principios SOLID Aplicados
*   **S - Single Responsibility Principle (SRP):** Cada clase tiene una única razón para cambiar. Los servicios manejan la lógica, los modelos los datos y la UI la visualización.
*   **O - Open/Closed Principle (OCP):** El sistema permite extender la lógica de autenticación o de obtención de datos mediante interfaces sin modificar los formularios.
*   **D - Dependency Inversion Principle (DIP):** Los formularios dependen de abstracciones (interfaces) que son inyectadas, no de implementaciones concretas.

## 3. Tabla de Datos (`cat_personal`)
El sistema visualiza la información de la tabla `cat_personal` con los siguientes campos:
*   Nombre, Apellido, Email, Teléfono, Cargo, Fecha de Contratación y Estado Activo.

## 4. Guía de Uso
1.  **Configuración de DB**: Al iniciar, ingrese el Host (`localhost`), Base de Datos (`mydb`), Usuario y Contraseña.
2.  **Conexión**: Presione "Conectar y Cargar". El sistema validará la conexión y mostrará los registros de la tabla en un Grid responsivo.
3.  **Login**: Una vez establecida la conexión, se habilitará el botón para acceder al formulario de validación de credenciales.

---
*Este proyecto fue realizado como parte de las actividades académicas para la Maestría en Cómputo Aplicado.*
