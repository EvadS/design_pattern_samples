package com.example.demo.version2;

import com.example.demo.MailInfo;
import com.example.demo.version2.MailSender_V2;
import org.springframework.beans.factory.annotation.Autowired;

public interface MailGenerator_V2 {
    String generate(MailInfo info);
    String getMyCode();

    // сеттер, тоже будет запущен
    @Autowired
    default  void registerMySelf(MailSender_V2 sender){
        sender.register(getMyCode(), this);
    }
}