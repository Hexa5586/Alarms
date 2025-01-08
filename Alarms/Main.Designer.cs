namespace Alarms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblTitle = new Label();
            btnMini = new TransparentButton();
            btnClose = new TransparentButton();
            btnMenu = new TransparentButton();
            tabctrlMain = new NoTabTabControl();
            tabpGrid = new TabPage();
            tabpEdit = new TabPage();
            tblpnlSave = new TableLayoutPanel();
            btnSave = new Sunny.UI.UIButton();
            tblpnlEdit = new TableLayoutPanel();
            lblAlarmTag = new Label();
            lblAlarmTime = new Label();
            tblpnlRepeat = new TableLayoutPanel();
            rdRepeat = new Sunny.UI.UIRadioButton();
            tblpnlRepeatSelect = new TableLayoutPanel();
            sw1 = new Sunny.UI.UISwitch();
            sw5 = new Sunny.UI.UISwitch();
            sw2 = new Sunny.UI.UISwitch();
            sw6 = new Sunny.UI.UISwitch();
            sw3 = new Sunny.UI.UISwitch();
            sw7 = new Sunny.UI.UISwitch();
            sw4 = new Sunny.UI.UISwitch();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rdOnlyOnce = new Sunny.UI.UIRadioButton();
            lblEditMode = new Label();
            lblAlarmMusic = new Label();
            cmbEditMode = new Sunny.UI.UIComboBox();
            txtAlarmTag = new Sunny.UI.UITextBox();
            cmbAlarmMusic = new Sunny.UI.UIComboBox();
            tblpnlAlarmTime = new TableLayoutPanel();
            tblpnlAlarmTimeHour = new TableLayoutPanel();
            btnHourDown = new Sunny.UI.UIButton();
            btnHourUp = new Sunny.UI.UIButton();
            lblAlarmTimeHour = new Label();
            tblpnlAlarmTimeMin = new TableLayoutPanel();
            btnMinDown = new Sunny.UI.UIButton();
            btnMinUp = new Sunny.UI.UIButton();
            lblAlarmTimeMin = new Label();
            lblTimeSep = new Label();
            lblAlarmRepeat = new Label();
            tabpSolutions = new TabPage();
            timerGC = new System.Windows.Forms.Timer(components);
            imglstControlBoxes = new ImageList(components);
            imglstAlarmBoxes = new ImageList(components);
            notifyIcon = new NotifyIcon(components);
            contNotifyIcon = new ContextMenuStrip(components);
            contNotifyIconDisplay = new ToolStripMenuItem();
            contNotifyIconExit = new ToolStripMenuItem();
            tblpnlMain = new TableLayoutPanel();
            pnlCaption = new TableLayoutPanel();
            tabctrlMain.SuspendLayout();
            tabpEdit.SuspendLayout();
            tblpnlSave.SuspendLayout();
            tblpnlEdit.SuspendLayout();
            tblpnlRepeat.SuspendLayout();
            tblpnlRepeatSelect.SuspendLayout();
            tblpnlAlarmTime.SuspendLayout();
            tblpnlAlarmTimeHour.SuspendLayout();
            tblpnlAlarmTimeMin.SuspendLayout();
            contNotifyIcon.SuspendLayout();
            tblpnlMain.SuspendLayout();
            pnlCaption.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(66, 17);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "TEST";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMini
            // 
            btnMini.BackColor = Color.FromArgb(0, 255, 255, 255);
            btnMini.BackgroundImageLayout = ImageLayout.Center;
            btnMini.Dock = DockStyle.Fill;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
            btnMini.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 255, 255, 255);
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.Location = new Point(1004, 4);
            btnMini.Margin = new Padding(4);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(60, 58);
            btnMini.TabIndex = 0;
            btnMini.Tag = "最小化";
            btnMini.UseVisualStyleBackColor = false;
            btnMini.Click += btnMini_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 255, 255, 255);
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Dock = DockStyle.Fill;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 255, 255, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1072, 4);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(65, 58);
            btnClose.TabIndex = 0;
            btnClose.Tag = "";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(0, 255, 255, 255);
            btnMenu.BackgroundImageLayout = ImageLayout.Center;
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 255, 255, 255);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(4, 4);
            btnMenu.Margin = new Padding(4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(54, 58);
            btnMenu.TabIndex = 0;
            btnMenu.Tag = "展开菜单";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // tabctrlMain
            // 
            tabctrlMain.Controls.Add(tabpGrid);
            tabctrlMain.Controls.Add(tabpEdit);
            tabctrlMain.Controls.Add(tabpSolutions);
            tabctrlMain.Dock = DockStyle.Fill;
            tabctrlMain.Location = new Point(4, 78);
            tabctrlMain.Margin = new Padding(4);
            tabctrlMain.Name = "tabctrlMain";
            tabctrlMain.SelectedIndex = 0;
            tabctrlMain.Size = new Size(1141, 1170);
            tabctrlMain.TabIndex = 0;
            tabctrlMain.SelectedIndexChanged += tabctrlMain_SelectedIndexChanged;
            // 
            // tabpGrid
            // 
            tabpGrid.BackColor = Color.FromArgb(26, 26, 26);
            tabpGrid.Location = new Point(0, 29);
            tabpGrid.Margin = new Padding(4);
            tabpGrid.Name = "tabpGrid";
            tabpGrid.Padding = new Padding(4);
            tabpGrid.Size = new Size(1141, 1141);
            tabpGrid.TabIndex = 0;
            tabpGrid.Text = "闹铃列表";
            // 
            // tabpEdit
            // 
            tabpEdit.AutoScroll = true;
            tabpEdit.BackColor = Color.FromArgb(26, 26, 26);
            tabpEdit.Controls.Add(tblpnlSave);
            tabpEdit.Controls.Add(tblpnlEdit);
            tabpEdit.Location = new Point(0, 29);
            tabpEdit.Margin = new Padding(4);
            tabpEdit.Name = "tabpEdit";
            tabpEdit.Padding = new Padding(4);
            tabpEdit.Size = new Size(1141, 1141);
            tabpEdit.TabIndex = 1;
            tabpEdit.Text = "闹铃编辑";
            // 
            // tblpnlSave
            // 
            tblpnlSave.ColumnCount = 3;
            tblpnlSave.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpnlSave.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpnlSave.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpnlSave.Controls.Add(btnSave, 1, 0);
            tblpnlSave.Dock = DockStyle.Bottom;
            tblpnlSave.Location = new Point(4, 1035);
            tblpnlSave.Margin = new Padding(4);
            tblpnlSave.Name = "tblpnlSave";
            tblpnlSave.RowCount = 1;
            tblpnlSave.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlSave.Size = new Size(1133, 102);
            tblpnlSave.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.FillColor = Color.FromArgb(50, 50, 50);
            btnSave.FillHoverColor = SystemColors.WindowFrame;
            btnSave.FillPressColor = Color.FromArgb(120, 120, 120);
            btnSave.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            btnSave.Location = new Point(381, 4);
            btnSave.Margin = new Padding(4);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 51;
            btnSave.RectColor = Color.FromArgb(50, 50, 50);
            btnSave.RectHoverColor = SystemColors.WindowFrame;
            btnSave.RectPressColor = Color.FromArgb(120, 120, 120);
            btnSave.Size = new Size(369, 84);
            btnSave.TabIndex = 0;
            btnSave.Text = "保存更改";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // tblpnlEdit
            // 
            tblpnlEdit.ColumnCount = 2;
            tblpnlEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5337734F));
            tblpnlEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.4662247F));
            tblpnlEdit.Controls.Add(lblAlarmTag, 0, 2);
            tblpnlEdit.Controls.Add(lblAlarmTime, 0, 4);
            tblpnlEdit.Controls.Add(tblpnlRepeat, 1, 8);
            tblpnlEdit.Controls.Add(lblEditMode, 0, 0);
            tblpnlEdit.Controls.Add(lblAlarmMusic, 0, 6);
            tblpnlEdit.Controls.Add(cmbEditMode, 1, 0);
            tblpnlEdit.Controls.Add(txtAlarmTag, 1, 2);
            tblpnlEdit.Controls.Add(cmbAlarmMusic, 1, 6);
            tblpnlEdit.Controls.Add(tblpnlAlarmTime, 1, 4);
            tblpnlEdit.Controls.Add(lblAlarmRepeat, 0, 8);
            tblpnlEdit.Dock = DockStyle.Top;
            tblpnlEdit.Location = new Point(4, 4);
            tblpnlEdit.Margin = new Padding(4);
            tblpnlEdit.Name = "tblpnlEdit";
            tblpnlEdit.RowCount = 9;
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 5.72976446F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 3.71932054F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 6.131852F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 3.81984258F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 28.2798634F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 2.95291758F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 6.23237467F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 4.925586F));
            tblpnlEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 38.208477F));
            tblpnlEdit.Size = new Size(1133, 986);
            tblpnlEdit.TabIndex = 0;
            // 
            // lblAlarmTag
            // 
            lblAlarmTag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAlarmTag.AutoSize = true;
            lblAlarmTag.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblAlarmTag.ForeColor = Color.Gainsboro;
            lblAlarmTag.Location = new Point(4, 92);
            lblAlarmTag.Margin = new Padding(4, 0, 4, 0);
            lblAlarmTag.Name = "lblAlarmTag";
            lblAlarmTag.Size = new Size(201, 60);
            lblAlarmTag.TabIndex = 1;
            lblAlarmTag.Text = "标签";
            lblAlarmTag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlarmTime
            // 
            lblAlarmTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAlarmTime.AutoSize = true;
            lblAlarmTime.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblAlarmTime.ForeColor = Color.Gainsboro;
            lblAlarmTime.Location = new Point(4, 189);
            lblAlarmTime.Margin = new Padding(4, 0, 4, 0);
            lblAlarmTime.Name = "lblAlarmTime";
            lblAlarmTime.Size = new Size(201, 278);
            lblAlarmTime.TabIndex = 2;
            lblAlarmTime.Text = "时间";
            lblAlarmTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblpnlRepeat
            // 
            tblpnlRepeat.ColumnCount = 1;
            tblpnlRepeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlRepeat.Controls.Add(rdRepeat, 0, 1);
            tblpnlRepeat.Controls.Add(tblpnlRepeatSelect, 0, 2);
            tblpnlRepeat.Controls.Add(rdOnlyOnce, 0, 0);
            tblpnlRepeat.Dock = DockStyle.Fill;
            tblpnlRepeat.Location = new Point(214, 610);
            tblpnlRepeat.Margin = new Padding(5);
            tblpnlRepeat.Name = "tblpnlRepeat";
            tblpnlRepeat.RowCount = 3;
            tblpnlRepeat.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3827391F));
            tblpnlRepeat.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7579737F));
            tblpnlRepeat.RowStyles.Add(new RowStyle(SizeType.Percent, 74.85928F));
            tblpnlRepeat.Size = new Size(914, 371);
            tblpnlRepeat.TabIndex = 11;
            // 
            // rdRepeat
            // 
            rdRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rdRepeat.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            rdRepeat.ForeColor = Color.Gainsboro;
            rdRepeat.Location = new Point(5, 50);
            rdRepeat.Margin = new Padding(5);
            rdRepeat.MinimumSize = new Size(1, 1);
            rdRepeat.Name = "rdRepeat";
            rdRepeat.RadioButtonColor = SystemColors.ButtonFace;
            rdRepeat.Size = new Size(872, 37);
            rdRepeat.TabIndex = 1;
            rdRepeat.Text = "重复";
            // 
            // tblpnlRepeatSelect
            // 
            tblpnlRepeatSelect.ColumnCount = 8;
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tblpnlRepeatSelect.Controls.Add(sw1, 0, 0);
            tblpnlRepeatSelect.Controls.Add(sw5, 0, 1);
            tblpnlRepeatSelect.Controls.Add(sw2, 2, 0);
            tblpnlRepeatSelect.Controls.Add(sw6, 2, 1);
            tblpnlRepeatSelect.Controls.Add(sw3, 4, 0);
            tblpnlRepeatSelect.Controls.Add(sw7, 4, 1);
            tblpnlRepeatSelect.Controls.Add(sw4, 6, 0);
            tblpnlRepeatSelect.Controls.Add(label1, 1, 0);
            tblpnlRepeatSelect.Controls.Add(label2, 1, 1);
            tblpnlRepeatSelect.Controls.Add(label3, 3, 0);
            tblpnlRepeatSelect.Controls.Add(label4, 3, 1);
            tblpnlRepeatSelect.Controls.Add(label5, 5, 0);
            tblpnlRepeatSelect.Controls.Add(label6, 5, 1);
            tblpnlRepeatSelect.Controls.Add(label7, 7, 0);
            tblpnlRepeatSelect.Dock = DockStyle.Fill;
            tblpnlRepeatSelect.Location = new Point(5, 97);
            tblpnlRepeatSelect.Margin = new Padding(5);
            tblpnlRepeatSelect.Name = "tblpnlRepeatSelect";
            tblpnlRepeatSelect.RowCount = 2;
            tblpnlRepeatSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlRepeatSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlRepeatSelect.Size = new Size(904, 269);
            tblpnlRepeatSelect.TabIndex = 2;
            // 
            // sw1
            // 
            sw1.ActiveColor = SystemColors.ScrollBar;
            sw1.ActiveText = "";
            sw1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw1.InActiveColor = Color.FromArgb(60, 60, 60);
            sw1.InActiveText = "";
            sw1.Location = new Point(5, 39);
            sw1.Margin = new Padding(5);
            sw1.MinimumSize = new Size(1, 1);
            sw1.Name = "sw1";
            sw1.Size = new Size(103, 55);
            sw1.TabIndex = 0;
            sw1.Text = "uiSwitch1";
            // 
            // sw5
            // 
            sw5.ActiveColor = SystemColors.ScrollBar;
            sw5.ActiveText = "";
            sw5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw5.InActiveColor = Color.FromArgb(60, 60, 60);
            sw5.InActiveText = "";
            sw5.Location = new Point(5, 174);
            sw5.Margin = new Padding(5);
            sw5.MinimumSize = new Size(1, 1);
            sw5.Name = "sw5";
            sw5.Size = new Size(103, 55);
            sw5.TabIndex = 1;
            sw5.Text = "uiSwitch2";
            // 
            // sw2
            // 
            sw2.ActiveColor = SystemColors.ScrollBar;
            sw2.ActiveText = "";
            sw2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw2.InActiveColor = Color.FromArgb(60, 60, 60);
            sw2.InActiveText = "";
            sw2.Location = new Point(231, 39);
            sw2.Margin = new Padding(5);
            sw2.MinimumSize = new Size(1, 1);
            sw2.Name = "sw2";
            sw2.Size = new Size(103, 55);
            sw2.TabIndex = 2;
            sw2.Text = "uiSwitch3";
            // 
            // sw6
            // 
            sw6.ActiveColor = SystemColors.ScrollBar;
            sw6.ActiveText = "";
            sw6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw6.InActiveColor = Color.FromArgb(60, 60, 60);
            sw6.InActiveText = "";
            sw6.Location = new Point(231, 174);
            sw6.Margin = new Padding(5);
            sw6.MinimumSize = new Size(1, 1);
            sw6.Name = "sw6";
            sw6.Size = new Size(103, 55);
            sw6.TabIndex = 3;
            sw6.Text = "uiSwitch4";
            // 
            // sw3
            // 
            sw3.ActiveColor = SystemColors.ScrollBar;
            sw3.ActiveText = "";
            sw3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw3.InActiveColor = Color.FromArgb(60, 60, 60);
            sw3.InActiveText = "";
            sw3.Location = new Point(457, 39);
            sw3.Margin = new Padding(5);
            sw3.MinimumSize = new Size(1, 1);
            sw3.Name = "sw3";
            sw3.Size = new Size(103, 55);
            sw3.TabIndex = 4;
            sw3.Text = "uiSwitch5";
            // 
            // sw7
            // 
            sw7.ActiveColor = SystemColors.ScrollBar;
            sw7.ActiveText = "";
            sw7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw7.InActiveColor = Color.FromArgb(60, 60, 60);
            sw7.InActiveText = "";
            sw7.Location = new Point(457, 174);
            sw7.Margin = new Padding(5);
            sw7.MinimumSize = new Size(1, 1);
            sw7.Name = "sw7";
            sw7.Size = new Size(103, 55);
            sw7.TabIndex = 5;
            sw7.Text = "uiSwitch6";
            // 
            // sw4
            // 
            sw4.ActiveColor = SystemColors.ScrollBar;
            sw4.ActiveText = "";
            sw4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sw4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw4.InActiveColor = Color.FromArgb(60, 60, 60);
            sw4.InActiveText = "";
            sw4.Location = new Point(683, 39);
            sw4.Margin = new Padding(5);
            sw4.MinimumSize = new Size(1, 1);
            sw4.Name = "sw4";
            sw4.Size = new Size(103, 55);
            sw4.TabIndex = 6;
            sw4.Text = "uiSwitch7";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(118, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 7;
            label1.Text = "周一";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(118, 186);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 8;
            label2.Text = "周五";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(344, 51);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 31);
            label3.TabIndex = 9;
            label3.Text = "周二";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(344, 186);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 31);
            label4.TabIndex = 10;
            label4.Text = "周六";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(570, 51);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 31);
            label5.TabIndex = 11;
            label5.Text = "周三";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(570, 186);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 31);
            label6.TabIndex = 12;
            label6.Text = "周日";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(796, 51);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 31);
            label7.TabIndex = 13;
            label7.Text = "周四";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdOnlyOnce
            // 
            rdOnlyOnce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rdOnlyOnce.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            rdOnlyOnce.ForeColor = Color.Gainsboro;
            rdOnlyOnce.Location = new Point(5, 5);
            rdOnlyOnce.Margin = new Padding(5);
            rdOnlyOnce.MinimumSize = new Size(1, 1);
            rdOnlyOnce.Name = "rdOnlyOnce";
            rdOnlyOnce.RadioButtonColor = SystemColors.ButtonFace;
            rdOnlyOnce.Size = new Size(872, 35);
            rdOnlyOnce.TabIndex = 0;
            rdOnlyOnce.Text = "仅一次";
            // 
            // lblEditMode
            // 
            lblEditMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEditMode.AutoSize = true;
            lblEditMode.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblEditMode.ForeColor = Color.Gainsboro;
            lblEditMode.Location = new Point(4, 0);
            lblEditMode.Margin = new Padding(4, 0, 4, 0);
            lblEditMode.Name = "lblEditMode";
            lblEditMode.Size = new Size(201, 56);
            lblEditMode.TabIndex = 0;
            lblEditMode.Text = "对象";
            lblEditMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlarmMusic
            // 
            lblAlarmMusic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAlarmMusic.AutoSize = true;
            lblAlarmMusic.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblAlarmMusic.ForeColor = Color.Gainsboro;
            lblAlarmMusic.Location = new Point(4, 496);
            lblAlarmMusic.Margin = new Padding(4, 0, 4, 0);
            lblAlarmMusic.Name = "lblAlarmMusic";
            lblAlarmMusic.Size = new Size(201, 61);
            lblAlarmMusic.TabIndex = 3;
            lblAlarmMusic.Text = "铃声";
            lblAlarmMusic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbEditMode
            // 
            cmbEditMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmbEditMode.DataSource = null;
            cmbEditMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEditMode.FillColor = Color.FromArgb(66, 66, 66);
            cmbEditMode.FillColor2 = Color.FromArgb(50, 50, 50);
            cmbEditMode.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            cmbEditMode.ForeColor = Color.White;
            cmbEditMode.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbEditMode.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbEditMode.Location = new Point(232, 9);
            cmbEditMode.Margin = new Padding(7, 9, 7, 9);
            cmbEditMode.MinimumSize = new Size(113, 0);
            cmbEditMode.Name = "cmbEditMode";
            cmbEditMode.Padding = new Padding(0, 0, 65, 4);
            cmbEditMode.Radius = 10;
            cmbEditMode.RectColor = SystemColors.ActiveBorder;
            cmbEditMode.RectDisableColor = SystemColors.WindowFrame;
            cmbEditMode.RectSides = ToolStripStatusLabelBorderSides.None;
            cmbEditMode.Size = new Size(877, 38);
            cmbEditMode.SymbolSize = 24;
            cmbEditMode.TabIndex = 7;
            cmbEditMode.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEditMode.Watermark = "";
            // 
            // txtAlarmTag
            // 
            txtAlarmTag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtAlarmTag.FillColor = Color.FromArgb(66, 66, 66);
            txtAlarmTag.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            txtAlarmTag.ForeColor = Color.White;
            txtAlarmTag.Location = new Point(232, 101);
            txtAlarmTag.Margin = new Padding(7, 9, 7, 9);
            txtAlarmTag.MinimumSize = new Size(1, 28);
            txtAlarmTag.Name = "txtAlarmTag";
            txtAlarmTag.Padding = new Padding(9);
            txtAlarmTag.Radius = 10;
            txtAlarmTag.RectColor = SystemColors.ActiveBorder;
            txtAlarmTag.RectSides = ToolStripStatusLabelBorderSides.None;
            txtAlarmTag.ShowText = false;
            txtAlarmTag.Size = new Size(877, 42);
            txtAlarmTag.TabIndex = 8;
            txtAlarmTag.TextAlignment = ContentAlignment.MiddleLeft;
            txtAlarmTag.Watermark = "";
            // 
            // cmbAlarmMusic
            // 
            cmbAlarmMusic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmbAlarmMusic.DataSource = null;
            cmbAlarmMusic.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAlarmMusic.FillColor = Color.FromArgb(66, 66, 66);
            cmbAlarmMusic.FillColor2 = Color.FromArgb(50, 50, 50);
            cmbAlarmMusic.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            cmbAlarmMusic.ForeColor = Color.White;
            cmbAlarmMusic.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbAlarmMusic.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbAlarmMusic.Location = new Point(232, 505);
            cmbAlarmMusic.Margin = new Padding(7, 9, 7, 9);
            cmbAlarmMusic.MinimumSize = new Size(113, 0);
            cmbAlarmMusic.Name = "cmbAlarmMusic";
            cmbAlarmMusic.Padding = new Padding(0, 0, 65, 4);
            cmbAlarmMusic.Radius = 10;
            cmbAlarmMusic.RectColor = SystemColors.ActiveBorder;
            cmbAlarmMusic.RectDisableColor = SystemColors.WindowFrame;
            cmbAlarmMusic.RectSides = ToolStripStatusLabelBorderSides.None;
            cmbAlarmMusic.Size = new Size(877, 43);
            cmbAlarmMusic.SymbolSize = 24;
            cmbAlarmMusic.TabIndex = 9;
            cmbAlarmMusic.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAlarmMusic.Watermark = "";
            // 
            // tblpnlAlarmTime
            // 
            tblpnlAlarmTime.ColumnCount = 3;
            tblpnlAlarmTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.6599274F));
            tblpnlAlarmTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.728894F));
            tblpnlAlarmTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.5116348F));
            tblpnlAlarmTime.Controls.Add(tblpnlAlarmTimeHour, 0, 0);
            tblpnlAlarmTime.Controls.Add(tblpnlAlarmTimeMin, 2, 0);
            tblpnlAlarmTime.Controls.Add(lblTimeSep, 1, 0);
            tblpnlAlarmTime.Dock = DockStyle.Fill;
            tblpnlAlarmTime.Location = new Point(213, 193);
            tblpnlAlarmTime.Margin = new Padding(4);
            tblpnlAlarmTime.Name = "tblpnlAlarmTime";
            tblpnlAlarmTime.RowCount = 1;
            tblpnlAlarmTime.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpnlAlarmTime.Size = new Size(916, 270);
            tblpnlAlarmTime.TabIndex = 10;
            // 
            // tblpnlAlarmTimeHour
            // 
            tblpnlAlarmTimeHour.ColumnCount = 1;
            tblpnlAlarmTimeHour.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlAlarmTimeHour.Controls.Add(btnHourDown, 0, 2);
            tblpnlAlarmTimeHour.Controls.Add(btnHourUp, 0, 0);
            tblpnlAlarmTimeHour.Controls.Add(lblAlarmTimeHour, 0, 1);
            tblpnlAlarmTimeHour.Dock = DockStyle.Right;
            tblpnlAlarmTimeHour.Location = new Point(19, 5);
            tblpnlAlarmTimeHour.Margin = new Padding(5);
            tblpnlAlarmTimeHour.Name = "tblpnlAlarmTimeHour";
            tblpnlAlarmTimeHour.RowCount = 3;
            tblpnlAlarmTimeHour.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblpnlAlarmTimeHour.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tblpnlAlarmTimeHour.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblpnlAlarmTimeHour.Size = new Size(394, 260);
            tblpnlAlarmTimeHour.TabIndex = 0;
            // 
            // btnHourDown
            // 
            btnHourDown.Dock = DockStyle.Fill;
            btnHourDown.FillColor = Color.FromArgb(70, 70, 70);
            btnHourDown.FillHoverColor = SystemColors.WindowFrame;
            btnHourDown.FillPressColor = Color.FromArgb(120, 120, 120);
            btnHourDown.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            btnHourDown.Location = new Point(4, 226);
            btnHourDown.Margin = new Padding(4);
            btnHourDown.MinimumSize = new Size(1, 1);
            btnHourDown.Name = "btnHourDown";
            btnHourDown.Radius = 0;
            btnHourDown.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnHourDown.RectColor = Color.FromArgb(70, 70, 70);
            btnHourDown.RectHoverColor = SystemColors.WindowFrame;
            btnHourDown.RectPressColor = Color.FromArgb(120, 120, 120);
            btnHourDown.Size = new Size(386, 30);
            btnHourDown.TabIndex = 11;
            btnHourDown.Text = "▾";
            btnHourDown.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btnHourUp
            // 
            btnHourUp.Dock = DockStyle.Fill;
            btnHourUp.FillColor = Color.FromArgb(70, 70, 70);
            btnHourUp.FillHoverColor = SystemColors.WindowFrame;
            btnHourUp.FillPressColor = Color.FromArgb(120, 120, 120);
            btnHourUp.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            btnHourUp.Location = new Point(4, 4);
            btnHourUp.Margin = new Padding(4);
            btnHourUp.MinimumSize = new Size(1, 1);
            btnHourUp.Name = "btnHourUp";
            btnHourUp.Radius = 10;
            btnHourUp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnHourUp.RectColor = Color.FromArgb(70, 70, 70);
            btnHourUp.RectHoverColor = SystemColors.WindowFrame;
            btnHourUp.RectPressColor = Color.FromArgb(120, 120, 120);
            btnHourUp.Size = new Size(386, 29);
            btnHourUp.TabIndex = 10;
            btnHourUp.Text = "▴";
            btnHourUp.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // lblAlarmTimeHour
            // 
            lblAlarmTimeHour.BackColor = Color.FromArgb(40, 40, 40);
            lblAlarmTimeHour.Dock = DockStyle.Fill;
            lblAlarmTimeHour.Font = new Font("Yu Gothic UI Semibold", 52F, FontStyle.Bold);
            lblAlarmTimeHour.ForeColor = Color.Gainsboro;
            lblAlarmTimeHour.Location = new Point(5, 37);
            lblAlarmTimeHour.Margin = new Padding(5, 0, 5, 0);
            lblAlarmTimeHour.Name = "lblAlarmTimeHour";
            lblAlarmTimeHour.Size = new Size(384, 185);
            lblAlarmTimeHour.TabIndex = 12;
            lblAlarmTimeHour.Text = "00";
            lblAlarmTimeHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblpnlAlarmTimeMin
            // 
            tblpnlAlarmTimeMin.ColumnCount = 1;
            tblpnlAlarmTimeMin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpnlAlarmTimeMin.Controls.Add(btnMinDown, 0, 2);
            tblpnlAlarmTimeMin.Controls.Add(btnMinUp, 0, 0);
            tblpnlAlarmTimeMin.Controls.Add(lblAlarmTimeMin, 0, 1);
            tblpnlAlarmTimeMin.Dock = DockStyle.Left;
            tblpnlAlarmTimeMin.Location = new Point(493, 5);
            tblpnlAlarmTimeMin.Margin = new Padding(5);
            tblpnlAlarmTimeMin.Name = "tblpnlAlarmTimeMin";
            tblpnlAlarmTimeMin.RowCount = 3;
            tblpnlAlarmTimeMin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblpnlAlarmTimeMin.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tblpnlAlarmTimeMin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblpnlAlarmTimeMin.Size = new Size(403, 260);
            tblpnlAlarmTimeMin.TabIndex = 1;
            // 
            // btnMinDown
            // 
            btnMinDown.Dock = DockStyle.Fill;
            btnMinDown.FillColor = Color.FromArgb(70, 70, 70);
            btnMinDown.FillHoverColor = SystemColors.WindowFrame;
            btnMinDown.FillPressColor = Color.FromArgb(120, 120, 120);
            btnMinDown.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            btnMinDown.Location = new Point(4, 226);
            btnMinDown.Margin = new Padding(4);
            btnMinDown.MinimumSize = new Size(1, 1);
            btnMinDown.Name = "btnMinDown";
            btnMinDown.Radius = 0;
            btnMinDown.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnMinDown.RectColor = Color.FromArgb(70, 70, 70);
            btnMinDown.RectHoverColor = SystemColors.WindowFrame;
            btnMinDown.RectPressColor = Color.FromArgb(120, 120, 120);
            btnMinDown.Size = new Size(395, 30);
            btnMinDown.TabIndex = 11;
            btnMinDown.Text = "▾";
            btnMinDown.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btnMinUp
            // 
            btnMinUp.Dock = DockStyle.Fill;
            btnMinUp.FillColor = Color.FromArgb(70, 70, 70);
            btnMinUp.FillHoverColor = SystemColors.WindowFrame;
            btnMinUp.FillPressColor = Color.FromArgb(120, 120, 120);
            btnMinUp.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            btnMinUp.Location = new Point(4, 4);
            btnMinUp.Margin = new Padding(4);
            btnMinUp.MinimumSize = new Size(1, 1);
            btnMinUp.Name = "btnMinUp";
            btnMinUp.Radius = 10;
            btnMinUp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnMinUp.RectColor = Color.FromArgb(70, 70, 70);
            btnMinUp.RectHoverColor = SystemColors.WindowFrame;
            btnMinUp.RectPressColor = Color.FromArgb(120, 120, 120);
            btnMinUp.Size = new Size(395, 29);
            btnMinUp.TabIndex = 10;
            btnMinUp.Text = "▴";
            btnMinUp.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // lblAlarmTimeMin
            // 
            lblAlarmTimeMin.BackColor = Color.FromArgb(40, 40, 40);
            lblAlarmTimeMin.Dock = DockStyle.Fill;
            lblAlarmTimeMin.Font = new Font("Yu Gothic UI Semibold", 52F, FontStyle.Bold);
            lblAlarmTimeMin.ForeColor = Color.Gainsboro;
            lblAlarmTimeMin.Location = new Point(5, 37);
            lblAlarmTimeMin.Margin = new Padding(5, 0, 5, 0);
            lblAlarmTimeMin.Name = "lblAlarmTimeMin";
            lblAlarmTimeMin.Size = new Size(393, 185);
            lblAlarmTimeMin.TabIndex = 12;
            lblAlarmTimeMin.Text = "00";
            lblAlarmTimeMin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeSep
            // 
            lblTimeSep.AutoSize = true;
            lblTimeSep.Dock = DockStyle.Fill;
            lblTimeSep.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTimeSep.ForeColor = Color.Gainsboro;
            lblTimeSep.Location = new Point(423, 0);
            lblTimeSep.Margin = new Padding(5, 0, 5, 0);
            lblTimeSep.Name = "lblTimeSep";
            lblTimeSep.Size = new Size(60, 270);
            lblTimeSep.TabIndex = 2;
            lblTimeSep.Text = ":";
            lblTimeSep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlarmRepeat
            // 
            lblAlarmRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAlarmRepeat.AutoSize = true;
            lblAlarmRepeat.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblAlarmRepeat.ForeColor = Color.Gainsboro;
            lblAlarmRepeat.Location = new Point(4, 605);
            lblAlarmRepeat.Margin = new Padding(4, 0, 4, 0);
            lblAlarmRepeat.Name = "lblAlarmRepeat";
            lblAlarmRepeat.Size = new Size(201, 381);
            lblAlarmRepeat.TabIndex = 4;
            lblAlarmRepeat.Text = "重复";
            lblAlarmRepeat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabpSolutions
            // 
            tabpSolutions.AutoScroll = true;
            tabpSolutions.BackColor = Color.FromArgb(26, 26, 26);
            tabpSolutions.Location = new Point(0, 29);
            tabpSolutions.Margin = new Padding(4);
            tabpSolutions.Name = "tabpSolutions";
            tabpSolutions.Padding = new Padding(4);
            tabpSolutions.Size = new Size(1141, 1141);
            tabpSolutions.TabIndex = 2;
            tabpSolutions.Text = "方案选择";
            // 
            // timerGC
            // 
            timerGC.Enabled = true;
            timerGC.Interval = 5000;
            timerGC.Tick += timerGC_Tick;
            // 
            // imglstControlBoxes
            // 
            imglstControlBoxes.ColorDepth = ColorDepth.Depth32Bit;
            imglstControlBoxes.ImageSize = new Size(30, 30);
            imglstControlBoxes.TransparentColor = Color.Transparent;
            // 
            // imglstAlarmBoxes
            // 
            imglstAlarmBoxes.ColorDepth = ColorDepth.Depth32Bit;
            imglstAlarmBoxes.ImageSize = new Size(25, 25);
            imglstAlarmBoxes.TransparentColor = Color.Transparent;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "闹铃管理系统";
            notifyIcon.BalloonTipTitle = "闹铃管理系统在托盘运行。";
            notifyIcon.ContextMenuStrip = contNotifyIcon;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "闹铃管理系统";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // contNotifyIcon
            // 
            contNotifyIcon.ImageScalingSize = new Size(24, 24);
            contNotifyIcon.Items.AddRange(new ToolStripItem[] { contNotifyIconDisplay, contNotifyIconExit });
            contNotifyIcon.Name = "contNotifyIcon";
            contNotifyIcon.Size = new Size(197, 64);
            // 
            // contNotifyIconDisplay
            // 
            contNotifyIconDisplay.Name = "contNotifyIconDisplay";
            contNotifyIconDisplay.Size = new Size(196, 30);
            contNotifyIconDisplay.Text = "显示主窗口(&D)";
            contNotifyIconDisplay.Click += contNotifyIconDisplay_Click;
            // 
            // contNotifyIconExit
            // 
            contNotifyIconExit.Name = "contNotifyIconExit";
            contNotifyIconExit.Size = new Size(196, 30);
            contNotifyIconExit.Text = "退出(&E)";
            contNotifyIconExit.Click += contNotifyIconExit_Click;
            // 
            // tblpnlMain
            // 
            tblpnlMain.ColumnCount = 1;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.Controls.Add(tabctrlMain, 0, 1);
            tblpnlMain.Controls.Add(pnlCaption, 0, 0);
            tblpnlMain.Dock = DockStyle.Fill;
            tblpnlMain.Location = new Point(0, 0);
            tblpnlMain.Margin = new Padding(4);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 2;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.922396F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 94.07761F));
            tblpnlMain.Size = new Size(1149, 1252);
            tblpnlMain.TabIndex = 1;
            // 
            // pnlCaption
            // 
            pnlCaption.ColumnCount = 5;
            pnlCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.491803F));
            pnlCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4918032F));
            pnlCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.8032761F));
            pnlCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.98360634F));
            pnlCaption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.147541F));
            pnlCaption.Controls.Add(btnClose, 4, 0);
            pnlCaption.Controls.Add(btnMini, 3, 0);
            pnlCaption.Controls.Add(btnMenu, 0, 0);
            pnlCaption.Controls.Add(lblTitle, 1, 0);
            pnlCaption.Dock = DockStyle.Fill;
            pnlCaption.Location = new Point(4, 4);
            pnlCaption.Margin = new Padding(4);
            pnlCaption.Name = "pnlCaption";
            pnlCaption.RowCount = 1;
            pnlCaption.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCaption.Size = new Size(1141, 66);
            pnlCaption.TabIndex = 1;
            pnlCaption.MouseDown += pnlCaption_MouseDown;
            pnlCaption.MouseMove += pnlCaption_MouseMove;
            pnlCaption.MouseUp += pnlCaption_MouseUp;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1149, 1252);
            Controls.Add(tblpnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "闹铃管理系统";
            Load += Main_Load;
            tabctrlMain.ResumeLayout(false);
            tabpEdit.ResumeLayout(false);
            tblpnlSave.ResumeLayout(false);
            tblpnlEdit.ResumeLayout(false);
            tblpnlEdit.PerformLayout();
            tblpnlRepeat.ResumeLayout(false);
            tblpnlRepeatSelect.ResumeLayout(false);
            tblpnlRepeatSelect.PerformLayout();
            tblpnlAlarmTime.ResumeLayout(false);
            tblpnlAlarmTime.PerformLayout();
            tblpnlAlarmTimeHour.ResumeLayout(false);
            tblpnlAlarmTimeMin.ResumeLayout(false);
            contNotifyIcon.ResumeLayout(false);
            tblpnlMain.ResumeLayout(false);
            pnlCaption.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TransparentButton btnClose;
        private TransparentButton btnMenu;
        private TransparentButton btnMini;
        private NoTabTabControl tabctrlMain;
        private TabPage tabpGrid;
        private TabPage tabpEdit;
        private System.Windows.Forms.Timer timerGC;
        private Label lblTitle;
        private ImageList imglstControlBoxes;
        private ImageList imglstAlarmBoxes;
        private TabPage tabpSolutions;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contNotifyIcon;
        private ToolStripMenuItem contNotifyIconDisplay;
        private ToolStripMenuItem contNotifyIconExit;
        private TableLayoutPanel tblpnlEdit;
        private Label lblEditMode;
        private Label lblAlarmTag;
        private Label lblAlarmTime;
        private Label lblAlarmMusic;
        private Label lblAlarmRepeat;
        private Sunny.UI.UIComboBox cmbEditMode;
        private Sunny.UI.UITextBox txtAlarmTag;
        private Sunny.UI.UIComboBox cmbAlarmMusic;
        private TableLayoutPanel tblpnlSave;
        private Sunny.UI.UIButton btnSave;
        private TableLayoutPanel tblpnlAlarmTime;
        private TableLayoutPanel tblpnlAlarmTimeHour;
        private TableLayoutPanel tblpnlAlarmTimeMin;
        private Sunny.UI.UIButton btnHourDown;
        private Sunny.UI.UIButton btnHourUp;
        private Sunny.UI.UIButton btnMinDown;
        private Sunny.UI.UIButton btnMinUp;
        private Label lblTimeSep;
        private Label lblAlarmTimeHour;
        private Label lblAlarmTimeMin;
        private TableLayoutPanel tblpnlRepeat;
        private Sunny.UI.UIRadioButton rdRepeat;
        private Sunny.UI.UIRadioButton rdOnlyOnce;
        private TableLayoutPanel tblpnlRepeatSelect;
        private Sunny.UI.UISwitch sw1;
        private Sunny.UI.UISwitch sw5;
        private Sunny.UI.UISwitch sw2;
        private Sunny.UI.UISwitch sw6;
        private Sunny.UI.UISwitch sw3;
        private Sunny.UI.UISwitch sw7;
        private Sunny.UI.UISwitch sw4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tblpnlMain;
        private TableLayoutPanel pnlCaption;
    }
}
