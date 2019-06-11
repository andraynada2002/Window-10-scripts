//Optimizing G94
//Optimizing GPU
//Optimizing G95
//Optimizing PCI Domain / Bus / Device
//Optimizing Asynchronous Engines
//Optimizing Max Threads Per Multiprocessor	
//Optimizing Max Threads Per Block
//Optimizing Max Registers Per Block
//Optimizing Max 32-bit Registers Per Multiprocessor
//Optimizing Multiprocessor
//Optimizing GPU Controller
//Optimizing Max Instructions Per Kernel
//Optimizing Warp Size
//Optimizing Max Block Size
//Optimizing Max Grid Size
//Optimizing Max 1D Texture Width	
//Optimizing Max 2D Texture Size	
//Optimizing Max 3D Texture Size
//Optimizing Max 1D Linear Texture Width	
//Optimizing Max 2D Linear Texture Size	
//Optimizing Max 2D Linear Texture Pitch	
//Optimizing Max 1D Layered Texture Width
//Optimizing Max 1D Layered Texture Layers	
//Optimizing Max Mipmapped 1D Texture Width	
//Optimizing Max Mipmapped 2D Texture Size	
//Optimizing Max Cubemap Texture Size	
//Optimizing Max Texture Array Size	
//Optimizing Max Texture Array Slices	
//Optimizing Max 1D Surface Width	
//Optimizing Max 2D Surface Size	
//Optimizing Compute Mode
//Optimizing Compute Capability	
//Optimizing CUDA DLL
//Optimizing nvcuda.dll
//Optimizing bandwidth memory
//Optimizing width memory
//Optimizing Global Memory Bus Width
//Optimizing Total Memory	
//Optimizing Total Constant Memory	
//Optimizing Max Shared Memory Per Block	
//Optimizing Max Shared Memory Per Multiprocessor	
//Optimizing Max Memory Pitch	
//Optimizing Texture Alignment	
//Optimizing Texture Pitch Alignment	
//Optimizing Surface Alignment	
[System.AttributeUsage(System.AttributeTargets.GPUS, Inherited = false, AllowMultiple = true)]
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
