package com.se.patterns.sample.сomputer;

public class ReachComputerBuilder extends ComputerBuilder {
    public void buildSystemBlock() {
        computer.setSystemBlock("Assus");
    }
    public void buildDisplay() {
        computer.setDisplay("HP");
    }
    public void buildManipulators() {
        computer.setManipulators("mouse+keyboard+sound");
    }
}