namespace avtovokzal
{
    partial class Главное_меню
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            cmdFrom = new ComboBox();
            cmdTo = new ComboBox();
            dtDeparture = new DateTimePicker();
            dtReturn = new DateTimePicker();
            numPassengers = new NumericUpDown();
            btnSearch = new Button();
            dgvResults = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPassengers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // cmdFrom
            // 
            cmdFrom.FormattingEnabled = true;
            cmdFrom.Location = new Point(48, 29);
            cmdFrom.Name = "cmdFrom";
            cmdFrom.Size = new Size(121, 23);
            cmdFrom.TabIndex = 1;
            // 
            // cmdTo
            // 
            cmdTo.FormattingEnabled = true;
            cmdTo.Location = new Point(233, 29);
            cmdTo.Name = "cmdTo";
            cmdTo.Size = new Size(121, 23);
            cmdTo.TabIndex = 2;
            // 
            // dtDeparture
            // 
            dtDeparture.Location = new Point(421, 29);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.Size = new Size(119, 23);
            dtDeparture.TabIndex = 3;
            // 
            // dtReturn
            // 
            dtReturn.Location = new Point(610, 29);
            dtReturn.Name = "dtReturn";
            dtReturn.Size = new Size(119, 23);
            dtReturn.TabIndex = 4;
            // 
            // numPassengers
            // 
            numPassengers.Location = new Point(609, 94);
            numPassengers.Name = "numPassengers";
            numPassengers.Size = new Size(120, 23);
            numPassengers.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(492, 234);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(48, 145);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(240, 150);
            dgvResults.TabIndex = 7;
            // 
            // Главное_меню
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResults);
            Controls.Add(btnSearch);
            Controls.Add(numPassengers);
            Controls.Add(dtReturn);
            Controls.Add(dtDeparture);
            Controls.Add(cmdTo);
            Controls.Add(cmdFrom);
            Name = "Главное_меню";
            Text = "Главное_меню";
            Load += Главное_меню_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPassengers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ComboBox cmdFrom;
        private ComboBox cmdTo;
        private DateTimePicker dtDeparture;
        private DateTimePicker dtReturn;
        private NumericUpDown numPassengers;
        private Button btnSearch;
        private DataGridView dgvResults;
    }
}