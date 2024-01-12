namespace logDumper;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnDumpLogs = new Button();
        progressBar1 = new ProgressBar();
        flowLayoutPanel1 = new FlowLayoutPanel();
        btnQuit = new Button();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // btnDumpLogs
        // 
        btnDumpLogs.Location = new Point(3, 32);
        btnDumpLogs.Name = "btnDumpLogs";
        btnDumpLogs.Size = new Size(107, 23);
        btnDumpLogs.TabIndex = 0;
        btnDumpLogs.Text = "Export Logs";
        btnDumpLogs.UseVisualStyleBackColor = true;
        btnDumpLogs.Click += btnDumpLogs_Click;
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(3, 3);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(236, 23);
        progressBar1.Step = 1;
        progressBar1.TabIndex = 1;
        progressBar1.Visible = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(progressBar1);
        flowLayoutPanel1.Controls.Add(btnDumpLogs);
        flowLayoutPanel1.Controls.Add(btnQuit);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(260, 92);
        flowLayoutPanel1.TabIndex = 3;
        // 
        // btnQuit
        // 
        btnQuit.Location = new Point(3, 61);
        btnQuit.Name = "btnQuit";
        btnQuit.Size = new Size(75, 23);
        btnQuit.TabIndex = 2;
        btnQuit.Text = "Quit";
        btnQuit.UseVisualStyleBackColor = true;
        btnQuit.Click += btnQuit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(260, 92);
        Controls.Add(flowLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        flowLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button btnDumpLogs;
    private ProgressBar progressBar1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnQuit;
}
