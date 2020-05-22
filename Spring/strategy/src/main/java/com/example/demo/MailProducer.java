package com.example.demo;

import com.example.demo.MailInfo;
import com.example.demo.version1.MailSender;
import com.example.demo.version2.MailSender_V2;
import com.github.javafaker.Faker;
import lombok.AllArgsConstructor;
import org.springframework.scheduling.annotation.Scheduled;
import org.springframework.stereotype.Service;

@Service
@AllArgsConstructor
public class MailProducer {

    // TODO: uncomment for  testing version 1
//    private MailSender mailSender;

    private MailSender_V2 mailSender;

    private final Faker faker =  new Faker();

    // for version 1
    @Scheduled(fixedDelay = 1000)
    public  void generatedMail(){
        MailInfo mailInfo = MailInfo.builder()
                .content(faker.chuckNorris().fact())
                /* у нас 2 бина, при попытке дернуть 3 - й UnsupportedOperationException */
                .templateCode(String.valueOf(faker.random().nextInt(3)+1))
                .build();

        mailSender.send(mailInfo);
    }
}
