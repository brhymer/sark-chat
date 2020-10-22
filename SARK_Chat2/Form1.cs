using RingCentral;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARK_Chat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        public string placeholder = "Enter the phone number of the client...";

        private async void enterPN_Return(object sender, KeyPressEventArgs e)
        {
            string cNumber = EnterPhoneNumber.Text;
            if (cNumber != "" && cNumber != placeholder)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    ClearItems();
                    try
                    {
                        Dictionary<string, List<GetMessageInfoResponse>> conv = await Program.read_messages(cNumber);
                        var orderedList = from s in conv.First().Value
                                          orderby s.creationTime
                                          descending
                                          select s;

                        ClearItems();
                        
                        PostItems(orderedList);
                        ComposeMessage.Visible = true;
                        SendButton.Visible = true;
                        

                    }
                    catch
                    {
                        string message = "No client found.";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
        public void PostItems(System.Linq.IOrderedEnumerable<GetMessageInfoResponse> items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    AddItem(item);
                }
            }
        }

        public void AddItem(GetMessageInfoResponse item)
        {

            var postItem = new PostItem(item);
            postItem.Dock = DockStyle.Top;
            int TBWidth = Math.Max(item.subject.Length * 10 - 50, 50);
            int TBHeight = Math.Max(((int)Math.Ceiling(((double)item.subject.Length / 85)) * 35), 52);

            postItem.Name = "postItem" + (Controls.Count + 1).ToString();
            postItem.Size = new Size(Math.Min(TBWidth, 100), TBHeight);
            PostsPanel.Controls.Add(postItem);
        }

        public void ClearItems()
        {
            PostsPanel.Controls.Clear();
        }

        private async void enterMessage(object sender, KeyPressEventArgs e)
        {
            string cNumber = EnterPhoneNumber.Text;
            if (ComposeMessage.Text != "" && ComposeMessage.Text != placeholder)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    await Program.send_sms(cNumber, ComposeMessage.Text);

                    Dictionary<string, List<GetMessageInfoResponse>> conv = await Program.read_messages(cNumber);
                    var orderedList = from s in conv.First().Value
                                      orderby s.creationTime
                                      descending
                                      select s;

                    ClearItems();
                    PostItems(orderedList);

                    ComposeMessage.Text = "Enter a message";
                }
            }
        }
    }
}
