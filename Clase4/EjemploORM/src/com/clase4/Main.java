package com.clase4;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        User user = new User(123, "jorgesanchez");
        Item item = new Item(123, user, "Iphone 8x como nuevo", 10000.0d);


        // Modelo tipico de acceso a datos (repository pattern)
        // IUserDao userDao = new UserDao();
        // IDataAccess... (variante1)
        // IRepository<User> (variante2)....
        // User user = userDao.getById(123);

    }
}

class User {
    Integer id;
    String nickname;
    ArrayList<Item> items;

    public User(Integer id, String nickname) {
        this.id = id;
        this.nickname = nickname;
    }

    public Integer getId() {
        return id;
    }

    public String getNickname() {
        return nickname;
    }

    public ArrayList<Item> getItems() {
        return items;
    }
}

class Item {
    Integer id;
    User user;
    String title;
    Double price;

    public Item(Integer id, User user, String title, Double price) {
        this.id = id;
        this.user = user;
        this.title = title;
        this.price = price;
    }

    public Integer getId() {
        return id;
    }

    public User getUser() {
        return user;
    }

    public String getTitle() {
        return title;
    }

    public Double getPrice() {
        return price;
    }
}