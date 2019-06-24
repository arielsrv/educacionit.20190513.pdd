import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        Stock goog = new Stock("GOOG", 1080.38d);

        Notificable Jorge = new Investor("Jorge");
        Notificable Juan = new Investor("Juan");
        Notificable Maria = new Investor("Maria");

        goog.subscribe(Jorge);
        goog.subscribe(Juan);
        goog.subscribe(Maria);

        goog.setPrice(1080.40d);
        goog.setPrice(1081.40d);
        goog.setPrice(1070.40d);
    }
}


class Stock {
    String name;
    Double price;
    ArrayList<Notificable> notificables = new ArrayList<>();

    public void subscribe(Notificable notificable) {
        this.notificables.add(notificable);
    }

    public Stock(String name, Double price) {
        this.name = name;
        this.price = price;
    }

    public void setPrice(Double price) {
        this.price = price;
        onChangePrice();
    }

    private void onChangePrice() {
        for (Notificable notificable : notificables) {
            notificable.update(this);
        }
    }
}

interface Notificable {
    void update(Stock stock);
}

class Investor implements Notificable {
    String name;
    Stock stock;

    public Investor(String name) {
        this.name = name;
    }

    @Override
    public void update(Stock stock) {
        System.out.println("Cambió el precio, ahora tomaré una decisión...");
    }
}

class LcdDisplay implements Notificable {

    @Override
    public void update(Stock stock) {
        System.out.println("Change price to show...");
    }
}