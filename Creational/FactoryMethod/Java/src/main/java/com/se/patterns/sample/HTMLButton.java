package com.se.patterns.sample;

import java.awt.event.ActionListener;
import java.util.concurrent.Callable;

public class HTMLButton implements Button{
    @Override
    public void render() {
        System.out.println("Вернуть HTML-код кнопки");
    }

    @Override
    public void onClick(Callable func) throws Exception {
        System.out.println("Навесить на кнопку обработчик событий HTML");

        System.out.println("before --> ");
        func.call();
        System.out.println("after <--");
    }



}
