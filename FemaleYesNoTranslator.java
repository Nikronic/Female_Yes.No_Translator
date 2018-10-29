import java.util.Random;
import java.util.Scanner;

public class FemaleYesNoTranslator {
    public static void main(String[] args) {

        System.out.println("Please enter yes or no");

        String answer = new Scanner(System.in).next();
        //input is actually not important, just wasting time!!!

        float number = new Random().nextFloat();
        
        if (number >= 0.5) {
            System.out.print("50% sure real answer is No");
        } else {
            System.out.print("50% sure real answer is Yes");
        }
    }
}
