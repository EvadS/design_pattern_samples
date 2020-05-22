package com.example.demo;

import lombok.Builder;
import lombok.Data;

@Data
@Builder(toBuilder = true)
public class MailInfo {
    private  String content;
    private  String templateCode;
}
