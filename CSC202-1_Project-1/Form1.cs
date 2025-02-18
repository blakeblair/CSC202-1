using System.ComponentModel;

namespace CSC202_1_Project_1;

public partial class Form1 : Form
{
    private bool _debugMode = false;


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool DebugMode
    {
        get => _debugMode;
        set
        {
            _debugMode = value;
            if (value)
            {
                DebugModeEnabled();
            }
            else
            {
                DebugModeDisabled();
            }
        }
    }
    
    //private void connectedComputeDevice whateverAFileDirectoryFromPCIsCalled { get; set; }
    //private void configSaveLocation whateverAFileDirectoryFromPCIsCalled { get; set; }
    //private void bciDevice howeverWeCallASpecificDeviceAttachedToPC { get; set; }

    private int _currentSelectionBciOutput { get; set; }
    private int _currentSelectionDevice { get; set; }

    private readonly List<string> _bciOutputs =
    [
        "BFI / NeuroFB / FocusLeft",
        "BFI / NeuroFB / FocusRight",
        "BFI / NeuroFB / FocusAvg",
        "BFI / NeuroFB / RelaxLeft",
        "BFI / NeuroFB / RelaxRight",
        "BFI / NeuroFB / RelaxAvg",
        "BFI / Biometrics / HeartBeatsPerMinute",
        "BFI / Biometrics / HeartBeatsPerSecond",
        "BFI / Biometrics / OxygenPercent",
        "BFI / Biometrics / BreathsPerMinute",
        "BFI / PwrBands / Left / Alpha",
        "BFI / PwrBands / Left / Beta",
        "BFI / PwrBands / Left / Theta",
        "BFI / PwrBands / Left / Delta",
        "BFI / PwrBands / Left / Gamma",
        "BFI / PwrBands / Right / Alpha",
        "BFI / PwrBands / Right / Beta",
        "BFI / PwrBands / Right / Theta",
        "BFI / PwrBands / Right / Delta",
        "BFI / PwrBands / Right / Gamma",
        "BFI / PwrBands / Avg / Alpha",
        "BFI / PwrBands / Avg / Beta",
        "BFI / PwrBands / Avg / Theta",
        "BFI / PwrBands / Avg / Delta",
        "BFI / PwrBands / Avg / Gamma",
        "BFI / Info / BatteryLevel",
        "BFI / Info / DeviceConnected",
        "BFI / Info / SecondsSinceLastUpdate",
        "BFI / Addons / HueShift",
    ];

    private readonly List<string> _devices =
    [
        "placeholderdevice_TailMotor",
        "placeholderdevice_LEarMotor_X",
        "placeholderdevice_LEarMotor_Y",
        "placeholderdevice_LEarMotor_Z",
        "placeholderdevice_REarMotor_X",
        "placeholderdevice_REarMotor_Y",
        "placeholderdevice_REarMotor_Z",
        "placeholderdevice_LEarLED",
        "placeholderdevice_REarLED",
        "placeholderdevice_TailLED",
        "placeholderdevice_HeadLED",
        "placeholderdevice_Soundboard",
        "placeholderdevice_FaceScreen",
    ];

    public Form1()
    {
        InitializeComponent();

        //setComputeDevice();
        //setBCIDevice();
        //setConfigSaveLocation();
        ListBciOutputs();
        ListDevices();
        OnSelectionChanged();

    }

    private void OnSelectionChanged()
    {
        if(_currentSelectionBciOutput >= 0 && _currentSelectionBciOutput < _bciOutputs.Count)
        {
            curOutput.Text = "Current: " + _bciOutputs[_currentSelectionBciOutput];
        }
        else
        {
            curOutput.Text = "Current: No selection recognized.";
        }
        
        if(_currentSelectionDevice >= 0 && _currentSelectionDevice < _devices.Count)
        {
            curDevice.Text = "Current: " + _devices[_currentSelectionDevice];
        }
        else
        {
            curDevice.Text = "Current: No selection recognized.";
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        _currentSelectionBciOutput = listBox1.SelectedIndex;
        OnSelectionChanged();
    }

    private void ListBciOutputs()
    {
        listBox1.DataSource = _bciOutputs;
    }

    private void ListDevices()
    {
        Device_Select.DataSource = _devices;
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Device_Select_SelectedIndexChanged(object sender, EventArgs e)
    {
        _currentSelectionDevice = Device_Select.SelectedIndex;
        OnSelectionChanged();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        DebugMode = checkBox1.Checked;
    }

    private void DebugModeEnabled()
    {
        curDevice.Visible = true;
        curOutput.Visible = true;
    }
    
    private void DebugModeDisabled()
    {
        curDevice.Visible = false;
        curOutput.Visible = false;
    }
}

// curDevice  curOutput