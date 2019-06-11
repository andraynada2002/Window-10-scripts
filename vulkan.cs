//Optimizing Vulkan
//Optimizing Vulkan - performance
//Optimizing Vulkan - sound
//Optimizing Vulkan - video
//Optimizing Vulkan API
//Optimizing Vulkan API - performance
//Optimizing Vulkan API - sound
//Optimizing Vulkan API - video
[System.AttributeUsage(System.AttributeTargets.VulkanX, Inherited = false, AllowMultiple = true)]
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
