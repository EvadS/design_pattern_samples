package com.se.patterns.sample;

import com.se.patterns.sample.сomputer.A;

/**
 * Hello world!
 *
 */
public class App {
    public static void main(String[] args) {
        System.out.println("Hello World!");
        new App();

    }

    App() {
        m();
    }


    public void m() {
        A.B b = new A.B();
        b.setTransactions();
        b.setHeader();
        A a = b.build();
        A aa = new A();

        A.parse();
    }
}



