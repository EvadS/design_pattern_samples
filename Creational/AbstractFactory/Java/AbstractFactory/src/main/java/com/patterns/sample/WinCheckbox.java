package com.patterns.sample;

public class WinCheckbox implements  Checkbox {
    @Override
    public void paint() {
        System.out.println(String.format("WinCheckbox clicked" ));
    }
}
