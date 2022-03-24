using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Shared
{
    public static class DataGridViewExtentions
    {
        public static void ConfigColoredGrid(this DataGridView grid)
        {
            Font font = new("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle darkLine = new()
            {
                BackColor = Color.FromArgb(173, 85, 37),
                Font = font,
                ForeColor = Color.Black,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = darkLine;

            DataGridViewCellStyle clearLine = new()
            {
                BackColor = Color.FromArgb(219, 123, 0),
                Font = font,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = clearLine;

        }

        public static void ConfigJustReadGrid(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;

            grid.RowsAdded += (sender, e) =>
            {
                grid.ClearSelection();
            };

            grid.RowsRemoved += (sender, e) =>
            {
                grid.ClearSelection();
            };
        }

        public static T SelectId<T>(this DataGridView grid)
        {
            const int firstLine = 0, firstColumn = 0;
            if (grid.SelectedRows.Count == 0)
                return default;

            object value = grid.SelectedRows[firstLine].Cells[firstColumn].Value;

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
