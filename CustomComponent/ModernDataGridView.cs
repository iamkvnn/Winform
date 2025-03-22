using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public class ModernDataGridView : DataGridView
    {
        public ModernDataGridView()
        {
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // Border styles
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Colors
            BackgroundColor = Color.White;
            GridColor = Color.FromArgb(240, 240, 240);

            // Rows
            RowHeadersVisible = false;
            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 144, 255);
            DefaultCellStyle.SelectionForeColor = Color.White;
            DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            RowTemplate.Height = 30;

            // Headers
            ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            ColumnHeadersHeight = 40;

            // General settings
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EnableHeadersVisualStyles = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            ReadOnly = true;
        }
    }
}
