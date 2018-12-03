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
            this.graph_Panel = new DecisionTreeSimulation.DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 60);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(790, 192);
            this.dataGrid.TabIndex = 0;
            // 
            // addClause_Button
            // 
            this.addClause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClause_Button.Location = new System.Drawing.Point(175, 3);
            this.addClause_Button.Name = "addClause_Button";
            this.addClause_Button.Size = new System.Drawing.Size(186, 42);
            this.addClause_Button.TabIndex = 1;
            this.addClause_Button.Text = "Thêm Cột Dữ Liệu";
            this.addClause_Button.UseVisualStyleBackColor = true;
            this.addClause_Button.Click += new System.EventHandler(this.addClause_Button_Click);
            // 
            // removeClause_Button
            // 
            this.removeClause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeClause_Button.Location = new System.Drawing.Point(367, 3);
            this.removeClause_Button.Name = "removeClause_Button";
            this.removeClause_Button.Size = new System.Drawing.Size(159, 42);
            this.removeClause_Button.TabIndex = 2;
            this.removeClause_Button.Text = "Xoá Cột Dữ Liệu";
            this.removeClause_Button.UseVisualStyleBackColor = true;
            this.removeClause_Button.Click += new System.EventHandler(this.removeClause_Button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(532, 3);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(94, 42);
            this.reset_Button.TabIndex = 3;
            this.reset_Button.Text = "Đặt Lại";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // inputClause_TextBox
            // 
            this.inputClause_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputClause_TextBox.Location = new System.Drawing.Point(12, 9);
            this.inputClause_TextBox.Name = "inputClause_TextBox";
            this.inputClause_TextBox.Size = new System.Drawing.Size(157, 23);
            this.inputClause_TextBox.TabIndex = 4;
            // 
            // buildDecisionTree_Button
            // 
            this.buildDecisionTree_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildDecisionTree_Button.Location = new System.Drawing.Point(315, 300);
            this.buildDecisionTree_Button.Name = "buildDecisionTree_Button";
            this.buildDecisionTree_Button.Size = new System.Drawing.Size(176, 57);
            this.buildDecisionTree_Button.TabIndex = 5;
            this.buildDecisionTree_Button.Text = "Xây Dựng Cây Và Kiểm Tra Kết Quả";
            this.buildDecisionTree_Button.UseVisualStyleBackColor = true;
            this.buildDecisionTree_Button.Click += new System.EventHandler(this.buildDecisionTree_Button_Click);
            // 
            // open_Button
            // 
            this.open_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_Button.Location = new System.Drawing.Point(632, 3);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(158, 42);
            this.open_Button.TabIndex = 7;
            this.open_Button.Text = "Mở Từ File Text";
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // input_check
            // 
            this.input_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_check.Location = new System.Drawing.Point(189, 265);
            this.input_check.Name = "input_check";
            this.input_check.Size = new System.Drawing.Size(245, 23);
            this.input_check.TabIndex = 8;
            this.input_check.Text = "Đen,Cao,Nặng,Có dùng thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông Tin Cần Kiểm Tra :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kết Quả : ";
            // 
            // graph_Panel
            // 
            this.graph_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graph_Panel.Location = new System.Drawing.Point(0, 363);
            this.graph_Panel.Name = "graph_Panel";
            this.graph_Panel.Size = new System.Drawing.Size(790, 274);
            this.graph_Panel.TabIndex = 6;
            this.graph_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Panel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 649);
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
    }
}

