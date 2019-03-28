package com.se.patterns.sample;

public interface ProfileIterator {
    boolean hasNext();

    Profile getNext();

    void reset();
}