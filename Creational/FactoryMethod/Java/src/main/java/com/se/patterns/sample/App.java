package com.se.patterns.sample;

import java.util.concurrent.Callable;

/**
 * Hello world!
 */
public class App {
    private static Dialog dialog;
    private static Callable myFunction;

    static {
        myFunction = new Callable() {
            @Override
            public Object call() throws Exception {
                System.out.println("CALLABLE");

               return null;
            }
        };
    }

    private static void initialize() {
        dialog = new WindowsDialog();
    }

    public static void main(String[] args) throws Exception {
        initialize();
        dialog.renderWindow(myFunction);
        System.out.println("Hello World!");
    }
}
