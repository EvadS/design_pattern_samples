package com.patterns.sample;

public class Client {

    private Button button;
    private GUIFactory factory;

    Client(GUIFactory factory) {
         this.factory = factory;
     }
    void createUI() {
        this.button = factory.createButton();
    }
    void paint(){
        button.click();
    }

}
