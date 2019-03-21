package com.se.patterns.sample;

import java.awt.event.ActionListener;
import java.util.concurrent.Callable;

public abstract class Dialog<T> {

    void renderWindow(Callable<T> func) throws Exception {
        // Чтобы использовать фабричный метод, вы должны
        // убедиться в том, что эта бизнес-логика не зависит от
        // конкретных классов продуктов. Button — это общий
        // интерфейс кнопок, поэтому все хорошо.
        Button okButton = createButton();
        okButton.onClick(func);
        okButton.render();
    }

    // Мы выносим весь код создания продуктов в особый метод,
    // который назвают "фабричным".
    abstract Button createButton();
}
