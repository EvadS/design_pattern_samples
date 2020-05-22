package com.example.demo.version1;

import com.example.demo.MailInfo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Map;

@Service
public class MailSender {

    @Autowired
    private Map<String, MailGenerator> map;


    public void send(MailInfo mailInfo) {
        String code = mailInfo.getTemplateCode();
        MailGenerator mailGenerator = map.get(code);
        if (mailGenerator == null) {
            throw new UnsupportedOperationException(code + " not supported yet.");
        }

        String html = mailGenerator.generate(mailInfo);

        sendMail(html);
    }

    private void sendMail(String html) {
        System.out.println("was sent : " + html);
    }
}
