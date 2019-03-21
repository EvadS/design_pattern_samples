package com.se.patterns.sample.сomputer;

public abstract  class ComputerBuilder {
    protected Computer computer;

    public Computer getComputer() {
        return computer;
    }

    public void createNewComputer() {
        buildDisplay();
        buildSystemBlock();
        buildManipulators();
    }

    public abstract void buildDisplay();
    public abstract void buildSystemBlock();
    public abstract void buildManipulators();




}
