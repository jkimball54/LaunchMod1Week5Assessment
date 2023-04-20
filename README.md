# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
That variable doesn't exist in that context so you will get an error saying that it hasn't been defined yet.
2. Describe the three As of a test:  
A -   Arrange
A -   Act
A -   Assert
Arrange is seting up all the needed variables, objects, etc for the test. Act performing the actual logic that needs to be tested. Assert is the final step when you test the expected values against the values you got in the Act phase.
3. What is the difference between `public` and `private` access modifiers?
Public will allow a variable, method, or property to be accessed and changed from anywhere that has a reference to that class. Private is the opposite, only allowing these things to happen from within the class.
4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  
(B) Return some information about an object  
(C) Make changes to an object and return information about the object.  
(D) None of the Above.  
A & B, It is better to do one or the other in a method but not both. This is to keep methods complying with the SRP (Single Responsibility Principle).

5. How did you determine what to answer for the question above?
The word "and" in option C is a giveaway that the method wouldn't be SRP.
## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* DM a link to your forked repository to your instructors
