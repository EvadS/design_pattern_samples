package com.se.patterns.sample.product;

import java.util.ArrayList;
import java.util.List;

/**
 * представляет объект, который должен быть создан. В данном случае все части объекта заключены в списке parts.

 */
public class Product
{
    List<Object> parts = new ArrayList<>();
    public void Add(String part)
    {
        parts.add(part);
    }
}