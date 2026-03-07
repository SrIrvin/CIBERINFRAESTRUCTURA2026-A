# Reporte de Proyecto: Formulario de Login Seguro con SOLID
**Estudiante:** Irving A. Sanchez R.  
**Materia:** Ciberinfraestructura  

## 1. Introducción
Este proyecto consiste en la implementación de un formulario de inicio de sesión (Login) desarrollado en C# .NET. El objetivo principal fue aplicar principios de diseño de software.

## 2. Arquitectura y Principios SOLID
Se aplicaron los siguientes principios para estructurar la solución:

*   **S - Single Responsibility Principle (SRP):** La lógica de validación y autenticación se separó completamente de la interfaz de usuario (UI), residiendo en la clase `AuthenticationService`. El formulario `Form1` solo se encarga de mostrar y capturar datos.
*   **O - Open/Closed Principle (OCP):** Mediante el uso de la interfaz `IAuthenticationService`, el sistema permite extender la lógica de autenticación (por ejemplo, cambiar a una base de datos SQL) sin modificar el código del formulario.
*   **D - Dependency Inversion Principle (DIP):** Se utilizó inyección de dependencias en el constructor del formulario, asegurando que el módulo de alto nivel no dependa de implementaciones de bajo nivel.

## 3. Funcionalidades Implementadas

### A. Validación de Complejidad de Contraseña
Se implementó una expresión regular (**Regex**) robusta que obliga al cumplimiento de:
*   Al menos una **letra mayúscula**.
*   Al menos una **letra minúscula**.
*   Al menos un **número**.
*   Al menos un **símbolo** (caracter especial).

### B. Validación de Coincidencia
El sistema incluye un segundo campo de entrada para confirmar la contraseña, validando que ambos textos sean idénticos.

### C. Retroalimentación (UX)
*   Manejo de diálogos (`MessageBox`) para informar sobre errores de validación.
*   Mensaje de éxito específico solicitado: `"La contraseña ha sido validada"` al cumplir todas las reglas.

## 4. Archivos Clave
*   `Program.cs`: Configuración inicial e inyección del servicio.
*   `IAuthenticationService.cs`: Contrato de servicios de seguridad.
*   `AuthenticationService.cs`: Lógica de validación con Regex.
*   `Form1.cs`: Manejo de eventos de la interfaz.
*   `DIAGRAMA_CLASES.mmd`: Representación visual de la arquitectura.

---
*Este proyecto fue realizado como parte de las actividades académicas para la Maestría en Cómputo Aplicado.*
