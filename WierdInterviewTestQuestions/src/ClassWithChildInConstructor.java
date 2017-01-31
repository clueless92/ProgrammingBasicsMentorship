/**
 * Created by Todor Ilchev on 2017-01-19.
 */
public class ClassWithChildInConstructor {

    // is this allowed in Java?

    private class Phone {

        Phone() {
        }

        Phone(SmartPhone phone) {

        }
    }

    private class SmartPhone extends Phone {

    }

}
