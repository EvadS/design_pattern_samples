package com.example.demo.version2;

import com.example.demo.MailInfo;
import org.springframework.stereotype.Component;

/**
 * @author Evgeniy Skiba on 22.05.2020
 * @project demo
 */
@Component
public class HappyBirthDay  implements MailGenerator_V2 {

    @Override
    public String generate(MailInfo mailInfo) {
        return mailInfo.getContent() + "\n was happy birth day mail.";
    }

    @Override
    public String getMyCode() {
        return "2";
    }
}