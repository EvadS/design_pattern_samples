package com.se.patterns.sample;

import java.io.File;

/**
 * Интерфейс подписчиков
 */
public interface EventListener {
    void update(String eventType, File file);
}
