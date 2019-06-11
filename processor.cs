//Optimizing Processor
//Optimizing Processor - performance
//Optimizing Processor - video
//Optimizing Processor - sound
//Optimizing Processer - properties
//Optimizing Processor - functions
//Optimizing Preprocessor
//Optimizing Preprocessor - performance
//Optimizing Preprocessor - video
//Optimizing Preprocessor - sound
//Optimizing Preprocessor - properties
//Optimizing Preprocessor - functions
[System.AttributeUsage(System.AttributeTargets.Proc, Inherited = false, AllowMultiple = true)]
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
