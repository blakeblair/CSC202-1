namespace CSC202_1_Project_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        ListBCIOutputs();
        ListDevices();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void ListBCIOutputs()
    {
        listBox1.Items.Add("BFI / NeuroFB / FocusLeft");
        listBox1.Items.Add("BFI / NeuroFB / FocusRight");
        listBox1.Items.Add("BFI / NeuroFB / FocusAvg");
        listBox1.Items.Add("BFI / NeuroFB / RelaxLeft");
        listBox1.Items.Add("BFI / NeuroFB / RelaxRight");
        listBox1.Items.Add("BFI / NeuroFB / RelaxAvg");
        listBox1.Items.Add("BFI / Biometrics / HeartBeatsPerMinute");
        listBox1.Items.Add("BFI / Biometrics / HeartBeatsPerSecond");
        listBox1.Items.Add("BFI / Biometrics / OxygenPercent");
        listBox1.Items.Add("BFI / Biometrics / BreathsPerMinute");
        listBox1.Items.Add("BFI / PwrBands / Left / Alpha");
        listBox1.Items.Add("BFI / PwrBands / Left / Beta");
        listBox1.Items.Add("BFI / PwrBands / Left / Theta");
        listBox1.Items.Add("BFI / PwrBands / Left / Delta");
        listBox1.Items.Add("BFI / PwrBands / Left / Gamma");
        listBox1.Items.Add("BFI / PwrBands / Right / Alpha");
        listBox1.Items.Add("BFI / PwrBands / Right / Beta");
        listBox1.Items.Add("BFI / PwrBands / Right / Theta");
        listBox1.Items.Add("BFI / PwrBands / Right / Delta");
        listBox1.Items.Add("BFI / PwrBands / Right / Gamma");
        listBox1.Items.Add("BFI / PwrBands / Avg / Alpha");
        listBox1.Items.Add("BFI / PwrBands / Avg / Beta");
        listBox1.Items.Add("BFI / PwrBands / Avg / Theta");
        listBox1.Items.Add("BFI / PwrBands / Avg / Delta");
        listBox1.Items.Add("BFI / PwrBands / Avg / Gamma");
        listBox1.Items.Add("BFI / Info / BatteryLevel");
        listBox1.Items.Add("BFI / Info / DeviceConnected");
        listBox1.Items.Add("BFI / Info / SecondsSinceLastUpdate");
        listBox1.Items.Add("BFI / Addons / HueShift");
    }
    
    private void ListDevices()
    {
        Device_Select.Items.Add("placeholderdevice_TailMotor");
        Device_Select.Items.Add("placeholderdevice_LEarMotor");
        Device_Select.Items.Add("placeholderdevice_REarMotor");
        Device_Select.Items.Add("placeholderdevice_LEarLED");
        Device_Select.Items.Add("placeholderdevice_REarLED");
        Device_Select.Items.Add("placeholderdevice_TailLED");
        Device_Select.Items.Add("placeholderdevice_HeadLED");
        Device_Select.Items.Add("placeholderdevice_Soundboard");
        Device_Select.Items.Add("placeholderdevice_FaceScreen");
    }
    
    

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
        
    }
}
