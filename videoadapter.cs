//Optimizing Video Adapter
//Optimizing Video Adapter - performance
//Optimizing Video Adapter - video
//Optimizing Video Adapter - sound
//Optimizing Video Adapter - properties
//Optimizing Video Adapter - functions
[System.AttributeUsage(System.AttributeTargets.VideoAdapter, Inherited = false, AllowMultiple = true)]
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
