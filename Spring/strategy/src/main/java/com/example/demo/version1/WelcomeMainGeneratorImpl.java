package com.example.demo.version1;

import com.example.demo.MailInfo;
import org.springframework.stereotype.Component;

// id бина
@Component("1")
public class WelcomeMainGeneratorImpl implements MailGenerator {

    @Override
    public String generate(MailInfo mailInfo) {
        return mailInfo.getContent() + "\n was welcome mail."  ;
    }
}
