namespace WpfApp8
{
    partial class formVitrinaAdmin
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.btnIzmenit = new System.Windows.Forms.Button();
            this.btnYdalit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(40, 35);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnDobavit
            // 
            this.btnDobavit.Location = new System.Drawing.Point(174, 35);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(75, 23);
            this.btnDobavit.TabIndex = 1;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = true;
            // 
            // btnIzmenit
            // 
            this.btnIzmenit.Location = new System.Drawing.Point(340, 35);
            this.btnIzmenit.Name = "btnIzmenit";
            this.btnIzmenit.Size = new System.Drawing.Size(75, 23);
            this.btnIzmenit.TabIndex = 2;
            this.btnIzmenit.Text = "Изменить";
            this.btnIzmenit.UseVisualStyleBackColor = true;
            // 
            // btnYdalit
            // 
            this.btnYdalit.Location = new System.Drawing.Point(494, 35);
            this.btnYdalit.Name = "btnYdalit";
            this.btnYdalit.Size = new System.Drawing.Size(75, 23);
            this.btnYdalit.TabIndex = 3;
            this.btnYdalit.Text = "Удалить";
            this.btnYdalit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // formVitrinaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnYdalit);
            this.Controls.Add(this.btnIzmenit);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.btnMenu);
            this.Name = "formVitrinaAdmin";
            this.Text = "formVitrinaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDobavit;
        private System.Windows.Forms.Button btnIzmenit;
        private System.Windows.Forms.Button btnYdalit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}