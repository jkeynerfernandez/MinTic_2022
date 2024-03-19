/*
Ejercicios para la clase Persona


Crear una función que se encargue de recibir 2 parámetros (nombres, apellidos) 

la función deberá retornar el siguiente mensaje “Hola bienvenido {nombres} {apellidos}”

Crear una función que se encargue de recibir 1 parámetro (frase) “ejemplo de la frase: Hoy es un día muy frío” a partir de esa frase mostrar el número de palabras que conforman la frase.

Crear una función que se encargue de recibir 1 parámetro (una contraseña) y determine si cumple con ciertos criterios de seguridad, como longitud mínima, presencia de letras mayúsculas, minúsculas y números.


Se considera nivel bajo si

La contraseña cuenta con 0-10 caracteres.

La contraseña no cuenta con caracteres especiales.

La contraseña no cuenta con números.

Se considera nivel medio si

la contraseña cuenta con 0-12 caracteres.

la contraseña no cuenta con caracteres especiales.

Se considera nivel alto si
      - la contraseña cuenta con 8-40 carácteres y tiene combinación de 

caracteres especiales, letras (minúsculas y mayúsculas) y números
*/


namespace Clases{

    public class Persona{


        public string Saludar(string nombres, string apellidos ){

            return $" Hola! bienvenido {nombres} {apellidos} ";

        }

        public string ContarPalabras(string frase){

            string[] palabras = frase.Split(" ") ;
            int longitud = palabras.Length;

          
            return $"las frase {frase} contienen {longitud} palablas";




        }
        





    }

}