package com.patterns.sample;

// Абстрактная фабрика знает обо всех абстрактных типах
// продуктов.
public abstract class GUIFactory {
    abstract Button createButton();
    abstract Checkbox createCheckbox();
}
