package com.se.sample;

public class Rectangle implements IFigure {
    int width;
    int height;

    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    public IFigure Clone() {
        return new Rectangle(this.width, this.height);
    }

    public void GetInfo() {
        System.out.println(String.format("Прямоугольник длиной {%s} и шириной {%s}", height, width));
    }
}
