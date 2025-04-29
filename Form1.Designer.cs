
namespace GeneticAlgorithms;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnRun = new Button();
        chkMinimize = new CheckBox();
        numPopSize = new NumericUpDown();
        numMutationRate = new NumericUpDown();
        LabelSettingsSummary = new Label();
        labelMutationRate = new Label();
        labelShowPopSize = new Label();
        labelPopSize = new Label();
        userInputFunc = new TextBox();
        btnReset = new Button();
        labelFunctionInfo = new Label();
        numGenerations = new NumericUpDown();
        labelGenerationCount = new Label();
        numMaxRange = new NumericUpDown();
        labelMinRange = new Label();
        labelMaxRange = new Label();
        numMinRange = new NumericUpDown();
        tabControl1 = new TabControl();
        chkGradDesc = new CheckBox();
        labelMinGradInfo = new Label();
        labelGradDescentOutput = new Label();
        ((System.ComponentModel.ISupportInitialize)numPopSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMutationRate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numGenerations).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMaxRange).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMinRange).BeginInit();
        SuspendLayout();
        // 
        // btnRun
        // 
        btnRun.AutoSize = true;
        btnRun.BackColor = SystemColors.Control;
        btnRun.Location = new Point(335, 202);
        btnRun.Name = "btnRun";
        btnRun.Size = new Size(330, 35);
        btnRun.TabIndex = 8;
        btnRun.Text = "Run Genetic Algorithm";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click;
        // 
        // chkMinimize
        // 
        chkMinimize.AutoSize = true;
        chkMinimize.BackColor = SystemColors.ButtonFace;
        chkMinimize.Location = new Point(570, 86);
        chkMinimize.Name = "chkMinimize";
        chkMinimize.Size = new Size(83, 19);
        chkMinimize.TabIndex = 5;
        chkMinimize.Text = "Minimize?";
        chkMinimize.UseVisualStyleBackColor = false;
        chkMinimize.CheckedChanged += chkMinimize_CheckedChanged;
        // 
        // numPopSize
        // 
        numPopSize.AutoSize = true;
        numPopSize.Location = new Point(376, 65);
        numPopSize.Name = "numPopSize";
        numPopSize.Size = new Size(47, 23);
        numPopSize.TabIndex = 3;
        // 
        // numMutationRate
        // 
        numMutationRate.AutoSize = true;
        numMutationRate.DecimalPlaces = 2;
        numMutationRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        numMutationRate.Location = new Point(485, 65);
        numMutationRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
        numMutationRate.Name = "numMutationRate";
        numMutationRate.Size = new Size(51, 23);
        numMutationRate.TabIndex = 4;
        // 
        // LabelSettingsSummary
        // 
        LabelSettingsSummary.AutoSize = true;
        LabelSettingsSummary.BackColor = SystemColors.Info;
        LabelSettingsSummary.ForeColor = SystemColors.InfoText;
        LabelSettingsSummary.Location = new Point(460, 240);
        LabelSettingsSummary.Name = "LabelSettingsSummary";
        LabelSettingsSummary.Size = new Size(73, 15);
        LabelSettingsSummary.TabIndex = 100;
        LabelSettingsSummary.Text = "placeholder";
        LabelSettingsSummary.Visible = false;
        LabelSettingsSummary.Click += LabelSettingsSummary_Click;
        // 
        // labelMutationRate
        // 
        labelMutationRate.AutoSize = true;
        labelMutationRate.BackColor = SystemColors.Info;
        labelMutationRate.Location = new Point(460, 102);
        labelMutationRate.Name = "labelMutationRate";
        labelMutationRate.Size = new Size(84, 15);
        labelMutationRate.TabIndex = 100;
        labelMutationRate.Text = "Mutation Rate";
        // 
        // labelShowPopSize
        // 
        labelShowPopSize.AutoSize = true;
        labelShowPopSize.Location = new Point(75, 342);
        labelShowPopSize.Name = "labelShowPopSize";
        labelShowPopSize.Size = new Size(0, 15);
        labelShowPopSize.TabIndex = 8;
        // 
        // labelPopSize
        // 
        labelPopSize.AutoSize = true;
        labelPopSize.BackColor = SystemColors.Info;
        labelPopSize.Location = new Point(351, 102);
        labelPopSize.Name = "labelPopSize";
        labelPopSize.Size = new Size(91, 15);
        labelPopSize.TabIndex = 100;
        labelPopSize.Text = "Population Size";
        // 
        // userInputFunc
        // 
        userInputFunc.Location = new Point(335, 133);
        userInputFunc.Multiline = true;
        userInputFunc.Name = "userInputFunc";
        userInputFunc.Size = new Size(330, 34);
        userInputFunc.TabIndex = 7;
        userInputFunc.TextChanged += userInputFunc_TextChanged;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(671, 202);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(97, 33);
        btnReset.TabIndex = 9;
        btnReset.Text = "Reset?";
        btnReset.UseVisualStyleBackColor = true;
        // 
        // labelFunctionInfo
        // 
        labelFunctionInfo.AutoSize = true;
        labelFunctionInfo.BackColor = SystemColors.Info;
        labelFunctionInfo.Location = new Point(419, 170);
        labelFunctionInfo.Name = "labelFunctionInfo";
        labelFunctionInfo.Size = new Size(162, 15);
        labelFunctionInfo.TabIndex = 100;
        labelFunctionInfo.Text = "Create a function. ex. (x^2-9)";
        // 
        // numGenerations
        // 
        numGenerations.Location = new Point(694, 65);
        numGenerations.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numGenerations.Name = "numGenerations";
        numGenerations.Size = new Size(84, 23);
        numGenerations.TabIndex = 6;
        numGenerations.Value = new decimal(new int[] { 1000, 0, 0, 0 });
        // 
        // labelGenerationCount
        // 
        labelGenerationCount.AutoSize = true;
        labelGenerationCount.BackColor = SystemColors.Info;
        labelGenerationCount.Location = new Point(686, 102);
        labelGenerationCount.Name = "labelGenerationCount";
        labelGenerationCount.Size = new Size(94, 15);
        labelGenerationCount.TabIndex = 100;
        labelGenerationCount.Text = "No. Generations";
        // 
        // numMaxRange
        // 
        numMaxRange.Location = new Point(275, 64);
        numMaxRange.Name = "numMaxRange";
        numMaxRange.Size = new Size(41, 23);
        numMaxRange.TabIndex = 2;
        // 
        // labelMinRange
        // 
        labelMinRange.AutoSize = true;
        labelMinRange.BackColor = SystemColors.Info;
        labelMinRange.Location = new Point(129, 102);
        labelMinRange.Name = "labelMinRange";
        labelMinRange.Size = new Size(96, 15);
        labelMinRange.TabIndex = 100;
        labelMinRange.Text = "Minimum Range";
        // 
        // labelMaxRange
        // 
        labelMaxRange.AutoSize = true;
        labelMaxRange.BackColor = SystemColors.Info;
        labelMaxRange.Location = new Point(245, 102);
        labelMaxRange.Name = "labelMaxRange";
        labelMaxRange.Size = new Size(98, 15);
        labelMaxRange.TabIndex = 100;
        labelMaxRange.Text = "Maximum Range";
        // 
        // numMinRange
        // 
        numMinRange.Location = new Point(158, 61);
        numMinRange.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        numMinRange.Name = "numMinRange";
        numMinRange.Size = new Size(41, 23);
        numMinRange.TabIndex = 1;
        // 
        // tabControl1
        // 
        tabControl1.Location = new Point(64, 342);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(966, 436);
        tabControl1.TabIndex = 21;
        tabControl1.Visible = false;
        // 
        // chkGradDesc
        // 
        chkGradDesc.AutoSize = true;
        chkGradDesc.BackColor = SystemColors.ButtonFace;
        chkGradDesc.Location = new Point(556, 61);
        chkGradDesc.Name = "chkGradDesc";
        chkGradDesc.Size = new Size(132, 19);
        chkGradDesc.TabIndex = 5;
        chkGradDesc.Text = "Gradient Descent?*";
        chkGradDesc.UseVisualStyleBackColor = false;
        // 
        // labelMinGradInfo
        // 
        labelMinGradInfo.AutoSize = true;
        labelMinGradInfo.BackColor = SystemColors.Info;
        labelMinGradInfo.Location = new Point(825, 80);
        labelMinGradInfo.Name = "labelMinGradInfo";
        labelMinGradInfo.Size = new Size(247, 90);
        labelMinGradInfo.TabIndex = 102;
        labelMinGradInfo.Text = resources.GetString("labelMinGradInfo.Text");
        // 
        // labelGradDescentOutput
        // 
        labelGradDescentOutput.AutoSize = true;
        labelGradDescentOutput.BackColor = SystemColors.Info;
        labelGradDescentOutput.ForeColor = SystemColors.InfoText;
        labelGradDescentOutput.Location = new Point(611, 240);
        labelGradDescentOutput.Name = "labelGradDescentOutput";
        labelGradDescentOutput.Size = new Size(42, 15);
        labelGradDescentOutput.TabIndex = 103;
        labelGradDescentOutput.Text = "label1";
        labelGradDescentOutput.Visible = false;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        AutoSize = true;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1129, 811);
        Controls.Add(labelGradDescentOutput);
        Controls.Add(labelMinGradInfo);
        Controls.Add(chkGradDesc);
        Controls.Add(tabControl1);
        Controls.Add(numMinRange);
        Controls.Add(labelMaxRange);
        Controls.Add(labelMinRange);
        Controls.Add(numMaxRange);
        Controls.Add(labelGenerationCount);
        Controls.Add(numGenerations);
        Controls.Add(labelFunctionInfo);
        Controls.Add(btnReset);
        Controls.Add(userInputFunc);
        Controls.Add(labelPopSize);
        Controls.Add(labelShowPopSize);
        Controls.Add(labelMutationRate);
        Controls.Add(LabelSettingsSummary);
        Controls.Add(numMutationRate);
        Controls.Add(numPopSize);
        Controls.Add(chkMinimize);
        Controls.Add(btnRun);
        Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        Text = "Genetic Algorithm Visualizer";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numPopSize).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMutationRate).EndInit();
        ((System.ComponentModel.ISupportInitialize)numGenerations).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMaxRange).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMinRange).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void LabelSettingsSummary_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Button btnRun;
    private CheckBox chkMinimize;
    private NumericUpDown numPopSize;
    private NumericUpDown numMutationRate;
    private Label LabelSettingsSummary;
    private Label labelMutationRate;
    private Label labelShowPopSize;
    private Label labelPopSize;
    private TextBox userInputFunc;
    private Button btnReset;
    private Label labelFunctionInfo;
    private NumericUpDown numGenerations;
    private Label labelGenerationCount;
    private NumericUpDown numMaxRange;
    private Label labelMinRange;
    private Label labelMaxRange;
    private NumericUpDown numMinRange;
    private TabControl tabControl1;
    private CheckBox chkGradDesc;
    private Label labelMinGradInfo;
    private Label labelGradDescentOutput;
}
