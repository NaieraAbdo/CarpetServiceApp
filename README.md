int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");

1. why the output of this Equation = $30.00?
                                                                                                لانها format speceifier بتحط الرقم في شكل فورمات ال currency اللي هو العمله بالدولار وممكن تحدد العمله.
   
3. what is its benefit?
                                                                                                        بتسهل عليا اني احط الداتا في شكل معين انا عايزه و بتديني اوبشنز اكتر للشكل اللي احط عليه الداتا.
   
4. try another example with a different specifier with a screenshot of the output.
                Console.WriteLine($"Y In Percent is:{ Y:p}");
output: Y In Percent is:2,000.00%
