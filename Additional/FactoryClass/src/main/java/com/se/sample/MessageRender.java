package com.se.sample;

public interface MessageRender {
    void render();
    MessageProvider getMessageProvider();
    void setMessageProvider(MessageProvider messageProvider);
}
