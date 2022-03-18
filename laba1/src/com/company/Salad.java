package com.company;

import factory.EnumVegetable;
import vegetables.Vegetables;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Salad {
    private ArrayList<Vegetables> list = new ArrayList<Vegetables>();
    public void makeSalad(ArrayList<Vegetables> list) {
        this.list = list;
        if (list.isEmpty()) {
            System.out.println("You haven't added any ingredients yet!");

            return;
        }

        System.out.println("The salad contains:");
        for (Vegetables vegetable : list) {
            System.out.println(vegetable.toString());
        }
        System.out.println("*************************");
        System.out.println("Total energy: " + countCalories() + "kcal");
    }

    public double countCalories() {
        double calories = 0.0;

        for (Vegetables vegetable : list) {
            calories += vegetable.getTotalCalories();
        }

        return calories;
    }
}
