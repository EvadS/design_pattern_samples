package com.example.demo.version2;

import com.example.demo.MailInfo;
import org.springframework.stereotype.Component;

// id бина
@Component
public class WelcomeMainGeneratorV2Impl implements MailGenerator_V2 {

    @Override
    public String generate(MailInfo mailInfo) {
        return mailInfo.getContent() + "\n was welcome mail."  ;
    }

    @Override
    public String getMyCode() {
        return "3";
    }
}
