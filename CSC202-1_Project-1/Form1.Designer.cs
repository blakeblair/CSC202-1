namespace CSC202_1_Project_1;

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
        start_form = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // start_form
        // 
        start_form.AccessibleName = "start_form";
        start_form.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
        start_form.Location = new System.Drawing.Point(258, 156);
        start_form.Name = "start_form";
        start_form.Size = new System.Drawing.Size(292, 98);
        start_form.TabIndex = 0;
        start_form.Text = "Start Form";
        start_form.UseVisualStyleBackColor = true;
        start_form.Click += start_form_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(start_form);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button start_form;

    #endregion
}