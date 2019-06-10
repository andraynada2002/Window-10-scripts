//Optimizing Intel Cougar Point PCH - High Definition Audio Controller [B3]
//Optimizing Intel Cougar Point PCH - Manageability Engine Interface 1 [B2]
//Optimizing Intel Cougar Point PCH - PCI Express Port 1 [B3]
//Optimizing Intel Cougar Point PCH - PCI Express Port 6 [B3]
//Optimizing Intel Cougar Point PCH - SATA AHCI 6-Port Controller [B3]
//Optimizing Intel Cougar Point PCH - SMBus Controller [B3]
//Optimizing Intel Cougar Point PCH - Thermal Management Controller [B3]
//Optimizing Intel Cougar Point PCH - USB EHCI #1 Controller [B3]
//Optimizing Intel Cougar Point PCH - USB EHCI #2 Controller [B3]
//Optimizing Intel H61 PCH - LPC Interface Controller [B3]
//Optimizing Intel Ivy Bridge - PCI Express Controller
//Optimizing Intel Ivy Bridge-DT - Host Bridge/DRAM Controller
//Optimizing Video Adapter
//Optimizing BUS mastering
[System.AttributeUsage(System.AttributeTargets.PCI, Inherited = false, AllowMultiple = true)]
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

