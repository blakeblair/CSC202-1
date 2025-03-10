﻿namespace CSC202_1_Project_1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panel1 = new System.Windows.Forms.Panel();
        lock1 = new System.Windows.Forms.CheckBox();
        lockToggle = new System.Windows.Forms.Button();
        curOutput = new System.Windows.Forms.Label();
        output_list = new System.Windows.Forms.ListBox();
        BCIOutput_title = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        lock2 = new System.Windows.Forms.CheckBox();
        curDevice = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        debugcheckbox = new System.Windows.Forms.CheckBox();
        button4 = new System.Windows.Forms.Button();
        Device_Select = new System.Windows.Forms.ComboBox();
        device_settings_title = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        timer1 = new System.Windows.Forms.Timer(components);
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.AutoSize = true;
        panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        panel1.Controls.Add(lock1);
        panel1.Controls.Add(lockToggle);
        panel1.Controls.Add(curOutput);
        panel1.Controls.Add(output_list);
        panel1.Controls.Add(BCIOutput_title);
        panel1.Location = new System.Drawing.Point(42, 56);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(522, 809);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // lock1
        // 
        lock1.Location = new System.Drawing.Point(10, 125);
        lock1.Name = "lock1";
        lock1.Size = new System.Drawing.Size(32, 35);
        lock1.TabIndex = 15;
        lock1.Text = "L";
        lock1.UseVisualStyleBackColor = true;
        lock1.CheckedChanged += lock1_CheckedChanged;
        // 
        // lockToggle
        // 
        lockToggle.Location = new System.Drawing.Point(419, 9);
        lockToggle.Name = "lockToggle";
        lockToggle.Size = new System.Drawing.Size(89, 40);
        lockToggle.TabIndex = 14;
        lockToggle.Text = "Toggle Locks";
        lockToggle.UseVisualStyleBackColor = true;
        lockToggle.Click += lockToggle_Click_1;
        // 
        // curOutput
        // 
        curOutput.Location = new System.Drawing.Point(48, 81);
        curOutput.Name = "curOutput";
        curOutput.Size = new System.Drawing.Size(385, 44);
        curOutput.TabIndex = 2;
        curOutput.Text = "Current: ";
        curOutput.Visible = false;
        // 
        // output_list
        // 
        output_list.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        output_list.ForeColor = System.Drawing.Color.Black;
        output_list.FormattingEnabled = true;
        output_list.Location = new System.Drawing.Point(43, 125);
        output_list.Margin = new System.Windows.Forms.Padding(16);
        output_list.Name = "output_list";
        output_list.ScrollAlwaysVisible = true;
        output_list.Size = new System.Drawing.Size(401, 484);
        output_list.TabIndex = 1;
        output_list.Tag = "unlocked";
        output_list.SelectedIndexChanged += output_list_SelectedIndexChanged;
        // 
        // BCIOutput_title
        // 
        BCIOutput_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BCIOutput_title.Location = new System.Drawing.Point(51, 17);
        BCIOutput_title.Name = "BCIOutput_title";
        BCIOutput_title.Size = new System.Drawing.Size(255, 61);
        BCIOutput_title.TabIndex = 0;
        BCIOutput_title.Text = "BCI Outputs";
        BCIOutput_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.AutoSize = true;
        panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        panel3.Controls.Add(lock2);
        panel3.Controls.Add(curDevice);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(textBox1);
        panel3.Controls.Add(debugcheckbox);
        panel3.Controls.Add(button4);
        panel3.Controls.Add(Device_Select);
        panel3.Controls.Add(device_settings_title);
        panel3.Location = new System.Drawing.Point(581, 56);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(770, 809);
        panel3.TabIndex = 2;
        panel3.Paint += panel3_Paint;
        // 
        // lock2
        // 
        lock2.Location = new System.Drawing.Point(24, 139);
        lock2.Name = "lock2";
        lock2.Size = new System.Drawing.Size(43, 21);
        lock2.TabIndex = 14;
        lock2.Text = "L";
        lock2.UseVisualStyleBackColor = true;
        lock2.CheckedChanged += lock2_CheckedChanged;
        // 
        // curDevice
        // 
        curDevice.Location = new System.Drawing.Point(78, 79);
        curDevice.Name = "curDevice";
        curDevice.Size = new System.Drawing.Size(275, 45);
        curDevice.TabIndex = 13;
        curDevice.Text = "Current: ";
        curDevice.Visible = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(389, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(314, 23);
        label1.TabIndex = 12;
        label1.Text = "Association Name";
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(385, 45);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(369, 33);
        textBox1.TabIndex = 11;
        // 
        // debugcheckbox
        // 
        debugcheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        debugcheckbox.Location = new System.Drawing.Point(92, 185);
        debugcheckbox.Name = "debugcheckbox";
        debugcheckbox.Size = new System.Drawing.Size(122, 34);
        debugcheckbox.TabIndex = 10;
        debugcheckbox.Text = "Debug Mode";
        debugcheckbox.UseVisualStyleBackColor = true;
        debugcheckbox.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
        button4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button4.Location = new System.Drawing.Point(556, 708);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(182, 66);
        button4.TabIndex = 9;
        button4.Text = "Save";
        button4.UseVisualStyleBackColor = false;
        // 
        // Device_Select
        // 
        Device_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        Device_Select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Device_Select.FormattingEnabled = true;
        Device_Select.Location = new System.Drawing.Point(73, 125);
        Device_Select.Name = "Device_Select";
        Device_Select.Size = new System.Drawing.Size(681, 53);
        Device_Select.TabIndex = 8;
        Device_Select.Tag = "unlocked";
        Device_Select.SelectedIndexChanged += Device_Select_SelectedIndexChanged;
        // 
        // device_settings_title
        // 
        device_settings_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        device_settings_title.Location = new System.Drawing.Point(31, 17);
        device_settings_title.Name = "device_settings_title";
        device_settings_title.Size = new System.Drawing.Size(335, 61);
        device_settings_title.TabIndex = 7;
        device_settings_title.Text = "Device Settings";
        device_settings_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.HotTrack;
        button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(1111, 895);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(240, 73);
        button1.TabIndex = 3;
        button1.Text = "Apply Configuration";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(865, 895);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(240, 73);
        button2.TabIndex = 4;
        button2.Text = "Import Configuration";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.Location = new System.Drawing.Point(619, 895);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(240, 73);
        button3.TabIndex = 5;
        button3.Text = "Export Configuration";
        button3.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        AutoSize = true;
        ClientSize = new System.Drawing.Size(1418, 774);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox lock2;
    private System.Windows.Forms.CheckBox lock1;

    private System.Windows.Forms.Button lockToggle;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label curDevice;

    private System.Windows.Forms.Label curOutput;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.CheckBox debugcheckbox;

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.ComboBox Device_Select;

    private System.Windows.Forms.ListBox output_list;

    private System.Windows.Forms.Label device_settings_title;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label BCIOutput_title;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}