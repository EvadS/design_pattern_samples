package com.patterns.sample;

public class WinButton implements  Button {
    @Override
    public void click() {
        System.out.println(String.format("WinButton clicked" ));
    }
}
