namespace TicTacToe
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.GameField_00 = new System.Windows.Forms.PictureBox();
            this.GameField_01 = new System.Windows.Forms.PictureBox();
            this.GameField_02 = new System.Windows.Forms.PictureBox();
            this.GameField_12 = new System.Windows.Forms.PictureBox();
            this.GameField_11 = new System.Windows.Forms.PictureBox();
            this.GameField_10 = new System.Windows.Forms.PictureBox();
            this.GameField_22 = new System.Windows.Forms.PictureBox();
            this.GameField_21 = new System.Windows.Forms.PictureBox();
            this.GameField_20 = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.GameFieldsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolbarFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CrossRadioButton = new System.Windows.Forms.RadioButton();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.GameResultLabel = new System.Windows.Forms.Label();
            this.GameResultLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_20)).BeginInit();
            this.GameFieldsFlowPanel.SuspendLayout();
            this.ToolbarFlowPanel.SuspendLayout();
            this.GameResultLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameField_00
            // 
            this.GameField_00.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_00.Enabled = false;
            this.GameField_00.InitialImage = null;
            this.GameField_00.Location = new System.Drawing.Point(11, 11);
            this.GameField_00.Name = "GameField_00";
            this.GameField_00.Size = new System.Drawing.Size(128, 128);
            this.GameField_00.TabIndex = 0;
            this.GameField_00.TabStop = false;
            this.GameField_00.Click += new System.EventHandler(this.GameField_11_Click);
            // 
            // GameField_01
            // 
            this.GameField_01.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_01.Enabled = false;
            this.GameField_01.InitialImage = null;
            this.GameField_01.Location = new System.Drawing.Point(145, 11);
            this.GameField_01.Name = "GameField_01";
            this.GameField_01.Size = new System.Drawing.Size(128, 128);
            this.GameField_01.TabIndex = 1;
            this.GameField_01.TabStop = false;
            this.GameField_01.Click += new System.EventHandler(this.GameField_12_Click);
            // 
            // GameField_02
            // 
            this.GameField_02.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_02.Enabled = false;
            this.GameField_02.InitialImage = null;
            this.GameField_02.Location = new System.Drawing.Point(279, 11);
            this.GameField_02.Name = "GameField_02";
            this.GameField_02.Size = new System.Drawing.Size(128, 128);
            this.GameField_02.TabIndex = 2;
            this.GameField_02.TabStop = false;
            this.GameField_02.Click += new System.EventHandler(this.GameField_13_Click);
            // 
            // GameField_12
            // 
            this.GameField_12.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_12.Enabled = false;
            this.GameField_12.InitialImage = null;
            this.GameField_12.Location = new System.Drawing.Point(279, 145);
            this.GameField_12.Name = "GameField_12";
            this.GameField_12.Size = new System.Drawing.Size(128, 128);
            this.GameField_12.TabIndex = 5;
            this.GameField_12.TabStop = false;
            this.GameField_12.Click += new System.EventHandler(this.GameField_23_Click);
            // 
            // GameField_11
            // 
            this.GameField_11.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_11.Enabled = false;
            this.GameField_11.InitialImage = null;
            this.GameField_11.Location = new System.Drawing.Point(145, 145);
            this.GameField_11.Name = "GameField_11";
            this.GameField_11.Size = new System.Drawing.Size(128, 128);
            this.GameField_11.TabIndex = 4;
            this.GameField_11.TabStop = false;
            this.GameField_11.Click += new System.EventHandler(this.GameField_22_Click);
            // 
            // GameField_10
            // 
            this.GameField_10.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_10.Enabled = false;
            this.GameField_10.InitialImage = null;
            this.GameField_10.Location = new System.Drawing.Point(11, 145);
            this.GameField_10.Name = "GameField_10";
            this.GameField_10.Size = new System.Drawing.Size(128, 128);
            this.GameField_10.TabIndex = 3;
            this.GameField_10.TabStop = false;
            this.GameField_10.Click += new System.EventHandler(this.GameField_21_Click);
            // 
            // GameField_22
            // 
            this.GameField_22.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_22.Enabled = false;
            this.GameField_22.InitialImage = null;
            this.GameField_22.Location = new System.Drawing.Point(279, 279);
            this.GameField_22.Name = "GameField_22";
            this.GameField_22.Size = new System.Drawing.Size(128, 128);
            this.GameField_22.TabIndex = 8;
            this.GameField_22.TabStop = false;
            this.GameField_22.Click += new System.EventHandler(this.GameField_33_Click);
            // 
            // GameField_21
            // 
            this.GameField_21.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_21.Enabled = false;
            this.GameField_21.InitialImage = null;
            this.GameField_21.Location = new System.Drawing.Point(145, 279);
            this.GameField_21.Name = "GameField_21";
            this.GameField_21.Size = new System.Drawing.Size(128, 128);
            this.GameField_21.TabIndex = 7;
            this.GameField_21.TabStop = false;
            this.GameField_21.Click += new System.EventHandler(this.GameField_32_Click);
            // 
            // GameField_20
            // 
            this.GameField_20.BackgroundImage = global::TicTacToe.Resources.Images.Cover;
            this.GameField_20.Enabled = false;
            this.GameField_20.InitialImage = null;
            this.GameField_20.Location = new System.Drawing.Point(11, 279);
            this.GameField_20.Name = "GameField_20";
            this.GameField_20.Size = new System.Drawing.Size(128, 128);
            this.GameField_20.TabIndex = 6;
            this.GameField_20.TabStop = false;
            this.GameField_20.Click += new System.EventHandler(this.GameField_31_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(183, 11);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(113, 34);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // GameFieldsFlowPanel
            // 
            this.GameFieldsFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_00);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_01);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_02);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_10);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_11);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_12);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_20);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_21);
            this.GameFieldsFlowPanel.Controls.Add(this.GameField_22);
            this.GameFieldsFlowPanel.Location = new System.Drawing.Point(11, 72);
            this.GameFieldsFlowPanel.Margin = new System.Windows.Forms.Padding(8);
            this.GameFieldsFlowPanel.Name = "GameFieldsFlowPanel";
            this.GameFieldsFlowPanel.Padding = new System.Windows.Forms.Padding(8);
            this.GameFieldsFlowPanel.Size = new System.Drawing.Size(418, 420);
            this.GameFieldsFlowPanel.TabIndex = 12;
            // 
            // ToolbarFlowPanel
            // 
            this.ToolbarFlowPanel.AutoSize = true;
            this.ToolbarFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolbarFlowPanel.Controls.Add(this.CrossRadioButton);
            this.ToolbarFlowPanel.Controls.Add(this.CircleRadioButton);
            this.ToolbarFlowPanel.Controls.Add(this.RestartButton);
            this.ToolbarFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolbarFlowPanel.Margin = new System.Windows.Forms.Padding(8);
            this.ToolbarFlowPanel.Name = "ToolbarFlowPanel";
            this.ToolbarFlowPanel.Padding = new System.Windows.Forms.Padding(8);
            this.ToolbarFlowPanel.Size = new System.Drawing.Size(439, 56);
            this.ToolbarFlowPanel.TabIndex = 13;
            // 
            // CrossRadioButton
            // 
            this.CrossRadioButton.AutoSize = true;
            this.CrossRadioButton.Location = new System.Drawing.Point(11, 11);
            this.CrossRadioButton.Name = "CrossRadioButton";
            this.CrossRadioButton.Size = new System.Drawing.Size(81, 29);
            this.CrossRadioButton.TabIndex = 12;
            this.CrossRadioButton.Text = "Cross";
            this.CrossRadioButton.UseVisualStyleBackColor = true;
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Checked = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(98, 11);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(79, 29);
            this.CircleRadioButton.TabIndex = 13;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Circle";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GameResultLabel
            // 
            this.GameResultLabel.AutoSize = true;
            this.GameResultLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GameResultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameResultLabel.ForeColor = System.Drawing.Color.Green;
            this.GameResultLabel.Location = new System.Drawing.Point(11, 8);
            this.GameResultLabel.Name = "GameResultLabel";
            this.GameResultLabel.Size = new System.Drawing.Size(196, 25);
            this.GameResultLabel.TabIndex = 14;
            this.GameResultLabel.Text = "Player Cross has won!";
            // 
            // GameResultLayoutPanel
            // 
            this.GameResultLayoutPanel.AutoSize = true;
            this.GameResultLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GameResultLayoutPanel.Controls.Add(this.GameResultLabel);
            this.GameResultLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameResultLayoutPanel.Location = new System.Drawing.Point(0, 509);
            this.GameResultLayoutPanel.Margin = new System.Windows.Forms.Padding(8);
            this.GameResultLayoutPanel.Name = "GameResultLayoutPanel";
            this.GameResultLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.GameResultLayoutPanel.Size = new System.Drawing.Size(439, 41);
            this.GameResultLayoutPanel.TabIndex = 14;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(439, 550);
            this.Controls.Add(this.GameFieldsFlowPanel);
            this.Controls.Add(this.ToolbarFlowPanel);
            this.Controls.Add(this.GameResultLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameBoard";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.GameField_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameField_20)).EndInit();
            this.GameFieldsFlowPanel.ResumeLayout(false);
            this.ToolbarFlowPanel.ResumeLayout(false);
            this.ToolbarFlowPanel.PerformLayout();
            this.GameResultLayoutPanel.ResumeLayout(false);
            this.GameResultLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox GameField_00;
        private PictureBox GameField_01;
        private PictureBox GameField_02;
        private PictureBox GameField_12;
        private PictureBox GameField_11;
        private PictureBox GameField_10;
        private PictureBox GameField_22;
        private PictureBox GameField_21;
        private PictureBox GameField_20;
        private Button RestartButton;
        private FlowLayoutPanel GameFieldsFlowPanel;
        private FlowLayoutPanel ToolbarFlowPanel;
        private RadioButton CrossRadioButton;
        private RadioButton CircleRadioButton;
        private Label GameResultLabel;
        private FlowLayoutPanel GameResultLayoutPanel;
    }
}