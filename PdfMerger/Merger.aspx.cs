using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;

public partial class Merger : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


   

    protected void AjaxFileUpload1_UploadCompleteAll1(object sender, AjaxFileUploadCompleteAllEventArgs e)
    {


        string path = Server.MapPath("~/PDFs/");
        string[] filenames = System.IO.Directory.GetFiles(path);
        DirectoryInfo dir = new DirectoryInfo(path);

        int files = dir.GetFiles().Count();
        if (files > 0)
        {


            //PdfReader pdfAddenda = new PdfReader(DOcUload.PostedFile.InputStream);
            //MemoryStream streamAddenda = new MemoryStream();
            //PdfStamper stamperAddenda = new PdfStamper(pdfAddenda, streamAddenda);
            //stamperAddenda.Close();
            //pdfAddenda.Close();
            //streamAddenda.Flush();
            //streamAddenda.Close();
            //byte[] addenda = streamAddenda.ToArray();


            Adding random text in staging
            

            //Document document = new Document();
            ////create PdfCopy object
            //PdfCopy copy = new PdfCopy(document, new FileStream(result, FileMode.Create));
            ////open the document
            //document.Open();
            ////PdfReader variable
            //PdfReader reader;
            //for (int i = 0; i < 2; i++)
            //{
            //    //create PdfReader object
            //    reader = new PdfReader(pdfs[i]);
            //    //merge combine pages
            //    for (int page = 1; page <= reader.NumberOfPages; page++)
            //        copy.AddPage(copy.GetImportedPage(reader, page));

            //}
            ////close the document object
            //document.Close();

           
        }
        else
        {
            Response.Write("<script>alert('Please add atleast two Documents to merge.');</script>");

        }
    }
    protected void btnStart_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~/PDFs/");
        string[] filenames = System.IO.Directory.GetFiles(path);
        DirectoryInfo dir = new DirectoryInfo(path);

        int files = dir.GetFiles().Count();
        if (files > 0)
        {

            String result = Server.MapPath("~/Merged/Output.pdf");
            //create Document object
            Document document = new Document();
            //create PdfCopy object
            PdfCopy copy = new PdfCopy(document, new FileStream(result, FileMode.Create));
            //open the document
            document.Open();
            //PdfReader variable
            PdfReader reader;
            for (int i = 0; i < filenames.Length; i++)
            {
                //create PdfReader object
                reader = new PdfReader(filenames[i]);
                //merge combine pages
                for (int page = 1; page <= reader.NumberOfPages; page++)
                    copy.AddPage(copy.GetImportedPage(reader, page));
                reader.Close();


            }
            //close the document object
            document.Close();
            copy.Close();
            //File.Open(Server.MapPath("~/Merged/Output.pdf"), FileMode.Open);
            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            FileOpen();
        }

    }

    protected void FileOpen()
    {
        string path = Server.MapPath("~/Merged/Output.pdf"); //get file object as FileInfo  
        FileInfo file = new FileInfo(path); //-- if the file exists on the server  


        if (file.Exists) //set appropriate headers  
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "inline; filename=" + file.Name);
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";


            // write file to browser
            Response.WriteFile(file.FullName);


            Response.End();
        }
        else
        {
            // if file does not exist
            Response.Write("This file does not exist.");
        }
    }

    protected void AjaxFileUpload1_UploadComplete1(object sender, AjaxFileUploadEventArgs e)
    {
        string filePath = "~/PDFS/" + e.FileName;

        AjaxFileUpload1.SaveAs(MapPath(filePath));
    }
}