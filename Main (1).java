class GrandFather {
    String name;
    int age;

    // Constructor
    public GrandFather(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public GrandFather() {
        this("GrandFather", 70);
    }

    // Method
    public void infoFamilyGrandFather() {
        System.out.println(name + " " + age);
    }

    // Inner class Uncle
    class Uncle {
        String name;
        int age;

        Uncle(String name, int age) {
            this.name = name;
            this.age = age;
        }

        Uncle() {
            this("Uncle", 45);
        }

        public void infoFamilyUncle() {
            System.out.println(name + " " + age);
        }
    }

    // Inner class Father
    class Father {
        String name;
        int age;

        Father(String name, int age) {
            this.name = name;
            this.age = age;
        }

        Father() {
            this("Father", 40);
        }

        public void infoFamilyFather() {
            System.out.println(name + " " + age);
        }

        // Brother
        class Brother {
            String name;
            int age;

            Brother(String name, int age) {
                this.name = name;
                this.age = age;
            }

            Brother() {
                this("Brother", 18);
            }

            public void infoFamilyBrother() {
                System.out.println(name + " " + age);
            }

            // Niece
            class Niece {
                String name;
                int age;

                Niece(String name, int age) {
                    this.name = name;
                    this.age = age;
                }

                Niece() {
                    this("Niece", 3);
                }

                public void infoFamilyNiece() {
                    System.out.println(name + " " + age);
                }
            }
        }

        // Me
        class Me {
            String name;
            int age;

            Me(String name, int age) {
                this.name = name;
                this.age = age;
            }

            Me() {
                this("Me", 20);
            }

            public void infoFamilyMe() {
                System.out.println(name + " " + age);
            }

            // Dog
            class MyDog {
                String name;
                int age;

                MyDog(String name, int age) {
                    this.name = name;
                    this.age = age;
                }

                MyDog() {
                    this("Dog", 2);
                }

                public void infoDog() {
                    System.out.println(name + " " + age);
                }
            }
        }
    }
}

public class Main {
    public static void main(String[] args) {

        GrandFather gf = new GrandFather();
        gf.infoFamilyGrandFather();

        GrandFather.Uncle uncle = gf.new Uncle();
        uncle.infoFamilyUncle();

        GrandFather.Father father = gf.new Father();
        father.infoFamilyFather();

        GrandFather.Father.Brother brother = father.new Brother();
        brother.infoFamilyBrother();

        GrandFather.Father.Brother.Niece niece = brother.new Niece();
        niece.infoFamilyNiece();

        GrandFather.Father.Me me = father.new Me();
        me.infoFamilyMe();

        GrandFather.Father.Me.MyDog dog = me.new MyDog();
        dog.infoDog();
    }
}
