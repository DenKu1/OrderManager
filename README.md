# OrderManager

Order Manager is a 3-layered .NET Framework WPF application.
To UI layer applied MVVM pattern.
The restaurant has a menu with different types of dishes. Kitchen has different cookers.
Dishes have different weights, different cooking times and different ones ingredients.
The customer has the opportunity to order a dish, then the application must display the time
preparation. Every chef in the kitchen has his own level, depending on which is faster or
cooks more slowly.
In addition, some types of dishes require the use of equipment (for example,
some stoves), which has a warm-up time when first used and after turning off some
time keeps the temperature. This affects the speed of cooking certain types of dishes, therefore
when calculating the time for cooking such dishes should take into account the current situation
equipment (assume that the time of its inclusion is equal to the time of the previous one
order this type of dish).

UML diagrams included:
+ class diagram
+ sequence diagram
+ use-case diagram

Main features:
+ Entity Framework Code first database
+ Services pattern and DTOs
+ Unit of work and repository patterns
+ MVVM pattern
+ Automapper
+ WPF model binding

Created for study purposes.

Created by DenKu1 (https://github.com/DenKu1)
