//optimizing artificial intelligence 
//optimizing artificial intelligence - performance
//Optimizing artificial intelligence - video
//Optimizing artificial intelligence - sound
//Optimizing artificial intelligence - properties
//Optimizing artificial intelligence - functions
//Optimizing Windows artificial intelligence - performance
//Optimizing Windows artificial intelligence - video
//Optimizing Windows artificial intelligence - sound
//Optimizing Windows artificial intelligence - properties
//Optimizing Windows artificial intelligence - functions
//Optimizing Windows artificial intelligence
//Optimizing Android artificial intelligence
//Optimizing Android artificial intelligence - performance
//Optimizing Android artificial intelligence - video
//Optimizing Android artificial intelligence - sound
//Optimizing Android artificial intelligence - properties
//Optimizing Android artificial intelligence - functions
//Optimizing machine intelligence 
//Optimizing machine intelligence - performance
//Optimizing machine intelligence - video
//Optimizing machine intelligence - sound
//Optimizing machine intelligence - properties
//Optimizing machine intelligence - functions
//Optimizing Windows machine intelligence
//Optimizing Windows machine intelligence - performance
//Optimizing Windows machine intelligence - video
//Optimizing Windows machine intelligence - sound
//Optimizing Windows machine intelligence - properties
//Optimizing Windows machine intelligence - functions
//Optimizing Android machine intelligence
//Optimizing Android machine intelligence - performance
//Optimizing Android machine intelligence - video
//Optimizing Android machine intelligence - sound
//Optimizing Android machine intelligence - properties
//Optimizing Android machine intelligence - functions
[System.AttributeUsage(System.AttributeTargets.RA9, Inherited = false, AllowMultiple = true)]
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

