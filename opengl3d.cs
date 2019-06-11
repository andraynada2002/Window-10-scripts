//Optimizing OpenGL
//Optimizing Properties OpenGL
//Optimizign OpenGL - video
//Optimizing OpenGL - sound
//Optimizing Functions OpenGL
//Optimizing OpenGL - performance
//Optimizing OpenGL - functions
//Optimizing OpenGL - properties
[System.AttributeUsage(System.AttributeTargets.OpenGL3D, Inherited = false, AllowMultiple = true)]
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


