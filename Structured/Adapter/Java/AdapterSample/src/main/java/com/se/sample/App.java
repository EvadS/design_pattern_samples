package com.se.sample;


public class App {

    public static void main(String[] args) {
        Adaptee adaptee = new Adaptee();
        Target target = new Adapter(adaptee);

        System.out.println("Adaptee interface is incompatible with the client.");
        System.out.println("But with adapter client can call it's method.");

        System.out.println(target.GetRequest());
    }
}