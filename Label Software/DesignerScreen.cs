using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Label_Software
{
    public partial class DesignerScreen : Form
    {
        public DesignerScreen()
        {
            InitializeComponent();

            // Karakter limitleri ekleniyor
            titleTextBox.MaxLength = 32; // Örneğin 40 karakter
            descriptionTextBox.MaxLength = 100; // 80 karakter

            // TextChanged olaylarını bağla
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;

            // RichTextBox ayarları
            previewTitle.Multiline = true;
            previewTitle.WordWrap = false;  // WordWrap'ı false yaparak sadece bir satırda yazı olmasını sağlıyoruz
            previewTitle.ScrollBars = RichTextBoxScrollBars.None; // Scrollbars None olarak ayarlandı
            previewTitle.SelectionAlignment = HorizontalAlignment.Center; // Metin hizalama

            previewDescription.Multiline = true;
            previewDescription.WordWrap = true;
            previewDescription.ScrollBars = RichTextBoxScrollBars.None; // Scrollbars None olarak ayarlandı
            previewDescription.SelectionAlignment = HorizontalAlignment.Center; // Metin hizalama
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            // Kullanıcı girişlerini al
            string line1 = titleTextBox.Text.Trim();
            string line2 = descriptionTextBox.Text.Trim();

            // Label boyutlarını kontrol et ve satır başı ekle
            line1 = AdjustTextToFitLabel(line1, previewTitle.Width, previewTitle.Font);
            line2 = AdjustTextToFitLabel(line2, previewDescription.Width, previewDescription.Font);

            // Önizleme alanını güncelle
            previewTitle.Text = line1;
            previewDescription.Text = line2;

            // previewDescription'ın satır sayısını hesapla
            int maxDescLines = previewDescription.Height / previewDescription.Font.Height;
            int descLineCount = CountLines(previewDescription.Text);

            // Eğer previewDescription'da satır sayısı limitin üzerine çıkarsa, yazıyı engelle
            if (descLineCount > maxDescLines)
            {
                // Son karakteri silerek daha fazla yazıyı engelle
                descriptionTextBox.Text = descriptionTextBox.Text.Substring(0, descriptionTextBox.Text.Length - 1);
                descriptionTextBox.SelectionStart = descriptionTextBox.Text.Length; // Cursor son pozisyonda
                MessageBox.Show("Açıklama için maksimum satır sayısına ulaşıldı. Daha fazla karakter eklenemez.");
            }
        }

        private string AdjustTextToFitLabel(string text, int labelWidth, Font font)
        {
            // Eğer previewTitle ise, yalnızca bir satırda sığmasını sağla
            if (font == previewTitle.Font) // Bu, sadece previewTitle için geçerli
            {
                // Metni keserek sadece bir satıra sığacak şekilde düzenle
                string testText = text;
                while (TextRenderer.MeasureText(testText, font).Width > labelWidth)
                {
                    testText = testText.Substring(0, testText.Length - 1); // Fazla karakteri çıkar
                }
                return testText;
            }

            // RichTextBox içinde metnin düzgün sarması için metni satırlara ayır
            StringBuilder sb = new StringBuilder();
            string[] words = text.Split(' '); // Kelimeleri ayır

            StringBuilder currentLine = new StringBuilder();

            foreach (string word in words)
            {
                string testLine = currentLine.Length == 0 ? word : currentLine + " " + word;

                // Test satırının genişliğini ölç
                int width = TextRenderer.MeasureText(testLine, font).Width;

                // Eğer metin label genişliğini aşarsa, mevcut satırdaki metni ekle ve yeni satıra geç
                if (width > labelWidth)
                {
                    // Mevcut satır uzunluğu label genişliğini geçtiğinde, mevcut satırı ekle ve yeni satıra geç
                    sb.AppendLine(currentLine.ToString());
                    currentLine.Clear();
                    currentLine.Append(word); // Yeni satır başında kelimeyi ekle
                }
                else
                {
                    // Eğer metin mevcut satıra sığıyorsa, kelimeyi ekle
                    if (currentLine.Length > 0)
                        currentLine.Append(" "); // Kelimeler arasında boşluk bırak
                    currentLine.Append(word); // Kelimeyi ekle
                }
            }

            // Son satırı da ekle
            if (currentLine.Length > 0)
            {
                sb.AppendLine(currentLine.ToString());
            }

            return sb.ToString();
        }

        private int CountLines(string text)
        {
            // Text'i satırlara ayırarak satır sayısını hesapla
            return text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).Length;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Kullanıcı girişlerini al
            string line1 = titleTextBox.Text.Trim();
            string line2 = descriptionTextBox.Text.Trim();

            // ZPL kodunu oluştur
            string zpl = $"^XA\n" +
                         $"^FO50,50^A0N,30,30^FD{line1}^FS\n" +
                         $"^FO50,100^A0N,30,30^FD{line2}^FS\n" +
                         "^XZ";

            // Yazıcıya gönder
            PrintZPL(zpl);
        }

        private void PrintZPL(string zpl)
        {
            string printerName = "Zebra ZD220"; // Yazıcınızın adı

            // RawPrinterHelper sınıfı ile yazdır
            RawPrinterHelper.SendStringToPrinter(printerName, zpl);
        }
    }

    public static class RawPrinterHelper
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In] ref DOCINFOA pDocInfo);

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        public static bool SendStringToPrinter(string printerName, string document)
        {
            IntPtr printerHandle = IntPtr.Zero;
            try
            {
                if (!OpenPrinter(printerName, out printerHandle, IntPtr.Zero))
                    return false;

                DOCINFOA docInfo = new DOCINFOA { pDocName = "ZPL Print", pDataType = "RAW" };
                if (!StartDocPrinter(printerHandle, 1, ref docInfo))
                    return false;

                IntPtr pBytes = Marshal.StringToCoTaskMemAnsi(document);
                WritePrinter(printerHandle, pBytes, document.Length, out _);
                Marshal.FreeCoTaskMem(pBytes);

                return EndDocPrinter(printerHandle);
            }
            finally
            {
                if (printerHandle != IntPtr.Zero)
                    ClosePrinter(printerHandle);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct DOCINFOA
        {
            public string pDocName;
            public string pOutputFile;
            public string pDataType;
        }
    }
}
