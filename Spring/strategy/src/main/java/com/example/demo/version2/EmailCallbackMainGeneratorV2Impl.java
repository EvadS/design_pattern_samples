package com.example.demo.version2;

import com.example.demo.MailInfo;
import org.springframework.stereotype.Component;

@Component
public class EmailCallbackMainGeneratorV2Impl implements MailGenerator_V2 {

    @Override
    public String generate(MailInfo mailInfo) {
        return mailInfo.getContent() + "\n don't call us.";
    }

    @Override
    public String getMyCode() {
        return "1";
    }
}
