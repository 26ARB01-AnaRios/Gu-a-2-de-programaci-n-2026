Algoritmo Conversor
	Definir valor Como Real
    Definir opcion Como Entero
    
    Escribir "1. Metros"
    Escribir "2. Pies"
    Escribir "3. Centimetros"
    Escribir "4. Pulgadas"
    
    Escribir "Ingrese valor:"
    Leer valor
    
    Escribir "Unidad destino:"
    Leer opcion
    
    Segun opcion Hacer
        1: Escribir "Metros: ", valor
        2: Escribir "Pies: ", valor * 3.28084
        3: Escribir "Centimetros: ", valor * 100
        4: Escribir "Pulgadas: ", valor * 39.3701
    FinSegun
FinAlgoritmo
