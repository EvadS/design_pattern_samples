package com.se.patterns.sample.product;

/**
 * определяет интерфейс для создания различных частей объекта Product
 */
public abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    public abstract Product GetResult();
}