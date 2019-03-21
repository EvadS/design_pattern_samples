package com.se.patterns.sample;
import java.awt.event.ActionListener;
import java.util.concurrent.Callable;

// Паттерн Фабричный метод применим тогда, когда в программе
// есть иерархия классов продуктов.
public interface Button<T> {
    void render();
    void onClick(Callable<T> func) throws Exception;
}