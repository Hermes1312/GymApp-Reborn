
namespace GymApp_Reborn
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.minimizeControl = new Guna.UI2.WinForms.Guna2ControlBox();
            this.menu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.exitControl = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.daysContext = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.bar.SuspendLayout();
            this.daysContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 100;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // bar
            // 
            this.bar.Controls.Add(this.minimizeControl);
            this.bar.Controls.Add(this.menu);
            this.bar.Controls.Add(this.exitControl);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.bar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.ShadowDecoration.Parent = this.bar;
            this.bar.Size = new System.Drawing.Size(913, 32);
            this.bar.TabIndex = 0;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // minimizeControl
            // 
            this.minimizeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControl.Animated = true;
            this.minimizeControl.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeControl.CustomClick = true;
            this.minimizeControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.minimizeControl.HoverState.Parent = this.minimizeControl;
            this.minimizeControl.IconColor = System.Drawing.Color.White;
            this.minimizeControl.Location = new System.Drawing.Point(823, 0);
            this.minimizeControl.Name = "minimizeControl";
            this.minimizeControl.ShadowDecoration.Parent = this.minimizeControl;
            this.minimizeControl.Size = new System.Drawing.Size(45, 32);
            this.minimizeControl.TabIndex = 4;
            this.minimizeControl.Click += new System.EventHandler(this.minimizeControl_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.menu.BorderThickness = 0;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.CustomizableEdges.BottomLeft = false;
            this.menu.CustomizableEdges.BottomRight = false;
            this.menu.CustomizableEdges.TopLeft = false;
            this.menu.CustomizableEdges.TopRight = false;
            this.menu.DisplayMember = "Porjekt";
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.menu.FocusedColor = System.Drawing.Color.Transparent;
            this.menu.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.menu.FocusedState.Parent = this.menu;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(158)))), ((int)(((byte)(182)))));
            this.menu.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.menu.HoverState.Parent = this.menu;
            this.menu.ItemHeight = 30;
            this.menu.Items.AddRange(new object[] {
            "GymApp",
            "Nowy",
            "Wczytaj",
            "Zapisz",
            "Zapisz jako"});
            this.menu.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.menu.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.menu.ItemsAppearance.Parent = this.menu;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.ShadowDecoration.Parent = this.menu;
            this.menu.Size = new System.Drawing.Size(178, 36);
            this.menu.StartIndex = 0;
            this.menu.TabIndex = 2;
            this.menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu.TextOffset = new System.Drawing.Point(13, 0);
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // exitControl
            // 
            this.exitControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControl.Animated = true;
            this.exitControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitControl.CustomClick = true;
            this.exitControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.exitControl.HoverState.Parent = this.exitControl;
            this.exitControl.IconColor = System.Drawing.Color.White;
            this.exitControl.Location = new System.Drawing.Point(868, 0);
            this.exitControl.Name = "exitControl";
            this.exitControl.ShadowDecoration.Parent = this.exitControl;
            this.exitControl.Size = new System.Drawing.Size(45, 32);
            this.exitControl.TabIndex = 1;
            this.exitControl.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            this.exitControl.MouseEnter += new System.EventHandler(this.exitControl_MouseEnter);
            this.exitControl.MouseLeave += new System.EventHandler(this.exitControl_MouseLeave);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.ContextMenuStrip = this.daysContext;
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 32);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(913, 418);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(144)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // daysContext
            // 
            this.daysContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolChangeName,
            this.toolUp,
            this.toolDown,
            this.toolRemove,
            this.toolAddBefore,
            this.toolAddAfter});
            this.daysContext.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.daysContext.Name = "daysContext";
            this.daysContext.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.daysContext.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.daysContext.RenderStyle.ColorTable = null;
            this.daysContext.RenderStyle.RoundedEdges = true;
            this.daysContext.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.daysContext.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.daysContext.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.daysContext.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.daysContext.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.daysContext.Size = new System.Drawing.Size(145, 136);
            this.daysContext.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.daysContext_ItemClicked);
            // 
            // toolChangeName
            // 
            this.toolChangeName.Name = "toolChangeName";
            this.toolChangeName.Size = new System.Drawing.Size(144, 22);
            this.toolChangeName.Text = "Zmień nazwę";
            // 
            // toolUp
            // 
            this.toolUp.Name = "toolUp";
            this.toolUp.Size = new System.Drawing.Size(144, 22);
            this.toolUp.Text = "Do góry";
            // 
            // toolDown
            // 
            this.toolDown.Name = "toolDown";
            this.toolDown.Size = new System.Drawing.Size(144, 22);
            this.toolDown.Text = "W dół";
            // 
            // toolRemove
            // 
            this.toolRemove.Name = "toolRemove";
            this.toolRemove.Size = new System.Drawing.Size(144, 22);
            this.toolRemove.Text = "Usuń";
            // 
            // toolAddBefore
            // 
            this.toolAddBefore.Name = "toolAddBefore";
            this.toolAddBefore.Size = new System.Drawing.Size(144, 22);
            this.toolAddBefore.Text = "Dodaj przed";
            // 
            // toolAddAfter
            // 
            this.toolAddAfter.Name = "toolAddAfter";
            this.toolAddAfter.Size = new System.Drawing.Size(144, 22);
            this.toolAddAfter.Text = "Dodaj po";
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.bar.ResumeLayout(false);
            this.daysContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel bar;
        private Guna.UI2.WinForms.Guna2ControlBox exitControl;
        private Guna.UI2.WinForms.Guna2ComboBox menu;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeControl;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip daysContext;
        private System.Windows.Forms.ToolStripMenuItem toolUp;
        private System.Windows.Forms.ToolStripMenuItem toolDown;
        private System.Windows.Forms.ToolStripMenuItem toolRemove;
        private System.Windows.Forms.ToolStripMenuItem toolAddBefore;
        private System.Windows.Forms.ToolStripMenuItem toolAddAfter;
        private System.Windows.Forms.ToolStripMenuItem toolChangeName;
        public Guna.UI2.WinForms.Guna2TabControl tabControl;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
    }
}

