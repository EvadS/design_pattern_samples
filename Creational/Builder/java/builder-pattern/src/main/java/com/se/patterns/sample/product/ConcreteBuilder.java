package com.se.patterns.sample.product;

/**
 * конкретная реализация Buildera. Создает объект Product и определяет интерфейс для доступа к нему
 */
public class ConcreteBuilder extends Builder {

    Product product = new Product();

    @Override
    public void BuildPartA() {
        product.Add("Part A");
    }

    @Override
    public void BuildPartB() {
        product.Add("Part B");
    }

    @Override
    public void BuildPartC() {
        product.Add("Part C");
    }

    @Override
    public Product GetResult() {
        return product;
    }
}