package com.clase4;

public class Main {

    public static void main(String[] args) {
	    ICalculadora calculadora = new CalculadoraConLog();

	    Integer resultado = calculadora.suma(2, 3);
        System.out.println(resultado);
    }
}

interface ICalculadora {
    Integer suma(Integer a, Integer b);
    Integer resta(Integer a, Integer b);
}

class CalculadoraConLog implements ICalculadora {

    ICalculadora calculadora = new Calculadora();

    @Override
    public Integer suma(Integer a, Integer b) {
        // Log.info("sumando dos numeros... user: apineiro");
        return calculadora.suma(a, b);
    }

    @Override
    public Integer resta(Integer a, Integer b) {
        // Log.info("restando dos numeros... user: apineiro");
        return calculadora.resta(a, b);
    }
}

class Calculadora implements ICalculadora {

    @Override
    public Integer suma(Integer a, Integer b) {
        return a + b;
    }

    @Override
    public Integer resta(Integer a, Integer b) {
        return a - b;
    }
}