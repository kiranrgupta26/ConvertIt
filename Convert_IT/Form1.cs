using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace Convert_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       private
       Microsoft.Office.Interop.Word.Application
       MSWordDoc;

        object UnknownType = Type.Missing;

        public string Word2PdfConversion(object InputLocation, object OutputLocation,string typeToConvert)
        {
            string temp;
            temp = typeToConvert;
            string result = "";
            try
            {
                MSWordDoc = null;
                if (MSWordDoc == null)
                {
                    MSWordDoc = new Microsoft.Office.Interop.Word.Application();
                    MSWordDoc.Visible = false;
                    MSWordDoc.Documents.Open(ref InputLocation, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType);
                    MSWordDoc.Application.Visible = false;
                    MSWordDoc.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMinimize;
                    object SavePdfFormat;
                    if(temp=="doc")
                    {
                        SavePdfFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument;
                    }
                    else
                    {
                        SavePdfFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF;
                    }

                    MSWordDoc.ActiveDocument.SaveAs(ref OutputLocation, ref SavePdfFormat, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType, ref UnknownType);
                    result = "Success";

                }

            }
            catch (Exception)
            {
                result = "Error";
            }
            finally
            {
                if (MSWordDoc == null)
                {

                }
                else
                {
                    MSWordDoc.Documents.Close(ref UnknownType, ref UnknownType, ref UnknownType);
                   
                }
                MSWordDoc.Quit(ref UnknownType, ref UnknownType, ref UnknownType);

            }
            return result;
        }

        string fileExtension;
        string InputFileName;
        object inputLocation;
        string OutputFileExtension;
        string typeToConvert;
        private void btnbrowsepdftodoc_Click(object sender, EventArgs e)
        {
            typeToConvert = "doc";
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                fileExtension = Path.GetExtension(fileDialog.FileName);
                if(fileExtension == ".PDF" || fileExtension == ".xps" || fileExtension == ".pdf")
                {
                    txtpath.Text = Path.GetFullPath(fileDialog.FileName);
                    InputFileName = Path.GetFileName(fileDialog.FileName);
                    inputLocation = fileDialog.FileName;
                    OutputFileExtension = InputFileName.Replace(fileExtension,".doc");
                }
                else
                {
                    MessageBox.Show("Not a PDF or XPS File");
                }
            }
        }
        object outputLocation;
        private void btnbrowseoutputLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            DialogResult result = openFolder.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtoutputLocation.Text = Path.GetFullPath(openFolder.SelectedPath);
                outputLocation = txtoutputLocation.Text +'\\'+ OutputFileExtension;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string suc = Word2PdfConversion(inputLocation, outputLocation,typeToConvert);
            if (suc == "Success")
            {
                MessageBox.Show(suc);
            }
        }

        private void btbbrowsedoctopdf_Click(object sender, EventArgs e)
        {
            typeToConvert = "pdf";
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileExtension = Path.GetExtension(fileDialog.FileName);
                if (fileExtension == ".doc" || fileExtension == ".docx")
                {
                    txtdoctopdf.Text = Path.GetFullPath(fileDialog.FileName);
                    InputFileName = Path.GetFileName(fileDialog.FileName);
                    inputLocation = fileDialog.FileName;
                    OutputFileExtension = InputFileName.Replace(fileExtension, ".pdf");
                }
                else
                {
                    MessageBox.Show("Not a DOC File");
                }
            }
        }

        private void btnPathToPdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            DialogResult result = openFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtoutputLocationToPdf.Text = Path.GetFullPath(openFolder.SelectedPath);
                outputLocation = txtoutputLocation.Text + '\\' + OutputFileExtension;
            }
        }

        private void btnConvertToPdf_Click(object sender, EventArgs e)
        {
            string suc = Word2PdfConversion(inputLocation, outputLocation,typeToConvert);
            if (suc == "Success")
            {
                MessageBox.Show(suc);
            }
        }
    }
}
