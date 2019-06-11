package com.clase4;

public class Main {

    public static void main(String[] args) {

        UserBuilder userBuilder = new UserBuilder();

        // User user = new User("jsanchez", "Capital ", 40, "Jorge", "Sanchez", "MALE");

        String word = "Hello world!";
        word
                .toString()
                .toString()
                .toString();

        User user = userBuilder
                .withNickname("jsanchez")
                .withAddress("Capital")
                .withAge(40)
                .withFirstName("Jorge")
                .withLastName("Sanchez")
                .isMale()
                    .build();

        // HttpBuilder builder = new HttpBuilder()
        // HttpRequest request = builder.isGet().withHeaders("", "").withUrl("http://...").withRetries(3).... etch..... build()
        // HttpRequest request = builder.isPost().withHeaders("", "").withUrl("http://...").withBody("{json}").withRetries(3).... etch..... build()

    }
}

class User {
    String nickname;
    String address;
    Integer age;
    String firstName;
    String lastName;
    String sex;

    public User(String nickname, String address, Integer age, String firstName, String lastName, String sex) {
        this.nickname = nickname;
        this.address = address;
        this.age = age;
        this.firstName = firstName;
        this.lastName = lastName;
        this.sex = sex;
    }
}


class UserBuilder {

    String nickname;
    String address;
    Integer age;
    String firstName;
    String lastName;
    String sex;

    public UserBuilder withNickname(String nickName) {
        this.nickname = nickName;
        return this;
    }

    public UserBuilder withAddress(String address) {
        this.address = address;
        return this;
    }

    public UserBuilder withAge(Integer age) {
        this.age = age;
        return this;
    }

    public UserBuilder withFirstName(String firstName) {
        this.firstName = firstName;
        return this;
    }

    public UserBuilder withLastName(String lastName) {
        this.lastName = lastName;
        return this;
    }

    public UserBuilder isMale() {
        this.sex = "MALE";
        return this;
    }

    public UserBuilder isFemale() {
        this.sex = "FEMALE";
        return this;
    }

    public User build(){
        return new User(this.nickname, this.address, this.age, this.firstName, this.lastName, this.sex);
    }
}