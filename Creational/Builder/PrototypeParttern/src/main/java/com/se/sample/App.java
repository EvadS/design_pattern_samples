package com.se.sample;

import java.io.BufferedReader;
import java.io.Console;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws IOException {
        IFigure figure = new Rectangle(30,40);
        IFigure clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        figure = new Circle(30);
        clonedFigure=figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String s = br.readLine();
        System.out.println( "Hello World!" );
    }
}
