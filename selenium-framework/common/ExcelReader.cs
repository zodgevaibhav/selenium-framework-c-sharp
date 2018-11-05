using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

class ExcelReader
{

    private static IWorkbook workbook;
    private static ISheet sheet;

    public static object[] getExcelDataArray(string filePath, string sheetName)
    {
        workbook = new XSSFWorkbook(filePath);
        sheet = workbook.GetSheet(sheetName);

        int columnCount = sheet.GetRow(0).LastCellNum;
        int rowCount = sheet.LastRowNum+1;
        object[] excelDataArray = new object[rowCount];
        for (int i = 0; i < rowCount; i++)
        {
            object[] tempArray = new object[columnCount];
            for (int j = 0; j < columnCount; j++)
            {
                tempArray[j] = sheet.GetRow(i).GetCell(j).StringCellValue;
            }
            excelDataArray[i] = tempArray;
        }
        return excelDataArray;
    }

}