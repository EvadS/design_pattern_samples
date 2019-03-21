package com.patterns.sample;

public class MacButton implements Button {
    @Override
    public void click() {
        System.out.println(String.format("MacButton clicked" ));
    }
}
