# Tutor de Hardware PC en Realidad Aumentada
## Repositorio del Proyecto — PSISP08075 Realidad Virtual y Aumentada
### Universidad Autónoma del Perú | Ingeniería de Sistemas | 2026-1

---

# Descripción del Proyecto

AR PC Hardware Tutor es una aplicación educativa desarrollada en Unity y Vuforia que utiliza realidad aumentada para facilitar el aprendizaje de los principales componentes internos de una computadora. Mediante el reconocimiento de imágenes (Image Targets), el usuario puede visualizar información interactiva sobre la placa madre, procesador (CPU), memoria RAM, tarjeta gráfica (GPU) y disco duro (HDD), fortaleciendo la comprensión de sus funciones dentro del sistema.

Además del modo de aprendizaje, la aplicación incorpora un módulo de evaluación que permite medir los conocimientos adquiridos durante la experiencia y proporciona retroalimentación inmediata al usuario.

| Campo | Detalle |
|-------|---------|
| **Tipo XR** | Realidad Aumentada (AR) |
| **Motor** | Unity 2022.3.62f1 |
| **Tecnología principal** | Vuforia Engine + Image Targets |
| **Lenguaje** | C# |
| **Curso** | PSISP08075 — Realidad Virtual y Aumentada |
| **Semestre** | 2026-1 |

---

# Objetivo

Desarrollar una aplicación educativa de realidad aumentada que permita reconocer componentes internos de una computadora y facilite su aprendizaje mediante contenido interactivo, navegación intuitiva y un módulo de evaluación.

---

# Funcionalidades implementadas

### Modo Aprendizaje

- Reconocimiento de Image Targets mediante Vuforia.
- Reconocimiento de:
  - Placa Madre
  - CPU
  - RAM
  - GPU
  - HDD
- Paneles dinámicos de información.
- Botones independientes para consultar cada componente.
- Navegación entre escenas.
- Interfaz optimizada para dispositivos móviles.

### Módulo de Evaluación

- Cuestionario interactivo.
- Preguntas de selección múltiple.
- Retroalimentación inmediata.
- Puntaje automático.
- Resultados finales.
- Preparación para cierre de la experiencia.

### Experiencia de Usuario

- Pantalla principal.
- Escena de exposición con explicación del proyecto.
- Navegación guiada.
- Diseño orientado al aprendizaje.
- Flujo continuo entre módulos.

---

# Integrantes del Grupo

| Nombre | Código | Rol |
|--------|--------|-----|
| Salazar Mondragón Jael Santiago | 2221898131 | Líder del proyecto, Desarrollo Unity y Desarrollo RA |
| Palacios Vegaray Jhener Erick | 2231890156 | Desarrollo Unity y Desarrollo RA |
| - Mendoza Muñoz Yalitza - Palomino Alvarez Ricardo - Silverio Quispe José Miguel | | Documentación y pruebas |

---

# Instalación y Uso

## Requisitos

- Unity 2022.3.62f1 (LTS)
- Android 7.0 o superior
- Vuforia Engine
- Visual Studio / Visual Studio Code

## Clonar el repositorio

```bash
git clone https://github.com/RubenCarty/AR-VR-g03-tutor-hardware-ra.git
cd AR-VR-g03-tutor-hardware-ra
```

## Abrir en Unity

1. Abrir Unity Hub.
2. Seleccionar **Add Project**.
3. Elegir la carpeta del proyecto.
4. Abrir con Unity 2022.3.62f1.
5. Configurar Vuforia.
6. Build and Run para Android.

---

# Flujo de la aplicación

```text
MenuScene
        │
        ▼
ExpoScene
        │
 ┌──────┴─────────┐
 │                │
 ▼                ▼
Modo Aprendizaje  Evaluación
      │              │
      ▼              ▼
   ARScene     EvaluationScene
                      │
                      ▼
               ResultsScene
                      │
                      ▼
                 ThanksScene
                      │
                      ▼
                 MenuScene
```

---

# Progreso del Proyecto

| Semana | Actividad | Estado |
|---------|-----------|--------|
| S01-S02 | Investigación y planteamiento del problema | ✅ |
| S03-S04 | MVP y arquitectura inicial | ✅ |
| S05-S06 | Reconocimiento inicial mediante Vuforia | ✅ |
| S07-S08 | Implementación de componentes interactivos | ✅ |
| S09-S10 | Diseño UI/UX y navegación | ✅ |
| S11-S12 | Integración del módulo de evaluación | ✅ |
| S13-S14 | Optimización, pruebas y mejoras visuales | 🚧 En desarrollo |
| S15-S16 | Integración final, accesibilidad y presentación | 🚧 En desarrollo |

---

# Tecnologías utilizadas

- Unity 2022.3.62f1
- Vuforia Engine
- C#
- TextMeshPro
- Android
- Git
- GitHub

> **Próximamente**
>
> - Unity Input System
> - Funciones de accesibilidad
> - Narración y mejoras multimedia

---

# Estructura del Repositorio

```text
AR-VR-g03-tutor-hardware-ra/
│
├── Assets/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Prefabs/
│   ├── Materials/
│   ├── Images/
│   ├── UI/
│   └── Vuforia/
│
├── Packages/
├── ProjectSettings/
├── docs/
│
├── README.md
└── .gitignore
```

---

# Estado actual del proyecto

Actualmente el proyecto cuenta con:

- Reconocimiento de cinco componentes de hardware.
- Paneles dinámicos de información.
- Escena de exposición.
- Módulo de evaluación funcional.
- Pantalla de resultados.
- Flujo completo entre escenas.
- Preparación para incorporar Input System.
- Próxima implementación de funciones de accesibilidad.

---

# Trabajo futuro

- Incorporación del Unity Input System.
- Funciones de accesibilidad (alto contraste y texto ampliado).
- Integración de audio educativo.
- Optimización del rendimiento.
- Validación con usuarios.
- Publicación de APK final.

---

# Licencia

Proyecto académico desarrollado para el curso **PSISP08075 – Realidad Virtual y Aumentada**.

Universidad Autónoma del Perú — 2026.
