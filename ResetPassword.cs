using System;
using System.Drawing;
using System.Windows.Forms;

namespace JEM
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultText = "")
        {

            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            // message
            Label lbl = new Label() { Left = 12, Top = 12, Text = text, AutoSize = true };
            prompt.Controls.Add(lbl);

            // input
            TextBox txt = new TextBox() { Left = 12, Top = lbl.Bottom + 8, Width = prompt.ClientSize.Width - 24 };
            txt.Text = defaultText;
            prompt.Controls.Add(txt);

            // OK button
            Button btnOk = new Button()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Left = prompt.ClientSize.Width - 180,
                Width = 80,
                Top = txt.Bottom + 12
            };
            prompt.Controls.Add(btnOk);

            // Cancel button
            Button btnCancel = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Left = prompt.ClientSize.Width - 90,
                Width = 80,
                Top = txt.Bottom + 12
            };
            prompt.Controls.Add(btnCancel);

            prompt.AcceptButton = btnOk;
            prompt.CancelButton = btnCancel;

            // Show dialog
            var result = prompt.ShowDialog();
            return result == DialogResult.OK ? txt.Text : string.Empty;
        }
    }
}
