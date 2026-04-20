Algoritmo Tipocaracter
	Definir c Como Caracter
    
    Escribir "Ingrese un caracter:"
    Leer c
    
    Si c >= "0" Y c <= "9" Entonces
        Escribir "Es un digito"
    Sino
        Segun c Hacer
            "a","e","i","o","u","A","E","I","O","U":
                Escribir "Es una vocal"
            De Otro Modo:
                Escribir "No es vocal ni digito"
        FinSegun
    FinSi
FinAlgoritmo
