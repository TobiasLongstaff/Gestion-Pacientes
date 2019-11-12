namespace CapaPresentacion
{
    partial class ListaDePacientes
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDePacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAnima = new System.Windows.Forms.Panel();
            this.TextboxBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BotonCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BotonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelAnima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1160, 724);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            // panelAnima
            // 
            this.panelAnima.BackColor = System.Drawing.Color.Transparent;
            this.panelAnima.Controls.Add(this.TextboxBuscar);
            this.panelAnima.Controls.Add(this.bunifuCustomDataGrid1);
            this.panelAnima.Controls.Add(this.BotonCerrar);
            this.Transition1.SetDecoration(this.panelAnima, BunifuAnimatorNS.DecorationType.None);
            this.panelAnima.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnima.Location = new System.Drawing.Point(0, 0);
            this.panelAnima.Name = "panelAnima";
            this.panelAnima.Size = new System.Drawing.Size(1160, 486);
            this.panelAnima.TabIndex = 67;
            this.panelAnima.Visible = false;
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
            this.TextboxBuscar.TabIndex = 72;
            this.TextboxBuscar.text = "Buscar Pacientes";
            this.TextboxBuscar.OnTextChange += new System.EventHandler(this.TextboxBuscar_OnTextChange);
            this.TextboxBuscar.Enter += new System.EventHandler(this.TextboxBuscar_Click);
            this.TextboxBuscar.Leave += new System.EventHandler(this.TextboxBuscar_Leave);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 50;
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(53, 78);
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
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(916, 393);
            this.bunifuCustomDataGrid1.TabIndex = 67;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.BotonCerrar, BunifuAnimatorNS.DecorationType.None);
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.ImageActive = null;
            this.BotonCerrar.Location = new System.Drawing.Point(1123, 11);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 22);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 71;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Zoom = 10;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
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
            this.BotonActualizar.TabIndex = 68;
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
            this.BotonEditar.TabIndex = 69;
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
            this.BotonEliminar.TabIndex = 70;
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BotonActualizar);
            this.panelBotones.Controls.Add(this.BotonEditar);
            this.panelBotones.Controls.Add(this.BotonEliminar);
            this.Transition1.SetDecoration(this.panelBotones, BunifuAnimatorNS.DecorationType.None);
            this.panelBotones.Location = new System.Drawing.Point(785, 492);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(222, 139);
            this.panelBotones.TabIndex = 71;
            this.panelBotones.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(48, 693);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ListaDePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1160, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelAnima);
            this.Controls.Add(this.pictureBox7);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDePacientes";
            this.Text = "ControlDePagos";
            this.Load += new System.EventHandler(this.ControlDePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelAnima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private BunifuAnimatorNS.BunifuTransition Transition1;
        private System.Windows.Forms.Panel panelAnima;
        private Bunifu.Framework.UI.BunifuTextbox TextboxBuscar;
        private Bunifu.Framework.UI.BunifuImageButton BotonCerrar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label label1;
    }
}