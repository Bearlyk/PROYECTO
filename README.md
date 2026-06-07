# MENU DE TORNEOS 1.0

Aplicacion de escritorio en C# Windows Forms para administrar torneos, jugadores, partidas, posiciones, historial y estadisticas. El proyecto mantiene una programacion simple, con `struct`, arreglos, archivos `.txt` y ciclos `for`/`while`.

## Estado Actual

El proyecto ya incluye:

- Flujo principal basado en torneos.
- Creacion y seleccion de torneos.
- Registro, busqueda y eliminacion de jugadores por torneo.
- Registro de partidas por torneo.
- Tabla de posiciones.
- Historial filtrado por torneo.
- Estadisticas con media, mediana, moda, porcentajes, probabilidad y matriz de puntajes.
- Formularios editables desde el Designer de Visual Studio.
- Estilo visual oscuro en formularios principales.
- Tipografia retro `OCR A Extended`.

## Requisitos

- Windows.
- Visual Studio con soporte para Windows Forms y .NET Framework.
- .NET Framework 4.7.2 Developer Pack.
- Fuente `OCR A Extended` instalada. Normalmente viene incluida en Windows.
- Permisos de escritura en la carpeta donde se ejecuta el programa para poder crear los archivos `.txt`.

## Compilar

Desde la carpeta del proyecto:

```powershell
cd ".\MENU DE TORNEOS 1.0"
dotnet msbuild ".\MENU DE TORNEOS 1.0.csproj" /p:GenerateResourceMSBuildArchitecture=CurrentArchitecture /p:GenerateResourceUsePreserializedResources=true
```

El ejecutable se genera en:

```text
bin/Debug/MENU DE TORNEOS 1.0.exe
```

Tambien se puede abrir `MENU DE TORNEOS 1.0.csproj` desde Visual Studio y compilar desde la interfaz.

## Ejecutar

Desde la carpeta del proyecto compilado:

```powershell
& ".\bin\Debug\MENU DE TORNEOS 1.0.exe"
```

## Archivos TXT

La aplicacion guarda los datos en archivos `.txt`.

No es necesario crear los archivos manualmente. Si no existen, el programa los crea automaticamente cuando se guarda informacion.

Los archivos usados son:

```text
datosTorneos.txt
datosJugador.txt
datosPartidas.txt
```

Actualmente las rutas son relativas, por lo tanto los archivos se crean en la carpeta desde donde se ejecuta el programa.

Si ejecutas desde Visual Studio o desde el `.exe` compilado, normalmente se crean en:

```text
MENU DE TORNEOS 1.0/bin/Debug/
```

Ejemplo:

```text
MENU DE TORNEOS 1.0/bin/Debug/datosTorneos.txt
MENU DE TORNEOS 1.0/bin/Debug/datosJugador.txt
MENU DE TORNEOS 1.0/bin/Debug/datosPartidas.txt
```

Si se ejecuta desde otra carpeta, los archivos se crearan en esa carpeta de ejecucion.

## Formato De Datos

Formato de torneo:

```text
TOR-01|COPA MAYO|LIGA|31/05/2026|ACTIVO
```

Formato de jugador:

```text
TOR-01|JUG-01|MARCO|MAKI|9|3|0|1|4|25|17
```

Campos del jugador:

```text
idTorneo|id|nombre|apodo|puntaje|ganados|empatados|perdidos|partidasJugadas|puntosAFavor|puntosEnContra
```

Formato de partida:

```text
TOR-01|PAR-01|JUG-01|JUG-02|MARCO|LUIS|5|3|MARCO|31/05/2026|FINALIZADA|LIGA
```

Campos de la partida:

```text
idTorneo|idPartida|idJugador1|idJugador2|nombreJugador1|nombreJugador2|puntajeJugador1|puntajeJugador2|ganador|fecha|estado|tipoTorneo
```

## Flujo De Uso

1. Entrar a la aplicacion.
2. Abrir `TORNEOS`.
3. Crear o seleccionar un torneo.
4. Registrar jugadores para ese torneo.
5. Registrar partidas entre jugadores del torneo.
6. Revisar posiciones, estadisticas e historial.

Si no hay torneo seleccionado, el menu bloquea los modulos de jugadores, partidas, posiciones, estadisticas e historial.

## Formularios

### Form1

Pantalla inicial con boton para entrar al menu.

### MENU

Pantalla principal. Incluye:

- Torneos
- Jugadores
- Partidas
- Clasificacion
- Estadistica
- Historial
- Salir

Tambien muestra el torneo actualmente seleccionado.

### TORNEOS

Permite:

- Crear torneo.
- Elegir tipo de torneo.
- Listar torneos.
- Seleccionar torneo activo.

Tipos disponibles:

```text
LIGA
TODOS_CONTRA_TODOS
ELIMINACION
```

### JUGADORES

Permite:

- Registrar jugador.
- Buscar jugador.
- Eliminar jugador sin partidas registradas.
- Mostrar jugadores del torneo actual en un `ListBox`.

### PARTIDAS

Permite:

- Seleccionar dos jugadores del torneo actual.
- Registrar puntajes.
- Calcular ganador o empate.
- Actualizar puntos, victorias, empates, derrotas y diferencia.
- Guardar la partida en archivo `.txt`.

### POSICIONES

Muestra la tabla de posiciones del torneo actual.

Ordena por:

- Puntaje.
- Partidas ganadas.
- Diferencia de puntos.

### ESTADISTICAS

Calcula sobre el torneo actual:

- Total de jugadores.
- Total de partidas.
- Media de puntajes.
- Mediana de puntajes.
- Moda de puntajes.
- Jugador con mas victorias.
- Jugador con mas derrotas.
- Probabilidad de victoria, empate y derrota.
- Matriz de puntajes.
- Suma de filas de la matriz.

### HISTORIAL

Permite:

- Mostrar partidas del torneo actual.
- Buscar por jugador.
- Buscar por ganador.

## Algebra Lineal Y Estadistica

La integracion academica esta en el formulario `ESTADISTICAS`.

La matriz de puntajes usa filas y columnas como jugadores:

```text
matriz[i, j]
```

Donde:

- `i` representa el jugador.
- `j` representa el rival.
- El valor representa los puntos anotados por `i` contra `j`.

La suma de una fila representa el total de puntos anotados por un jugador contra todos sus rivales.

Las estadisticas usan operaciones simples:

```text
media = suma de puntajes / cantidad de jugadores
porcentajeVictorias = ganados / partidasJugadas * 100
diferenciaPuntos = puntosAFavor - puntosEnContra
```

## Estructura Principal

```text
MENU DE TORNEOS 1.0/
  README.md
  .gitignore
  MENU DE TORNEOS 1.0/
    MENU DE TORNEOS 1.0.csproj
    MENU DE TORNEOS 1.0.slnx
    Program.cs
    global.cs
    Form1.cs
    MENU.cs
    TORNEOS.cs
    JUGADORES.cs
    PARTIDAS.cs
    POSICIONES.cs
    ESTADISTICAS.cs
    HISTORIAL.cs
    SALIR.cs
    *.Designer.cs
    *.resx
    App.config
```

## Notas De Desarrollo

- Se usan `struct`, no clases propias para los datos.
- No se usa `foreach`.
- No se usa LINQ.
- No se usan lambdas.
- Los formularios principales estan disponibles para editar desde Visual Studio Designer.
- Los controles nuevos fueron movidos a sus archivos `Designer.cs`.
- Los fondos originales de `Form1`, `MENU` y `JUGADORES` se cargan desde sus `.resx`.
