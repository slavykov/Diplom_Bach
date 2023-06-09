using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Diplom_Bach
{
    internal class WorkWithExcelandWord
    {
        


        public void LoadFromExcelToDataGrid(DataGridView dataGridView, out int rows, out int columns)
        {
            rows = 0;
            columns = 0;

            OpenFileDialog ofd = new OpenFileDialog();
           
            ofd.DefaultExt = "*.xls;*.xlsx";
            
            ofd.Filter = "Excel Sheet(*.xlsx)|*.xlsx";
          
            ofd.Title = "Выберите документ для загрузки данных";
            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            DataTable dt = new DataTable();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                

                workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);

            
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(
                    new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                            (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                rows = dt.Rows.Count;
                columns = dt.Columns.Count - 1;

                dataGridView.DataSource = dt;
                app.Quit();
                MessageBox.Show("Файл " + ofd.FileName + " завантажений.");
            }
            else
            {
                MessageBox.Show("Вкажіть файл формату *.xlsx для завантаження");
            }    
        }

        public void DownloadTheResultToWordFile(List<int> fxfcopt)
        {
            int j = 0;
            Word._Application word_app = new Word.ApplicationClass();

            object missing = Type.Missing;
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
            para.Range.Text = "Результати розрахунків";
            object style_name = "Заголовок 1";
            para.Range.set_Style(ref style_name);

            if (fxfcopt.Count > 3)
            {
                for (int i = 0; i < fxfcopt.Count/3; i++)
                {
                    para.Range.InsertParagraphAfter();

                    para.Range.Text = "Підприємству " + fxfcopt[j].ToString() +
                    " необхідно виділити xc = " + fxfcopt[j+1].ToString() +
                    " fc = " + fxfcopt[j+2].ToString();
                    
                    para.Range.InsertParagraphAfter();
                    j = j + 3 ;
                }
            }else
            {
                para.Range.InsertParagraphAfter();

                para.Range.Text = "Підприємству " + fxfcopt[0].ToString() +
                " необхідно виділити xc = " + fxfcopt[1].ToString() +
                " fc = " + fxfcopt[2].ToString();

                para.Range.InsertParagraphAfter();
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word document|*.doc";
            saveFileDialog1.Title = "Save the Word Document";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string docName = saveFileDialog1.FileName;
                if (docName.Length > 0)
                {
                    object oDocName = (object)docName;
                    word_doc.SaveAs(ref oDocName, ref missing, ref missing, ref missing, ref missing, ref missing,
                                 ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                                 ref missing, ref missing, ref missing, ref missing);
                    MessageBox.Show("Файл з результатами збережено: " + docName);
                }else
                {
                    MessageBox.Show("Виникла помилка при збереженні файлу результатів!");
                }
            }



            //object filename = Path.GetFullPath(
            //    Path.Combine(Application.StartupPath, "\\result.doc"));


            //word_doc.SaveAs(ref filename, ref missing, ref missing,
            //    ref missing, ref missing, ref missing, ref missing,
            //    ref missing, ref missing, ref missing, ref missing,
            //    ref missing, ref missing, ref missing, ref missing,
            //    ref missing);


            
            object save_changes = false;
            word_doc.Close(ref save_changes, ref missing, ref missing);
            word_app.Quit(ref save_changes, ref missing, ref missing);

        }

    }
}
