namespace CapaPresentacion
{
    partial class RegistroDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDiario));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BotonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextboxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 50;
            this.Transition1.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle23;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(53, 78);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(895, 363);
            this.bunifuCustomDataGrid1.TabIndex = 37;
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
            this.BotonActualizar.ButtonText = "Actualizar";
            this.BotonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.BotonActualizar, BunifuAnimatorNS.DecorationType.None);
            this.BotonActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.IdleBorderThickness = 1;
            this.BotonActualizar.IdleCornerRadius = 20;
            this.BotonActualizar.IdleFillColor = System.Drawing.Color.White;
            this.BotonActualizar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonActualizar.Location = new System.Drawing.Point(13, 5);
            this.BotonActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(171, 47);
            this.BotonActualizar.TabIndex = 38;
            this.BotonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.ActiveBorderThickness = 1;
            this.BotonEditar.ActiveCornerRadius = 20;
            this.BotonEditar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEditar.ActiveForecolor = System.Drawing.Color.White;
            this.BotonEditar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.BotonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEditar.BackgroundImage")));
            this.BotonEditar.ButtonText = "Editar";
            this.BotonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.BotonEditar, BunifuAnimatorNS.DecorationType.None);
            this.BotonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEditar.IdleBorderThickness = 1;
            this.BotonEditar.IdleCornerRadius = 20;
            this.BotonEditar.IdleFillColor = System.Drawing.Color.White;
            this.BotonEditar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEditar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEditar.Location = new System.Drawing.Point(13, 46);
            this.BotonEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(171, 47);
            this.BotonEditar.TabIndex = 39;
            this.BotonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.ActiveBorderThickness = 1;
            this.BotonEliminar.ActiveCornerRadius = 20;
            this.BotonEliminar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.BotonEliminar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.BotonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.BackgroundImage")));
            this.BotonEliminar.ButtonText = "Eliminar";
            this.BotonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.BotonEliminar, BunifuAnimatorNS.DecorationType.None);
            this.BotonEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEliminar.IdleBorderThickness = 1;
            this.BotonEliminar.IdleCornerRadius = 20;
            this.BotonEliminar.IdleFillColor = System.Drawing.Color.White;
            this.BotonEliminar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(137)))), ((int)(((byte)(247)))));
            this.BotonEliminar.Location = new System.Drawing.Point(13, 87);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(171, 47);
            this.BotonEliminar.TabIndex = 40;
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(990, 639);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.BotonCerrar, BunifuAnimatorNS.DecorationType.None);
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.ImageActive = null;
            this.BotonCerrar.Location = new System.Drawing.Point(953, 11);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 22);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 42;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Zoom = 10;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
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
            this.TextboxBuscar.Location = new System.Drawing.Point(28, 23);
            this.TextboxBuscar.Name = "TextboxBuscar";
            this.TextboxBuscar.Size = new System.Drawing.Size(253, 32);
            this.TextboxBuscar.TabIndex = 73;
            this.TextboxBuscar.text = "Buscar Pacientes";
            this.TextboxBuscar.OnTextChange += new System.EventHandler(this.TextboxBuscar_OnTextChange);
            this.TextboxBuscar.Enter += new System.EventHandler(this.TextboxBuscar_Enter);
            this.TextboxBuscar.Leave += new System.EventHandler(this.TextboxBuscar_Leave);
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.TextboxBuscar);
            this.panelFondo.Controls.Add(this.bunifuCustomDataGrid1);
            this.Transition1.SetDecoration(this.panelFondo, BunifuAnimatorNS.DecorationType.None);
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(990, 460);
            this.panelFondo.TabIndex = 74;
            this.panelFondo.Visible = false;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BotonActualizar);
            this.panelBotones.Controls.Add(this.BotonEditar);
            this.panelBotones.Controls.Add(this.BotonEliminar);
            this.Transition1.SetDecoration(this.panelBotones, BunifuAnimatorNS.DecorationType.None);
            this.panelBotones.Location = new System.Drawing.Point(738, 456);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(210, 149);
            this.panelBotones.TabIndex = 75;
            this.panelBotones.Visible = false;
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Transition1.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation6;
            // 
            // RegistroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(990, 724);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.pictureBox7);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroDiario";
            this.Text = "RegintroDiario";
            this.Load += new System.EventHandler(this.RegistroDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuImageButton BotonCerrar;
        private Bunifu.Framework.UI.BunifuTextbox TextboxBuscar;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelBotones;
        private BunifuAnimatorNS.BunifuTransition Transition1;
    }
}