Algoritmo Impresoras
	Definir cantidad, forma Como Entero
    Definir precio, total, descuento, totalFinal Como Real
    
    precio <- 650 * 1.12
    
    Escribir "Cantidad de impresoras:"
    Leer cantidad
    
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta (5%)"
    Escribir "3. Vale (15%)"
    Leer forma
    
    total <- precio * cantidad
    
    Segun forma Hacer
        1: descuento <- total * 0.10
        2: descuento <- total * 0.05
        3: descuento <- total * 0.15
    FinSegun
    
    totalFinal <- total - descuento
    
    Escribir "Total sin descuento: ", total
    Escribir "Descuento: ", descuento
    Escribir "Total a pagar: ", totalFinal
FinAlgoritmo
