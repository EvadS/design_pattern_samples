package com.example.demo.version1;

import com.example.demo.MailInfo;
import org.springframework.stereotype.Component;

@Component("2")
public class EmailCallbackMainGeneratorImpl implements MailGenerator {

    @Override
    public String generate(MailInfo mailInfo) {
        return mailInfo.getContent() + "\n don't call us.";
    }
}
