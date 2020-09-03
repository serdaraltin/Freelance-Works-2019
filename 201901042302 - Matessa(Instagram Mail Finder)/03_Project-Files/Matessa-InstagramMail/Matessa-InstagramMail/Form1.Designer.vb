<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbAnahtar = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnahtar = New System.Windows.Forms.TextBox()
        Me.rchb_durum = New System.Windows.Forms.RichTextBox()
        Me.gbArama = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSozcuk = New System.Windows.Forms.TextBox()
        Me.btnBaslat = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.picBildirim = New System.Windows.Forms.PictureBox()
        Me.richMailListe = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnKopyala = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.gbPRoxy = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chOtoDegis = New System.Windows.Forms.CheckBox()
        Me.btnDosyaSec = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProxy = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.slbIp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstProxy = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbproxysayi = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TaramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇerezleriTemizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖnbelleğiTemizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbAnahtar.SuspendLayout()
        Me.gbArama.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picBildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.gbPRoxy.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAnahtar
        '
        Me.gbAnahtar.Controls.Add(Me.Label9)
        Me.gbAnahtar.Controls.Add(Me.Label3)
        Me.gbAnahtar.Controls.Add(Me.Label5)
        Me.gbAnahtar.Controls.Add(Me.txtAnahtar)
        Me.gbAnahtar.ForeColor = System.Drawing.Color.Red
        Me.gbAnahtar.Location = New System.Drawing.Point(267, 36)
        Me.gbAnahtar.Name = "gbAnahtar"
        Me.gbAnahtar.Size = New System.Drawing.Size(249, 152)
        Me.gbAnahtar.TabIndex = 1
        Me.gbAnahtar.TabStop = False
        Me.gbAnahtar.Text = "Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(14, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 39)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Mail adresi indexlenen veriler içerisindeki " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "anahtar sözcükle uyumlu olanların l" & _
            "istelenmesini " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sağlar.Boş bırakılması halinde hata oluşabilir."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(61, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Örnek : gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(14, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sunucu"
        '
        'txtAnahtar
        '
        Me.txtAnahtar.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtAnahtar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnahtar.ForeColor = System.Drawing.Color.Gold
        Me.txtAnahtar.Location = New System.Drawing.Point(64, 33)
        Me.txtAnahtar.Name = "txtAnahtar"
        Me.txtAnahtar.Size = New System.Drawing.Size(163, 20)
        Me.txtAnahtar.TabIndex = 1
        Me.txtAnahtar.Text = "gmail.com"
        '
        'rchb_durum
        '
        Me.rchb_durum.BackColor = System.Drawing.SystemColors.MenuText
        Me.rchb_durum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rchb_durum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rchb_durum.ForeColor = System.Drawing.Color.Honeydew
        Me.rchb_durum.Location = New System.Drawing.Point(10, 416)
        Me.rchb_durum.Name = "rchb_durum"
        Me.rchb_durum.ReadOnly = True
        Me.rchb_durum.Size = New System.Drawing.Size(506, 179)
        Me.rchb_durum.TabIndex = 7
        Me.rchb_durum.Text = ""
        '
        'gbArama
        '
        Me.gbArama.Controls.Add(Me.Label8)
        Me.gbArama.Controls.Add(Me.Label6)
        Me.gbArama.Controls.Add(Me.Label1)
        Me.gbArama.Controls.Add(Me.txtSozcuk)
        Me.gbArama.ForeColor = System.Drawing.Color.Red
        Me.gbArama.Location = New System.Drawing.Point(12, 36)
        Me.gbArama.Name = "gbArama"
        Me.gbArama.Size = New System.Drawing.Size(249, 152)
        Me.gbArama.TabIndex = 0
        Me.gbArama.TabStop = False
        Me.gbArama.Text = "Arama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(13, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 39)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Anahtar filtreleme görevi görür ve dikkatli " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seçilmesi gerekmektedir. Anahtar sö" & _
            "zcük baz " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alınarak indexleme yapılır."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(61, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Örnek : football"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sözcük"
        '
        'txtSozcuk
        '
        Me.txtSozcuk.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtSozcuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSozcuk.ForeColor = System.Drawing.Color.Gold
        Me.txtSozcuk.Location = New System.Drawing.Point(64, 31)
        Me.txtSozcuk.Name = "txtSozcuk"
        Me.txtSozcuk.Size = New System.Drawing.Size(163, 20)
        Me.txtSozcuk.TabIndex = 0
        Me.txtSozcuk.Text = "football"
        '
        'btnBaslat
        '
        Me.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaslat.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnBaslat.Location = New System.Drawing.Point(24, 19)
        Me.btnBaslat.Name = "btnBaslat"
        Me.btnBaslat.Size = New System.Drawing.Size(92, 30)
        Me.btnBaslat.TabIndex = 6
        Me.btnBaslat.Text = "BAŞLAT"
        Me.btnBaslat.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnIptal)
        Me.GroupBox4.Controls.Add(Me.btnBaslat)
        Me.GroupBox4.ForeColor = System.Drawing.Color.MediumOrchid
        Me.GroupBox4.Location = New System.Drawing.Point(10, 349)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 61)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "İşlem"
        '
        'btnIptal
        '
        Me.btnIptal.Enabled = False
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnIptal.Location = New System.Drawing.Point(133, 19)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(92, 30)
        Me.btnIptal.TabIndex = 7
        Me.btnIptal.Text = "İPTAL"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.picBildirim)
        Me.GroupBox5.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox5.Location = New System.Drawing.Point(267, 349)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(249, 61)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Durum"
        '
        'picBildirim
        '
        Me.picBildirim.Image = Global.Matessa_InstagramMail.My.Resources.Resources._30
        Me.picBildirim.Location = New System.Drawing.Point(37, 20)
        Me.picBildirim.Name = "picBildirim"
        Me.picBildirim.Size = New System.Drawing.Size(175, 27)
        Me.picBildirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBildirim.TabIndex = 18
        Me.picBildirim.TabStop = False
        Me.picBildirim.Visible = False
        '
        'richMailListe
        '
        Me.richMailListe.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.richMailListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richMailListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.richMailListe.ForeColor = System.Drawing.Color.LawnGreen
        Me.richMailListe.Location = New System.Drawing.Point(522, 42)
        Me.richMailListe.Name = "richMailListe"
        Me.richMailListe.ReadOnly = True
        Me.richMailListe.Size = New System.Drawing.Size(361, 488)
        Me.richMailListe.TabIndex = 8
        Me.richMailListe.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnKopyala)
        Me.GroupBox6.Controls.Add(Me.btnKaydet)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox6.Location = New System.Drawing.Point(522, 534)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(361, 61)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dosya"
        '
        'btnKopyala
        '
        Me.btnKopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKopyala.ForeColor = System.Drawing.Color.Aqua
        Me.btnKopyala.Location = New System.Drawing.Point(210, 19)
        Me.btnKopyala.Name = "btnKopyala"
        Me.btnKopyala.Size = New System.Drawing.Size(106, 30)
        Me.btnKopyala.TabIndex = 10
        Me.btnKopyala.Text = "KOPYALA"
        Me.btnKopyala.UseVisualStyleBackColor = True
        '
        'btnKaydet
        '
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.ForeColor = System.Drawing.Color.Aqua
        Me.btnKaydet.Location = New System.Drawing.Point(41, 19)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(163, 30)
        Me.btnKaydet.TabIndex = 9
        Me.btnKaydet.Text = "KAYDET"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'gbPRoxy
        '
        Me.gbPRoxy.Controls.Add(Me.Label14)
        Me.gbPRoxy.Controls.Add(Me.Label12)
        Me.gbPRoxy.Controls.Add(Me.chOtoDegis)
        Me.gbPRoxy.Controls.Add(Me.btnDosyaSec)
        Me.gbPRoxy.Controls.Add(Me.Label13)
        Me.gbPRoxy.Controls.Add(Me.txtProxy)
        Me.gbPRoxy.ForeColor = System.Drawing.Color.Red
        Me.gbPRoxy.Location = New System.Drawing.Point(12, 194)
        Me.gbPRoxy.Name = "gbPRoxy"
        Me.gbPRoxy.Size = New System.Drawing.Size(249, 152)
        Me.gbPRoxy.TabIndex = 2
        Me.gbPRoxy.TabStop = False
        Me.gbPRoxy.Text = "Proxy"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(13, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 39)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Otomatik değiştirme seçeneği proxy " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sunucusunun isteği başarısız olursa listede " & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bulunan yeni bir proxy ayarlar."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(13, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(235, 39)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Proxyler veri alınan sunucu isteği reddetmesi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "durumunda devreye girerek dağınık" & _
            " bağlantılarla " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "veri toplamaya devam eder."
        '
        'chOtoDegis
        '
        Me.chOtoDegis.AutoSize = True
        Me.chOtoDegis.Checked = True
        Me.chOtoDegis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chOtoDegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chOtoDegis.ForeColor = System.Drawing.Color.SpringGreen
        Me.chOtoDegis.Location = New System.Drawing.Point(11, 84)
        Me.chOtoDegis.Name = "chOtoDegis"
        Me.chOtoDegis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chOtoDegis.Size = New System.Drawing.Size(103, 17)
        Me.chOtoDegis.TabIndex = 4
        Me.chOtoDegis.Text = "Otomatik Değiştir"
        Me.chOtoDegis.UseVisualStyleBackColor = True
        '
        'btnDosyaSec
        '
        Me.btnDosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDosyaSec.ForeColor = System.Drawing.Color.Red
        Me.btnDosyaSec.Location = New System.Drawing.Point(218, 18)
        Me.btnDosyaSec.Name = "btnDosyaSec"
        Me.btnDosyaSec.Size = New System.Drawing.Size(25, 21)
        Me.btnDosyaSec.TabIndex = 3
        Me.btnDosyaSec.Text = "..."
        Me.btnDosyaSec.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(14, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dosya"
        '
        'txtProxy
        '
        Me.txtProxy.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProxy.ForeColor = System.Drawing.Color.Gold
        Me.txtProxy.Location = New System.Drawing.Point(64, 19)
        Me.txtProxy.Name = "txtProxy"
        Me.txtProxy.ReadOnly = True
        Me.txtProxy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtProxy.Size = New System.Drawing.Size(149, 20)
        Me.txtProxy.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slbIp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 604)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'slbIp
        '
        Me.slbIp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.slbIp.ForeColor = System.Drawing.Color.Aqua
        Me.slbIp.Name = "slbIp"
        Me.slbIp.Size = New System.Drawing.Size(66, 19)
        Me.slbIp.Text = "127.0.0.1"
        '
        'lstProxy
        '
        Me.lstProxy.BackColor = System.Drawing.Color.Black
        Me.lstProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProxy.ForeColor = System.Drawing.Color.Fuchsia
        Me.lstProxy.FormattingEnabled = True
        Me.lstProxy.Location = New System.Drawing.Point(6, 19)
        Me.lstProxy.Name = "lstProxy"
        Me.lstProxy.Size = New System.Drawing.Size(235, 106)
        Me.lstProxy.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbproxysayi)
        Me.GroupBox3.Controls.Add(Me.lstProxy)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Magenta
        Me.GroupBox3.Location = New System.Drawing.Point(268, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 151)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proxy Liste"
        '
        'lbproxysayi
        '
        Me.lbproxysayi.AutoSize = True
        Me.lbproxysayi.ForeColor = System.Drawing.Color.DeepPink
        Me.lbproxysayi.Location = New System.Drawing.Point(6, 130)
        Me.lbproxysayi.Name = "lbproxysayi"
        Me.lbproxysayi.Size = New System.Drawing.Size(13, 13)
        Me.lbproxysayi.TabIndex = 25
        Me.lbproxysayi.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaramaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TaramaToolStripMenuItem
        '
        Me.TaramaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TaramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇerezleriTemizleToolStripMenuItem, Me.ÖnbelleğiTemizleToolStripMenuItem})
        Me.TaramaToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.TaramaToolStripMenuItem.Name = "TaramaToolStripMenuItem"
        Me.TaramaToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.TaramaToolStripMenuItem.Text = "Tarama"
        '
        'ÇerezleriTemizleToolStripMenuItem
        '
        Me.ÇerezleriTemizleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ÇerezleriTemizleToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.ÇerezleriTemizleToolStripMenuItem.Name = "ÇerezleriTemizleToolStripMenuItem"
        Me.ÇerezleriTemizleToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÇerezleriTemizleToolStripMenuItem.Text = "Çerezleri Temizle"
        '
        'ÖnbelleğiTemizleToolStripMenuItem
        '
        Me.ÖnbelleğiTemizleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ÖnbelleğiTemizleToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.ÖnbelleğiTemizleToolStripMenuItem.Name = "ÖnbelleğiTemizleToolStripMenuItem"
        Me.ÖnbelleğiTemizleToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖnbelleğiTemizleToolStripMenuItem.Text = "Önbelleği Temizle"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(889, 42)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(449, 553)
        Me.WebBrowser1.TabIndex = 25
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button1.Location = New System.Drawing.Point(830, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "İPTAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbPRoxy)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.richMailListe)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbArama)
        Me.Controls.Add(Me.rchb_durum)
        Me.Controls.Add(Me.gbAnahtar)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstaMail"
        Me.gbAnahtar.ResumeLayout(False)
        Me.gbAnahtar.PerformLayout()
        Me.gbArama.ResumeLayout(False)
        Me.gbArama.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.picBildirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.gbPRoxy.ResumeLayout(False)
        Me.gbPRoxy.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbAnahtar As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAnahtar As System.Windows.Forms.TextBox
    Friend WithEvents rchb_durum As System.Windows.Forms.RichTextBox
    Friend WithEvents gbArama As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBaslat As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents richMailListe As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKopyala As System.Windows.Forms.Button
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents picBildirim As System.Windows.Forms.PictureBox
    Friend WithEvents gbPRoxy As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chOtoDegis As System.Windows.Forms.CheckBox
    Friend WithEvents btnDosyaSec As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProxy As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents slbIp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstProxy As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbproxysayi As System.Windows.Forms.Label
    Friend WithEvents txtSozcuk As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TaramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇerezleriTemizleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖnbelleğiTemizleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
