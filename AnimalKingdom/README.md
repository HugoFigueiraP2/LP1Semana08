```mermaid
classDiagram
    class Bat 
    class Bee 
    class Cat 
    class Dog 
    class Animal 
    class ICanFly 
    <<interface>> ICanFly
    class IMammal
    <<interface>> IMammal

    Cat ..|> IMammal
    Dog ..|> IMammal
    Bat ..|> IMammal
    Bat ..|> ICanFly
    Bee ..|> ICanFly
    Cat --|> Animal 
    Bee --|> Animal
    Bat --|> Animal
    Dog --|> Animal
    Program --> Animal
    