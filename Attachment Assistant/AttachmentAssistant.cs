using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attachment_Assistant
{
    public partial class frmMain : Form
    {
        string attnameDate;
        string attnameDocType;
        string attnameSuffix;

        public frmMain()
        {
            InitializeComponent();
            InitializeTreeView();
            datePicker.Value = DateTime.Today;
            clbSuffixes.Items.Clear();
            attnameDate = datePicker.Value.ToString("yyyyMMdd") + " - ";
        }

        private void InitializeTreeView()
        {
            treeDocType.ExpandAll();
        }

        private void treeDocType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            clbSuffixes.Items.Clear();

            if (treeDocType.SelectedNode.Tag != null)
            {
                attnameDocType = treeDocType.SelectedNode.Text;

                switch (treeDocType.SelectedNode.Tag)
                {
                    case "EmpLeaveApp":
                        clbSuffixes.Items.Add("Med Cert");
                        break;
                    default:
                        break;
                }
            } else
            {
                attnameDocType = null;
            }

            BuildAttachmentName();
        }

        private void BuildAttachmentName()
        {
            BuildSuffixList();

            if (attnameDocType != null)
            {
                txtAttachmentName.Text = attnameDate + attnameDocType + " [" + attnameSuffix  + "]";
            } else
            {
                txtAttachmentName.Text = "";
            }
        }

        private void cbNoDate_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNoDate.Checked == true)
            {
                datePicker.Enabled = false;
                attnameDate = "";
            } else
            {
                datePicker.Enabled = true;
                attnameDate = datePicker.Value.ToString("yyyyMMdd") + " - ";
            }

            BuildAttachmentName();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            attnameDate = datePicker.Value.ToString("yyyyMMdd") + " - ";

            BuildAttachmentName();
        }

        private void clbSuffixes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildSuffixList();
        }

        private void BuildSuffixList()
        {
            attnameSuffix = "";

            attnameSuffix = attnameSuffix + string.Join(",", clbSuffixes.SelectedItems.Cast<);
          

            //attnameSuffix = (attnameSuffix.Length > 0) ? attnameSuffix + string.Join(",", clbSuffixes.SelectedItems) : attnameSuffix;
        }
    }
}
