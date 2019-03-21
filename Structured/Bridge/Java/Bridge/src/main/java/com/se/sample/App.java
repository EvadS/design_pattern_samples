package com.se.sample;

import com.se.sample.devices.*;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        testDevice(new Tv());
        testDevice(new Radio());

        System.out.println( "Hello World!" );
    }

    public static void testDevice(Device device) {
        System.out.println("Tests with basic remote.");
        BasicRemote basicRemote = new BasicRemote(device);
        basicRemote.power();
        device.printStatus();

        System.out.println("Tests with advanced remote.");
        AdvancedRemote advancedRemote = new AdvancedRemote(device);
        advancedRemote.power();
        advancedRemote.mute();
        device.printStatus();
    }
}
