//Optimizing Core and Shell
//Optimizing Core and Shell - performance
//Optimizing Core and Shell - properties
//Optimizing Core and Shell - video
//Optimizing Core and Shell - sound
//Optimizing Core and Shell - functions
//Optimizing Windows Core and Shell
//Optimizing Windows Core and Shell - performance
//Optimizing Windows Core and Shell - properties
//Optimizing Windows Core and Shell - video
//Optimizing Windows Core and Shell - functions
//Optimizing Windows Core and Shell - sound
//Optimizing Android Core and Shell
//Optimizing Android Core and Shell - performance
//Optimizing Android Core and Shell - properties
//Optimizing Android Core and Shell - video
//Optimizing Android Core and Shell - functions
//Optimizing Android Core and Shell - sound
[System.AttributeUsage(System.AttributeTargets.CAS, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    readonly string positionalString;
    
    // This is a positional argument
    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;
        
        // TODO: Implement code here
        throw new System.NotImplementedException();
    }
    
    public string PositionalString
    {
        get { return positionalString; }
    }
    
    // This is a named argument
    public int NamedInt { get; set; }
}
