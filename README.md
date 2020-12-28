## Detalles de la implementación

- Se agregó la clase Impresora la cual es la encargada de imprimir las formas.
- En el método Imprimir se utilizó un diccionario donde la clave es el nombre de la forma y el valor es un objeto del tipo Almacenamiento. De esta forma el metodo queda generico y si se agregan nuevas formas no hace falta modificarlo.
- La clase FormaGeometrica ahora es abstracta y padre de las distintas formas (Circulo, Cuadrado, TrianguloEquilatero, Trapecio, Rectangulo).
- Para los idiomas se utilizó el patrón Strategy.
- Para obtener el nombre de las figuras se utilizó el patrón Double dispatch, por eso en la Clase Almacenamiento se agregó el atributo UltimaFormaEncontrada.
- Se agregaron más test unitarios.