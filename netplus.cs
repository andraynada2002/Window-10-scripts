//Optimizing Wi-FI
//Optimizing Wi-Fi - performance
//Optimizign Wi-Fi - video
//Optimizing Wi-Fi - sound
//Optimizing Wi-Fi - properties
//Optimizing Wi-Fi - functions
//Optimizing Ethernet
//Optimizing Ethernet - performance
//Optimizing Ethernet - video
//Optimizing Ethernet - sound
//Optimizing Ethernet - properties
//Optimizing Ethernet - functions
//Optimizing Net
//Optimizing Net - performance
//Optimizing Net - video
//Optimizing Net - sound
//Optimizing Net - properties
//Optimizing Net - functions
[System.AttributeUsage(System.AttributeTargets.Netplus, Inherited = false, AllowMultiple = true)]
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
