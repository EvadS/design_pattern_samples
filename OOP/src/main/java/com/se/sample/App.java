package com.se.sample;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        Outer6 outer6 = new Outer6("Last Name .... ");

        Outer6.Inner6 inner = outer6.new Inner6("String 1", "String 2", "String 3");
        //Outer6.Inner6 inner6 = new Outer6.Inner6(0"F Name", "Man");

        System.out.println("------------------------");
        System.out.println(inner.toString());
        System.out.println("------------------------");


        System.out.println("Get from base ");
        outer6.setlName("New Last name");

        inner = outer6.new Inner6("String 1", "String 2");
        System.out.println(inner.toString());
        System.out.println("------------------------");

    }
}
