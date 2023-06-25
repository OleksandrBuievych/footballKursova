namespace footballKursova
{
    partial class Form1
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
            this.displayStateButton = new System.Windows.Forms.Button();
            this.printTableButton = new System.Windows.Forms.Button();
            this.addResultButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tournamentsListBox = new System.Windows.Forms.ListBox();
            this.tournamentTableGridView = new System.Windows.Forms.DataGridView();
            this.tournamentCalendarGridView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.matchesCheckBox = new System.Windows.Forms.CheckBox();
            this.schemeLabel = new System.Windows.Forms.TextBox();
            this.teamStatisticsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statistics = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentCalendarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamStatisticsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // displayStateButton
            // 
            this.displayStateButton.Location = new System.Drawing.Point(667, 585);
            this.displayStateButton.Name = "displayStateButton";
            this.displayStateButton.Size = new System.Drawing.Size(112, 59);
            this.displayStateButton.TabIndex = 12;
            this.displayStateButton.Text = "Вивести статистику";
            this.displayStateButton.UseVisualStyleBackColor = true;
            this.displayStateButton.Click += new System.EventHandler(this.displayStateButton_Click);
            // 
            // printTableButton
            // 
            this.printTableButton.Location = new System.Drawing.Point(561, 585);
            this.printTableButton.Name = "printTableButton";
            this.printTableButton.Size = new System.Drawing.Size(100, 59);
            this.printTableButton.TabIndex = 11;
            this.printTableButton.Text = "Друкувати таблицю";
            this.printTableButton.UseVisualStyleBackColor = true;
            this.printTableButton.Click += new System.EventHandler(this.printTableButton_Click);
            // 
            // addResultButton
            // 
            this.addResultButton.Location = new System.Drawing.Point(444, 585);
            this.addResultButton.Name = "addResultButton";
            this.addResultButton.Size = new System.Drawing.Size(94, 59);
            this.addResultButton.TabIndex = 10;
            this.addResultButton.Text = "Додати результат";
            this.addResultButton.UseVisualStyleBackColor = true;
            this.addResultButton.Click += new System.EventHandler(this.addResultButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(332, 585);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 59);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(230, 585);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 59);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Змінити";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(127, 585);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 59);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tournamentsListBox
            // 
            this.tournamentsListBox.FormattingEnabled = true;
            this.tournamentsListBox.ItemHeight = 16;
            this.tournamentsListBox.Location = new System.Drawing.Point(81, 193);
            this.tournamentsListBox.Name = "tournamentsListBox";
            this.tournamentsListBox.Size = new System.Drawing.Size(120, 84);
            this.tournamentsListBox.TabIndex = 13;
            // 
            // tournamentTableGridView
            // 
            this.tournamentTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentTableGridView.Location = new System.Drawing.Point(291, 193);
            this.tournamentTableGridView.Name = "tournamentTableGridView";
            this.tournamentTableGridView.RowHeadersWidth = 51;
            this.tournamentTableGridView.RowTemplate.Height = 24;
            this.tournamentTableGridView.Size = new System.Drawing.Size(240, 150);
            this.tournamentTableGridView.TabIndex = 14;
            // 
            // tournamentCalendarGridView
            // 
            this.tournamentCalendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentCalendarGridView.Location = new System.Drawing.Point(571, 193);
            this.tournamentCalendarGridView.Name = "tournamentCalendarGridView";
            this.tournamentCalendarGridView.RowHeadersWidth = 51;
            this.tournamentCalendarGridView.RowTemplate.Height = 24;
            this.tournamentCalendarGridView.Size = new System.Drawing.Size(240, 150);
            this.tournamentCalendarGridView.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 412);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 16;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(80, 466);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 17;
            // 
            // matchesCheckBox
            // 
            this.matchesCheckBox.AutoSize = true;
            this.matchesCheckBox.Location = new System.Drawing.Point(86, 521);
            this.matchesCheckBox.Name = "matchesCheckBox";
            this.matchesCheckBox.Size = new System.Drawing.Size(95, 21);
            this.matchesCheckBox.TabIndex = 18;
            this.matchesCheckBox.Text = "Має матчі";
            this.matchesCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemeLabel
            // 
            this.schemeLabel.Location = new System.Drawing.Point(81, 338);
            this.schemeLabel.Name = "schemeLabel";
            this.schemeLabel.Size = new System.Drawing.Size(100, 22);
            this.schemeLabel.TabIndex = 20;
            // 
            // teamStatisticsGridView
            // 
            this.teamStatisticsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamStatisticsGridView.Location = new System.Drawing.Point(291, 391);
            this.teamStatisticsGridView.Name = "teamStatisticsGridView";
            this.teamStatisticsGridView.RowHeadersWidth = 51;
            this.teamStatisticsGridView.RowTemplate.Height = 24;
            this.teamStatisticsGridView.Size = new System.Drawing.Size(240, 150);
            this.teamStatisticsGridView.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Таблиця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Календар";
            // 
            // statistics
            // 
            this.statistics.AutoSize = true;
            this.statistics.Location = new System.Drawing.Point(365, 358);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(84, 17);
            this.statistics.TabIndex = 24;
            this.statistics.Text = "Статистика";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(844, 193);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(931, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Таблиця 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Схема";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Назва";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Тип турніру";
            // 
            // saveTable
            // 
            this.saveTable.Location = new System.Drawing.Point(785, 585);
            this.saveTable.Name = "saveTable";
            this.saveTable.Size = new System.Drawing.Size(92, 59);
            this.saveTable.TabIndex = 29;
            this.saveTable.Text = "Зберегти таблицю";
            this.saveTable.UseVisualStyleBackColor = true;
            this.saveTable.Click += new System.EventHandler(this.saveTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 656);
            this.Controls.Add(this.saveTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamStatisticsGridView);
            this.Controls.Add(this.schemeLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.matchesCheckBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.tournamentCalendarGridView);
            this.Controls.Add(this.tournamentTableGridView);
            this.Controls.Add(this.tournamentsListBox);
            this.Controls.Add(this.displayStateButton);
            this.Controls.Add(this.printTableButton);
            this.Controls.Add(this.addResultButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tournamentTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentCalendarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamStatisticsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayStateButton;
        private System.Windows.Forms.Button printTableButton;
        private System.Windows.Forms.Button addResultButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox tournamentsListBox;
        private System.Windows.Forms.DataGridView tournamentTableGridView;
        private System.Windows.Forms.DataGridView tournamentCalendarGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.CheckBox matchesCheckBox;
        private System.Windows.Forms.TextBox schemeLabel;
        private System.Windows.Forms.DataGridView teamStatisticsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statistics;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveTable;
    }
}

