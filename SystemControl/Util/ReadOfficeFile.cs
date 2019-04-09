using Accord.IO;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemControl.Util
{
    public class ReadOfficeFile
    {
        private string fName;
        Boolean hasHeaders = true;
        DataTable tableSource;
        private string extension, fileDataName, dirLocal;
        private double[,] sourceMatrix;

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public bool HasHeaders
        {
            get
            {
                return hasHeaders;
            }

            set
            {
                hasHeaders = value;
            }
        }

        public DataTable TableSource
        {
            get
            {
                return tableSource;
            }

            set
            {
                tableSource = value;
            }
        }

        public string Extension
        {
            get
            {
                return extension;
            }

            set
            {
                extension = value;
            }
        }

        public string FileDataName
        {
            get
            {
                return fileDataName;
            }

            set
            {
                fileDataName = value;
            }
        }

        public string DirLocal
        {
            get
            {
                return dirLocal;
            }

            set
            {
                dirLocal = value;
            }
        }

        public double[,] SourceMatrix
        {
            get
            {
                return sourceMatrix;
            }

            set
            {
                sourceMatrix = value;
            }
        }

        public ReadOfficeFile(string fName)
        {
            this.FName = fName;
            Extension = Path.GetExtension(fName);
            FileDataName = Path.GetFileName(fName);
            DirLocal = Path.GetDirectoryName(fName);
        }
        public void initReader(Form th)
        {
            if (Extension == ".csv")
            {
                CsvReader csvR = new CsvReader(FName, HasHeaders);
                TableSource = csvR.ToTable();

            }
           
            if (Extension == ".xls" || Extension == ".xlsx")
            {
                ExcelReader db = new ExcelReader(FName, true, false);
                TableSelectDialog t = new TableSelectDialog(db.GetWorksheetList());
                if (t.ShowDialog(th) == DialogResult.OK)
                {
                    TableSource = db.GetWorksheet(t.Selection);
                }

            }

            SourceMatrix = TableSource.ToMatrix(out ReadMatData.columnNames);
            // Detect the kind of problem loaded.
            if (SourceMatrix.GetLength(1) == 2)
            {
                MessageBox.Show("Missing class column.");
                return;
            }

            ReadMatData.ViewNumSum = 1;
        }

        public double[,] getMatrixTrain() {
            return sourceMatrix.RemoveColumn(sourceMatrix.GetLength(1) - 1);
        }

        public double[] getMatrixTarget()
        {
            return sourceMatrix.GetColumn(sourceMatrix.GetLength(1) - 1);
        }

        public int getMatrixTrainLength()
        {
            return sourceMatrix.RemoveColumn(sourceMatrix.GetLength(1) - 1).GetLength(1);
        }
        public int getMatrixTargetLength()
        {
            return sourceMatrix.GetColumn(sourceMatrix.GetLength(1) - 1).Length;
        }

    }
}
