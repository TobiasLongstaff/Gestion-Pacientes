namespace CapaPresentacion
{
    partial class AgregarRegistroDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRegistroDiario));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BotonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TexboxFecha = new System.Windows.Forms.TextBox();
            this.CheckboxFechaDeHoy = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.FechaYhora = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ComboboxAsistencia = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelHoratext = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.Separatorhora = new Bunifu.Framework.UI.BunifuSeparator();
            this.paneldatagrid = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TextboxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HoraCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.LabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneldatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(312, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.Transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 63);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.Transition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "Agregar registro";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.Date.BorderRadius = 5;
            this.Transition1.SetDecoration(this.Date, BunifuAnimatorNS.DecorationType.None);
            this.Date.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.FormatCustom = "";
            this.Date.Location = new System.Drawing.Point(30, 481);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(293, 36);
            this.Date.TabIndex = 19;
            this.Date.Value = new System.DateTime(2019, 10, 27, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Transition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(25, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "FECHA DE REGISTRO:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.Transition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(25, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition1.SetDecoration(this.textBoxID, BunifuAnimatorNS.DecorationType.None);
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxID.ForeColor = System.Drawing.Color.Gray;
            this.textBoxID.Location = new System.Drawing.Point(68, 276);
            this.textBoxID.MaxLength = 100;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(255, 18);
            this.textBoxID.TabIndex = 35;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(30, 346);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(293, 8);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(25, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "NOMBRE:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition1.SetDecoration(this.textBoxNombre, BunifuAnimatorNS.DecorationType.None);
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNombre.Location = new System.Drawing.Point(30, 330);
            this.textBoxNombre.MaxLength = 100;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(293, 18);
            this.textBoxNombre.TabIndex = 26;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuSeparator4.LineThickness = 3;
            this.bunifuSeparator4.Location = new System.Drawing.Point(68, 291);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(255, 8);
            this.bunifuSeparator4.TabIndex = 37;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.ActiveBorderThickness = 1;
            this.BotonActualizar.ActiveCornerRadius = 20;
            this.BotonActualizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.ActiveForecolor = System.Drawing.Color.White;
            this.BotonActualizar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.BotonActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonActualizar.BackgroundImage")));
            this.BotonActualizar.ButtonText = "Guardar";
            this.BotonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.BotonActualizar, BunifuAnimatorNS.DecorationType.None);
            this.BotonActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.IdleBorderThickness = 1;
            this.BotonActualizar.IdleCornerRadius = 20;
            this.BotonActualizar.IdleFillColor = System.Drawing.Color.White;
            this.BotonActualizar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.Location = new System.Drawing.Point(168, 725);
            this.BotonActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(171, 47);
            this.BotonActualizar.TabIndex = 38;
            this.BotonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // TexboxFecha
            // 
            this.TexboxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition1.SetDecoration(this.TexboxFecha, BunifuAnimatorNS.DecorationType.None);
            this.TexboxFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexboxFecha.Location = new System.Drawing.Point(21, 735);
            this.TexboxFecha.Name = "TexboxFecha";
            this.TexboxFecha.Size = new System.Drawing.Size(140, 26);
            this.TexboxFecha.TabIndex = 59;
            this.TexboxFecha.Text = "1234";
            this.TexboxFecha.Visible = false;
            // 
            // CheckboxFechaDeHoy
            // 
            this.CheckboxFechaDeHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckboxFechaDeHoy.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckboxFechaDeHoy.Checked = true;
            this.CheckboxFechaDeHoy.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Transition1.SetDecoration(this.CheckboxFechaDeHoy, BunifuAnimatorNS.DecorationType.None);
            this.CheckboxFechaDeHoy.ForeColor = System.Drawing.Color.White;
            this.CheckboxFechaDeHoy.Location = new System.Drawing.Point(170, 419);
            this.CheckboxFechaDeHoy.Name = "CheckboxFechaDeHoy";
            this.CheckboxFechaDeHoy.Size = new System.Drawing.Size(20, 20);
            this.CheckboxFechaDeHoy.TabIndex = 60;
            this.CheckboxFechaDeHoy.Click += new System.EventHandler(this.CheckboxFechaDeHoy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.Transition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(25, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "FECHA DE HOY:";
            // 
            // LabelHora
            // 
            this.LabelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelHora.AutoSize = true;
            this.LabelHora.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.LabelHora, BunifuAnimatorNS.DecorationType.None);
            this.LabelHora.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.LabelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.LabelHora.Location = new System.Drawing.Point(13, 161);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(171, 48);
            this.LabelHora.TabIndex = 63;
            this.LabelHora.Text = "24/59/59";
            this.LabelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.Transition1.SetDecoration(this.labelFecha, BunifuAnimatorNS.DecorationType.None);
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.labelFecha.Location = new System.Drawing.Point(16, 209);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(266, 25);
            this.labelFecha.TabIndex = 64;
            this.labelFecha.Text = "viernes 10, octubre 11 de 2019";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaYhora
            // 
            this.FechaYhora.Enabled = true;
            this.FechaYhora.Tick += new System.EventHandler(this.FechaYhora_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Transition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(25, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "ASISTENCIA:";
            // 
            // ComboboxAsistencia
            // 
            this.ComboboxAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.ComboboxAsistencia.BorderRadius = 3;
            this.Transition1.SetDecoration(this.ComboboxAsistencia, BunifuAnimatorNS.DecorationType.None);
            this.ComboboxAsistencia.DisabledColor = System.Drawing.Color.Gray;
            this.ComboboxAsistencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ComboboxAsistencia.ForeColor = System.Drawing.Color.White;
            this.ComboboxAsistencia.Items = new string[] {
        "Ausente",
        "Presente"};
            this.ComboboxAsistencia.Location = new System.Drawing.Point(145, 616);
            this.ComboboxAsistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboboxAsistencia.Name = "ComboboxAsistencia";
            this.ComboboxAsistencia.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.ComboboxAsistencia.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.ComboboxAsistencia.selectedIndex = -1;
            this.ComboboxAsistencia.Size = new System.Drawing.Size(178, 25);
            this.ComboboxAsistencia.TabIndex = 1;
            // 
            // labelHoratext
            // 
            this.labelHoratext.AutoSize = true;
            this.Transition1.SetDecoration(this.labelHoratext, BunifuAnimatorNS.DecorationType.None);
            this.labelHoratext.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoratext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.labelHoratext.Location = new System.Drawing.Point(25, 557);
            this.labelHoratext.Name = "labelHoratext";
            this.labelHoratext.Size = new System.Drawing.Size(70, 25);
            this.labelHoratext.TabIndex = 161;
            this.labelHoratext.Text = "HORA:";
            // 
            // textBoxHora
            // 
            this.textBoxHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition1.SetDecoration(this.textBoxHora, BunifuAnimatorNS.DecorationType.None);
            this.textBoxHora.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxHora.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHora.Location = new System.Drawing.Point(30, 585);
            this.textBoxHora.MaxLength = 8;
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(293, 18);
            this.textBoxHora.TabIndex = 162;
            // 
            // Separatorhora
            // 
            this.Separatorhora.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.Separatorhora, BunifuAnimatorNS.DecorationType.None);
            this.Separatorhora.ForeColor = System.Drawing.Color.Transparent;
            this.Separatorhora.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.Separatorhora.LineThickness = 3;
            this.Separatorhora.Location = new System.Drawing.Point(29, 601);
            this.Separatorhora.Name = "Separatorhora";
            this.Separatorhora.Size = new System.Drawing.Size(294, 8);
            this.Separatorhora.TabIndex = 163;
            this.Separatorhora.Transparency = 255;
            this.Separatorhora.Vertical = false;
            // 
            // paneldatagrid
            // 
            this.paneldatagrid.Controls.Add(this.bunifuCustomDataGrid1);
            this.Transition1.SetDecoration(this.paneldatagrid, BunifuAnimatorNS.DecorationType.None);
            this.paneldatagrid.Location = new System.Drawing.Point(2, 119);
            this.paneldatagrid.Name = "paneldatagrid";
            this.paneldatagrid.Size = new System.Drawing.Size(347, 90);
            this.paneldatagrid.TabIndex = 167;
            this.paneldatagrid.Visible = false;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 17;
            this.bunifuCustomDataGrid1.ColumnHeadersVisible = false;
            this.Transition1.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(10, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(327, 90);
            this.bunifuCustomDataGrid1.TabIndex = 163;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // TextboxBuscar
            // 
            this.TextboxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.TextboxBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextboxBuscar.BackgroundImage")));
            this.TextboxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextboxBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition1.SetDecoration(this.TextboxBuscar, BunifuAnimatorNS.DecorationType.None);
            this.TextboxBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.TextboxBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.TextboxBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxBuscar.Icon")));
            this.TextboxBuscar.Location = new System.Drawing.Point(12, 81);
            this.TextboxBuscar.Name = "TextboxBuscar";
            this.TextboxBuscar.Size = new System.Drawing.Size(327, 36);
            this.TextboxBuscar.TabIndex = 166;
            this.TextboxBuscar.text = "Buscar Paciente";
            this.TextboxBuscar.OnTextChange += new System.EventHandler(this.TextboxBuscar_OnTextChange);
            this.TextboxBuscar.Enter += new System.EventHandler(this.TextboxBuscar_Enter);
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition1.SetDecoration(this.textBoxApellido, BunifuAnimatorNS.DecorationType.None);
            this.textBoxApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.ForeColor = System.Drawing.Color.Gray;
            this.textBoxApellido.Location = new System.Drawing.Point(30, 387);
            this.textBoxApellido.MaxLength = 100;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(293, 18);
            this.textBoxApellido.TabIndex = 168;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(30, 403);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(293, 8);
            this.bunifuSeparator2.TabIndex = 170;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Transition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(25, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 169;
            this.label2.Text = "APELLIDO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.Transition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(25, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 172;
            this.label7.Text = "HORA ACTUAL:";
            // 
            // HoraCheckbox
            // 
            this.HoraCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.HoraCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.HoraCheckbox.Checked = true;
            this.HoraCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Transition1.SetDecoration(this.HoraCheckbox, BunifuAnimatorNS.DecorationType.None);
            this.HoraCheckbox.ForeColor = System.Drawing.Color.White;
            this.HoraCheckbox.Location = new System.Drawing.Point(168, 529);
            this.HoraCheckbox.Name = "HoraCheckbox";
            this.HoraCheckbox.Size = new System.Drawing.Size(20, 20);
            this.HoraCheckbox.TabIndex = 171;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.Transition1.SetDecoration(this.pictureBoxError, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(145, 704);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 174;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.Transition1.SetDecoration(this.LabelError, BunifuAnimatorNS.DecorationType.None);
            this.LabelError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.LabelError.Location = new System.Drawing.Point(168, 705);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(38, 17);
            this.LabelError.TabIndex = 173;
            this.LabelError.Text = "Error";
            this.LabelError.Visible = false;
            // 
            // AgregarRegistroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(352, 786);
            this.Controls.Add(this.HoraCheckbox);
            this.Controls.Add(this.CheckboxFechaDeHoy);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paneldatagrid);
            this.Controls.Add(this.TextboxBuscar);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.Separatorhora);
            this.Controls.Add(this.labelHoratext);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.ComboboxAsistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TexboxFecha);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1457, 147);
            this.Name = "AgregarRegistroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarRegistroDiario";
            this.Load += new System.EventHandler(this.AgregarRegistroDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker Date;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxID;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxNombre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonActualizar;
        public System.Windows.Forms.TextBox TexboxFecha;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox CheckboxFechaDeHoy;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer FechaYhora;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown ComboboxAsistencia;
        public System.Windows.Forms.TextBox textBoxHora;
        private Bunifu.Framework.UI.BunifuSeparator Separatorhora;
        private System.Windows.Forms.Label labelHoratext;
        private BunifuAnimatorNS.BunifuTransition Transition1;
        private System.Windows.Forms.Panel paneldatagrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuTextbox TextboxBuscar;
        public System.Windows.Forms.TextBox textBoxApellido;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCheckbox HoraCheckbox;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label LabelError;
    }
}