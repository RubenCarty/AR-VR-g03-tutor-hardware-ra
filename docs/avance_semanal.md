# Checklist de Avance Semanal — Tutor de Hardware PC en RA

## Semana 01-02: Investigación y planteamiento

- [x] Investigación de aplicaciones similares y referentes de realidad aumentada.
- [x] Definición del problema, usuario objetivo y contexto de uso.
- [x] Primera propuesta del proyecto presentada al docente.
- [x] Repositorio GitHub creado para el grupo.
- [x] Objetivo general, objetivos específicos y alcance inicial definidos.

**Evidencia:** informe del proyecto, análisis comparativo de aplicaciones similares y repositorio del grupo.

---

## Semana 03-04: Prototipo conceptual

- [x] MVP definido con las funcionalidades mínimas del proyecto.
- [x] Arquitectura técnica inicial planteada.
- [x] Flujo de navegación y estructura preliminar de pantallas definidos.
- [x] Proyecto Unity creado y configurado.
- [x] Vuforia Engine instalado y configurado.
- [x] Primera escena de realidad aumentada implementada.
- [x] Primer Image Target configurado para reconocer una placa madre.

**Evidencia:** proyecto Unity, primeras escenas, configuración de Vuforia e informe del prototipo inicial.

---

## Semana 05-06: Primera iteración

- [x] Menú principal implementado.
- [x] Escena de realidad aumentada funcionando.
- [x] Primera funcionalidad de reconocimiento AR implementada.
- [x] Image Target de placa madre configurado.
- [x] Información básica del componente mostrada al reconocer el marcador.
- [x] Aplicación ejecutada y validada desde Unity.

**Evidencia:** escenas `MenuScene` y `ARScene`, Image Target configurado y capturas del primer reconocimiento.

---

## Semana 07-08: Interacción y ampliación del prototipo

- [x] Interfaz básica implementada mediante Unity Canvas y TextMeshPro.
- [x] Botones de navegación configurados.
- [x] Panel informativo para los componentes implementado.
- [x] Reconocimiento ampliado a CPU, RAM, GPU, HDD y placa madre.
- [x] Etiquetas y explicaciones educativas incorporadas.
- [x] Aplicación probada en un dispositivo Android.
- [x] Flujo básico de aprendizaje validado.

**Evidencia:** escenas Unity, scripts de interacción, capturas del reconocimiento y prueba en dispositivo Android.

---

## Semana 09-10: Escenas y experiencia de usuario

- [x] Escena de exposición inicial implementada.
- [x] Información sobre el propósito y uso de la aplicación incorporada.
- [x] Selección entre modo aprendizaje y evaluación integrada en `ExpoScene`.
- [x] UI principal completada y organizada mediante Layout Groups.
- [x] Panel informativo dinámico reutilizable implementado.
- [x] Retroalimentación visual incorporada mediante indicadores, paneles y mensajes.
- [ ] Retroalimentación sonora implementada.

> La retroalimentación sonora no fue incluida en el alcance final del proyecto.

**Evidencia:** capturas de `ExpoScene`, `ARScene` y paneles informativos.

---

## Semana 11-12: Funcionalidades especiales

- [x] Interacción táctil implementada mediante Unity Input System.
- [x] Indicador “Toca para ver información” incorporado.
- [x] Detección de toques sobre zonas libres de la pantalla.
- [x] Bloqueo de toques realizados sobre botones y elementos UI.
- [x] Quiz interactivo implementado.
- [x] Validación de respuestas correctas e incorrectas.
- [x] Puntaje y retroalimentación durante la evaluación.
- [x] Pantalla de resultados implementada.
- [x] Almacenamiento local mediante `PlayerPrefs`.
- [ ] Integración de datos mediante API.
- [ ] Audio espacial configurado.

> La integración con API y el audio espacial no fueron necesarios para el funcionamiento ni para el alcance final de la aplicación.

**Evidencia:** scripts `ARInteractionController.cs`, `QuizManager.cs`, `ResultsManager.cs` y funcionamiento del módulo de evaluación.

---

## Semana 13-14: Calidad, accesibilidad y correcciones

- [x] Función de texto grande implementada.
- [x] Función de alto contraste implementada.
- [x] Persistencia de preferencias de accesibilidad entre escenas.
- [x] Pruebas funcionales internas realizadas.
- [x] Corrección del panel que mostraba información de un componente incorrecto.
- [x] Corrección de botones UI interpretados como toques sobre la escena AR.
- [x] Corrección del desplazamiento de elementos dentro de los Layout Groups.
- [x] Corrección de botones deformados al activar texto grande.
- [x] Corrección de respuestas del quiz configuradas con el mismo índice.

**Evidencia:** `PLAN_PRUEBAS.md`, `docs/BUGS.md`, scripts de accesibilidad y pruebas funcionales del prototipo.

---

## Semana 15-16: Integración y entrega final

- [x] Flujo completo de escenas implementado.
- [x] `MenuScene` finalizada.
- [x] `ExpoScene` finalizada.
- [x] `ARScene` finalizada.
- [x] `EvaluationScene` finalizada.
- [x] `ResultsScene` finalizada.
- [x] `ThanksScene` finalizada.
- [x] Reconocimiento de cinco componentes de hardware implementado.
- [x] Accesibilidad visual incorporada.
- [x] Código C# organizado dentro del proyecto Unity.
- [x] Arquitectura técnica documentada.
- [x] Bugs identificados y corregidos.
- [x] Plan de pruebas funcionales preparado.
- [X] README final completamente actualizado.
- [X] Capturas reales agregadas al repositorio.
- [X] FPS promedio registrado.
- [X] APK final nuevamente generado y validado.
- [X] Video demo de 2 a 3 minutos grabado y enlazado.
- [X] Presentación final de 10 minutos preparada.
- [X] Reflexión individual completada.
- [X] Pull Request final creado hacia la rama `main`.

**Evidencia final esperada:** proyecto Unity completo, scripts C#, documentación, capturas, plan de pruebas, registro de bugs, APK, video demo y Pull Request en GitHub.