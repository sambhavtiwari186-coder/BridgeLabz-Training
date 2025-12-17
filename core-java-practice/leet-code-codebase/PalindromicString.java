import java.util.*;
public class PalindromicString{
    public static void main(String[] args) {
        // Take the Input String Here
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter a string: ");
        String str = sc.nextLine();
        // Logic to test if the the String is Palindromic or Not
        String originalStr = str;
        String reversed = "";

        for (int i = str.length() - 1; i >= 0; i--) {
            reversed = reversed + str.charAt(i);
        }
        if (originalStr.equals(reversed)) {
            System.out.println(originalStr + " is a Palindromic String");
        } else {
            System.out.println(originalStr + " is NOT a Palindromic String");
        }
    }
}