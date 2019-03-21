package com.patterns.sample;

public class MacCheckbox implements Checkbox {
    @Override
    public void paint() {
        System.out.println(String.format("MacCheckbox paint" ));
    }
}
