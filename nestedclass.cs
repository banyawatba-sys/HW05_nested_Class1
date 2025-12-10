using System;

class GrandFather {
    public string name;
    public int age;

    public GrandFather(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public GrandFather() : this("GrandFather", 70) {}

    public void infoFamilyGrandFather() {
        Console.WriteLine(name + " " + age);
    }

    public class Uncle {
        public string name;
        public int age;

        public Uncle(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public Uncle() : this("Uncle", 45) {}

        public void infoFamilyUncle() {
            Console.WriteLine(name + " " + age);
        }
    }

    public class Father {
        public string name;
        public int age;

        public Father(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public Father() : this("Father", 40) {}

        public void infoFamilyFather() {
            Console.WriteLine(name + " " + age);
        }

        public class Brother {
            public string name; 
            public int age;

            public Brother(string name, int age) {
                this.name = name;
                this.age = age;
            }

            public Brother() : this("Brother", 18) {}

            public void infoFamilyBrother() {
                Console.WriteLine(name + " " + age);
            }

            public class Niece {
                public string name; 
                public int age;

                public Niece(string name, int age) {
                    this.name = name;
                    this.age = age;
                }

                public Niece() : this("Niece", 3) {}

                public void infoFamilyNiece() {
                    Console.WriteLine(name + " " + age);
                }
            }
        }

        public class Me {
            public string name; 
            public int age;

            public Me(string name, int age) {
                this.name = name;
                this.age = age;
            }

            public Me() : this("Me", 20) {}

            public void infoFamilyMe() {
                Console.WriteLine(name + " " + age);
            }

            public class MyDog {
                public string name; 
                public int age;

                public MyDog(string name, int age) {
                    this.name = name;
                    this.age = age;
                }

                public MyDog() : this("Dog", 2) {}

                public void infoDog() {
                    Console.WriteLine(name + " " + age);
                }
            }
        }
    }
}

class Program {
    static void Main() {
        GrandFather gf = new GrandFather();
        gf.infoFamilyGrandFather();

        GrandFather.Uncle u = new GrandFather.Uncle();
        u.infoFamilyUncle();

        GrandFather.Father f = new GrandFather.Father();
        f.infoFamilyFather();

        GrandFather.Father.Brother b = new GrandFather.Father.Brother();
        b.infoFamilyBrother();

        GrandFather.Father.Brother.Niece n = new GrandFather.Father.Brother.Niece();
        n.infoFamilyNiece();

        GrandFather.Father.Me me = new GrandFather.Father.Me();
        me.infoFamilyMe();

        GrandFather.Father.Me.MyDog d = new GrandFather.Father.Me.MyDog();
        d.infoDog();
    }
}
