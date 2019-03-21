package com.se.sample;

class Circle implements IFigure {
    int radius;

    public Circle(int r) {
        radius = r;
    }

    public IFigure Clone() {
        return new Circle(this.radius);
    }

    public void GetInfo() {
        System.out.println(String.format("Круг радиусом %s", radius));
    }
}