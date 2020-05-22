package com.example.demo.version2;

import com.example.demo.MailInfo;
import com.example.demo.version1.MailGenerator;
import org.springframework.stereotype.Service;

import java.util.HashMap;
import java.util.Map;

@Service
public class MailSender_V2 {

    private Map<String, MailGenerator_V2> map =
            new HashMap<>();

    public void register(String code, MailGenerator_V2 generator) {
        map.put(code, generator);
    }


    public void send(MailInfo mailInfo) {
        String code = mailInfo.getTemplateCode();
        MailGenerator_V2 mailGenerator = map.get(code);
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
