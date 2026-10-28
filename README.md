# Slice (Proyecto IXIPTLA)

Prototipo de arquitectura de sistemas en C++ y mecánicas de combate modulares para título AAA de acción y aventura en tercera persona, ambientado en Tenochtitlan (1518).

## Requisitos del Sistema
* **Motor Gráfico:** Unreal Engine 5.8
* **Entorno (IDE):** Visual Studio Code (se recomienda utilizar la extensión Roo Code para asistencia en desarrollo).
* **Dependencias:** Node.js (utilizado para automatización de código y flujos de trabajo) y Git LFS.

## Configuración y Compilación
1. **Instalar Git LFS:** Es obligatorio ejecutar `git lfs install` en la terminal antes de clonar el proyecto para gestionar correctamente los assets pesados.
2. **Clonar y Bifurcar:** Utiliza el flujo de Fork. Clona tu bifurcación localmente.
3. **Generar Archivos:** Haz clic derecho sobre el archivo `SliceIA.uproject` y selecciona **Generate Visual Studio project files**.
4. **Compilar el Código:** Abre el proyecto en VS Code y ejecuta la tarea de compilación (*Development Editor Build*) para procesar los módulos de C++.
5. **Scripts de Automatización:** Si trabajarás con la generación automática de código, verifica la inicialización de los scripts en Node.js correspondientes a tu tarea.

## Flujo de Colaboración
La rama `main` cuenta con protección activa. Ningún colaborador tiene permisos de subida directa. 
* Trabaja cada mecánica o tarea en una rama aislada (`git checkout -b feature/nombre-tarea`).
* Sube los cambios a tu repositorio bifurcado.
* Abre un **Pull Request** detallando las implementaciones realizadas. Todo código será revisado antes de su integración.
*
