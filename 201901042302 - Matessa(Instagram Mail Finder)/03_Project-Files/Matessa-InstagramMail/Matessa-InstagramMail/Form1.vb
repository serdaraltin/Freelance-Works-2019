Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Form1
    <Runtime.InteropServices.DllImport("wininet.dll", SetLastError:=True)> _
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    End Function

    Dim mailsifre As String
    Dim aramaolustur As Boolean = False
    Dim proxyno As Integer = 0
    Dim tarayici As WebBrowser
    Dim tarama As Integer = 0

    Private Sub CiktiEkle(ByVal veri As String, ByVal tip As String)
        Dim tarih As String = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString()
        If rchb_durum.Text <> "" Then
            rchb_durum.AppendText(Environment.NewLine + tarih + " >> ")
        Else
            rchb_durum.AppendText(tarih + " >> ")
        End If
        rchb_durum.Select(rchb_durum.Text.IndexOf(tarih), tarih.Length)
        rchb_durum.SelectionColor = Color.Yellow
        rchb_durum.AppendText(veri)
        rchb_durum.Select(rchb_durum.Text.IndexOf(veri), veri.Length)
        Select Case (tip)
            Case "bilgi"
                rchb_durum.SelectionColor = Color.Cyan
            Case "uyari"
                rchb_durum.SelectionColor = Color.Orange
            Case "hata"
                rchb_durum.SelectionColor = Color.Red
        End Select
        For i As Integer = 0 To rchb_durum.Text.Length - 1
            If (rchb_durum.Text(i) = ">") Then
                rchb_durum.Select(i, 1)
                rchb_durum.SelectionColor = Color.Wheat
            End If

        Next
        Dim ayrac As String = veri
        If veri.Contains("[") And veri.Contains("]") Then
            Try
                ayrac = ayrac.Remove(0, ayrac.IndexOf("[") + 1)
                ayrac = ayrac.Substring(0, ayrac.IndexOf("]"))
                rchb_durum.Select(rchb_durum.Text.IndexOf(ayrac), ayrac.Length)
                rchb_durum.SelectionColor = Color.Magenta
            Catch ex As Exception
                ayrac = ayrac.Remove(0, ayrac.IndexOf("[") + 1)
                ayrac = ayrac.Substring(0, ayrac.IndexOf("]") + 1)
                rchb_durum.Select(rchb_durum.Text.IndexOf(ayrac), ayrac.Length - 1)
                rchb_durum.SelectionColor = Color.Magenta
            End Try
        End If
        If (veri.Contains("Tarama işlemi tamamlandı.")) Then
            rchb_durum.Select(rchb_durum.Text.IndexOf("Tarama işlemi tamamlandı."), veri.Length)
            rchb_durum.SelectionColor = Color.SpringGreen
        End If
        rchb_durum.DeselectAll()
        rchb_durum.SelectionStart = rchb_durum.TextLength
        rchb_durum.ScrollToCaret()
    End Sub

    Private Sub btnBaslat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaslat.Click
        If Not (txtProxy.Text = "") Then
            btnBaslat.Enabled = False
            btnIptal.Enabled = True
            gbAnahtar.Enabled = False
            gbArama.Enabled = False
            gbPRoxy.Enabled = False
            VeriCek(txtSozcuk.Text, txtAnahtar.Text)
            CiktiEkle("Tarama başlatıldı.", "bilgi")
        Else
            MessageBox.Show("Proxy sunucuları ekleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIptal.Click
        btnIptal.Enabled = False
        btnBaslat.Enabled = True
        picBildirim.Visible = False
        tarayici.Navigate("")
        gbAnahtar.Enabled = True
        gbArama.Enabled = True
        gbPRoxy.Enabled = True
        tarama = 0
        CiktiEkle("Tarama iptal edildi", "uyari")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
        'System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
        tarayici = New WebBrowser
        ' tarayici.ScriptErrorsSuppressed = True
        AddHandler tarayici.DocumentCompleted, AddressOf tarayici_yuklendi
        AddHandler tarayici.Navigating, AddressOf tarayici_yukleniyor
    End Sub

    Private Structure Struct_internet_proxy_info
        Public accesstype As Integer
        Public proxy As IntPtr
        Public proxybypass As IntPtr
    End Structure

    Private Sub proxy_ayarla(ByVal proxystring As String)
        Try
            Const internet_option_proxy As Integer = 38
            Const internet_open_type_proxy As Integer = 3
            Dim struc_ipi As Struct_internet_proxy_info
            struc_ipi.accesstype = internet_open_type_proxy
            struc_ipi.proxy = Marshal.StringToHGlobalAnsi(proxystring)
            struc_ipi.proxybypass = Marshal.StringToHGlobalAnsi("local")
            Dim intstruct As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struc_ipi))
            Marshal.StructureToPtr(struc_ipi, intstruct, True)
            Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, internet_option_proxy, intstruct, Marshal.SizeOf(struc_ipi))
            slbIp.Text = "Proxy Sunucusu : " + proxystring
            CiktiEkle("[" + proxystring + "] proxy sunucusuna baglanildi.", "bilgi")

        Catch ex As Exception
            CiktiEkle("[" + proxystring + "] proxy sunucusuna baglanilamadi.", "hata")
        End Try
    End Sub

    Private Sub VeriCek(ByVal baslik As String, ByVal mail As String)
        Dim baglanti As String = "https://www.google.com.tr/search?&q=site%3Awww.instagram.com+intitle%3A" + baslik + "+" + """" + mail + """" + "&start=" + tarama.ToString
        tarama += 10
        Try
            tarayici.Navigate("www.google.com")
            CiktiEkle("Adrese bağlanılıyor...", "bilgi")
        Catch ex As Exception
            CiktiEkle(ex.Message.ToString(), "hata")
            If (chOtoDegis.Checked) Then
                proxy_ayarla(lstProxy.Items(proxyno).ToString)
                proxyno += 1
                lstProxy.SelectedIndex = proxyno
                VeriCek(txtSozcuk.Text, txtAnahtar.Text)
                CiktiEkle("Otomatik proxy bağlantısı başlatıldı.", "bilgi")
            End If
        End Try

    End Sub

    Private Sub tarayici_yukleniyor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        picBildirim.Visible = True

    End Sub

    Private Sub tarayici_yuklendi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (tarayici.DocumentText.Contains("https://www.google.com/recaptcha/api.js") Or tarayici.DocumentText.Contains("bilgisayar ağınızdan gelen sıra dışı bir trafik algıladı")) Then
            If (tarama > 0) Then
                tarama -= 10
            End If
            CiktiEkle("Sunucu bağlantı reddi.", "hata")
            CiktiEkle("Kimlik doğrulama ile karşılaşıldı.", "uyari")
            If (chOtoDegis.Checked) Then
                proxy_ayarla(lstProxy.Items(proxyno).ToString)
                proxyno += 1
                lstProxy.SelectedIndex = proxyno
                VeriCek(txtSozcuk.Text, txtAnahtar.Text)
                CiktiEkle("Otomatik proxy bağlantısı başlatıldı.", "bilgi")
            End If
        Else
            MailAnaliz(HtmlDonustur(tarayici.DocumentText))
        End If

        If (tarayici.Url.ToString() = "https://www.google.com.tr/?gws_rd=ssl") Then
            For Each element As HtmlElement In tarayici.Document.All
                If (element.GetAttribute("name") = "q") Then
                    element.SetAttribute("value", "site:www.instagram.com intitle:" + txtSozcuk.Text + """" + txtAnahtar.Text + """")
                End If
            Next
            For Each element As HtmlElement In tarayici.Document.All
                If (element.GetAttribute("name") = "btnK") Then
                    element.InvokeMember("click")
                End If
            Next
        End If

        Me.Text = tarayici.Url.ToString
        picBildirim.Visible = False

    End Sub

    Public Function HtmlDonustur(ByVal HTMLCode As String) As String
        Return System.Text.RegularExpressions.Regex.Replace( _
          HTMLCode, "<[^>]*>", "")
    End Function

    Private Sub MailAnaliz(ByVal metin As String)
        CiktiEkle("Mail adresleri analiz ediliyor...", "bilgi")
        Dim mailadet As Integer = 0
      
        Dim src As String = metin
        Dim words As String() = src.Split(" ")
        For Each word As String In words
            If (word.Contains("@") And word.Contains(".")) Then
                If (word.Contains("<") And word.Contains(">")) Then
                    Dim toAdd As New List(Of String)
                    Dim noTags As String() = GetBetweenAll(word, ">", "<")
                    For Each w As String In noTags
                        If (w.Contains("@") And w.Contains(".") And Not w.Contains("=")) Then
                            If (w.EndsWith(",") Or w.EndsWith(".")) Then
                                richMailListe.AppendText(w.Substring(0, w.Length - 1))
                            Else
                                richMailListe.AppendText(w)
                            End If
                        End If
                        mailadet += 1
                    Next
                End If
            End If
        Next
        If (mailadet = 0) Then
            If (tarama = 10) Then
                proxyno += 1
                proxy_ayarla(lstProxy.Items(proxyno).ToString)
                VeriCek(txtSozcuk.Text, txtAnahtar.Text)
                CiktiEkle("Ters giden bir durum var.Tarama tekrarlanıyor", "uyari")
            Else
                tarayici.Stop()
                btnIptal.Enabled = False
                btnBaslat.Enabled = True
                picBildirim.Visible = False

                gbAnahtar.Enabled = True
                gbArama.Enabled = True
                gbPRoxy.Enabled = True
                tarama = 0
                CiktiEkle("Tarama işlemi tamamlandı.", "bilgi")

                ' MessageBox.Show("Tarama işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            CiktiEkle("[" + mailadet.ToString + "] adet mail bulundu.", "bilgi")
            VeriCek(txtSozcuk.Text, txtAnahtar.Text)
        End If

    End Sub

    Private Function removeTags(ByVal w As String)
        Dim toReturn As New List(Of String)
        Dim noTags As String() = GetBetweenAll(w, ">", "<")
        For Each word As String In noTags
            If (word.Contains("@") And word.Contains(".") And Not word.Contains("=")) Then
                toReturn.Add(word)
            End If
        Next
        Return toReturn
    End Function

    Private Function GetBetweenAll(ByVal Source As String, ByVal Str1 As String, ByVal Str2 As String) As String()
        Dim Results, T As New List(Of String)
        T.AddRange(Regex.Split(Source, Str1))
        T.RemoveAt(0)
        For Each I As String In T
            Results.Add(Regex.Split(I, Str2)(0))
        Next
        Return Results.ToArray
    End Function

    Private Sub btnDosyaSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosyaSec.Click
        Dim dosyasec As OpenFileDialog = New OpenFileDialog
        dosyasec.Title = "Proxy Dosyası Seç"
        dosyasec.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"
        dosyasec.FileName = "Proxy.txt"
        If (dosyasec.ShowDialog() = DialogResult.OK) Then
            For Each satir As String In File.ReadAllLines(dosyasec.FileName)
                lstProxy.Items.Add(satir)
            Next
            txtProxy.Text = dosyasec.FileName
            lbproxysayi.Text = lstProxy.Items.Count.ToString
            CiktiEkle("Proxy dosyası [" + dosyasec.FileName + "] olarak ayarlandı.", "bilgi")
        End If
    End Sub

    Private Sub btnKopyala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKopyala.Click
        If (rchb_durum.Text <> "") Then
            Clipboard.SetText(rchb_durum.Text)
        End If
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        If (rchb_durum.Text <> "") Then
            Dim kaydet As SaveFileDialog = New SaveFileDialog
            kaydet.Title = "Kaydet"
            kaydet.FileName = "Mail.txt"
            kaydet.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"
            If (kaydet.ShowDialog() = DialogResult.OK) Then
                File.CreateText(kaydet.FileName).Close()
                Dim yaz As StreamWriter = New StreamWriter(kaydet.FileName)
                yaz.Write(rchb_durum.Text)
                yaz.Close()
                CiktiEkle("Dosya kaydedildi", "bilgi")
            End If
        End If
    End Sub

    Private Sub ÇerezleriTemizleToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇerezleriTemizleToolStripMenuItem.Click
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
        CiktiEkle("Çerezler Temizlendi.", "bilgi")
    End Sub

    Private Sub ÖnbelleğiTemizleToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖnbelleğiTemizleToolStripMenuItem.Click
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
        CiktiEkle("Önbellek Temizlendi.", "bilgi")
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If (WebBrowser1.Url.ToString() = "https://www.google.com.tr/?gws_rd=ssl") Then
            For Each element As HtmlElement In WebBrowser1.Document.All
                If (element.GetAttribute("name") = "q") Then
                    MessageBox.Show("asd")
                    element.SetAttribute("value", "site:www.instagram.com intitle:" + txtSozcuk.Text + """" + txtAnahtar.Text + """")
                End If
            Next
            For Each element As HtmlElement In WebBrowser1.Document.All
                If (element.GetAttribute("name") = "btnK") Then
                    element.InvokeMember("click")
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (WebBrowser1.Url.ToString() = "https://www.google.com.tr/?gws_rd=ssl") Then
            For Each element As HtmlElement In WebBrowser1.Document.All
                If (element.GetAttribute("title") = "Ara") Then
                    MessageBox.Show("asd")
                    element.SetAttribute("value", "site:www.instagram.com intitle:" + txtSozcuk.Text + """" + txtAnahtar.Text + """")
                End If
            Next
            For Each element As HtmlElement In WebBrowser1.Document.All
                If (element.GetAttribute("name") = "btnK") Then
                    element.InvokeMember("click")
                End If
            Next
        End If
    End Sub
End Class
