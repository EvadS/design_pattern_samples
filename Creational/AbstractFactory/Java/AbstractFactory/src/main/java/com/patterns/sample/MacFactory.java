package com.patterns.sample;

public class MacFactory extends GUIFactory {
    @Override
    Button createButton() {
        return  new MacButton();
    }

    @Override
    Checkbox createCheckbox() {
        return new MacCheckbox();
    }
}
