using Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("ruta", () => "Hello World!");

app.MapGet("calculadora/sumar",() => {
    Calculadora calculadora = new Calculadora();
    
    
    return calculadora.Sumar(1,2);
    
});

app.MapGet("calculadora/resta",() => {
    Calculadora calculadora = new Calculadora();
    
    
    return calculadora.Restar(1,2);
    
});

app.MapGet("calculadora/multiplicar",() => {
    Calculadora calculadora = new Calculadora();
    
    
    return calculadora.Multiplicar(1,2);
    
});

app.MapGet("calculadora/dividir",() => {
    Calculadora calculadora = new Calculadora();
    
    
    return calculadora.Dividir(1,2);
    
});

app.MapGet("persona/contarPalabras",() => {
    Persona persona1 = new Persona();
    
    
    return persona1.ContarPalabras("Hola, minombre es keyner fernandez y soy de bello");
    
    
});


app.Run();