namespace ProblemGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.output_panel = new System.Windows.Forms.Panel();
            this.main_output = new System.Windows.Forms.RichTextBox();
            this.options_panel = new System.Windows.Forms.Panel();
            this.Square_tab = new System.Windows.Forms.TabControl();
            this.square_page = new System.Windows.Forms.TabPage();
            this.sq_only_integer = new System.Windows.Forms.CheckBox();
            this.sq_generate_button = new System.Windows.Forms.Button();
            this.sq_generate_2_root = new System.Windows.Forms.CheckBox();
            this.sq_generate_1_root = new System.Windows.Forms.CheckBox();
            this.sq_generate_0_root = new System.Windows.Forms.CheckBox();
            this.sq_C_to = new System.Windows.Forms.TextBox();
            this.sq_B_to = new System.Windows.Forms.TextBox();
            this.sq_A_to = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sq_num2gen = new System.Windows.Forms.TextBox();
            this.sq_C_from = new System.Windows.Forms.TextBox();
            this.sq_B_from = new System.Windows.Forms.TextBox();
            this.sq_A_from = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sq_num2gen_label = new System.Windows.Forms.Label();
            this.sq_C_label = new System.Windows.Forms.Label();
            this.sq_B_label = new System.Windows.Forms.Label();
            this.sq_A_label = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.module_Eq_string = new System.Windows.Forms.TextBox();
            this.number_of_module_eq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.output_panel.SuspendLayout();
            this.options_panel.SuspendLayout();
            this.Square_tab.SuspendLayout();
            this.square_page.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.output_panel);
            this.main_panel.Controls.Add(this.options_panel);
            this.main_panel.Controls.Add(this.menuStrip1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(864, 424);
            this.main_panel.TabIndex = 0;
            // 
            // output_panel
            // 
            this.output_panel.Controls.Add(this.main_output);
            this.output_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_panel.Location = new System.Drawing.Point(213, 24);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(651, 400);
            this.output_panel.TabIndex = 4;
            // 
            // main_output
            // 
            this.main_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_output.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_output.Location = new System.Drawing.Point(0, 0);
            this.main_output.Name = "main_output";
            this.main_output.Size = new System.Drawing.Size(651, 400);
            this.main_output.TabIndex = 0;
            this.main_output.Text = "";
            // 
            // options_panel
            // 
            this.options_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.options_panel.Controls.Add(this.Square_tab);
            this.options_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.options_panel.Location = new System.Drawing.Point(0, 24);
            this.options_panel.Name = "options_panel";
            this.options_panel.Size = new System.Drawing.Size(213, 400);
            this.options_panel.TabIndex = 3;
            // 
            // Square_tab
            // 
            this.Square_tab.Controls.Add(this.square_page);
            this.Square_tab.Controls.Add(this.tabPage1);
            this.Square_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Square_tab.Location = new System.Drawing.Point(0, 0);
            this.Square_tab.Name = "Square_tab";
            this.Square_tab.SelectedIndex = 0;
            this.Square_tab.Size = new System.Drawing.Size(213, 400);
            this.Square_tab.TabIndex = 1;
            // 
            // square_page
            // 
            this.square_page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.square_page.Controls.Add(this.sq_only_integer);
            this.square_page.Controls.Add(this.sq_generate_button);
            this.square_page.Controls.Add(this.sq_generate_2_root);
            this.square_page.Controls.Add(this.sq_generate_1_root);
            this.square_page.Controls.Add(this.sq_generate_0_root);
            this.square_page.Controls.Add(this.sq_C_to);
            this.square_page.Controls.Add(this.sq_B_to);
            this.square_page.Controls.Add(this.sq_A_to);
            this.square_page.Controls.Add(this.richTextBox1);
            this.square_page.Controls.Add(this.sq_num2gen);
            this.square_page.Controls.Add(this.sq_C_from);
            this.square_page.Controls.Add(this.sq_B_from);
            this.square_page.Controls.Add(this.sq_A_from);
            this.square_page.Controls.Add(this.label3);
            this.square_page.Controls.Add(this.label2);
            this.square_page.Controls.Add(this.label1);
            this.square_page.Controls.Add(this.sq_num2gen_label);
            this.square_page.Controls.Add(this.sq_C_label);
            this.square_page.Controls.Add(this.sq_B_label);
            this.square_page.Controls.Add(this.sq_A_label);
            this.square_page.Location = new System.Drawing.Point(4, 22);
            this.square_page.Name = "square_page";
            this.square_page.Padding = new System.Windows.Forms.Padding(3);
            this.square_page.Size = new System.Drawing.Size(205, 374);
            this.square_page.TabIndex = 0;
            this.square_page.Text = "Square";
            // 
            // sq_only_integer
            // 
            this.sq_only_integer.AutoSize = true;
            this.sq_only_integer.Checked = true;
            this.sq_only_integer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sq_only_integer.Location = new System.Drawing.Point(6, 185);
            this.sq_only_integer.Name = "sq_only_integer";
            this.sq_only_integer.Size = new System.Drawing.Size(108, 17);
            this.sq_only_integer.TabIndex = 20;
            this.sq_only_integer.Text = "Only integer roots";
            this.sq_only_integer.UseVisualStyleBackColor = true;
            // 
            // sq_generate_button
            // 
            this.sq_generate_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sq_generate_button.Location = new System.Drawing.Point(3, 348);
            this.sq_generate_button.Name = "sq_generate_button";
            this.sq_generate_button.Size = new System.Drawing.Size(199, 23);
            this.sq_generate_button.TabIndex = 16;
            this.sq_generate_button.Text = "Generate";
            this.sq_generate_button.UseVisualStyleBackColor = true;
            this.sq_generate_button.Click += new System.EventHandler(this.sq_generate_button_Click);
            // 
            // sq_generate_2_root
            // 
            this.sq_generate_2_root.AutoSize = true;
            this.sq_generate_2_root.Checked = true;
            this.sq_generate_2_root.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sq_generate_2_root.Location = new System.Drawing.Point(6, 162);
            this.sq_generate_2_root.Name = "sq_generate_2_root";
            this.sq_generate_2_root.Size = new System.Drawing.Size(150, 17);
            this.sq_generate_2_root.TabIndex = 19;
            this.sq_generate_2_root.Text = "Generate 2 roots problems";
            this.sq_generate_2_root.UseVisualStyleBackColor = true;
            // 
            // sq_generate_1_root
            // 
            this.sq_generate_1_root.AutoSize = true;
            this.sq_generate_1_root.Location = new System.Drawing.Point(6, 139);
            this.sq_generate_1_root.Name = "sq_generate_1_root";
            this.sq_generate_1_root.Size = new System.Drawing.Size(145, 17);
            this.sq_generate_1_root.TabIndex = 18;
            this.sq_generate_1_root.Text = "Generate 1 root problems";
            this.sq_generate_1_root.UseVisualStyleBackColor = true;
            // 
            // sq_generate_0_root
            // 
            this.sq_generate_0_root.AutoSize = true;
            this.sq_generate_0_root.Location = new System.Drawing.Point(6, 116);
            this.sq_generate_0_root.Name = "sq_generate_0_root";
            this.sq_generate_0_root.Size = new System.Drawing.Size(150, 17);
            this.sq_generate_0_root.TabIndex = 17;
            this.sq_generate_0_root.Text = "Generate 0 roots problems";
            this.sq_generate_0_root.UseVisualStyleBackColor = true;
            // 
            // sq_C_to
            // 
            this.sq_C_to.Location = new System.Drawing.Point(70, 85);
            this.sq_C_to.Name = "sq_C_to";
            this.sq_C_to.Size = new System.Drawing.Size(22, 20);
            this.sq_C_to.TabIndex = 15;
            this.sq_C_to.Text = "10";
            // 
            // sq_B_to
            // 
            this.sq_B_to.Location = new System.Drawing.Point(70, 59);
            this.sq_B_to.Name = "sq_B_to";
            this.sq_B_to.Size = new System.Drawing.Size(22, 20);
            this.sq_B_to.TabIndex = 13;
            this.sq_B_to.Text = "10";
            // 
            // sq_A_to
            // 
            this.sq_A_to.Location = new System.Drawing.Point(70, 33);
            this.sq_A_to.Name = "sq_A_to";
            this.sq_A_to.Size = new System.Drawing.Size(22, 20);
            this.sq_A_to.TabIndex = 11;
            this.sq_A_to.Text = "10";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(135, 22);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Ax^2+Bx^2+C=0";
            // 
            // sq_num2gen
            // 
            this.sq_num2gen.Location = new System.Drawing.Point(173, 214);
            this.sq_num2gen.Name = "sq_num2gen";
            this.sq_num2gen.Size = new System.Drawing.Size(22, 20);
            this.sq_num2gen.TabIndex = 7;
            this.sq_num2gen.Text = "10";
            // 
            // sq_C_from
            // 
            this.sq_C_from.Location = new System.Drawing.Point(26, 85);
            this.sq_C_from.Name = "sq_C_from";
            this.sq_C_from.Size = new System.Drawing.Size(22, 20);
            this.sq_C_from.TabIndex = 5;
            this.sq_C_from.Text = "1";
            // 
            // sq_B_from
            // 
            this.sq_B_from.Location = new System.Drawing.Point(26, 59);
            this.sq_B_from.Name = "sq_B_from";
            this.sq_B_from.Size = new System.Drawing.Size(22, 20);
            this.sq_B_from.TabIndex = 3;
            this.sq_B_from.Text = "1";
            // 
            // sq_A_from
            // 
            this.sq_A_from.Location = new System.Drawing.Point(26, 33);
            this.sq_A_from.Name = "sq_A_from";
            this.sq_A_from.Size = new System.Drawing.Size(22, 20);
            this.sq_A_from.TabIndex = 1;
            this.sq_A_from.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // sq_num2gen_label
            // 
            this.sq_num2gen_label.AutoSize = true;
            this.sq_num2gen_label.Location = new System.Drawing.Point(6, 217);
            this.sq_num2gen_label.Name = "sq_num2gen_label";
            this.sq_num2gen_label.Size = new System.Drawing.Size(161, 13);
            this.sq_num2gen_label.TabIndex = 8;
            this.sq_num2gen_label.Text = "Number of problems to generate:";
            // 
            // sq_C_label
            // 
            this.sq_C_label.AutoSize = true;
            this.sq_C_label.Location = new System.Drawing.Point(6, 88);
            this.sq_C_label.Name = "sq_C_label";
            this.sq_C_label.Size = new System.Drawing.Size(14, 13);
            this.sq_C_label.TabIndex = 6;
            this.sq_C_label.Text = "C";
            // 
            // sq_B_label
            // 
            this.sq_B_label.AutoSize = true;
            this.sq_B_label.Location = new System.Drawing.Point(6, 62);
            this.sq_B_label.Name = "sq_B_label";
            this.sq_B_label.Size = new System.Drawing.Size(14, 13);
            this.sq_B_label.TabIndex = 4;
            this.sq_B_label.Text = "B";
            // 
            // sq_A_label
            // 
            this.sq_A_label.AutoSize = true;
            this.sq_A_label.Location = new System.Drawing.Point(6, 36);
            this.sq_A_label.Name = "sq_A_label";
            this.sq_A_label.Size = new System.Drawing.Size(14, 13);
            this.sq_A_label.TabIndex = 2;
            this.sq_A_label.Text = "A";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.number_of_module_eq);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.module_Eq_string);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(205, 374);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Module";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.teXToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // teXToolStripMenuItem
            // 
            this.teXToolStripMenuItem.Name = "teXToolStripMenuItem";
            this.teXToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.teXToolStripMenuItem.Text = "TeX";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // module_Eq_string
            // 
            this.module_Eq_string.Location = new System.Drawing.Point(8, 6);
            this.module_Eq_string.Name = "module_Eq_string";
            this.module_Eq_string.Size = new System.Drawing.Size(191, 20);
            this.module_Eq_string.TabIndex = 0;
            // 
            // number_of_module_eq
            // 
            this.number_of_module_eq.Location = new System.Drawing.Point(175, 319);
            this.number_of_module_eq.Name = "number_of_module_eq";
            this.number_of_module_eq.Size = new System.Drawing.Size(22, 20);
            this.number_of_module_eq.TabIndex = 9;
            this.number_of_module_eq.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of problems to generate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 424);
            this.Controls.Add(this.main_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Problem Generator";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.output_panel.ResumeLayout(false);
            this.options_panel.ResumeLayout(false);
            this.Square_tab.ResumeLayout(false);
            this.square_page.ResumeLayout(false);
            this.square_page.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel output_panel;
        private System.Windows.Forms.Panel options_panel;
        private System.Windows.Forms.RichTextBox main_output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl Square_tab;
        private System.Windows.Forms.TabPage square_page;
        private System.Windows.Forms.CheckBox sq_only_integer;
        private System.Windows.Forms.Button sq_generate_button;
        private System.Windows.Forms.CheckBox sq_generate_2_root;
        private System.Windows.Forms.CheckBox sq_generate_1_root;
        private System.Windows.Forms.CheckBox sq_generate_0_root;
        private System.Windows.Forms.TextBox sq_C_to;
        private System.Windows.Forms.TextBox sq_B_to;
        private System.Windows.Forms.TextBox sq_A_to;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox sq_num2gen;
        private System.Windows.Forms.TextBox sq_C_from;
        private System.Windows.Forms.TextBox sq_B_from;
        private System.Windows.Forms.TextBox sq_A_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sq_num2gen_label;
        private System.Windows.Forms.Label sq_C_label;
        private System.Windows.Forms.Label sq_B_label;
        private System.Windows.Forms.Label sq_A_label;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem teXToolStripMenuItem;
        private System.Windows.Forms.TextBox number_of_module_eq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox module_Eq_string;
    }
}

