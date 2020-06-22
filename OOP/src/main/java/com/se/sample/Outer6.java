package com.se.sample;

/**
 * @author Evgeniy Skiba on 23.06.2020
 * @project multiinheritance
 */

/**
 * @author Ar20L80
 */
class AnyClass {
    private String sex;

    public AnyClass(String sex) {
        this.sex = sex;
    }

    public String getSex() {
        return sex;
    }
} // класс от которого наследуем Inner6

public class Outer6 { // внешний класс

    private String lName;

    public void setlName(String lName) {
        this.lName = lName;
    }

    public Outer6(String lName) {
        this.lName = lName;
    }

    public class Inner6 extends AnyClass { // внутренний класс явно унаследован от "прилегающего"
        // тут мы унаследовали внутренний класс от  AnyClass{}
        // и можем расширить функциональность класса AnyClass{}
        // и класса Outer6

        private String fName;

        public Inner6(String fName, String lName, String sex) {
            super(sex);
            this.fName = fName;

            Outer6.this.lName = lName;
        }

        public Inner6(String fName, String sex) {
            super(sex);
            this.fName = fName;
        }

        @Override
        public String toString() {
            return "Inner6{" +
                    "fName='" + fName + '\'' +
                    "sex='" + super.getSex() + '\''+
                    "lName='" + Outer6.this.lName + '}';
        }
    }
}