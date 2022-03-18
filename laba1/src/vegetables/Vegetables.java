package vegetables;

import com.company.Salad;

import java.util.Arrays;

public abstract class Vegetables extends Salad {
    private String name;
    private String category;
    public double calories_vegetable;
    private double k;
    public Vegetables(String name) {
        this.name = name;
    }
    public Vegetables(String name,double calories,double k) {
        if (calories < 0) {
            throw new IllegalArgumentException("Cannot create vegetable with "
                    + calories + "kcal");
        }
        this.name = name;
        this.calories_vegetable= calories;
        this.k = k;
    }
    public String getName() {
        return name;
    }
    public double getCalories() {
        return calories_vegetable;
    }
    public String getCategory() {
        return category;
    }
    protected void setName(String name) {
        this.name = name;
    }
    protected void setCategory(String category) {
        this.category = category;
    }
    public double getTotalCalories() {
        return calories_vegetable * k ;
    }
    public String toString(){
        return name;
    }
}
