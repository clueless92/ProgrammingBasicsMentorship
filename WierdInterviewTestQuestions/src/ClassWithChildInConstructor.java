/**
 * Created by Todor Ilchev on 2017-01-19.
 */
public class ClassWithChildInConstructor {

    private class Phone {
        Phone() {
        }

        Phone(Phone phone) {

        }

        Phone(SmartPhone phone) {

        }
    }

    private class SmartPhone extends Phone {

        SmartPhone(SmartPhone phone) {
            super(phone);
        }
    }

}
