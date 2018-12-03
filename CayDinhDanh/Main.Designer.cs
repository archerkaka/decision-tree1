namespace DecisionTreeSimulation
{
    partial class Main
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addClause_Button = new System.Windows.Forms.Button();
            this.removeClause_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.inputClause_TextBox = new System.Windows.Forms.TextBox();
            this.buildDecisionTree_Button = new System.Windows.Forms.Button();
            this.open_Button = new System.Windows.Forms.Button();
            this.input_check = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.rules_textBox = new System.Windows.Forms.TextBox();
            this.graph_Panel = new DecisionTreeSimulation.DoubleBufferedPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(3, 74);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1053, 236);
            this.dataGrid.TabIndex = 0;
            // 
            // addClause_Button
            // 
            this.addClause_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClause_Button.Location = new System.Drawing.Point(235, 4);
            this.addClause_Button.Margin = new System.Windows.Forms.Padding(4);
            this.addClause_Button.Name = "addClause_Button";
            this.addClause_Button.Size = new System.Drawing.Size(248, 52);
            this.addClause_Button.TabIndex = 1;
            this.addClause_Button.Text = "Thêm Cột Dữ Liệu";
            this.addClause_Button.UseVisualStyleBackColor = true;
            this.addClause_Button.Click += new System.EventHandler(this.addClause_Button_Click);
            // 
            // removeClause_Button
            // 
            this.removeClause_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeClause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeClause_Button.Location = new System.Drawing.Point(491, 4);
            this.removeClause_Button.Margin = new System.Windows.Forms.Padding(4);
            this.removeClause_Button.Name = "removeClause_Button";
            this.removeClause_Button.Size = new System.Drawing.Size(212, 52);
            this.removeClause_Button.TabIndex = 2;
            this.removeClause_Button.Text = "Xoá Cột Dữ Liệu";
            this.removeClause_Button.UseVisualStyleBackColor = true;
            this.removeClause_Button.Click += new System.EventHandler(this.removeClause_Button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(711, 4);
            this.reset_Button.Margin = new System.Windows.Forms.Padding(4);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(125, 52);
            this.reset_Button.TabIndex = 3;
            this.reset_Button.Text = "Đặt Lại";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // inputClause_TextBox
            // 
            this.inputClause_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputClause_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputClause_TextBox.Location = new System.Drawing.Point(19, 11);
            this.inputClause_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputClause_TextBox.Name = "inputClause_TextBox";
            this.inputClause_TextBox.Size = new System.Drawing.Size(208, 26);
            this.inputClause_TextBox.TabIndex = 4;
            // 
            // buildDecisionTree_Button
            // 
            this.buildDecisionTree_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildDecisionTree_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildDecisionTree_Button.Location = new System.Drawing.Point(395, 318);
            this.buildDecisionTree_Button.Margin = new System.Windows.Forms.Padding(4);
            this.buildDecisionTree_Button.Name = "buildDecisionTree_Button";
            this.buildDecisionTree_Button.Size = new System.Drawing.Size(235, 60);
            this.buildDecisionTree_Button.TabIndex = 5;
            this.buildDecisionTree_Button.Text = "Xây Dựng Cây \r\n";
            this.buildDecisionTree_Button.UseVisualStyleBackColor = true;
            this.buildDecisionTree_Button.Click += new System.EventHandler(this.buildDecisionTree_Button_Click);
            // 
            // open_Button
            // 
            this.open_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_Button.Location = new System.Drawing.Point(845, 4);
            this.open_Button.Margin = new System.Windows.Forms.Padding(4);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(211, 52);
            this.open_Button.TabIndex = 7;
            this.open_Button.Text = "Mở Từ File Text";
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // input_check
            // 
            this.input_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_check.Location = new System.Drawing.Point(264, 744);
            this.input_check.Margin = new System.Windows.Forms.Padding(4);
            this.input_check.Name = "input_check";
            this.input_check.Size = new System.Drawing.Size(456, 26);
            this.input_check.TabIndex = 8;
            this.input_check.Text = "male,0,cheap,low";
            this.input_check.TextChanged += new System.EventHandler(this.input_check_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 750);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trường Hợp Cần Kiểm Tra :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 800);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kết Quả : ";
            // 
            // check_button
            // 
            this.check_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_button.Location = new System.Drawing.Point(765, 743);
            this.check_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(219, 36);
            this.check_button.TabIndex = 11;
            this.check_button.Text = "Kiểm Tra";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // rules_textBox
            // 
            this.rules_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules_textBox.Location = new System.Drawing.Point(1100, 74);
            this.rules_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rules_textBox.Multiline = true;
            this.rules_textBox.Name = "rules_textBox";
            this.rules_textBox.ReadOnly = true;
            this.rules_textBox.Size = new System.Drawing.Size(393, 649);
            this.rules_textBox.TabIndex = 12;
            // 
            // graph_Panel
            // 
            this.graph_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graph_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graph_Panel.Location = new System.Drawing.Point(3, 386);
            this.graph_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.graph_Panel.Name = "graph_Panel";
            this.graph_Panel.Size = new System.Drawing.Size(1053, 337);
            this.graph_Panel.TabIndex = 6;
            this.graph_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1216, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Các Luật Tìm Được";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 848);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rules_textBox);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_check);
            this.Controls.Add(this.open_Button);
            this.Controls.Add(this.graph_Panel);
            this.Controls.Add(this.buildDecisionTree_Button);
            this.Controls.Add(this.inputClause_TextBox);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.removeClause_Button);
            this.Controls.Add(this.addClause_Button);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Mô Phỏng Cây Quyết Định";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button addClause_Button;
        private System.Windows.Forms.Button removeClause_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.TextBox inputClause_TextBox;
        private System.Windows.Forms.Button buildDecisionTree_Button;
        private DoubleBufferedPanel graph_Panel;
        private System.Windows.Forms.Button open_Button;
        private System.Windows.Forms.TextBox input_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.TextBox rules_textBox;
        private System.Windows.Forms.Label label3;
    }
}

