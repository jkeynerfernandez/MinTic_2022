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
using System;
using System.Text;

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

        public string ConprobarPassword(string password){
            /*Se considera nivel bajo si

            La contraseña cuenta con 0-10 caracteres.
            La contraseña no cuenta con caracteres especiales.
            La contraseña no cuenta con números.

            Se considera nivel medio si

            la contraseña cuenta con 0-12 caracteres.
            la contraseña no cuenta con caracteres especiales.

            Se considera nivel alto si

            - la contraseña cuenta con 8-40 carácteres y tiene combinación de 

            caracteres especiales, letras (minúsculas y mayúsculas) y números*/


            int longitud= password.Length;
            List<int> numeric = new List<int>;// Esta lista va a contener el valor de cada caracter 
            IEnumerable<int> numerosAZ = Enumerable.Range(65, 90);//numeros de la A -Z ascci
            IEnumerable<int> numerosaz = Enumerable.Range(97, 122);//numeros de la a -z ascci

            bool mayuculas = false;
            bool minusculas = false;
            bool caracteresEspeciales= false;

            foreach (var item in password)//esre ciclo recorre cada valor 
            {
                numeric.add((int)item) // convierte cada caracter en entero, su respectivo ascci gracias  a using System; y using System.Text;

                
            }

            for (int i = 0; i < password.length; i++){ //ciclo que comprueba si tiene caracteres especiales, mayusculas, minusculas
                        
                        if (password[i] in numerosAZ) //contiene al menos 1 mayuscula
                        {
                            mayusculas = true;

                        }else if (password[i] in numerosaz){ // contienen almenos 1 minuscula 
                            
                            minusculas = true;

                        }else{
                            caracteresEspeciales = true;
                        }



            }


            if (longitud >=8 && longitud <=40 ){ //comprobar longitud.

                

                    if(mayusculas==true && minusculas == true && caracteresEspeciales == true){

                        return "password de nivel alto";

                    }

            }else if(longitud >=0 && longitud <=12  ){

                if (caracteresEspeciales== true){
                    return "password de nivel medio";
                }


            }    
        }        

            




        

        
        





    }

}