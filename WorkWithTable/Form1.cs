using System.Data;
using OfficeOpenXml;

namespace WorkWithTable
{
    public partial class Form1 : Form
    {
        private ExcelManager excelManager;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            excelManager = new ExcelManager();
            dataTable = new DataTable();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Привязка данных к DataGridView
            DGV.DataSource = dataTable;

        }
        private void OpenBT_Click(object sender, EventArgs e)
        {
            // Открытие Excel файла и загрузка данных в DataTable
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                dataTable = excelManager.LoadExcelData(filePath);
                DGV.DataSource = dataTable;

            }
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в Excel файл
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    // Если файл существует, удаляем его
                    File.Delete(filePath);
                }
                excelManager.SaveExcelData(filePath, dataTable);

                MessageBox.Show("Сохранение завершено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            // Добавление новой строки в DataTable и обновление DataGridView
            DataRow newRow = dataTable.NewRow();
            dataTable.Rows.Add(newRow);
            DGV.DataSource = dataTable;
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            // Удаление выбранной строки из DataTable и обновление DataGridView
            if (DGV.SelectedRows.Count > 0)
            {
                int selectedIndex = DGV.SelectedRows[0].Index;
                dataTable.Rows.RemoveAt(selectedIndex);
                DGV.DataSource = dataTable;
            }
        }
        
        public class ExcelManager
        {
            public DataTable LoadExcelData(string filePath)
            {
                DataTable dataTable = new DataTable();

                using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    for (int col = 1; col <= colCount; col++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int col = 1; col <= colCount; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Value;
                        }

                        dataTable.Rows.Add(dataRow);
                    }
                }

                return dataTable;
            }

            public void SaveExcelData(string filePath, DataTable dataTable)
            {
                using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    for (int col = 1; col <= dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col].Value = dataTable.Columns[col - 1].ColumnName;
                    }

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                        }
                    }

                    package.Save();
                }
            }
        }

    }
}