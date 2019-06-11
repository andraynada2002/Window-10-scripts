//Optimizing AGP
//Optimizing AGP - performance
//Optimizing AGP - video
//Optimizing AGP - sound
//Optimizing AGP - properties
//Optimizing AGP - functions
[System.AttributeUsage(System.AttributeTargets.AGP, Inherited = false, AllowMultiple = true)]
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
