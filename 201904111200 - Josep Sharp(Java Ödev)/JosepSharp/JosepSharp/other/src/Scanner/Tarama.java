package Scanner;

import SK.gnome.morena.*;
import SK.gnome.twain.TwainException;
import SK.gnome.twain.TwainManager;
import com.itextpdf.text.DocumentException;
import java.awt.Toolkit;
import com.itextpdf.text.Document;
import java.awt.Image;
import com.itextpdf.text.PageSize;
import com.itextpdf.text.pdf.PdfContentByte;
import com.itextpdf.text.pdf.PdfWriter;
import java.io.FileOutputStream;
import java.io.IOException;

public class Tarama {

    public static final String DEST = "scanner.pdf";

    public static void main(String[] args) {
        Tarama ls = new Tarama();
        ls.pdfReader();
    }

    public void pdfReader() {
        try {
            MorenaSource source = TwainManager.getDefaultSource();
            System.err.println("Selected source is " + source);
            if (source != null) {

                MorenaImage morenaImage = new MorenaImage(source);
                Image image = Toolkit.getDefaultToolkit().createImage(morenaImage);
                Document document = new Document(PageSize.A4.rotate());
                PdfWriter writer = PdfWriter.getInstance(document, new FileOutputStream(DEST));
                document.open();
                PdfContentByte canvas = writer.getDirectContentUnder();
                com.itextpdf.text.Image itextimage = com.itextpdf.text.Image.getInstance(image, null);
                itextimage.scaleAbsolute(PageSize.A4.rotate());
                itextimage.setAbsolutePosition(0, 0);
                canvas.addImage(itextimage);
                document.close();
            }
            Morena.close();
        } catch (DocumentException | IOException | MorenaException e) {
            System.err.println("Pdf Error !" + e);
        }

    }
}
