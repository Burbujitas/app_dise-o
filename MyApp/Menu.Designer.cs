
namespace MyApp
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenu2 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.addProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.codigosBarra = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenu3 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu4 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.rjDropdownMenu5 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.menuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.rjDropdownMenu2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.rjDropdownMenu5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por categoria";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(353, 89);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 4;
            this.rjComboBox1.Texts = "";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(620, 358);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.Text = "Editar Columna";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.agregarProductoToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(169, 92);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ayudaToolStripMenuItem.Text = "ayuda";
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.IsMainMenu = false;
            this.rjDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProducto,
            this.categorias,
            this.codigosBarra,
            this.Ayuda});
            this.rjDropdownMenu2.MenuItemHeight = 25;
            this.rjDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Name = "rjDropdownMenu2";
            this.rjDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(185, 92);
            this.rjDropdownMenu2.Text = "Menu";
            // 
            // addProducto
            // 
            this.addProducto.Name = "addProducto";
            this.addProducto.Size = new System.Drawing.Size(184, 22);
            this.addProducto.Text = "Agregar Producto";
            // 
            // categorias
            // 
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(184, 22);
            this.categorias.Text = "Organizar Categorias";
            // 
            // codigosBarra
            // 
            this.codigosBarra.Name = "codigosBarra";
            this.codigosBarra.Size = new System.Drawing.Size(184, 22);
            this.codigosBarra.Text = "Codigos de barra";
            // 
            // Ayuda
            // 
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(184, 22);
            this.Ayuda.Text = "Ayuda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem1.Text = "menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem2,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem2
            // 
            this.menuToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem1,
            this.organizarCategoriasToolStripMenuItem,
            this.codigoDeBarrasToolStripMenuItem});
            this.menuToolStripMenuItem2.Name = "menuToolStripMenuItem2";
            this.menuToolStripMenuItem2.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem2.Text = "Menu";
            this.menuToolStripMenuItem2.Click += new System.EventHandler(this.menuToolStripMenuItem2_Click);
            // 
            // rjDropdownMenu3
            // 
            this.rjDropdownMenu3.IsMainMenu = false;
            this.rjDropdownMenu3.MenuItemHeight = 25;
            this.rjDropdownMenu3.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Name = "rjDropdownMenu3";
            this.rjDropdownMenu3.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu3.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu4
            // 
            this.rjDropdownMenu4.IsMainMenu = false;
            this.rjDropdownMenu4.MenuItemHeight = 25;
            this.rjDropdownMenu4.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Name = "rjDropdownMenu4";
            this.rjDropdownMenu4.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu4.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDropdownMenu5
            // 
            this.rjDropdownMenu5.IsMainMenu = false;
            this.rjDropdownMenu5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem3,
            this.agregarToolStripMenuItem,
            this.ferToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.rjDropdownMenu5.MenuItemHeight = 25;
            this.rjDropdownMenu5.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu5.Name = "rjDropdownMenu5";
            this.rjDropdownMenu5.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu5.Size = new System.Drawing.Size(115, 92);
            // 
            // menuToolStripMenuItem3
            // 
            this.menuToolStripMenuItem3.Name = "menuToolStripMenuItem3";
            this.menuToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.menuToolStripMenuItem3.Text = "menu";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.agregarToolStripMenuItem.Text = "agregar";
            // 
            // ferToolStripMenuItem
            // 
            this.ferToolStripMenuItem.Name = "ferToolStripMenuItem";
            this.ferToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ferToolStripMenuItem.Text = "fer";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // agregarProductoToolStripMenuItem1
            // 
            this.agregarProductoToolStripMenuItem1.Name = "agregarProductoToolStripMenuItem1";
            this.agregarProductoToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.agregarProductoToolStripMenuItem1.Text = "Agregar producto";
            this.agregarProductoToolStripMenuItem1.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem1_Click);
            // 
            // organizarCategoriasToolStripMenuItem
            // 
            this.organizarCategoriasToolStripMenuItem.Name = "organizarCategoriasToolStripMenuItem";
            this.organizarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.organizarCategoriasToolStripMenuItem.Text = "Organizar categorias";
            // 
            // codigoDeBarrasToolStripMenuItem
            // 
            this.codigoDeBarrasToolStripMenuItem.Name = "codigoDeBarrasToolStripMenuItem";
            this.codigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.codigoDeBarrasToolStripMenuItem.Text = "Codigo de barras";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(31, 88);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(200, 31);
            this.rjTextBox1.TabIndex = 14;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.rjDropdownMenu2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rjDropdownMenu5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu2;
        private System.Windows.Forms.ToolStripMenuItem addProducto;
        private System.Windows.Forms.ToolStripMenuItem categorias;
        private System.Windows.Forms.ToolStripMenuItem codigosBarra;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem2;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu3;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu4;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu5;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem organizarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeBarrasToolStripMenuItem;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
    }
}