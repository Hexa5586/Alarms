using System.CodeDom;
using System.Drawing;
using System.Drawing.Drawing2D;
using Sunny.UI;

namespace Alarms
{

    public struct AlarmInfo
    {
        public int alarmNum = 0;
        public TimeOnly alarmTime = new TimeOnly();
        public String alarmTag = "";
        public String alarmMusic = "";
        public String alarmMode = "";

        public Size alarmSize = new Size();
        public double dpi_ratio;

        public AlarmInfo(int _num, TimeOnly _time, String _tag, String _music, String _mode, Size _size, double _ratio)
        {
            alarmNum = _num;
            alarmTime = _time;
            alarmTag = _tag;
            alarmMusic = _music;
            alarmMode = _mode;
            alarmSize = _size;
            dpi_ratio = _ratio;
        }
        
    };

    public partial class Main : Form
    {
        const int pnlTabWidth = 300;
        const int btnTabHeight = 80;
        const int btnTabWidth = 280;
        const int btnTabLocationX = 10;
        const int tabsTopMargin = 40;
        const int tabsPrevMargin = 10;
        const int alarmsTopMargin = 0;
        const int alarmsPrevMargin = 20;
        const int alarmsLocationX = 20;
        const int scrollWidth = 30;

        bool isMoving = false;
        bool pnlTabsToggled = false;
        Point startMovingPoint = new Point();

        public Main()
        {
            InitializeComponent();
        }

        private void toggle(ref Control con)
        {
            if (pnlTabsToggled)
            {

                con.Location = new Point(-pnlTabWidth, con.Location.Y);
                this.pnlCaption.BringToFront();
            }
            else
            {
                while (con.Location.X < 0)
                {
                    con.Location = new Point(con.Location.X + 1, con.Location.Y);
                    Thread.Sleep(0);
                }
                con.BringToFront();
            }

            pnlTabsToggled = !pnlTabsToggled;

        }

        public void recursive_font_adjust(Control con, double dpi_ratio)
        {
            if (con.Controls.Count == 0)
            {
                con.Font = new Font(con.Font.FontFamily, (float)(con.Font.SizeInPoints / dpi_ratio), con.Font.Style);
                return;
            }

            foreach (Control child in con.Controls)
            {
                recursive_font_adjust(child, dpi_ratio);
            }
            return;

        }

        private void AlarmCardsLoad(double dpiRatio)
        {
            int w = (int)((this.tabctrlMain.Width - 2 * alarmsLocationX - scrollWidth * dpiRatio));
            int h = (int)(this.tabctrlMain.Height / 5);
            AlarmInfo[] test = {
                new AlarmInfo(0, new TimeOnly(8, 30), "起床", "MUSIC1", "每天", new Size(w, h), dpiRatio),
                new AlarmInfo(1, new TimeOnly(11, 00), "午饭", "MUSIC2", "每天", new Size(w, h), dpiRatio),
                new AlarmInfo(2, new TimeOnly(13, 00), "午觉", "MUSIC1", "每天", new Size(w, h), dpiRatio),
                new AlarmInfo(3, new TimeOnly(15, 00), "社团", "MUSIC3", "1|3|5", new Size(w, h), dpiRatio),
                new AlarmInfo(4, new TimeOnly(18, 00), "晚饭", "MUSIC2", "每天", new Size(w, h), dpiRatio),
                new AlarmInfo(5, new TimeOnly(23, 00), "睡觉", "MUSIC1", "工作日", new Size(w, h), dpiRatio)
            };

            int cnt = 0;
            foreach (AlarmInfo i in test)
            {
                CardPanel new_card = new CardPanel(i);
                new_card.Location = new Point(alarmsLocationX, (new_card.cardHeight + alarmsPrevMargin) * cnt + alarmsTopMargin);
                new_card.alarmEdit.BackgroundImage = this.imglstAlarmBoxes.Images[0];
                new_card.alarmDel.BackgroundImage = this.imglstAlarmBoxes.Images[1];
                this.tabpGrid.Controls.Add(new_card);
                cnt++;
            }
            tabpGrid.AutoScroll = true;
        }

        private void SolutionRadiosLoad(double dpiRatio)
        {
            string[] solNames = { "家用", "校用", "自用" };
            int count = solNames.Length;

            TableLayoutPanel tbl = new TableLayoutPanel();
            tbl.Name = "tblpnlSolutions";
            tbl.Dock = DockStyle.Top;
            tbl.AutoSize = true;
            tbl.ColumnCount = 2;
            tbl.RowCount = count;

            tbl.ColumnStyles.Clear();
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            
            tbl.RowStyles.Clear();
            for (int i = 0;i < count; i++)
            {
                tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, (float)(this.tabpSolutions.Height / 10)));
                UIRadioButton new_sol = new UIRadioButton();
                new_sol.Text = "  " + solNames[i];
                new_sol.Dock = DockStyle.Fill;
                new_sol.RadioButtonSize = (int)(20 * dpiRatio);
                new_sol.RadioButtonColor = Color.FromArgb(240, 240, 240);
                new_sol.ForeColor = Color.Gainsboro;
                new_sol.Font = new Font("Microsoft YaHei", (float)(15 / dpiRatio), FontStyle.Bold);
                tbl.Controls.Add(new_sol, 1, i);
            }

            tabpSolutions.Controls.Add(tbl);
        }

        private void EditTabAdjust(double dpiRatio)
        {
            recursive_font_adjust(this.tabpEdit, dpiRatio);

            sw1.Height = (int)(sw1.Height / dpiRatio);
            sw2.Height = (int)(sw2.Height / dpiRatio);
            sw3.Height = (int)(sw3.Height / dpiRatio);
            sw4.Height = (int)(sw4.Height / dpiRatio);
            sw5.Height = (int)(sw5.Height / dpiRatio);
            sw6.Height = (int)(sw6.Height / dpiRatio);
            sw7.Height = (int)(sw7.Height / dpiRatio);
        }

        private void PanelTabLoad(double dpiRatio)
        {
            Panel pnlTabs = new Panel();
            pnlTabs.SuspendLayout();
            pnlTabs.Size = new Size(pnlTabWidth, this.Height - pnlCaption.Height);
            pnlTabs.Location = new Point(-pnlTabWidth, pnlCaption.Height);
            pnlTabs.BackColor = Color.FromArgb(35, 35, 35);
            pnlTabs.Font = new Font(pnlTabs.Font.FontFamily, 12);

            Label lblCaption = new Label();
            lblCaption.Text = "Menu";
            lblCaption.ForeColor = Color.Gray;
            lblCaption.BackColor = Color.Transparent;
            lblCaption.AutoSize = false;
            lblCaption.Font = new Font("Microsoft YaHei", 8);
            lblCaption.Size = new Size(btnTabWidth, tabsTopMargin);
            lblCaption.Location = new Point(btnTabLocationX, 0);
            lblCaption.TextAlign = ContentAlignment.MiddleLeft;
            pnlTabs.Controls.Add(lblCaption);

            int cnt = 0;
            foreach (TabPage tab in tabctrlMain.TabPages)
            {
                TransparentButton btn = new TransparentButton();
                btn.TabIndex = cnt;
                btn.Size = new Size(btnTabWidth, btnTabHeight);
                btn.Location = new Point(btnTabLocationX, tabsTopMargin + (btnTabHeight + tabsPrevMargin) * (cnt++) - 1);
                btn.Text = tab.Text;
                btn.ForeColor = Color.Gainsboro;
                btn.Click += tabButton_Click;
                pnlTabs.Controls.Add(btn);
            }

            pnlTabs.Name = "pnlTabs";
            this.Controls.Add(pnlTabs);
            recursive_font_adjust(pnlTabs, dpiRatio);

            pnlTabs.Invalidate();
            pnlTabs.BringToFront();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            double dpiRatio;
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                float dpiX = graphics.DpiX;
                float dpiY = graphics.DpiY;
                dpiRatio = dpiX / 155;
                //MessageBox.Show(dpiX.ToString() + dpiY.ToString());
                
            }

            this.Height = (int)(this.Height / dpiRatio);
            this.Width = (int)(this.Width / dpiRatio);
            tblpnlEdit.Height = (int)(tblpnlEdit.Height / dpiRatio);
            tblpnlSave.Height = (int)(tblpnlSave.Height / dpiRatio);

            this.Location = new Point((int)((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2), 
                                      (int)((Screen.PrimaryScreen.Bounds.Height - this.Height) / 2));

            this.notifyIcon.Visible = true;
            this.pnlCaption.BringToFront();

            //tabctrlMain.Height = this.Height - pnlCaption.Height + tabAreaHeight;
            pnlCaption.Height = this.Height / 1120 * 60;
            btnMenu.Width = btnMenu.Height = pnlCaption.Height / 60 * 46;
            btnMini.Width = btnMini.Height = pnlCaption.Height / 60 * 46;
            btnClose.Width = btnClose.Height = pnlCaption.Height / 60 * 46;

            imglstControlBoxes.ColorDepth = ColorDepth.Depth32Bit;
            imglstControlBoxes.Images.Add(Image.FromFile(@"Images\Menu.png"));
            imglstControlBoxes.Images.Add(Image.FromFile(@"Images\Minimize.png"));
            imglstControlBoxes.Images.Add(Image.FromFile(@"Images\Close.png"));

            imglstAlarmBoxes.ColorDepth = ColorDepth.Depth32Bit;
            imglstAlarmBoxes.Images.Add(Image.FromFile(@"Images\Edit.png"));
            imglstAlarmBoxes.Images.Add(Image.FromFile(@"Images\Delete.png"));

            this.btnMenu.BackgroundImage = imglstControlBoxes.Images[0];
            this.btnMini.BackgroundImage = imglstControlBoxes.Images[1];
            this.btnClose.BackgroundImage = imglstControlBoxes.Images[2];

            this.tabctrlMain.Region = new Region(new RectangleF(this.tabpGrid.Left, this.tabpGrid.Top, this.tabpGrid.Width, this.tabpGrid.Height));

            AlarmCardsLoad(dpiRatio);
            EditTabAdjust(dpiRatio);
            SolutionRadiosLoad(dpiRatio);
            PanelTabLoad(dpiRatio);

            lblTitle.Text = tabctrlMain.TabPages[tabctrlMain.SelectedIndex].Text;

            recursive_font_adjust(this.pnlCaption, dpiRatio);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlCaption_MouseDown(object sender, MouseEventArgs e)
        {
            startMovingPoint = e.Location;
            isMoving = true;
        }

        private void pnlCaption_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void pnlCaption_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.Location = new Point(this.Location.X + e.X - startMovingPoint.X,
                    this.Location.Y + e.Y - startMovingPoint.Y);
            }

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                if (con.Name == "pnlTabs")
                {
                    Control pnlTab = con;
                    toggle(ref pnlTab);

                }
            }

        }

        private void tabButton_Click(object sender, EventArgs e)
        {
            Button? clickedbtn = sender as Button;
            if (clickedbtn == null)
            {
                return;
            }
            foreach (Control con in this.Controls)
            {
                if (con.Name == "pnlTabs")
                {
                    Control pnlTab = con;
                    toggle(ref pnlTab);

                }
            }
            tabctrlMain.SelectTab(clickedbtn.TabIndex);

        }

        private void timerGC_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void tabctrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tabctrlMain.TabPages[tabctrlMain.SelectedIndex].Text;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void contNotifyIconDisplay_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void contNotifyIconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class TransparentButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            this.BackColor = Color.FromArgb(0, 255, 255, 255);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 255, 255, 255);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
            this.FlatAppearance.BorderSize = 0;
        }
    }

    public class CardPanel : Panel
    {
        
        public int alarmNum = 0;
        public Label alarmTime = new Label();
        public Label alarmSettings = new Label();
        public Label alarmTag = new Label();
        public TransparentButton alarmDel = new TransparentButton();
        public TransparentButton alarmEdit = new TransparentButton();

        public const int alarmButtonsLength = 40;

        public int cardWidth, cardHeight;

        //public const int alarmTimeFontSize = 42;
        //public const int alarmTagSettingsFontSize = 12;

        public CardPanel(AlarmInfo info)
        {
            cardWidth = info.alarmSize.Width;
            cardHeight = info.alarmSize.Height;
            //MessageBox.Show(cardWidth.ToString());

            int alarmTimeLocationX = cardWidth * 8 / 97;
            int alarmTimeWidth = cardWidth * 36 / 97;
            int alarmTagSettingsLocationX = cardWidth * 40 / 97;
            int alarmTagSettingsWidth = cardWidth * 47 / 97;
            
            int alarmButtonsLocationX = cardWidth - alarmTimeLocationX - alarmButtonsLength;

            int alarmTimeFontSize = (int)(42 / info.dpi_ratio);
            int alarmTagSettingsFontSize = (int)(12 / info.dpi_ratio);

            this.Width = cardWidth;
            this.Height = cardHeight;

            alarmTime.AutoSize = true;
            alarmTag.AutoSize = true;
            alarmSettings.AutoSize = true;

            alarmTime.Text = info.alarmTime.Hour.ToString("D2") + ":" + info.alarmTime.Minute.ToString("D2");
            alarmTag.Text = info.alarmTag;
            alarmSettings.Text = info.alarmMusic + "; " + info.alarmMode;

            alarmTime.Font = new Font(new FontFamily("Microsoft YaHei"), alarmTimeFontSize, FontStyle.Bold);
            alarmTag.Font = new Font(new FontFamily("Microsoft YaHei"), alarmTagSettingsFontSize, FontStyle.Bold);
            alarmSettings.Font = new Font(new FontFamily("Microsoft YaHei"), alarmTagSettingsFontSize, FontStyle.Bold);

            Graphics g_time = Graphics.FromHwnd(alarmTime.Handle);
            SizeF size_time = g_time.MeasureString(alarmTime.Text, alarmTime.Font);
            float height_time = size_time.Height;

            Graphics g_tagsettings = Graphics.FromHwnd(alarmTag.Handle);
            SizeF size_tagsettings = g_tagsettings.MeasureString(alarmTag.Text, alarmTag.Font);
            float height_tagsettings = size_tagsettings.Height;

            int alarmUpperLocationY = (int)((cardHeight - height_time) / 2);
            int alarmLowerLocationY = (int)(alarmUpperLocationY + height_time - height_tagsettings);

            alarmTime.TextAlign = ContentAlignment.MiddleCenter;
            alarmTime.Location = new Point(alarmTimeLocationX, alarmUpperLocationY);
            
            alarmTime.ForeColor = Color.White;
            alarmTime.BackColor = Color.Transparent;
            
            alarmTag.TextAlign = ContentAlignment.BottomLeft;
            alarmTag.Location = new Point(alarmTagSettingsLocationX, alarmUpperLocationY);
            
            alarmTag.ForeColor = Color.Gainsboro;
            alarmTag.BackColor = Color.Transparent;
            
            alarmSettings.TextAlign = ContentAlignment.TopLeft;
            alarmSettings.Location = new Point(alarmTagSettingsLocationX, alarmLowerLocationY);
            
            alarmSettings.ForeColor = Color.Gainsboro;
            alarmSettings.BackColor = Color.Transparent;

            /*
            alarmTime.BorderStyle = BorderStyle.FixedSingle;
            alarmTag.BorderStyle = BorderStyle.FixedSingle;
            alarmSettings.BorderStyle = BorderStyle.FixedSingle;
            */

            alarmEdit.Location = new Point(alarmButtonsLocationX, alarmUpperLocationY);
            alarmEdit.Size = new Size(alarmButtonsLength, alarmButtonsLength);
            alarmEdit.BackgroundImageLayout = ImageLayout.Center;

            alarmDel.Location = new Point(alarmButtonsLocationX, alarmLowerLocationY);
            alarmDel.Size = new Size(alarmButtonsLength, alarmButtonsLength);
            alarmDel.BackgroundImageLayout = ImageLayout.Center;

            this.Controls.Add(alarmTime);
            this.Controls.Add(alarmTag);
            this.Controls.Add(alarmSettings);
            this.Controls.Add(alarmDel);
            this.Controls.Add(alarmEdit);

        }

        
        private void FillRound(Rectangle rectangle,
            Graphics g, Brush br, int _radius)
        {
            g.FillPath(br, DrawRoundRect(rectangle.X,
                rectangle.Y, rectangle.Width - 2,
                rectangle.Height - 1, _radius));
        }
        
        private static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            FillRound(new Rectangle(new Point(0, 0), new Size(this.Size.Width - 1, this.Size.Height - 1)), e.Graphics, 
                    new SolidBrush(Color.FromArgb(50, 50, 50)), 30);
        }
    }

    public class NoTabTabControl : TabControl
    {
        public override Rectangle DisplayRectangle
        {
            get
            {
                Rectangle rect = base.DisplayRectangle;
                return new Rectangle(rect.Left - 4, rect.Top - 4, rect.Width + 8, rect.Height + 8);
            }
        }
    }
}
