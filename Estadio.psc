Algoritmo Estadio
	Definir sector, cantidad Como Entero
    Definir precio, total Como Real
	
    Escribir "1. Palco Q300"
    Escribir "2. Tribuna Q100 - Q125"
    Escribir "3. Preferencia Q50 - Q75"
    Escribir "4. Generales Q30 - Q50"
	
    Escribir "Seleccione sector:"
    Leer sector
	
    Segun sector Hacer
        1:
            precio <- 300
        2:
            precio <- 125
        3:
            precio <- 75
        4:
            precio <- 50
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
	
    Escribir "Cantidad de entradas:"
    Leer cantidad
	
    total <- precio * cantidad
	
    Escribir "Total a pagar: Q", total

FinAlgoritmo
