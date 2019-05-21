package com.clase2;

public class Main {

    public static void main(String[] args) {
	    // Tipicamente ante consultas a una base

        // 1. Abrir una conexión
        // 2. Ejecuta la consulta (sujeto a la consulta)
        // 3. Se cierra la conexion

        // Result result = new CustomerDao().execute()
        // Result result = new ProductDao().execute()

        BaseDao customerDao = new CustomerDao();
        customerDao.execute();

        BaseDao productDao = new ProductDao();
        productDao.execute();
    }
}


abstract class BaseDao {

    // Método plantilla (o template method)
    void execute() {
        openConnection();
        query();
        closeConnection();
    }

    public void openConnection() {
        System.out.println("Opening connection...");
    }

    public void closeConnection() {
        System.out.println("Closing connection...");
    }

    public abstract void query();
}

class CustomerDao extends BaseDao {

    @Override
    public void query() {
        System.out.println("SELECT * FROM Customers");
    }
}

class ProductDao extends BaseDao {

    @Override
    public void query() {
        System.out.println("SELECT * FROM Products");
    }
}

abstract class MyClass {
    public abstract void operation1();
    public abstract void operation2();
    public abstract void operation3();

    void execute() {
        operation1();
        operation2();
        operation3();
    }
}

class ConcreteClass1 extends MyClass {

    @Override
    public void operation1() {

    }

    @Override
    public void operation2() {

    }

    @Override
    public void operation3() {

    }
}


