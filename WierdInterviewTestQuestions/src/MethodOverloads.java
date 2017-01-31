import java.util.ArrayList;

public class MethodOverloads {

    // Which of the methods can be considered overloads of each other?
    // (choose the 2 right answers)

    public void read() { // METHOD1

    }

//    public String read() { // METHOD2
//        return null;
//    }

    ArrayList read(int a) { // METHOD3
        return null;
    }

    // a) METHOD1 and METHOD2 are overloads - NO
    // b) METHOD2 and METHOD3 are overloads - YES
    // c) METHOD3 and METHOD1 are overloads - YES
    // d) All methods are overloads of each other - NO

}
