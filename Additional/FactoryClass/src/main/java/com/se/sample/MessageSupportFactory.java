package com.se.sample;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.security.Provider;
import java.util.Properties;

public class MessageSupportFactory {

    private  static  MessageSupportFactory instance;

    private  Properties properties;
    private MessageRender render;
    private MessageProvider provider;

    public MessageSupportFactory() {
        properties = new Properties();

        try{
            properties.load(new FileInputStream(
                    "com/se/sample/msf.properties"));

            String renderClass = properties.getProperty("render.class");
            String providerClass = properties.getProperty("provider.class");

            render = (MessageRender)Class.forName(renderClass).newInstance();
            provider = (MessageProvider)Class.forName(renderClass).newInstance();

        }
        catch (FileNotFoundException ex){

        } catch (IllegalAccessException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (InstantiationException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }


    }

    static {
        instance = new MessageSupportFactory();
    }

    public static MessageSupportFactory getInstance() {
        return instance;
    }

    public MessageRender getRender() {
        return render;
    }

    public MessageProvider getProvider() {
        return provider;
    }
}
