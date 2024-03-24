# Trabajo practico Nro 2

- [Trabajo practico Nro 2](#trabajo-practico-nro-2)
  - [1\_ Determinar el valor de las siguientes expresiones: Recordar que la prioridad de las operaciones es como en matemática, la multiplicación y división y luego la suma y resta](#1_-determinar-el-valor-de-las-siguientes-expresiones-recordar-que-la-prioridad-de-las-operaciones-es-como-en-matemática-la-multiplicación-y-división-y-luego-la-suma-y-resta)
  - [2\_ Construir tabla de verdad para determinar el valor lógico de la siguiente expresión: Como en la Teoría](#2_-construir-tabla-de-verdad-para-determinar-el-valor-lógico-de-la-siguiente-expresión-como-en-la-teoría)
  - [3\_ Escribir expresiones lógico-matemáticas para expresar los siguientes conceptos](#3_-escribir-expresiones-lógico-matemáticas-para-expresar-los-siguientes-conceptos)
  - [4\_ ¿Qué valores devuelven las siguientes asignaciones?](#4_-qué-valores-devuelven-las-siguientes-asignaciones)
  - [5\_ Desarrollar Algoritmos para: DESARROLLAR UN EJEMPLO CON NÚMEROS PREVIO](#5_-desarrollar-algoritmos-para-desarrollar-un-ejemplo-con-números-previo)
    - [a\_ La cajera de un supermercado desea calcular el vuelto de una compra realizada](#a_-la-cajera-de-un-supermercado-desea-calcular-el-vuelto-de-una-compra-realizada)
      - [Algoritmo\_A](#algoritmo_a)
      - [Traza\_A](#traza_a)
    - [b\_  Expresar la capacidad de un disco rígido de Megabytes a Gigabytes (1Gb = 1024 Mb)](#b_--expresar-la-capacidad-de-un-disco-rígido-de-megabytes-a-gigabytes-1gb--1024-mb)
      - [Algoritmo\_B](#algoritmo_b)
      - [Traza\_B](#traza_b)
    - [c\_ Hacer un algori tmo para determinar el tiempo que durará un viaje en auto, conociendo la velocidad constante a la que se conduce y la distancia a recorrer. (Tener en cuenta el cálculo de velocidad)](#c_-hacer-un-algori-tmo-para-determinar-el-tiempo-que-durará-un-viaje-en-auto-conociendo-la-velocidad-constante-a-la-que-se-conduce-y-la-distancia-a-recorrer-tener-en-cuenta-el-cálculo-de-velocidad)
      - [Algoritmo\_C](#algoritmo_c)
      - [Traza\_C](#traza_c)
    - [d\_ Dado el tamaño de una foto en bytes y otra en Kilobytes, cuánto ocuparan en total juntas en Mb para enviarlas por mail. (1Kb = 1024 bytes y 1Mb= 1024 Kb)](#d_-dado-el-tamaño-de-una-foto-en-bytes-y-otra-en-kilobytes-cuánto-ocuparan-en-total-juntas-en-mb-para-enviarlas-por-mail-1kb--1024-bytes-y-1mb-1024-kb)
      - [Algoritmo\_D](#algoritmo_d)
      - [Traza\_D](#traza_d)
    - [e\_ En una clase se desea saber qué % de mujeres y cual de varones hay con respecto al total. Conociendo la cantidad de cada sexo](#e_-en-una-clase-se-desea-saber-qué--de-mujeres-y-cual-de-varones-hay-con-respecto-al-total-conociendo-la-cantidad-de-cada-sexo)
      - [Algoritmo\_E](#algoritmo_e)
      - [Traza\_E](#traza_e)
    - [f\_ Se sabe que un pintor necesita 0.5 litros de pintura por metro cuadrado de pared a pintar. Determinar la cantidad de pintura necesaria para dar 4 manos de pintura a una pared rectangular](#f_-se-sabe-que-un-pintor-necesita-05-litros-de-pintura-por-metro-cuadrado-de-pared-a-pintar-determinar-la-cantidad-de-pintura-necesaria-para-dar-4-manos-de-pintura-a-una-pared-rectangular)
      - [Algoritmo\_F](#algoritmo_f)
      - [Traza\_F](#traza_f)
    - [g\_ Calcular el salario de un operador dada la tarifa horaria y el número de horas trabajadas diariamente. Suponer que trabaja 30 días al mes y que las retenciones son el 20% del sueldo bruto](#g_-calcular-el-salario-de-un-operador-dada-la-tarifa-horaria-y-el-número-de-horas-trabajadas-diariamente-suponer-que-trabaja-30-días-al-mes-y-que-las-retenciones-son-el-20-del-sueldo-bruto)
      - [Algoritmo\_G](#algoritmo_g)
      - [Traza\_G](#traza_g)

## 1_ Determinar el valor de las siguientes expresiones: Recordar que la prioridad de las operaciones es como en matemática, la multiplicación y división y luego la suma y resta

a. 4/2= *2*

b. 6-1* = *4*

c. 4 // 2 = *0*

d. 8<>8? = *falso*

e. 4/e 2 = *2*

## 2_ Construir tabla de verdad para determinar el valor lógico de la siguiente expresión: Como en la Teoría

(dia >=1 ) y ( dia <= 31) para los valores 2, 34, y 1.

| *valor dia* | *dia >=1* | *dia <=31* | *and* |
|-----------|---------|----------|-----|
| *2*      |  true   | true     | *true*|
| *34*      |  true   | false     | *false*|
| *1*      |  true   | true     | *true*|

## 3_ Escribir expresiones lógico-matemáticas para expresar los siguientes conceptos

Comprobar la validez de las mismas usando tablas para diferentes valores y analizando los resultados
obtenidos.

a. Num es un número par.

| *valor num* | *valor num // 2* | *num // 2 == 0* |
|-------------|------------------|-----------------|
| *2*         |  0               | true            |
| *34*        |  0               | true            |
| *1*         |  1               | false           |
| *13*        |  1               | false           |

b. Num tiene al menos dos dígitos.

| *valor num* | *valor absoluto num*    | *valor abs > 9*   | and   |
|-------------|-------------------------|-------------------|-------|
| *2*         |  2                      | false             | false |
| *34*        |  34                     | true              | true  |
| *1*         |  1                      | false             | false |
| *-13*       |  -13                    | true              | true  |
| *133*       |  133                    | true              | false |

c. Num es múltiplo de x y múltiplo de 4.

| *valor num* | *valor x*  | *num mod x == 0* | *num mod x == 0* |  and   |
|-------------|------------|------------------|------------------|--------|
| *4*         |  *4*       | true             | true             | true   |
| *34*        |  *3*       | false            | false            | false  |
| *1*         |  *1*       | true             | true             |  true  |
| *13*        |  *1*       | false            | true             |  false  |

## 4_ ¿Qué valores devuelven las siguientes asignaciones?

a. *Mes <-- 2*                Rta.: 2

b. *Mes <-- Mes*              Rta.: 2 (Suponiendo que mes sigue valiendo lo asignado en inciso a)

c. *Mes <--  9 * Mes +1*      Rta.: 19 (Suponiendo que mes sigue valiendo lo asignado en inciso a)

d. *Mes <-- Num //3*          Rta.: 1

e. *Mes <-- 6 / 4*            Rta.: 1.5

## 5_ Desarrollar Algoritmos para: DESARROLLAR UN EJEMPLO CON NÚMEROS PREVIO

### a_ La cajera de un supermercado desea calcular el vuelto de una compra realizada

#### Algoritmo_A

```Swift
 AlgoritmoCalculoVueltoCompra

DE :
    valorCompra ∈ R+
    montoPagado ∈ R+
DS: 
    vuelto ∈ R+

Comienzo
    vuelto <--  montoPagado - valorCompra

Fin.
```

#### Traza_A

| valorCompra | montoPagado | vuelto |
|-------------|-------------|--------|
|   1200      |     1500    | 300    |
|   22200     |     30000   | 7800   |

### b_  Expresar la capacidad de un disco rígido de Megabytes a Gigabytes (1Gb = 1024 Mb)

#### Algoritmo_B

```Swift
 AlgoritmoConvercionMbToGb

DE :
    cantidadMb ∈ R+
DC:
    mbToGb = 1024    
DS: 
    cantidadGb ∈ R+

Comienzo
    cantidadGb <--  cantidadMb / mbToGb
Fin.
```

#### Traza_B

| cantidadMb  | cantidadGb |
|-------------|------------|
|   1200      | 1.17       |
|   22200     | 22.67      |

### c_ Hacer un algori tmo para determinar el tiempo que durará un viaje en auto, conociendo la velocidad constante a la que se conduce y la distancia a recorrer. (Tener en cuenta el cálculo de velocidad)

#### Algoritmo_C

```Swift
 CalculoDuracionViaje

DE :
    velocidad ∈ R+
    distancia ∈ R+
DS: 
    tiempo ∈ R

Comienzo
    tiempo <--  distancia / velociad
Fin.
```

#### Traza_C

| velocidad   | distancia  |  tiempo |
|-------------|------------|---------|
|   120       | 200        | 1.66    |
|   200.5     | 2000       | 9.97    |

### d_ Dado el tamaño de una foto en bytes y otra en Kilobytes, cuánto ocuparan en total juntas en Mb para enviarlas por mail. (1Kb = 1024 bytes y 1Mb= 1024 Kb)

#### Algoritmo_D

```Swift
 AlgoritmoCalculoTamañoConvertidoAMbFotos
DE:
    pesoFotoEnB ∈ R+
    pesoFotoEnKb ∈ R+
DC:
    factorDeConvercion <-- 1024
DA:
    bToKb  ∈ R+
DS: 
    pesoFotosEnMb ∈ R+

Comienzo
    bToKb <-- pesoFotoEnB / factorConvercion
    pesoFotosEnMb <-- (pesoFotoEnKb + bToKb) / factorConvercion
Fin.

```

#### Traza_D

| pesoFotoEnB   | pesoFotoEnKb  |  bToKb  | pesoFotosEnMb |
|---------------|---------------|---------|---------------|
|   3000        | 200           | 2.92    | 0.198         |
|   24400       | 2000          | 23.82   | 1.97          |

### e_ En una clase se desea saber qué % de mujeres y cual de varones hay con respecto al total. Conociendo la cantidad de cada sexo

#### Algoritmo_E

```Swift
 AlgoritmoCalculoCantidadAlumnosPorSexo
DE:
    cantidadAlumnos ∈ N
    cantidadAlumnas ∈ N
DA:
    cantidadTotalAlumnos ∈ N
DS: 
    porcentajeAlumnas ∈ N
    porcentajeAlumnos ∈ N

Comienzo
    cantidadTotalAlumnos <-- cantidadAlumnos + cantidadAlumnas

    porcentajeAlumnas <-- (cantidadAlumnas * 100) /e cantidadTotalAlumnos
    porcentajeAlumnos <-- (cantidadAlumnos * 100) /e cantidadTotalAlumnos

Fin.

```

#### Traza_E

| cantidadAlumnos   | cantidadAlumnas  |  cantidadTotalAlumnos  | porcentajeAlumnas | porcentajeAlumnos |
|-------------------|------------------|------------------------|-------------------|-------------------|
|   344             | 200              | 544                    | 36.76             | 63.24             |
|   24400           | 2000             | 26400                  | 7.58              | 92.42             |

### f_ Se sabe que un pintor necesita 0.5 litros de pintura por metro cuadrado de pared a pintar. Determinar la cantidad de pintura necesaria para dar 4 manos de pintura a una pared rectangular

#### Algoritmo_F

```Swift
 CalculoCantidadDePinturaPorMetrosCuadrados
DE:
    metrosAPintar ∈ R+
    cantidadManos ∈ N
DA:
    cantidadPorMano ∈ R+
DC:
    litrosPorMetro <-- 0.5
DS: 
    cantidadTotal ∈ R+

Comienzo
    cantidadPorMano <-- metrosAPintar *  litrosPorMetro
    cantidadTotal <-- cantidadPorMano * cantidadManos

Fin.

```

#### Traza_F

|   metrosAPintar   | cantidadManos  |  cantidadPorMano  | cantidadTotal |
|-------------------|----------------|-------------------|---------------|
|   23              | 3              | 11.5              | 34.5          |
|   588             | 6              | 294               | 1764          |

### g_ Calcular el salario de un operador dada la tarifa horaria y el número de horas trabajadas diariamente. Suponer que trabaja 30 días al mes y que las retenciones son el 20% del sueldo bruto

#### Algoritmo_G

```Swift
 CalculoSueldoNeto
DE:
    tarifaHoraria ∈ R+
    horasTrabajadas ∈ N
DA:
    sueldoBruto ∈ R+
DC:
    diasTrabajados <-- 30
    retenciones <-- 0.2
DS: 
    sueldoNeto ∈ R+

Comienzo
    
    sueldoBruto <-- tarifaHoraria * horasTrabajadas * diasTrabajados
    sueldoNeto <-- sueldoBruto - (sueldoBruto * retenciones)

Fin.

```

#### Traza_G

|   tarifaHoraria   | horasTrabajadas  |  sueldoBruto  | sueldoNeto |
|-------------------|------------------|---------------|------------|
|   1220            | 5                | 183000        | 146400     |
|   5000            | 6                | 900000        | 720000     |
