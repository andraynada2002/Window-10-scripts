//Optimizing Applications
//Optimizing Applications - performance
//Optimizing Appliications - sound
//Optimizing Applications - video
//Optimizing Applications - properties
//Optimizing Applications - functions
//Optimizing Microsoft Store Applications
//Optimizing Microsoft Store Applications - performance
//Optimizing Microsoft Store Applications - video
//Optimizing Microsoft Store Applications - sound
//Optimizing Microsoft Store Applications - properties
//Optimizing Microsoft Store Applications - functions
[System.AttributeUsage(System.AttributeTargets.Applications, Inherited = false, AllowMultiple = true)]
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

