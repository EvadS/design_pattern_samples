package com.se.sample;

//46
public class StandartOutputMessageRender implements  MessageRender {
    private MessageProvider messageProvider;
    @Override
    public void render() {

        if(messageProvider == null){
            throw  new RuntimeException(
                    "You must set the propertu message Render :" +
            StandartOutputMessageRender.class.getName());
        }

        System.out.println(messageProvider.getMessage());
    }

    @Override
    public MessageProvider getMessageProvider() {
        return messageProvider;
    }

    @Override
    public void setMessageProvider(MessageProvider messageProvider) {
this.messageProvider = messageProvider;
    }
}
