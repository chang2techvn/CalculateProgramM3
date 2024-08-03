using System;
using System.Windows.Forms;

namespace CalculateProgram.Modules
{
    public static class DisplayModule
    {
        public static void DisplayResult(ListView lvResult, string id, string name, int lastMonth, int thisMonth, int consumption, double price, double totalBill)
        {
            // Add results to ListView
            lvResult.Items.Clear();
            int index = lvResult.Items.Count + 1;
            ListViewItem item = new ListViewItem(index.ToString())
            {
                SubItems =
                {
                    new ListViewItem.ListViewSubItem(null, id),
                    new ListViewItem.ListViewSubItem(null, name),
                    new ListViewItem.ListViewSubItem(null, lastMonth.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, thisMonth.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, consumption.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, price.ToString("0.00") + " đ/m3"),
                    new ListViewItem.ListViewSubItem(null, totalBill.ToString("0.00") + " đ"),
                    new ListViewItem.ListViewSubItem(null, "Showbill"),
                    new ListViewItem.ListViewSubItem(null, "Delete")
                }
            };
            lvResult.Items.Add(item);

            // Resize columns
            for (int i = 0; i < lvResult.Columns.Count; i++)
            {
                lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Save results to file
            string filePath = "Results.txt";
            FileModule.SaveResultsToFile(filePath, lvResult);

            // Show detailed billing information in a separate form
            Showbill showbillForm = new Showbill(
                id,
                name,
                lastMonth.ToString() + " m3",
                thisMonth.ToString() + " m3",
                consumption.ToString() + " m3",
                price.ToString("0.00") + " đ/m3",
                totalBill.ToString("0.00") + " đ"
            );
            showbillForm.ShowDialog();
        }
    }
}
