#include <iostream>
using namespace std;

class GrandFather {
public:
    string name;
    int age;

    GrandFather(string name="GrandFather", int age=70) {
        this->name = name;
        this->age = age;
    }

    void infoFamilyGrandFather() {
        cout << name << " " << age << endl;
    }

    class Uncle {
    public:
        string name;
        int age;

        Uncle(string name="Uncle", int age=45) {
            this->name = name;
            this->age = age;
        }

        void infoFamilyUncle() {
            cout << name << " " << age << endl;
        }
    };

    class Father {
    public:
        string name;
        int age;

        Father(string name="Father", int age=40) {
            this->name = name;
            this->age = age;
        }

        void infoFamilyFather() {
            cout << name << " " << age << endl;
        }

        class Brother {
        public:
            string name;
            int age;

            Brother(string name="Brother", int age=18) {
                this->name = name;
                this->age = age;
            }

            void infoFamilyBrother() {
                cout << name << " " << age << endl;
            }

            class Niece {
            public:
                string name;
                int age;

                Niece(string name="Niece", int age=3) {
                    this->name = name;
                    this->age = age;
                }

                void infoFamilyNiece() {
                    cout << name << " " << age << endl;
                }
            };
        };

        class Me {
        public:
            string name;
            int age;

            Me(string name="Me", int age=20) {
                this->name = name;
                this->age = age;
            }

            void infoFamilyMe() {
                cout << name << " " << age << endl;
            }

            class MyDog {
            public:
                string name;
                int age;

                MyDog(string name="Dog", int age=2) {
                    this->name = name;
                    this->age = age;
                }

                void infoDog() {
                    cout << name << " " << age << endl;
                }
            };
        };
    };
};

int main() {
    GrandFather gf;
    gf.infoFamilyGrandFather();

    GrandFather::Uncle().infoFamilyUncle();
    GrandFather::Father().infoFamilyFather();
    GrandFather::Father::Brother().infoFamilyBrother();
    GrandFather::Father::Brother::Niece().infoFamilyNiece();
    GrandFather::Father::Me().infoFamilyMe();
    GrandFather::Father::Me::MyDog().infoDog();
}
