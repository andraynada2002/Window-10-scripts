//Optimizing FPU
//FPU optimizing
//Optimizing FPU quality
//Optimizing FPU performance
//Optimizing FPU - video
//Optimizing FPU - sound
//Optimizing FPU - performance
//Optimizing FPU - properties
//Optimizing FPU - functions
[System.AttributeUsage(System.AttributeTargets.FPU, Inherited = false, AllowMultiple = true)]
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



