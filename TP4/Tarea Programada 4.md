# Tarea Programada 4

| Curso                           | Programación Avanzada               |
| :------------------------------ | :---------------------------------- |
| Código                          | SC-601                              |
| Profesor                        | Luis Andrés Rojas Matey             |
| Fecha y hora de entrega inicial | Miércoles 9 de julio a las 9:00 pm  |
| Fecha y hora de entrega final   | Miércoles 16 de julio a las 6:00 pm |
| Valor                           | 4 %                                 |

<br />

## Introducción

Los números naturales tienen varias propiedades. Entre ellas se encuentran si son divisibles por dos (pares) y si son primos (solo divisibles por 1 y él mismo).

<br />

## Objetivo

Investigar y aplicar las capacidades del _library_ [`jQuery`](https://jquery.com) en una página web.

<br />

## Requisitos

Para este proyecto se utilizará una única página web (`index.html`), la cual deberá cargarse por medio de un servidor web (como por ejemplo [`IIS`](https://www.iis.net), [`Apache`](https://httpd.apache.org), [`nginx`](https://nginx.org), etc.) y, al cargarse en un navegador web, la misma referencia un _framework_ de estilos llamado [Pico](https://picocss.com) (dentro de la carpeta `css`) y el _library_ `jQuery` (en la carpeta `js`).

Se adjuntan los pasos para instalar y usar el servidor web llamado [`http-server`](https://github.com/http-party/http-server), en caso de que se quiera utilizar:

1. Instalar [**Node.js**](https://nodejs.org). Se recomienda la versión LTS o _Long-Term Support_ (**22.17.x**).

2. Instalar el paquete `http-server` y sus dependencias utilizando el sistema de gestión de paquetes [`npm`](https://www.npmjs.com):

```bash
$ npm install http-server
```

3. Ejecutar el servidor web:

```bash
$ npx http-server -c-1 .
```

Una vez ejecutado, se debería desplegar algo similar a esto:

```
Starting up http-server, serving .

http-server version: 14.1.1

http-server settings:
CORS: disabled
Cache: -1 seconds
Connection Timeout: 120 seconds
Directory Listings: visible
AutoIndex: visible
Serve GZIP Files: false
Serve Brotli Files: false
Default File Extension: none

Available on:
  http://127.0.0.1:8080
  http://192.168.100.238:8080
  http://192.168.100.175:8080
Hit CTRL-C to stop the server
```

Notar las opciones de dirección web indicadas para utilizarla(s) en un navegador web. Por ejemplo, al dirigirse a la dirección `http://localhost:8080` en el navegador, se abrirá automáticamente la página `index.html`. Dicha página muestra dos columnas: una llamada **Seleccionador**, que contiene tres _switches_; y otra llamada **Números**, que despliega una lista con los primeros cien números naturales a partir del 1.

<br />

## Especificaciones funcionales

La finalidad, en sentido general, es ocultar los números según los _switches_. Esto se logra agregando el componente denominado `oculto` al atributo `class` de un elemento específico, el cual ya está definido en el mismo archivo HTML:

```html
<style>
  .oculto {
    display: none;
  }
</style>
```

Se debe tener en cuenta que el único archivo que debe ser modificado es el HTML (`index.html`), específicamente el contenido del elemento `script`:

```html
<script defer>
  ...
</script>
```

Específicamente, se deben hacer las siguientes actividades:

1. Cambiar la lógica para utilizar **jQuery**.

2. Agregar la lógica para que el _switch_ **Impares** funcione.

3. Incluir la lógica para que el _switch_ **Primos** funcione.

<br />

### Cambiar la lógica para utilizar **jQuery**

Dentro de la sección **#1** del HTML, se debe cambiar el código (el cual está hecho con JavaScript "puro" o _vanilla_) utilizando **jQuery**. Técnicamente, esto implica listar los números naturales y agregar el componente `par` o `impar` en el atributo `class` de los números correspondientes. Tener en cuenta que también se debe cambiar la lógica del _switch_ a su equivalente con **jQuery**.

Como norma general, todo código que empiece con `document.` (como por ejemplo `document.createElement...` o `document.getElementById...`), así como los componentes/funciones que utiliza (por ejemplo `numeros.appendChild...` o `pares.addEventListener`) tienen su equivalente con **jQuery**.

<br />

### Agregar la lógica para que el _switch_ **Impares** funcione

Dentro de la sección **#2** del HTML, se debe agregar la lógica para incluir o excluir el componente `oculto` en el atributo `class` para los números impares, basado en el valor del _switch_ correspondiente, utilizando igualmente **jQuery**.

<br />

### Incluir la lógica para que el _switch_ **Primos** funcione

Similar a los puntos anteriores, dentro de la sección **#3** del archivo HTML, se debe agregar la lógica para que el _switch_ **Primos** funcione correctamente (ocultar los números primos) con **jQuery**. Para esto, primeramente se debe implementar el algoritmo denominado [Criba de Eratóstenes](https://es.wikipedia.org/wiki/Criba_de_Erat%C3%B3stenes) para obtener los números primos y, posteriormente, agregar el componente `primo` al atributo `class` de dichos números. Finalmente, se debe también incluir la lógica del _switch_, también con **jQuery**.

<br />

## Especificaciones técnicas

Como se indicó, todo lo necesario para mostrar la página web (incluyendo el _framework_ de CSS y **jQuery**) está incluido dentro del mismo proyecto, por lo que no se deben incluir más archivos (de CSS o JavaScript) o elementos adicionales de HTML, ya sea de estilos (`<style>`) o de lógica (`<script>`).

<br />

## Entregables

Al ser una tarea de carácter individual, se debe entregar un único archivo comprimido **ZIP** con el siguiente nombre: `TP4-[Carné].zip`. Ejemplo de nombre del archivo **ZIP**: `TP4-FH12345678.zip`.

El mismo debe contener únicamente lo siguiente:

- El archivo `index.html` con las modificaciones.

- Un archivo `README.md` con la documentación en [Markdown](https://www.markdownguide.org) donde se indique lo siguiente:

  - Su nombre, carné y el enlace al repositorio si lo subió a `GitHub`, `GitLab` o algún otro proveedor.

  - Páginas web donde halló posibles soluciones a problemas encontrados o _snippets_ de código.

  - _Prompts_ (consultas y respuestas) de los _chatbots_ de IA (`Copilot`, `Gemini`, `ChatGPT`, etc.) que haya utilizado.

<br />

## Evaluación

El proyecto será calificado según la rúbrica que se presenta en el programa del curso.
