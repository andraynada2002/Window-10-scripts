//CPU optimizing
//Optimizing CPU loading
//Optimizing CPU performance
//Optimizing CPU quality
//Optimizing CPU Max Power Limit
//Optimizing CPU IA Cores Thermal Design Current
//Optimizing CPU Cores Thermal Design Current
//Optimizing CPU Power Limit 1 (Long Duration)
//Optimizing CPU Power Limit 2 (Short Duration)
//Optimizing CPU type power
//Optimizing Multi CPU
//Optimizing ACPI Processor ID
//Optimizing Local ACPI LINT#
//Optimizing Polarity Active High
//Optimizing Trigger Mode
//Optimizing Global System Interrupt
//Optimizing I/O APIC
//Optimizing Processor Local APIC
//Optimizing CPU Thermal Design Power
//Optimizing CPU - video
//Optimizing CPU - sound
//Optimizing CPU - performance
//Optimizing CPU - functions
//Optimizing CPU - properties
[System.AttributeUsage(System.AttributeTargets.CPU, Inherited = false, AllowMultiple = true)]
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





