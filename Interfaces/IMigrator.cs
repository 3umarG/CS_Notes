namespace Interfaces
{
    /*
     * Interface is Pure Abstraction way 
     * can't have any concrete methods
     * all methods is abstract by them self
     * all derived classed should override/impelemnt all methods
     * 
     * ********* NOT for multiple inheritance ***********
     * HOW !!!!!!!!!!!
     * because inheritance means that there is methods and attributes you can derive and use from the child class
     * 
     * BUT .. when using interfaces there is not concrete methods or attributes ... you should write very thing with your own implementation
     * 
     * 
     * also Interfaces used fro improving Testability by using FakeClasses from Interface
     * 
     * 
     * at the end Interfaces used for improving Extensionability 
     * "Open for Extension - Closed for Modification"
     * 
     */
    interface IMigrator
    {
        void Migrate();
    }
}