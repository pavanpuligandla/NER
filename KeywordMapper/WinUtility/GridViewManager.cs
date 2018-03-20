using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeywordMapper.WinUtility
{
    public class GridViewManager
    {
        public static void GridSerialNumbers(DataGridViewRowPostPaintEventArgs e, DataGridView dgvTemp)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvTemp.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvTemp.Font);

                if (dgvTemp.RowHeadersWidth < (int)(size.Width + 20)) dgvTemp.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;

                e.Graphics.DrawString(strRowNumber, dgvTemp.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
