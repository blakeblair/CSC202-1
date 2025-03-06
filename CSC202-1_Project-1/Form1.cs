using System.ComponentModel;
using System.Drawing.Configuration;

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

    private void output_list_SelectedIndexChanged(object sender, EventArgs e)
    {
        _currentSelectionBciOutput = output_list.SelectedIndex;
        OnSelectionChanged();
    }
    
    /*
     //This section requires Drawmode Owner Fixed or Owner Variable, which have been set back to normal until I can finish figuring out the Bounds issue causing list items to overlap.
     
    private void output_list_DrawItem(object sender, DrawItemEventArgs e)
    {
        var backColor = this.BackColor;         //Default BackColor
        var textColor = this.ForeColor;         //Default ForeColor
        var data = output_list.Text;
        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            backColor = Color.Green;        //Seletion BackColor
            textColor = Color.White;           //Seletion ForeColor
        }
        e.Graphics.Clear(this.BackColor); //have to clear after every event to prevent overwriting list positions
        using (var brush = new SolidBrush(backColor))
            e.Graphics.FillRectangle(brush, e.Bounds);
        //TextRenderer.DrawText(e.Graphics, data, output_list.Font, e.Bounds, textColor,
            //TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            TextRenderer.DrawText(e.Graphics, data, output_list.Font, e.Bounds, textColor);
    }
    */

    private void lockToggle_Click_1(object sender, EventArgs e)
    {
        List<Control> affectedControls = new List<Control>();
        affectedControls.Add(output_list);
        affectedControls.Add(Device_Select);
        System.Windows.Forms.CheckBox[] willToggle = GetChecks();
        foreach (var item in willToggle)
        {
            if (item.Checked)
            {
                if (item.Name == "lock1")
                {
                    output_list.Tag = "willtoggle";
                }
                else if (item.Name == "lock2")
                {
                    Device_Select.Tag = "willtoggle";
                }
            }
            else
            {
                if (item.Name == "lock1")
                {
                    output_list.Tag = "nottoggle";
                }
                else if (item.Name == "lock2")
                {
                    Device_Select.Tag = "nottoggle";
                }
            }
        }

        foreach (Control c in affectedControls)
        {
            InputLocker(c);
            Console.WriteLine(c.Name);
        }
    }
    private void InputLocker(System.Windows.Forms.Control controller)
    {
        try
        {
            if (controller.Tag.ToString() == "willtoggle")
            {
                controller.Enabled = !controller.Enabled;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private CheckBox[] GetChecks()
    {
        return [lock1, lock2];
    }
    
    private void ListBciOutputs()
    {
        output_list.DataSource = _bciOutputs;
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
        DebugMode = debugcheckbox.Checked;
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

    private void lock1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void lock2_CheckedChanged(object sender, EventArgs e)
    {
        
    }
}

// curDevice  curOutput