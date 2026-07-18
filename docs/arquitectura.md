# Arquitectura Técnica — Tutor de Hardware PC en RA

## Tecnologías utilizadas

- Unity 2022.3.62f1
- Vuforia Engine
- Unity Input System
- TextMeshPro
- C#
- Android
- Git y GitHub

## Visión general del sistema

La aplicación fue desarrollada en Unity y utiliza Vuforia Engine para reconocer imágenes asociadas a componentes internos de una computadora. La lógica de interacción se implementa mediante scripts en C#, mientras que la interfaz se presenta mediante elementos UI de Unity y TextMeshPro.

```text
Capa de presentación
├── Escenas Unity
├── Canvas UI
├── TextMeshPro
├── Paneles informativos
└── Funciones de accesibilidad

Capa de lógica
├── ARInteractionController
├── InfoPanelController
├── QuizManager
├── ResultsManager
├── GestorAccesibilidadVisual
├── ExpoPanelController
└── SceneLoader

Capa de reconocimiento AR
├── Vuforia Engine
├── ARCamera
├── Image Targets
└── Default Observer Event Handler

Capa de almacenamiento local
└── PlayerPrefs
    ├── Puntaje de evaluación
    ├── Total de preguntas
    ├── Estado de texto grande
    └── Estado de alto contraste
```

## Componentes principales

## Componentes principales

| Componente | Propósito | Script asociado |
|---|---|---|
| Reconocimiento AR | Gestiona el reconocimiento de los marcadores de RAM, CPU, GPU, HDD y placa madre, además de controlar la interacción con los componentes detectados. | `ARInteractionController.cs` |
| Panel informativo | Muestra el nombre y la descripción del componente reconocido mediante un panel dinámico. | `InfoPanelController.cs` |
| Interacción táctil | Detecta los toques del usuario y evita que las pulsaciones sobre la interfaz gráfica activen la interacción con la escena AR. | `ARInteractionController.cs` |
| Evaluación | Administra las preguntas, valida las respuestas y calcula el puntaje obtenido por el usuario. | `QuizManager.cs` |
| Resultados | Recupera el puntaje almacenado y presenta los resultados finales de la evaluación. | `ResultsManager.cs` |
| Accesibilidad | Gestiona las funciones de texto grande, alto contraste y la persistencia de estas preferencias entre escenas. | `GestorAccesibilidadVisual.cs` |
| Navegación | Controla la transición entre las diferentes escenas de la aplicación. | `SceneLoader.cs` |
| Exposición inicial | Actualiza el contenido informativo mostrado en la escena de introducción de la aplicación. | `ExpoPanelController.cs` |

## Flujo de escenas

```text
MenuScene
    │
    ▼
ExpoScene
    ├─────────────────────────┐
    │                         │
    ▼                         ▼
ARScene                 EvaluationScene
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

## Jerarquía principal de ARScene

```text
ARScene
├── ARCamera
├── ImageTarget_RAM
├── ImageTarget_CPU
├── ImageTarget_GPU
├── ImageTarget_HDD
├── ImageTarget_Motherboard
├── Canvas
│   ├── Botón volver
│   ├── Indicador de toque
│   ├── Panel informativo
│   └── Panel de accesibilidad
├── ARInteractionController
├── InfoPanelController
└── GestorAccesibilidadVisual
```

## Flujo del reconocimiento

1. La cámara del dispositivo captura el marcador.
2. Vuforia compara la imagen con los Image Targets configurados.
3. Al reconocer un marcador, se identifica el tipo de componente.
4. Se muestra el indicador “Toca para ver información”.
5. El Input System detecta el toque del usuario.
6. Se verifica que el toque no haya ocurrido sobre un botón o panel UI.
7. `ARInteractionController` llama al método correspondiente.
8. InfoPanelController actualiza el título y la descripción según el componente reconocido.
9. Cuando se pierde el marcador, el contenido informativo se oculta.

## Decisiones de diseño

| Decisión | Alternativa descartada | Justificación |
|---|---|---|
| Uso de Vuforia Image Targets | Reconocimiento únicamente con AR Foundation | Vuforia permitió asociar imágenes específicas con cada componente de hardware. |
| Panel informativo dinámico | Un panel independiente por componente | Reduce duplicación de objetos UI y facilita el mantenimiento. |
| Un solo controlador de interacción | Un script distinto para cada componente | Centraliza la lógica y evita código repetido. |
| PlayerPrefs | Base de datos o API externa | Los datos almacenados son simples y solo se necesitan localmente. |
| Selección de modos en ExpoScene | Crear una escena adicional | Reduce la cantidad de escenas y simplifica la navegación. |

## Métricas de rendimiento

| Métrica | Objetivo | Resultado obtenido |
|---|---:|---:|
| FPS promedio | ≥ 30 FPS | ≥ 70 FPS |
| Tiempo de inicio | ≤ 5 segundos | ≤ 5 s |
| Componentes reconocidos | 5 | 5 |
| Casos de prueba ejecutados | ≥ 5 | 8 |
| Bugs documentados y cerrados | ≥ 3 | 5 |

