class GrandFather:
    def __init__(self, name="GrandFather", age=70):
        self.name = name
        self.age = age

    def infoFamilyGrandFather(self):
        print(self.name, self.age)

    class Uncle:
        def __init__(self, name="Uncle", age=45):
            self.name = name
            self.age = age

        def infoFamilyUncle(self):
            print(self.name, self.age)

    class Father:
        def __init__(self, name="Father", age=40):
            self.name = name
            self.age = age

        def infoFamilyFather(self):
            print(self.name, self.age)

        class Brother:
            def __init__(self, name="Brother", age=18):
                self.name = name
                self.age = age

            def infoFamilyBrother(self):
                print(self.name, self.age)

            class Niece:
                def __init__(self, name="Niece", age=3):
                    self.name = name
                    self.age = age

                def infoFamilyNiece(self):
                    print(self.name, self.age)

        class Me:
            def __init__(self, name="Me", age=20):
                self.name = name
                self.age = age

            def infoFamilyMe(self):
                print(self.name, self.age)

            class MyDog:
                def __init__(self, name="Dog", age=2):
                    self.name = name
                    self.age = age

                def infoDog(self):
                    print(self.name, self.age)


gf = GrandFather()
gf.infoFamilyGrandFather()

GrandFather.Uncle().infoFamilyUncle()
GrandFather.Father().infoFamilyFather()
GrandFather.Father.Brother().infoFamilyBrother()
GrandFather.Father.Brother.Niece().infoFamilyNiece()
GrandFather.Father.Me().infoFamilyMe()
GrandFather.Father.Me.MyDog().infoDog()
