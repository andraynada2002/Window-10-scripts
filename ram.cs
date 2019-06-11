//RAM optimizing
//Optimizing RAM
//Optimizing RAM performance
//Optimizing Physical memory
//Optimizing Ram quality
//Optimizing Physical memory performance
//Optimizing DDR4
//Optimizing DDR3
//Optimizing DDR2
//Optimizing DDR
//Optimizing Physical memory quality
//Physical Memory optimizing
//Optimizing CAS Latency (CL)
//Optimizing RAS To CAS Delay (tRCD)
//Optimizing RAS Precharge (tRP)
//Optimizing RAS Active Time (tRAS)
//Optimizing Row Refresh Cycle Time (tRFC)
//Optimizing Command Rate (CR)
//Optimizing RAS To RAS Delay (tRRD)
//Optimizing Write Recovery Time (tWR)
//Optimizing Read To Read Delay (tRTR)
//Optimizing Read To Write Delay (tRTW)	
//Optimizing Write To Read Delay (tWTR)	
//Optimizing Write To Write Delay (tWTW)
//Optimizing Read To Precharge Delay (tRTP)	
//Optimizing Four Activate Window Delay (tFAW)	
//Optimizing Write CAS Latency (tWCL)	
//Optimizing CKE Min. Pulse Width (tCKE)
//Optimizing Refresh Period (tREF)	
//Optimizing Round Trip Latency (tRTL)	
//Optimizing I/O Latency (tIOL)	
//Optimizing Burst Length (BL)
//Optimizing Intel Ivy Bridge-DT IMC
//Optimizing timer controller
//Optimizing RAM - performance
//Optimizing RAM - video
//Optimizing RAM - sound
//Optimizing DDR - performance
//Optimizing DDR - video
//Optimizing DDR - sound
//Optimizing DDR2 - performance
//Optimizing DDR2 - sound
//Optimizing DDR2 - video
//Optimizing DDR3 - performance
//Optimizing DDR3 - sound
//Optimizing DDR3 - video
//Optimizing DDR4 - performance
//Optimizing DDR4 - sound
//Optimizing DDR4 - video
//Optimizing DDR5 - performance
//Optimizing DDR5 - video
//Optimizing DDR5 - sound
[System.AttributeUsage(System.AttributeTargets.RAMPM, Inherited = false, AllowMultiple = true)]
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



