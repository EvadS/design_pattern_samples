package com.se.sample;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {

        MessageRender mr = new StandartOutputMessageRender();
        MessageProvider mp = new HelloWorldMessageProvider();

        mr.setMessageProvider(mp);
        mr.render();

    }
}
