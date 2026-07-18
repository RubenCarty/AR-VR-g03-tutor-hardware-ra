# Registro de Bugs — Tutor de Hardware PC en RA

## BUG-001 — Panel con información del componente incorrecto

| Campo | Detalle |
|---|---|
| Severidad | Mayor |
| Estado | CERRADO |
| Descripción | Al reconocer la RAM, el panel mostraba información del CPU. |
| Causa | El controlador activaba el panel sin identificar el componente reconocido. |
| Solución | Se agregó el enum TipoComponente y un switch para seleccionar la información correcta. |
| Verificación | Se probaron RAM, CPU, GPU, HDD y placa madre correctamente. |

## BUG-002 — El panel informativo mostraba siempre el componente CPU

| Campo | Detalle |
|---|---|
| Severidad | Media |
| Estado | CERRADO |
| Descripción | Independientemente del componente reconocido, el panel informativo mostraba siempre la información correspondiente al CPU. |
| Causa | El componente detectado no se actualizaba correctamente antes de abrir el panel de información. |
| Solución | Se corrigió la asignación del componente activo y se actualizó la lógica del `ARInteractionController` para enviar el tipo correcto al `InfoPanelController`. |
| Verificación | Cada marcador (CPU, RAM, GPU, HDD y placa madre) muestra ahora únicamente su información correspondiente. |

## BUG-003 — El contenido de ExpoScene cambiaba de posición

| Campo | Detalle |
|---|---|
| Severidad | Media |
| Estado | CERRADO |
| Descripción | El contenido se desplazaba al mostrar u ocultar el panel de información. |
| Causa | El panel era desactivado dentro de un Vertical Layout Group. |
| Solución | Se mantuvo el panel activo y se modificó solamente su contenido. |
| Verificación | El panel conserva una altura y ubicación fija. |

## BUG-004 — Botones deformados al activar texto grande

| Campo | Detalle |
|---|---|
| Severidad | Media |
| Estado | CERRADO |
| Descripción | Los textos se salían de los botones al activar A+. |
| Causa | El Layout Group sobrescribía el tamaño del RectTransform. |
| Solución | Se configuraron Layout Element y dimensiones preferidas. |
| Verificación | Los botones conservan proporciones adecuadas. |

## BUG-005 — Contenido AR persistente al perder el target

| Campo | Detalle |
|---|---|
| Severidad | Menor |
| Estado | CERRADO |
| Descripción | El contenido podía permanecer visible al retirar lentamente el Image Target. |
| Causa | Vuforia aceptaba estados de seguimiento limitado. |
| Solución | Se ajustó el reconocimiento para aceptar seguimiento TRACKED. |
| Verificación | El contenido desaparece cuando se pierde el seguimiento directo. |