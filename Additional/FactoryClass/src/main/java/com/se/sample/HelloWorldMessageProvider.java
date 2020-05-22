package com.se.sample;

public class HelloWorldMessageProvider  implements MessageProvider{
    @Override
    public String getMessage() {
        return "Hello world !!";
    }
}
