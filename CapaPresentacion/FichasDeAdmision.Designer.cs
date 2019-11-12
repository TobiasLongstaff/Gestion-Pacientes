namespace CapaPresentacion
{
    partial class FichasDeAdmision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichasDeAdmision));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.BotonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BotonEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-1, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(992, 648);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.bunifuDropdown1);
            this.panelFondo.Controls.Add(this.bunifuCustomDataGrid1);
            this.Transition1.SetDecoration(this.panelFondo, BunifuAnimatorNS.DecorationType.None);
            this.panelFondo.Location = new System.Drawing.Point(-1, 1);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(992, 491);
            this.panelFondo.TabIndex = 43;
            this.panelFondo.Visible = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.Transition1.SetDecoration(this.bunifuDropdown1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Buscar"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(56, 42);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 42;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 50;
            this.Transition1.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(230)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(47, 109);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 30;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(898, 372);
            this.bunifuCustomDataGrid1.TabIndex = 43;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BotonActualizar);
            this.panelBotones.Controls.Add(this.BotonEditar);
            this.panelBotones.Controls.Add(this.BotonEliminar);
            this.Transition1.SetDecoration(this.panelBotones, BunifuAnimatorNS.DecorationType.None);
            this.panelBotones.Location = new System.Drawing.Point(695, 488);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(264, 157);
            this.panelBotones.TabIndex = 44;
            this.panelBotones.Visible = false;
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
            this.BotonActualizar.Location = new System.Drawing.Point(78, 0);
            this.BotonActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(171, 47);
            this.BotonActualizar.TabIndex = 47;
            this.BotonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BotonEditar.Location = new System.Drawing.Point(78, 41);
            this.BotonEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(171, 47);
            this.BotonEditar.TabIndex = 48;
            this.BotonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BotonEliminar.Location = new System.Drawing.Point(78, 82);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(171, 47);
            this.BotonEliminar.TabIndex = 49;
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation3;
            // 
            // FichasDeAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(990, 724);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.pictureBox7);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FichasDeAdmision";
            this.Text = "FichasDeAdmision";
            this.Load += new System.EventHandler(this.FichasDeAdmision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private BunifuAnimatorNS.BunifuTransition Transition1;
        private System.Windows.Forms.Panel panelFondo;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel panelBotones;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 BotonEliminar;
    }
}