package com.se.patterns.sample;

import java.awt.event.ActionListener;
import java.util.concurrent.Callable;

public class WindowsButton implements Button {
    @Override
    public void render() {
        System.out.println(" Отрисовать кнопку в стиле Windows.");
    }

    @Override
    public void onClick(Callable func) throws Exception {
        System.out.println("Навесить на кнопку обработчик событий Windows");

        System.out.println("before --> ");
        func.call();
        System.out.println("after <--");

    }

}
