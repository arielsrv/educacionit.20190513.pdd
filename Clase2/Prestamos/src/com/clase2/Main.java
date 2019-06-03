package com.clase2;

public class Main {

    public static void main(String[] args) {
        double amount = 14000d;

        Approver employee = new Employee();
        Approver supervisor = new Supervisor();
        Approver manager = new Manager();

        employee.setNext(supervisor);
        supervisor.setNext(manager);

        employee.processRequest(amount);

        // Chain of responsibility
    }
}


abstract class Approver {
    protected Approver next;

    public void setNext(Approver next) {
        this.next = next;
    }

    public abstract void processRequest(double amount);
}

class Employee extends Approver {

    @Override
    public void processRequest(double amount) {
        if (amount > 0 && amount <= 10000) {
            System.out.println("I'm Employee, i can approve this. ");
        } else {
            next.processRequest(amount);
        }
    }
}

class Supervisor extends Approver {

    @Override
    public void processRequest(double amount) {
        if (amount > 10000 && amount <= 50000) {
            System.out.println("I'm Supervisor, i can approve this. ");
        } else {
            next.processRequest(amount);
        }
    }
}

class Manager extends Approver {

    @Override
    public void processRequest(double amount) {
        if (amount > 50000 && amount <= 500000) {
            System.out.println("I'm Manager, i can approve this. ");
        } else {
            System.out.println("Nobody approve this. ");
        }
    }
}
