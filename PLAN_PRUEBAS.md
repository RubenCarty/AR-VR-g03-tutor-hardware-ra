# Plan de Pruebas — Tutor de Hardware PC en RA

## TC-001 — Navegación al módulo de exposición

| Campo | Detalle |
|---|---|
| Precondición | La aplicación se encuentra en MenuScene. |
| Pasos | 1. Pulsar “Iniciar experiencia”. |
| Resultado esperado | Se abre ExpoScene sin errores. |
| Resultado obtenido | ExpoScene se abrió correctamente. |
| Estado | PASA |

## TC-002 — Reconocimiento de RAM

| Campo | Detalle |
|---|---|
| Precondición | ARScene abierta y permiso de cámara habilitado. |
| Pasos | 1. Enfocar el Image Target de RAM. |
| Resultado esperado | Aparecen las etiquetas y el indicador táctil. |
| Resultado obtenido | La RAM fue reconocida correctamente. |
| Estado | PASA |

## TC-003 — Apertura del panel mediante toque

| Campo | Detalle |
|---|---|
| Precondición | Existe un Image Target reconocido. |
| Pasos | 1. Tocar una zona libre de la pantalla. |
| Resultado esperado | Se abre el panel informativo del componente reconocido. |
| Resultado obtenido | El panel mostró la información correcta. |
| Estado | PASA |

## TC-004 — Botones de accesibilidad

| Campo | Detalle |
|---|---|
| Precondición | Una escena con accesibilidad está abierta. |
| Pasos | 1. Activar Texto grande. 2. Activar Alto contraste. |
| Resultado esperado | Los textos aumentan y los colores cambian correctamente. |
| Resultado obtenido | Ambas opciones funcionaron sin errores. |
| Estado | PASA |

## TC-005 — Persistencia de accesibilidad

| Campo | Detalle |
|---|---|
| Precondición | Texto grande o alto contraste activado. |
| Pasos | 1. Cambiar a otra escena. |
| Resultado esperado | La configuración permanece activa. |
| Resultado obtenido | La preferencia se conservó mediante PlayerPrefs. |
| Estado | PASA |

## TC-006 — Respuesta correcta en la evaluación

| Campo | Detalle |
|---|---|
| Precondición | EvaluationScene abierta. |
| Pasos | 1. Seleccionar una alternativa correcta. |
| Resultado esperado | Se muestra retroalimentación positiva y aumenta el puntaje. |
| Resultado obtenido | La respuesta fue validada correctamente. |
| Estado | PASA |

## TC-007 — Respuesta incorrecta en la evaluación

| Campo | Detalle |
|---|---|
| Precondición | EvaluationScene abierta. |
| Pasos | 1. Seleccionar una alternativa incorrecta. |
| Resultado esperado | Se muestra retroalimentación correctiva. |
| Resultado obtenido | La aplicación indicó que la respuesta era incorrecta. |
| Estado | PASA |

## TC-008 — Visualización de resultados

| Campo | Detalle |
|---|---|
| Precondición | Todas las preguntas fueron respondidas. |
| Pasos | 1. Finalizar la evaluación. |
| Resultado esperado | Se muestra el puntaje, porcentaje y mensaje final. |
| Resultado obtenido | ResultsScene mostró los datos correctamente. |
| Estado | PASA |