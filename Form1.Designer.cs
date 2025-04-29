
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
        btnRun = new Button();
        chkMinimize = new CheckBox();
        numPopSize = new NumericUpDown();
        numMutationRate = new NumericUpDown();
        LabelSettingsSummary = new Label();
        labelMutationRate = new Label();
        labelShowPopSize = new Label();
        labelPopSize = new Label();
        dataGridView1 = new DataGridView();
        Individual = new DataGridViewTextBoxColumn();
        Weight = new DataGridViewTextBoxColumn();
        userInputFunc = new TextBox();
        btnReset = new Button();
        labelFunctionInfo = new Label();
        numGenerations = new NumericUpDown();
        labelGenerationCount = new Label();
        numMaxRange = new NumericUpDown();
        labelMinRange = new Label();
        labelMaxRange = new Label();
        numMinRange = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numPopSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMutationRate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
        btnRun.TabIndex = 0;
        btnRun.Text = "Run Genetic Algorithm";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click;
        // 
        // chkMinimize
        // 
        chkMinimize.AutoSize = true;
        chkMinimize.BackColor = SystemColors.ButtonFace;
        chkMinimize.Location = new Point(573, 66);
        chkMinimize.Name = "chkMinimize";
        chkMinimize.Size = new Size(80, 19);
        chkMinimize.TabIndex = 3;
        chkMinimize.Text = "Minimize?";
        chkMinimize.UseVisualStyleBackColor = false;
        chkMinimize.CheckedChanged += chkMinimize_CheckedChanged;
        // 
        // numPopSize
        // 
        numPopSize.AutoSize = true;
        numPopSize.Location = new Point(376, 65);
        numPopSize.Name = "numPopSize";
        numPopSize.Size = new Size(44, 23);
        numPopSize.TabIndex = 4;
        // 
        // numMutationRate
        // 
        numMutationRate.AutoSize = true;
        numMutationRate.DecimalPlaces = 2;
        numMutationRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        numMutationRate.Location = new Point(485, 65);
        numMutationRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
        numMutationRate.Name = "numMutationRate";
        numMutationRate.Size = new Size(44, 23);
        numMutationRate.TabIndex = 5;
        // 
        // LabelSettingsSummary
        // 
        LabelSettingsSummary.AutoSize = true;
        LabelSettingsSummary.BackColor = SystemColors.Info;
        LabelSettingsSummary.ForeColor = SystemColors.InfoText;
        LabelSettingsSummary.Location = new Point(460, 240);
        LabelSettingsSummary.Name = "LabelSettingsSummary";
        LabelSettingsSummary.Size = new Size(69, 15);
        LabelSettingsSummary.TabIndex = 6;
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
        labelMutationRate.Size = new Size(82, 15);
        labelMutationRate.TabIndex = 7;
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
        labelPopSize.Size = new Size(88, 15);
        labelPopSize.TabIndex = 9;
        labelPopSize.Text = "Population Size";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Individual, Weight });
        dataGridView1.Location = new Point(376, 333);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(250, 250);
        dataGridView1.TabIndex = 10;
        dataGridView1.Visible = false;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Individual
        // 
        Individual.HeaderText = "Individual";
        Individual.Name = "Individual";
        // 
        // Weight
        // 
        Weight.HeaderText = "Weight";
        Weight.Name = "Weight";
        // 
        // userInputFunc
        // 
        userInputFunc.Location = new Point(335, 133);
        userInputFunc.Multiline = true;
        userInputFunc.Name = "userInputFunc";
        userInputFunc.Size = new Size(330, 34);
        userInputFunc.TabIndex = 11;
        userInputFunc.TextChanged += userInputFunc_TextChanged;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(671, 202);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(97, 33);
        btnReset.TabIndex = 12;
        btnReset.Text = "Reset?";
        btnReset.UseVisualStyleBackColor = true;
        // 
        // labelFunctionInfo
        // 
        labelFunctionInfo.AutoSize = true;
        labelFunctionInfo.BackColor = SystemColors.Info;
        labelFunctionInfo.Location = new Point(419, 170);
        labelFunctionInfo.Name = "labelFunctionInfo";
        labelFunctionInfo.Size = new Size(159, 15);
        labelFunctionInfo.TabIndex = 13;
        labelFunctionInfo.Text = "Create a function. ex. (x^2-9)";
        // 
        // numGenerations
        // 
        numGenerations.Location = new Point(684, 65);
        numGenerations.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numGenerations.Name = "numGenerations";
        numGenerations.Size = new Size(84, 23);
        numGenerations.TabIndex = 14;
        numGenerations.Value = new decimal(new int[] { 1000, 0, 0, 0 });
        // 
        // labelGenerationCount
        // 
        labelGenerationCount.AutoSize = true;
        labelGenerationCount.BackColor = SystemColors.Info;
        labelGenerationCount.Location = new Point(684, 102);
        labelGenerationCount.Name = "labelGenerationCount";
        labelGenerationCount.Size = new Size(92, 15);
        labelGenerationCount.TabIndex = 15;
        labelGenerationCount.Text = "No. Generations";
        // 
        // numMaxRange
        // 
        numMaxRange.Location = new Point(275, 64);
        numMaxRange.Name = "numMaxRange";
        numMaxRange.Size = new Size(41, 23);
        numMaxRange.TabIndex = 16;
        // 
        // labelMinRange
        // 
        labelMinRange.AutoSize = true;
        labelMinRange.BackColor = SystemColors.Info;
        labelMinRange.Location = new Point(129, 102);
        labelMinRange.Name = "labelMinRange";
        labelMinRange.Size = new Size(96, 15);
        labelMinRange.TabIndex = 17;
        labelMinRange.Text = "Minimum Range";
        // 
        // labelMaxRange
        // 
        labelMaxRange.AutoSize = true;
        labelMaxRange.BackColor = SystemColors.Info;
        labelMaxRange.Location = new Point(245, 102);
        labelMaxRange.Name = "labelMaxRange";
        labelMaxRange.Size = new Size(97, 15);
        labelMaxRange.TabIndex = 18;
        labelMaxRange.Text = "Maximum Range";
        // 
        // numMinRange
        // 
        numMinRange.Location = new Point(158, 61);
        numMinRange.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        numMinRange.Name = "numMinRange";
        numMinRange.Size = new Size(41, 23);
        numMinRange.TabIndex = 19;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        AutoSize = true;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(984, 811);
        Controls.Add(numMinRange);
        Controls.Add(labelMaxRange);
        Controls.Add(labelMinRange);
        Controls.Add(numMaxRange);
        Controls.Add(labelGenerationCount);
        Controls.Add(numGenerations);
        Controls.Add(labelFunctionInfo);
        Controls.Add(btnReset);
        Controls.Add(userInputFunc);
        Controls.Add(dataGridView1);
        Controls.Add(labelPopSize);
        Controls.Add(labelShowPopSize);
        Controls.Add(labelMutationRate);
        Controls.Add(LabelSettingsSummary);
        Controls.Add(numMutationRate);
        Controls.Add(numPopSize);
        Controls.Add(chkMinimize);
        Controls.Add(btnRun);
        Name = "Form1";
        Text = "Genetic Algorithm Visualizer";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numPopSize).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMutationRate).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Individual;
    private DataGridViewTextBoxColumn Weight;
    private TextBox userInputFunc;
    private Button btnReset;
    private Label labelFunctionInfo;
    private NumericUpDown numGenerations;
    private Label labelGenerationCount;
    private NumericUpDown numMaxRange;
    private Label labelMinRange;
    private Label labelMaxRange;
    private NumericUpDown numMinRange;
}
