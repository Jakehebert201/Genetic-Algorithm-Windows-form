
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
        ((System.ComponentModel.ISupportInitialize)numPopSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMutationRate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // btnRun
        // 
        btnRun.AutoSize = true;
        btnRun.BackColor = SystemColors.Control;
        btnRun.Location = new Point(62, 171);
        btnRun.Name = "btnRun";
        btnRun.Size = new Size(330, 35);
        btnRun.TabIndex = 0;
        btnRun.Text = "Run Genetic Algorithm";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click_1;
        // 
        // chkMinimize
        // 
        chkMinimize.AutoSize = true;
        chkMinimize.Location = new Point(312, 65);
        chkMinimize.Name = "chkMinimize";
        chkMinimize.Size = new Size(80, 19);
        chkMinimize.TabIndex = 3;
        chkMinimize.Text = "Minimize?";
        chkMinimize.UseVisualStyleBackColor = true;
        // 
        // numPopSize
        // 
        numPopSize.AutoSize = true;
        numPopSize.Location = new Point(101, 61);
        numPopSize.Name = "numPopSize";
        numPopSize.Size = new Size(44, 23);
        numPopSize.TabIndex = 4;
        // 
        // numMutationRate
        // 
        numMutationRate.AutoSize = true;
        numMutationRate.DecimalPlaces = 2;
        numMutationRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        numMutationRate.Location = new Point(207, 61);
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
        LabelSettingsSummary.Location = new Point(182, 231);
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
        labelMutationRate.Location = new Point(188, 87);
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
        labelPopSize.Location = new Point(86, 87);
        labelPopSize.Name = "labelPopSize";
        labelPopSize.Size = new Size(88, 15);
        labelPopSize.TabIndex = 9;
        labelPopSize.Text = "Population Size";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Individual, Weight });
        dataGridView1.Location = new Point(101, 303);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(243, 336);
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
        userInputFunc.Location = new Point(62, 118);
        userInputFunc.Multiline = true;
        userInputFunc.Name = "userInputFunc";
        userInputFunc.Size = new Size(330, 34);
        userInputFunc.TabIndex = 11;
        userInputFunc.Text = "Create an optimization function that the Algorithm will adapt to. ex. (X^2-9)";
        userInputFunc.TextChanged += userInputFunc_TextChanged;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(407, 171);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(97, 33);
        btnReset.TabIndex = 12;
        btnReset.Text = "Reset?";
        btnReset.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        AutoSize = true;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(552, 672);
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
}
