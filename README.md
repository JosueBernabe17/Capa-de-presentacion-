# Sistema de Ventas - Capa de Presentación

Bienvenido a la **Capa de Presentación** del Sistema de Ventas, un proyecto desarrollado en **C#** que implementa una interfaz gráfica funcional y profesional. Esta capa permite a los usuarios acceder al sistema mediante un inicio de sesión seguro y navegar por el menú principal para realizar las operaciones clave.

## 🚀 Características

- **Pantalla de Inicio de Sesión (Login):**
  - Autenticación de usuarios mediante credenciales.
  - Validación de entradas para evitar errores comunes.
  - Feedback al usuario en caso de datos incorrectos.

- **Menú Principal:**
  - Navegación intuitiva y organizada para acceder a las funcionalidades principales del sistema.
  - Interfaz diseñada para ser amigable y eficiente.

## 📂 Estructura del Proyecto

El proyecto sigue una arquitectura de capas para una mejor organización y mantenimiento. Esta capa se comunica con las capas de **negocio** y **datos** para ofrecer una experiencia fluida al usuario final.

```plaintext
SistemaVentas/
├── Presentacion/
│   ├── Login.cs
│   ├── MenuPrincipal.cs
│   ├── Recursos (Imágenes, Iconos, etc.)
│   ├── Program.cs
├── Negocio/ (Capa lógica del negocio)
├── Datos/ (Capa de acceso a datos)
