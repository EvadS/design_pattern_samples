package com.se.patterns.sample;

public class WebDialog extends Dialog {
    @Override
    Button createButton() {
        return new HTMLButton();
    }
}
