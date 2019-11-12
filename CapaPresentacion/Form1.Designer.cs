namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BotonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LabelError = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Textboxfalso = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(74, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // TextboxNombre
            // 
            this.TextboxNombre.BackColor = System.Drawing.Color.White;
            this.TextboxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.TextboxNombre.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxNombre.HintText = "";
            this.TextboxNombre.isPassword = false;
            this.TextboxNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.TextboxNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.TextboxNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.TextboxNombre.LineThickness = 3;
            this.TextboxNombre.Location = new System.Drawing.Point(82, 282);
            this.TextboxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxNombre.Name = "TextboxNombre";
            this.TextboxNombre.Size = new System.Drawing.Size(321, 33);
            this.TextboxNombre.TabIndex = 6;
            this.TextboxNombre.Text = "Tobiaslongstaff";
            this.TextboxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(77, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(77, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "CONTRASEÑA";
            // 
            // BotonCrear
            // 
            this.BotonCrear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(231)))));
            this.BotonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(231)))));
            this.BotonCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCrear.BorderRadius = 0;
            this.BotonCrear.ButtonText = "CREAR";
            this.BotonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCrear.DisabledColor = System.Drawing.Color.Gray;
            this.BotonCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrear.Iconcolor = System.Drawing.Color.Transparent;
            this.BotonCrear.Iconimage = null;
            this.BotonCrear.Iconimage_right = null;
            this.BotonCrear.Iconimage_right_Selected = null;
            this.BotonCrear.Iconimage_Selected = null;
            this.BotonCrear.IconMarginLeft = 0;
            this.BotonCrear.IconMarginRight = 0;
            this.BotonCrear.IconRightVisible = true;
            this.BotonCrear.IconRightZoom = 0D;
            this.BotonCrear.IconVisible = true;
            this.BotonCrear.IconZoom = 90D;
            this.BotonCrear.IsTab = false;
            this.BotonCrear.Location = new System.Drawing.Point(247, 451);
            this.BotonCrear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(231)))));
            this.BotonCrear.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.BotonCrear.OnHoverTextColor = System.Drawing.Color.White;
            this.BotonCrear.selected = false;
            this.BotonCrear.Size = new System.Drawing.Size(156, 44);
            this.BotonCrear.TabIndex = 10;
            this.BotonCrear.Text = "CREAR";
            this.BotonCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonCrear.Textcolor = System.Drawing.Color.White;
            this.BotonCrear.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // BotonLogin
            // 
            this.BotonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.BotonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.BotonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonLogin.BorderRadius = 0;
            this.BotonLogin.ButtonText = "LOGIN";
            this.BotonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BotonLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BotonLogin.Iconimage = null;
            this.BotonLogin.Iconimage_right = null;
            this.BotonLogin.Iconimage_right_Selected = null;
            this.BotonLogin.Iconimage_Selected = null;
            this.BotonLogin.IconMarginLeft = 0;
            this.BotonLogin.IconMarginRight = 0;
            this.BotonLogin.IconRightVisible = true;
            this.BotonLogin.IconRightZoom = 0D;
            this.BotonLogin.IconVisible = true;
            this.BotonLogin.IconZoom = 90D;
            this.BotonLogin.IsTab = false;
            this.BotonLogin.Location = new System.Drawing.Point(82, 451);
            this.BotonLogin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.BotonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BotonLogin.selected = false;
            this.BotonLogin.Size = new System.Drawing.Size(156, 44);
            this.BotonLogin.TabIndex = 11;
            this.BotonLogin.Text = "LOGIN";
            this.BotonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonLogin.Textcolor = System.Drawing.Color.White;
            this.BotonLogin.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLogin.Click += new System.EventHandler(this.BotonLogin_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(801, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.White;
            this.LabelError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.LabelError.Location = new System.Drawing.Point(106, 413);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(38, 17);
            this.LabelError.TabIndex = 13;
            this.LabelError.Text = "Error";
            this.LabelError.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Textboxfalso
            // 
            this.Textboxfalso.BackColor = System.Drawing.Color.White;
            this.Textboxfalso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textboxfalso.Enabled = false;
            this.Textboxfalso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textboxfalso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Textboxfalso.HintForeColor = System.Drawing.Color.Empty;
            this.Textboxfalso.HintText = "";
            this.Textboxfalso.isPassword = true;
            this.Textboxfalso.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.Textboxfalso.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.Textboxfalso.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.Textboxfalso.LineThickness = 3;
            this.Textboxfalso.Location = new System.Drawing.Point(82, 362);
            this.Textboxfalso.Margin = new System.Windows.Forms.Padding(4);
            this.Textboxfalso.Name = "Textboxfalso";
            this.Textboxfalso.Size = new System.Drawing.Size(321, 33);
            this.Textboxfalso.TabIndex = 23;
            this.Textboxfalso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxContraseña
            // 
            this.TextboxContraseña.BackColor = System.Drawing.Color.White;
            this.TextboxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextboxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.TextboxContraseña.Location = new System.Drawing.Point(88, 370);
            this.TextboxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxContraseña.MaxLength = 20;
            this.TextboxContraseña.Name = "TextboxContraseña";
            this.TextboxContraseña.Size = new System.Drawing.Size(315, 18);
            this.TextboxContraseña.TabIndex = 39;
            this.TextboxContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxContraseña_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(186)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(841, 530);
            this.Controls.Add(this.TextboxContraseña);
            this.Controls.Add(this.Textboxfalso);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNombre;
        private Bunifu.Framework.UI.BunifuFlatButton BotonLogin;
        private Bunifu.Framework.UI.BunifuFlatButton BotonCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textboxfalso;
        private System.Windows.Forms.TextBox TextboxContraseña;
    }
}

