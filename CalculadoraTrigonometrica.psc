Algoritmo CalculadoraTrigonometrica
	Definir angulo, rad Como Real
    Definir opcion Como Entero
    
    Escribir "CALCULADORA TRIGONOMETRICA"
    Escribir "1. Seno"
    Escribir "2. Coseno"
    Escribir "3. Tangente"
    
    Escribir "Ingrese el angulo en grados:"
    Leer angulo
    
    rad <- angulo * PI / 180
    
    Escribir "Seleccione una opcion:"
    Leer opcion
    
    Segun opcion Hacer
        1:
            Escribir "Seno: ", Sen(rad)
        2:
            Escribir "Coseno: ", Cos(rad)
        3:
            Escribir "Tangente: ", Tan(rad)
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinAlgoritmo
