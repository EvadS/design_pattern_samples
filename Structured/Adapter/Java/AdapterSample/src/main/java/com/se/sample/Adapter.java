package com.se.sample;

// Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
// интерфейсом.
class Adapter implements Target {
    private Adaptee _adaptee;

    public Adapter(Adaptee adaptee) {
        this._adaptee = adaptee;
    }

    public String GetRequest() {
        return String.format("This is '%s'", this._adaptee.GetSpecificRequest());
    }
}