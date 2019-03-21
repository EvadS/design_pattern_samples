package com.se.patterns.sample.сomputer;

import java.util.List;

public class A {

    private boolean finished;

    private A() {

    }

    public static A parse(byte[] bytes) {
        return new A();
    }

    public byte[] getBytes() {
        if (!finished) {
            throw new RuntimeException();
        }
        validate();
        return null;
    }

    public boolean validate() {
        return false;
    }

    public static class B {

        private BlockHeader header;
        private List<Transaction> transactions;

        public B() {
        }

        public B setTransactions(List<Transaction> transactions) {
            this.transactions = transactions;
            return this;
        }

        public B setHeader(BlockHeader header) {

            this.header = header;
            return this;
        }

        public A build() {
            A a = new A();
            a.setHeader(header);
            a.setTransactions(transactions);
            a.validate();
            return a;
        }
    }

    private void setTransactions(List<Transaction> transactions) {
    }

    private void setHeader(BlockHeader header) {
    }
}
