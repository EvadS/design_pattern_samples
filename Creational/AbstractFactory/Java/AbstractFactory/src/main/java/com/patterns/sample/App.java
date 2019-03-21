package com.patterns.sample;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {

        GUIFactory factory = new WinFactory();
        Client client = new Client(factory);

        client.createUI();
        client.paint();

        System.out.println( "Hello World!" );
    }
}
