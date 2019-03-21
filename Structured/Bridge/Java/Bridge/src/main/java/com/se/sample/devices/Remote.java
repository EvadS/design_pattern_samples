package com.se.sample.devices;

/**
 * Общий интерфейс всех пультов ДУ
 */
public interface  Remote {
    void power();

    void volumeDown();

    void volumeUp();

    void channelDown();

    void channelUp();
}
