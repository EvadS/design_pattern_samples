package com.se.patterns.sample.product;

/**
 * распорядитель - создает объект, используя объекты Builder
 */
public class Director
{
    Builder builder;
    public Director(Builder builder)
    {
        this.builder = builder;
    }
    public void Construct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}