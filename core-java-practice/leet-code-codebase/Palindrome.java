import java.util.*;
public class Palindrome{
    public static void main  (String[] args){
        // Take Input
         Scanner sc = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int num = sc.nextInt();
        // Code to find if the number is Palindromic or Not
        int originalNum = num;
        int reversed = 0;

        while (num != 0) {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;
        }

        if (originalNum == reversed) {
            System.out.println(originalNum + " is a Palindromic Number");
        } else {
            System.out.println(originalNum + " is NOT a Palindromic Number");
        }
    }
}