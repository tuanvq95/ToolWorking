using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolWorking.Model;
using ToolWorking.Utils;

namespace ToolWorking.Views
{
    public partial class Json : Form
    {
        bool isInputKey;

        string indentCharacter = CONST.STRING_TAB;

        List<string> lstInputKey;
        List<string> lstInputValue;

        public Json()
        {
            InitializeComponent();
        }

        #region Event
        private void rbInput_CheckedChanged(object sender, EventArgs e)
        {
            panelInput.Visible = rbInput.Checked;
        }

        private void rbOutput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbModeTree_CheckedChanged(object sender, EventArgs e)
        {
            isInputKey = true;
            groupInputKey.Text = "Input Keys";
        }

        private void rbModePath_CheckedChanged(object sender, EventArgs e)
        {
            isInputKey = false;
            groupInputKey.Text = "Input JSON";
        }

        private void txtIndent_TextChanged(object sender, EventArgs e)
        {
            indentCharacter = string.IsNullOrEmpty(txtIndent.Text) ? CONST.STRING_TAB : txtIndent.Text.Trim();
        }

        private void txtInputKey_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputKey.Text)) return;

            string[] arrKeys = txtInputKey.Text.Split(CONST.STRING_SEPARATORS, StringSplitOptions.None);

            if (arrKeys.Length > 0)
            {
                foreach (var _key in arrKeys)
                {
                    string key = _key.Trim().Replace("  ", string.Empty);
                    if (string.IsNullOrEmpty(key) ||
                        (!isInputKey && (key.Equals("[") || key.Equals("{") || key.Equals("}")))) continue;

                    if (isInputKey)
                    {
                        lstInputKey.Add(key.Replace(indentCharacter, string.Empty));
                    }
                    else
                    {
                        key = key.Replace("\"", "").Replace(",", string.Empty);
                        key = (key.Contains("[") || key.Contains("{")) ? key : key.Replace(":", string.Empty).Trim();
                        lstInputKey.Add(key.Replace(indentCharacter, string.Empty));
                    }
                }
            }


            gridInputValue.DataSource = new List<JsonModel>();
            if (lstInputKey.Count > 0)
            {
                List<JsonModel> lstValue = new List<JsonModel>();
                for (int i = 0; i < lstInputKey.Count; i++)
                {
                    string key = lstInputKey[i];

                    if (key.Contains(":"))
                    {
                        string[] arrKey = key.Split(':');

                        string numberText = arrKey[1].Replace("[", string.Empty);
                        int number = int.TryParse(numberText, out int result) ? result : 1;

                        lstValue.Add(new JsonModel(arrKey[0].Trim(), string.Empty, number));
                    }
                    else
                    {
                        lstValue.Add(new JsonModel(key, string.Empty));
                    }
                }
            }
        }

        private void txtInputValue_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Function

        #endregion
    }
}